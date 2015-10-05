namespace LikeWin8Message
{
    partial class MessageForm
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
            this.messagePanel1 = new LikeWin8Message.MessagePanel();
            this.SuspendLayout();
            // 
            // messagePanel1
            // 
            this.messagePanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.messagePanel1.Location = new System.Drawing.Point(0, 0);
            this.messagePanel1.Name = "messagePanel1";
            this.messagePanel1.Size = new System.Drawing.Size(450, 60);
            this.messagePanel1.TabIndex = 0;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 60);
            this.ControlBox = false;
            this.Controls.Add(this.messagePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageForm";
            this.ShowInTaskbar = false;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageForm_FormClosed);
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.Shown += new System.EventHandler(this.MessageForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private MessagePanel messagePanel1;
    }
}