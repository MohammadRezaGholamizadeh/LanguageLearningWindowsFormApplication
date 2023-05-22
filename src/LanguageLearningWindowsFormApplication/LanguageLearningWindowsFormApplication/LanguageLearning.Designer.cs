namespace LanguageLearningWindowsFormApplication
{
    partial class LanguageLearning
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
            this.btn_backButton = new System.Windows.Forms.Button();
            this.btn_forwardButton = new System.Windows.Forms.Button();
            this.btn_reloadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_backButton
            // 
            this.btn_backButton.Image = global::LanguageLearningWindowsFormApplication.Properties.Resources.Back1;
            this.btn_backButton.Location = new System.Drawing.Point(21, 12);
            this.btn_backButton.Name = "btn_backButton";
            this.btn_backButton.Size = new System.Drawing.Size(48, 48);
            this.btn_backButton.TabIndex = 2;
            this.btn_backButton.UseVisualStyleBackColor = true;
            this.btn_backButton.Click += new System.EventHandler(this.btn_backButton_Click);
            // 
            // btn_forwardButton
            // 
            this.btn_forwardButton.Image = global::LanguageLearningWindowsFormApplication.Properties.Resources.Forward;
            this.btn_forwardButton.Location = new System.Drawing.Point(75, 12);
            this.btn_forwardButton.Name = "btn_forwardButton";
            this.btn_forwardButton.Size = new System.Drawing.Size(48, 48);
            this.btn_forwardButton.TabIndex = 3;
            this.btn_forwardButton.UseVisualStyleBackColor = true;
            this.btn_forwardButton.Click += new System.EventHandler(this.btn_forwardButton_Click);
            // 
            // btn_reloadButton
            // 
            this.btn_reloadButton.Image = global::LanguageLearningWindowsFormApplication.Properties.Resources.Reload;
            this.btn_reloadButton.Location = new System.Drawing.Point(129, 12);
            this.btn_reloadButton.Name = "btn_reloadButton";
            this.btn_reloadButton.Size = new System.Drawing.Size(48, 48);
            this.btn_reloadButton.TabIndex = 4;
            this.btn_reloadButton.UseVisualStyleBackColor = true;
            this.btn_reloadButton.Click += new System.EventHandler(this.btn_reloadButton_Click);
            // 
            // LanguageLearning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 765);
            this.Controls.Add(this.btn_reloadButton);
            this.Controls.Add(this.btn_forwardButton);
            this.Controls.Add(this.btn_backButton);
            this.Name = "LanguageLearning";
            this.Text = "Language Learning";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_backButton;
        private Button btn_forwardButton;
        private Button btn_reloadButton;
    }
}