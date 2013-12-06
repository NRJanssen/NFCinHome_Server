using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCInHome_Server
{
    class TranslateCommand
    {
        private Dictionary<int, string> protocol;

        public TranslateCommand()
        {
            protocol = new Dictionary<int, string>();
            fillDictionary();
        }

        private void fillDictionary()
        {
            //1.x Livingroom
            protocol.Add(11, "Televisie");
            protocol.Add(12, "Lamp boven tafel");
            protocol.Add(13, "Lampen naast de bank");
            //2.x Bathroom
            protocol.Add(21, "");
            //3.x Garage
            protocol.Add(31, "");
        }

        public string getValue(int key)
        {
            string temp = protocol[key];
            if (temp != null)
            {
                return temp;
            }
            else
            {
                return "-1";
            }
        }
    }
}
