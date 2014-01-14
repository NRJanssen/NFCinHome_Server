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
            this.lb_received_commands = new System.Windows.Forms.ListBox();
            this.pb_background = new System.Windows.Forms.PictureBox();
            this.livingroom_table_lamp = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingroom_table_lamp)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_received_commands
            // 
            this.lb_received_commands.FormattingEnabled = true;
            this.lb_received_commands.Location = new System.Drawing.Point(12, 12);
            this.lb_received_commands.Name = "lb_received_commands";
            this.lb_received_commands.Size = new System.Drawing.Size(242, 576);
            this.lb_received_commands.TabIndex = 0;
            // 
            // pb_background
            // 
            this.pb_background.Image = ((System.Drawing.Image)(resources.GetObject("pb_background.Image")));
            this.pb_background.Location = new System.Drawing.Point(296, 24);
            this.pb_background.Name = "pb_background";
            this.pb_background.Size = new System.Drawing.Size(846, 564);
            this.pb_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_background.TabIndex = 1;
            this.pb_background.TabStop = false;
            // 
            // livingroom_table_lamp
            // 
            this.livingroom_table_lamp.Image = ((System.Drawing.Image)(resources.GetObject("livingroom_table_lamp.Image")));
            this.livingroom_table_lamp.Location = new System.Drawing.Point(908, 228);
            this.livingroom_table_lamp.Name = "livingroom_table_lamp";
            this.livingroom_table_lamp.Size = new System.Drawing.Size(135, 120);
            this.livingroom_table_lamp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.livingroom_table_lamp.TabIndex = 2;
            this.livingroom_table_lamp.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 615);
            this.Controls.Add(this.livingroom_table_lamp);
            this.Controls.Add(this.pb_background);
            this.Controls.Add(this.lb_received_commands);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livingroom_table_lamp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_received_commands;
        private System.Windows.Forms.PictureBox pb_background;
        private System.Windows.Forms.PictureBox livingroom_table_lamp;


    }
}

