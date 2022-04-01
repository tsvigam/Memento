
namespace Memento
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SaveBtn = new System.Windows.Forms.Button();
            this.RestoreBtn = new System.Windows.Forms.Button();
            this.RubText = new System.Windows.Forms.TextBox();
            this.AudText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(41, 185);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(94, 29);
            this.SaveBtn.TabIndex = 0;
            this.SaveBtn.Text = "SaveBtn";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // RestoreBtn
            // 
            this.RestoreBtn.Location = new System.Drawing.Point(141, 185);
            this.RestoreBtn.Name = "RestoreBtn";
            this.RestoreBtn.Size = new System.Drawing.Size(94, 29);
            this.RestoreBtn.TabIndex = 1;
            this.RestoreBtn.Text = "RestoreBtn";
            this.RestoreBtn.UseVisualStyleBackColor = true;
            this.RestoreBtn.Click += new System.EventHandler(this.RestoreBtn_Click);
            // 
            // RubText
            // 
            this.RubText.Location = new System.Drawing.Point(41, 33);
            this.RubText.Name = "RubText";
            this.RubText.Size = new System.Drawing.Size(187, 27);
            this.RubText.TabIndex = 2;
            // 
            // AudText
            // 
            this.AudText.Location = new System.Drawing.Point(41, 93);
            this.AudText.Name = "AudText";
            this.AudText.Size = new System.Drawing.Size(187, 27);
            this.AudText.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.AudText);
            this.Controls.Add(this.RubText);
            this.Controls.Add(this.RestoreBtn);
            this.Controls.Add(this.SaveBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button RestoreBtn;
        private System.Windows.Forms.TextBox RubText;
        private System.Windows.Forms.TextBox AudText;
    }
}

