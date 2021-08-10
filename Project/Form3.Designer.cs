namespace Project
{
    partial class Form3
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
            this.btnRestart2 = new System.Windows.Forms.Button();
            this.btnQuit2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRestart2
            // 
            this.btnRestart2.Location = new System.Drawing.Point(496, 283);
            this.btnRestart2.Name = "btnRestart2";
            this.btnRestart2.Size = new System.Drawing.Size(119, 32);
            this.btnRestart2.TabIndex = 0;
            this.btnRestart2.Text = "Restart";
            this.btnRestart2.UseVisualStyleBackColor = true;
            this.btnRestart2.Click += new System.EventHandler(this.btnRestart2_Click);
            // 
            // btnQuit2
            // 
            this.btnQuit2.Location = new System.Drawing.Point(496, 347);
            this.btnQuit2.Name = "btnQuit2";
            this.btnQuit2.Size = new System.Drawing.Size(119, 32);
            this.btnQuit2.TabIndex = 1;
            this.btnQuit2.Text = "Quit";
            this.btnQuit2.UseVisualStyleBackColor = true;
            this.btnQuit2.Click += new System.EventHandler(this.btnQuit2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project.Properties.Resources.Game_over;
            this.ClientSize = new System.Drawing.Size(1124, 735);
            this.Controls.Add(this.btnQuit2);
            this.Controls.Add(this.btnRestart2);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRestart2;
        private System.Windows.Forms.Button btnQuit2;
    }
}