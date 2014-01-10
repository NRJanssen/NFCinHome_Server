/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

package nfcinhome_server;

import java.util.ArrayList;

/**
 *
 * @author fhict
 */
public class Translator {
    
    private final ArrayList<command> translations;

    public Translator(){
        translations = new ArrayList<>();
        fillTranslations();
    }

    private void fillTranslations() {
        translations.add(new command("livingroom_table_lamp", "Table Lamp", 11));
        translations.add(new command("livingroom_couch_lamo", "Couch Lamp", 12));
    }
    
    public String getCommandName(int command){
        for (command c : translations){
            if (c.getCommando() == command){
                return c.getName();
            }
        }
        return null;
    }
}
