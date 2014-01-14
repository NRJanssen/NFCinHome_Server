using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFCInHome_Server
{
    class Command
    {
        private string name;
        private string descriptor;
        private int command;

        public Command(string name, string descriptor, int command)
        {
            this.name = name;
            this.descriptor = descriptor;
            this.command = command;
        }

        public string getName()
        {
            return name;
        }

        public string getDescriptor()
        {
            return descriptor;
        }

        public int getCommand()
        {
            return command;
        }
    }
}
