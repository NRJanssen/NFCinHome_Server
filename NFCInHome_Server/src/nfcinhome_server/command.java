/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package nfcinhome_server;

/**
 *
 * @author fhict
 */
public class command {
    
    private String name;
    private String descriptor;
    private int commando;
    
    public command (String name, String descriptor, int commando){
        this.name = name;
        this.descriptor = descriptor;
        this.commando = commando;
    }

    public String getName() {
        return name;
    }

    public String getDescriptor() {
        return descriptor;
    }

    public int getCommando() {
        return commando;
    }
}
