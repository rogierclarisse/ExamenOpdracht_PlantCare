namespace PlantCare2._0
{
    partial class ParentForm
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
            this.btGoToLogin = new System.Windows.Forms.Button();
            this.btGoToSignUp = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGoToLogin
            // 
            this.btGoToLogin.Location = new System.Drawing.Point(647, 384);
            this.btGoToLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btGoToLogin.Name = "btGoToLogin";
            this.btGoToLogin.Size = new System.Drawing.Size(168, 52);
            this.btGoToLogin.TabIndex = 4;
            this.btGoToLogin.Text = "Log in";
            this.btGoToLogin.UseVisualStyleBackColor = true;
            this.btGoToLogin.Click += new System.EventHandler(this.btGoToLogin_Click);
            // 
            // btGoToSignUp
            // 
            this.btGoToSignUp.Location = new System.Drawing.Point(647, 473);
            this.btGoToSignUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btGoToSignUp.Name = "btGoToSignUp";
            this.btGoToSignUp.Size = new System.Drawing.Size(168, 52);
            this.btGoToSignUp.TabIndex = 5;
            this.btGoToSignUp.Text = "Sign up";
            this.btGoToSignUp.UseVisualStyleBackColor = true;
            this.btGoToSignUp.Click += new System.EventHandler(this.btGoToSignUp_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2108, 48);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(2108, 1056);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(2108, 1056);
            this.Controls.Add(this.btGoToSignUp);
            this.Controls.Add(this.btGoToLogin);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ParentForm";
            this.Text = "ParentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btGoToLogin;
        private System.Windows.Forms.Button btGoToSignUp;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button button1;
    }
}