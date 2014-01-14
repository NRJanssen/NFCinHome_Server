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
            this.lb_received_commands = new System.Windows.Forms.ListBox();
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1154, 615);
            this.Controls.Add(this.lb_received_commands);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_received_commands;


    }
}

