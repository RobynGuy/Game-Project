namespace Project
{
    partial class Form4
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
            this.btnRestart1 = new System.Windows.Forms.Button();
            this.btnQuit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestart1
            // 
            this.btnRestart1.Location = new System.Drawing.Point(480, 263);
            this.btnRestart1.Name = "btnRestart1";
            this.btnRestart1.Size = new System.Drawing.Size(112, 27);
            this.btnRestart1.TabIndex = 0;
            this.btnRestart1.Text = "Restart";
            this.btnRestart1.UseVisualStyleBackColor = true;
            this.btnRestart1.Click += new System.EventHandler(this.btnRestart1_Click);
            // 
            // btnQuit1
            // 
            this.btnQuit1.Location = new System.Drawing.Point(480, 324);
            this.btnQuit1.Name = "btnQuit1";
            this.btnQuit1.Size = new System.Drawing.Size(112, 27);
            this.btnQuit1.TabIndex = 1;
            this.btnQuit1.Text = "Quit";
            this.btnQuit1.UseVisualStyleBackColor = true;
            this.btnQuit1.Click += new System.EventHandler(this.btnQuit1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.You_Win_;
            this.ClientSize = new System.Drawing.Size(1124, 735);
            this.Controls.Add(this.btnQuit1);
            this.Controls.Add(this.btnRestart1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestart1;
        private System.Windows.Forms.Button btnQuit1;
    }
}