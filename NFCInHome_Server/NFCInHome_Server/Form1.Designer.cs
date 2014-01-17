namespace NFCInHome_Server
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.livingroom_table_lamp = new System.Windows.Forms.PictureBox();
            this.livingroom_couch_lamp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.livingroom_table_lamp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingroom_couch_lamp)).BeginInit();
            this.SuspendLayout();
            // 
            // livingroom_table_lamp
            // 
            this.livingroom_table_lamp.BackColor = System.Drawing.Color.Transparent;
            this.livingroom_table_lamp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.livingroom_table_lamp.Image = ((System.Drawing.Image)(resources.GetObject("livingroom_table_lamp.Image")));
            this.livingroom_table_lamp.Location = new System.Drawing.Point(949, 402);
            this.livingroom_table_lamp.Margin = new System.Windows.Forms.Padding(4);
            this.livingroom_table_lamp.Name = "livingroom_table_lamp";
            this.livingroom_table_lamp.Size = new System.Drawing.Size(106, 127);
            this.livingroom_table_lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livingroom_table_lamp.TabIndex = 2;
            this.livingroom_table_lamp.TabStop = false;
            // 
            // livingroom_couch_lamp
            // 
            this.livingroom_couch_lamp.BackColor = System.Drawing.Color.Transparent;
            this.livingroom_couch_lamp.Image = global::NFCInHome_Server.Properties.Resources.livingroom_couch_lamp_off;
            this.livingroom_couch_lamp.Location = new System.Drawing.Point(527, 352);
            this.livingroom_couch_lamp.Name = "livingroom_couch_lamp";
            this.livingroom_couch_lamp.Size = new System.Drawing.Size(201, 321);
            this.livingroom_couch_lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livingroom_couch_lamp.TabIndex = 3;
            this.livingroom_couch_lamp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NFCInHome_Server.Properties.Resources.livingroom;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1218, 757);
            this.Controls.Add(this.livingroom_couch_lamp);
            this.Controls.Add(this.livingroom_table_lamp);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.livingroom_table_lamp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingroom_couch_lamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox livingroom_table_lamp;
        private System.Windows.Forms.PictureBox livingroom_couch_lamp;


    }
}

