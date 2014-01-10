/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package nfcinhome_server;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.IOException;
import java.io.InputStreamReader;
import java.io.InterruptedIOException;
import java.io.OutputStreamWriter;
import java.net.ServerSocket;
import java.net.Socket;

/**
 *
 * @author fhict
 */
public class NFCInHome_Server {

    private static final int TCP_SERVER_PORT = 2000;
    private final boolean server_active = true;
    private final infoFrame info;

    public NFCInHome_Server(infoFrame info) {
        this.info = info;
        initializeServer();
    }

    private void initializeServer() {
        ServerSocket ss = null;
        try {
            ss = new ServerSocket(TCP_SERVER_PORT);
            while (server_active) {
                Socket s = ss.accept();
                BufferedReader in = new BufferedReader(new InputStreamReader(s.getInputStream()));
                BufferedWriter out = new BufferedWriter(new OutputStreamWriter(s.getOutputStream()));
                String incomingMsg = in.readLine() + System.getProperty("line.separator");
                System.out.println("received: " + incomingMsg);
                handleMessage(incomingMsg);
                String outgoingMsg = "1" + System.getProperty("line.separator");
                out.write(outgoingMsg);
                out.flush();
                System.out.println("sent: " + outgoingMsg);
            }
        } catch (InterruptedIOException e) {
            System.err.println(e.toString());
        } catch (IOException e) {
            System.err.println(e.toString());
        } finally {
            if (ss != null) {
                try {
                    ss.close();
                } catch (IOException e) {
                    System.err.println(e.toString());
                }
            }
        }
    }
    
    private void handleMessage(String message){
        if (!message.isEmpty()){
            String[] commands = message.split(";");
            for (String command : commands) {
                info.addMessage(command);
            }
        }
    }
}
