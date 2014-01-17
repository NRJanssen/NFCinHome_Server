using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace NFCInHome_Server
{
    public partial class Form1 : Form
    {
        private Translator translator;
        private Form f;
        public Form1()
        {
            this.f = this;
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
                Console.WriteLine(c.getDescriptor());
                foreach (System.Windows.Forms.Control pb in f.Controls.Find(c.getName(), false))
                {
                    if (pb.Name == c.getName()){
                        PictureBox p = (PictureBox)pb;
                        if (!c.getVisible())
                        {
                            p.Image = c.getOnImage();
                            c.setVisible(true);
                        }
                        else
                        {
                            p.Image = c.getOffImage();
                            c.setVisible(false);
                        }
                    }
                }
            });
        }
    }
}