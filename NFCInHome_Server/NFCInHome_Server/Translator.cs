using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCInHome_Server
{
    class Translator
    {
        private List<Command> translations;

        public Translator()
        {
            translations = new List<Command>();
            fillTranslations();
        }

        private void fillTranslations()
        {
            translations.Add(new Command("livingroom_table_lamp", "Table Lamp", 11, false, NFCInHome_Server.Properties.Resources.livingroom_table_lamp_on, NFCInHome_Server.Properties.Resources.livingroom_table_lamp_off));
            translations.Add(new Command("livingroom_couch_lamp", "Couch Lamp", 12, false, NFCInHome_Server.Properties.Resources.livingroom_couch_lamp_on, NFCInHome_Server.Properties.Resources.livingroom_couch_lamp_off));
        }

        public Command getCommand(int command)
        {
            foreach (Command c in translations)
            {
                if (c.getCommand() == command)
                {
                    return c;
                }
            }
            return null;
        }
    }
}
