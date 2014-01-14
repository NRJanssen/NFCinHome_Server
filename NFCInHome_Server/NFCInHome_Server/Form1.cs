using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NFCInHome_Server
{
    public partial class Form1 : Form
    {
        Translator translator;
        public Form1()
        {
            InitializeComponent();
            translator = new Translator();
            Server s = new Server(this);
        }

        public void updateForm(String elementToBeUpdated)
        {
            int command = Convert.ToInt32(elementToBeUpdated);
            this.Invoke((MethodInvoker)delegate
            {
                Command c = translator.getCommand(command);
                lb_received_commands.Items.Add(c.getDescriptor());
            });
        }
    }
}
