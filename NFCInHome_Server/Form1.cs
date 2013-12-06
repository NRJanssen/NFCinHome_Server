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
        private TranslateCommand tc;
        private CommandListener cl;
        private string labelText = "";
        public Form1()
        {
            InitializeComponent();
            tc = new TranslateCommand();
            cl = new CommandListener(this);
            cl.startListening();
        }
        public void setLabel(String text)
        {
            labelText += "\n" + tc.getValue(Convert.ToInt32(text));
            label1.Invoke(new Action(delegate() { label1.Text = labelText; }));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}
