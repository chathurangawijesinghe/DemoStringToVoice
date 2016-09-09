namespace DemoStringToVoice
{
    partial class frmStringToVoice
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
            this.btnStringToVoice = new System.Windows.Forms.Button();
            this.txtString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStringToVoice
            // 
            this.btnStringToVoice.Location = new System.Drawing.Point(181, 48);
            this.btnStringToVoice.Name = "btnStringToVoice";
            this.btnStringToVoice.Size = new System.Drawing.Size(93, 23);
            this.btnStringToVoice.TabIndex = 0;
            this.btnStringToVoice.Text = "String To Voice";
            this.btnStringToVoice.UseVisualStyleBackColor = true;
            this.btnStringToVoice.Click += new System.EventHandler(this.btnStringToVoice_Click);
            // 
            // txtString
            // 
            this.txtString.Location = new System.Drawing.Point(12, 12);
            this.txtString.Name = "txtString";
            this.txtString.Size = new System.Drawing.Size(230, 20);
            this.txtString.TabIndex = 1;
            // 
            // frmStringToVoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 81);
            this.Controls.Add(this.txtString);
            this.Controls.Add(this.btnStringToVoice);
            this.Name = "frmStringToVoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "String To Voice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStringToVoice;
        private System.Windows.Forms.TextBox txtString;
    }
}