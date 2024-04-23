namespace Excel_Connection
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
            this.cmd_Write = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmd_Write
            // 
            this.cmd_Write.Location = new System.Drawing.Point(22, 51);
            this.cmd_Write.Name = "cmd_Write";
            this.cmd_Write.Size = new System.Drawing.Size(130, 47);
            this.cmd_Write.TabIndex = 0;
            this.cmd_Write.Text = "cmd_Write";
            this.cmd_Write.UseVisualStyleBackColor = true;
            this.cmd_Write.Click += new System.EventHandler(this.cmd_Write_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmd_Write);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmd_Write;
    }
}

