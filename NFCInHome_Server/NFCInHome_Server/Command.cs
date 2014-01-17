using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace NFCInHome_Server
{
    class Command
    {
        private string name;
        private string descriptor;
        private int command;
        private bool visible;
        private Bitmap offImage;
        private Bitmap onImage;

        public Command(string name, string descriptor, int command, bool visible, Bitmap onImage, Bitmap offImage)
        {
            this.name = name;
            this.descriptor = descriptor;
            this.command = command;
            this.visible = visible;
            this.offImage = offImage;
            this.onImage = onImage;
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

        public bool getVisible()
        {
            return visible;
        }

        public void setVisible(bool visible)
        {
            this.visible = visible;
        }

        public Bitmap getOnImage()
        {
            return onImage;
        }

        public Bitmap getOffImage()
        {
            return offImage;
        }
    }
}
