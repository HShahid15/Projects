namespace thompson
{
    partial class loginPopUp
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
            this.loginBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // loginBrowser
            // 
            this.loginBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginBrowser.Location = new System.Drawing.Point(0, 0);
            this.loginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.loginBrowser.Name = "loginBrowser";
            this.loginBrowser.Size = new System.Drawing.Size(1374, 929);
            this.loginBrowser.TabIndex = 5;
            this.loginBrowser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.loginBrowser_Navigated);
            this.loginBrowser.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.loginBrowser_Navigating);
            // 
            // loginPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1374, 929);
            this.Controls.Add(this.loginBrowser);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "loginPopUp";
            this.Text = "Rent Space - Login";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.WebBrowser loginBrowser;
    }
}