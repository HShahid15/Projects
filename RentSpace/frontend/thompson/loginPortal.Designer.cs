namespace thompson
{
    partial class loginPortal
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
            this.label1 = new System.Windows.Forms.Label();
            this.organizationCombo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(506, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 79);
            this.label1.TabIndex = 0;
            this.label1.Text = "RentSpace";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // organizationCombo
            // 
            this.organizationCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.organizationCombo.FormattingEnabled = true;
            this.organizationCombo.Items.AddRange(new object[] {
            "Queen\'s University",
            "University of Western Ontario"});
            this.organizationCombo.Location = new System.Drawing.Point(515, 552);
            this.organizationCombo.Name = "organizationCombo";
            this.organizationCombo.Size = new System.Drawing.Size(360, 33);
            this.organizationCombo.TabIndex = 1;
            this.organizationCombo.SelectedIndexChanged += new System.EventHandler(this.organizationCombo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(515, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Organization:";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(520, 622);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(148, 50);
            this.loginButton.TabIndex = 3;
            this.loginButton.Text = "Log In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginPortal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.ClientSize = new System.Drawing.Size(1374, 929);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.organizationCombo);
            this.Controls.Add(this.label1);
            this.Name = "loginPortal";
            this.Text = "RentSpace - Startup Portal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox organizationCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
    }
}