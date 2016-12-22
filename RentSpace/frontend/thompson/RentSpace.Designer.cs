namespace thompson
{
    partial class RentSpace
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RentSpace));
            this.dateChooser = new System.Windows.Forms.DateTimePicker();
            this.cartTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.floor = new System.Windows.Forms.ComboBox();
            this.libPick = new System.Windows.Forms.ComboBox();
            this.facilityHeader = new System.Windows.Forms.Label();
            this.userLabel = new System.Windows.Forms.Label();
            this.userHeader = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.bookingGridView = new System.Windows.Forms.DataGridView();
            this.time1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time2 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time5 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time6 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time7 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time8 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time9 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time11 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time12 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time13 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time14 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.time15 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.refreshButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.remainingHoursLabel = new System.Windows.Forms.Label();
            this.cartLabel1 = new System.Windows.Forms.Label();
            this.cartLabel2 = new System.Windows.Forms.Label();
            this.cartLabel3 = new System.Windows.Forms.Label();
            this.cartLabel4 = new System.Windows.Forms.Label();
            this.cartLabel5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cartTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dateChooser
            // 
            this.dateChooser.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.dateChooser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.dateChooser.Location = new System.Drawing.Point(222, 134);
            this.dateChooser.MaxDate = new System.DateTime(3000, 12, 31, 0, 0, 0, 0);
            this.dateChooser.MinDate = new System.DateTime(2016, 11, 29, 0, 0, 0, 0);
            this.dateChooser.Name = "dateChooser";
            this.dateChooser.Size = new System.Drawing.Size(199, 19);
            this.dateChooser.TabIndex = 1;
            // 
            // cartTableLayoutPanel
            // 
            this.cartTableLayoutPanel.BackColor = System.Drawing.SystemColors.Control;
            this.cartTableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.cartTableLayoutPanel.ColumnCount = 1;
            this.cartTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cartTableLayoutPanel.Controls.Add(this.cartLabel2, 0, 1);
            this.cartTableLayoutPanel.Controls.Add(this.cartLabel5, 0, 4);
            this.cartTableLayoutPanel.Controls.Add(this.cartLabel4, 0, 3);
            this.cartTableLayoutPanel.Controls.Add(this.cartLabel3, 0, 2);
            this.cartTableLayoutPanel.Controls.Add(this.cartLabel1, 0, 0);
            this.cartTableLayoutPanel.Location = new System.Drawing.Point(169, 214);
            this.cartTableLayoutPanel.Name = "cartTableLayoutPanel";
            this.cartTableLayoutPanel.RowCount = 5;
            this.cartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cartTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.cartTableLayoutPanel.Size = new System.Drawing.Size(253, 119);
            this.cartTableLayoutPanel.TabIndex = 4;
            this.cartTableLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.cartTableLayoutPanel_Paint);
            // 
            // floor
            // 
            this.floor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.floor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.floor.ForeColor = System.Drawing.SystemColors.WindowText;
            this.floor.FormattingEnabled = true;
            this.floor.Items.AddRange(new object[] {
            "Floor 1",
            "Floor 2",
            "Floor 3",
            "Floor 4"});
            this.floor.Location = new System.Drawing.Point(222, 110);
            this.floor.Name = "floor";
            this.floor.Size = new System.Drawing.Size(199, 21);
            this.floor.TabIndex = 6;
            this.floor.SelectedIndexChanged += new System.EventHandler(this.floor_SelectedIndexChanged);
            // 
            // libPick
            // 
            this.libPick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.libPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F);
            this.libPick.ForeColor = System.Drawing.SystemColors.WindowText;
            this.libPick.FormattingEnabled = true;
            this.libPick.Items.AddRange(new object[] {
            "Stauffer Library"});
            this.libPick.Location = new System.Drawing.Point(222, 86);
            this.libPick.Name = "libPick";
            this.libPick.Size = new System.Drawing.Size(199, 21);
            this.libPick.TabIndex = 15;
            this.libPick.SelectedIndexChanged += new System.EventHandler(this.libPick_SelectedIndexChanged);
            // 
            // facilityHeader
            // 
            this.facilityHeader.AutoSize = true;
            this.facilityHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.facilityHeader.Location = new System.Drawing.Point(166, 86);
            this.facilityHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.facilityHeader.Name = "facilityHeader";
            this.facilityHeader.Size = new System.Drawing.Size(51, 13);
            this.facilityHeader.TabIndex = 21;
            this.facilityHeader.Text = "Facility:";
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(219, 9);
            this.userLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(53, 13);
            this.userLabel.TabIndex = 20;
            this.userLabel.Text = "userLabel";
            // 
            // userHeader
            // 
            this.userHeader.AutoSize = true;
            this.userHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userHeader.Location = new System.Drawing.Point(166, 9);
            this.userHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.userHeader.Name = "userHeader";
            this.userHeader.Size = new System.Drawing.Size(37, 13);
            this.userHeader.TabIndex = 19;
            this.userHeader.Text = "User:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 111);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Floor:";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1st Floor.png");
            this.imageList1.Images.SetKeyName(1, "2nd Floor.png");
            this.imageList1.Images.SetKeyName(2, "3rd Floor.png");
            this.imageList1.Images.SetKeyName(3, "4th Floor.png");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Date:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(166, 189);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(118, 13);
            this.label20.TabIndex = 26;
            this.label20.Text = "Active Rooms/Cart:";
            // 
            // bookingGridView
            // 
            this.bookingGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bookingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.time1,
            this.time2,
            this.time3,
            this.time4,
            this.time5,
            this.time6,
            this.time7,
            this.time8,
            this.time9,
            this.time10,
            this.time11,
            this.time12,
            this.time13,
            this.time14,
            this.time15});
            this.bookingGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.bookingGridView.Location = new System.Drawing.Point(8, 376);
            this.bookingGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bookingGridView.MultiSelect = false;
            this.bookingGridView.Name = "bookingGridView";
            this.bookingGridView.ReadOnly = true;
            this.bookingGridView.RowTemplate.Height = 33;
            this.bookingGridView.Size = new System.Drawing.Size(848, 150);
            this.bookingGridView.TabIndex = 27;
            this.bookingGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bookingGridView_CellContentClick);
            // 
            // time1
            // 
            this.time1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time1.HeaderText = "8:30";
            this.time1.Name = "time1";
            this.time1.ReadOnly = true;
            // 
            // time2
            // 
            this.time2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time2.HeaderText = "9:30";
            this.time2.Name = "time2";
            this.time2.ReadOnly = true;
            // 
            // time3
            // 
            this.time3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time3.HeaderText = "10:30";
            this.time3.Name = "time3";
            this.time3.ReadOnly = true;
            // 
            // time4
            // 
            this.time4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time4.HeaderText = "11:30";
            this.time4.Name = "time4";
            this.time4.ReadOnly = true;
            // 
            // time5
            // 
            this.time5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time5.HeaderText = "12:30";
            this.time5.Name = "time5";
            this.time5.ReadOnly = true;
            // 
            // time6
            // 
            this.time6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time6.HeaderText = "1:30";
            this.time6.Name = "time6";
            this.time6.ReadOnly = true;
            // 
            // time7
            // 
            this.time7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time7.HeaderText = "2:30";
            this.time7.Name = "time7";
            this.time7.ReadOnly = true;
            // 
            // time8
            // 
            this.time8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time8.HeaderText = "3:30";
            this.time8.Name = "time8";
            this.time8.ReadOnly = true;
            // 
            // time9
            // 
            this.time9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time9.HeaderText = "4:30";
            this.time9.Name = "time9";
            this.time9.ReadOnly = true;
            // 
            // time10
            // 
            this.time10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time10.HeaderText = "5:30";
            this.time10.Name = "time10";
            this.time10.ReadOnly = true;
            // 
            // time11
            // 
            this.time11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time11.HeaderText = "6:30";
            this.time11.Name = "time11";
            this.time11.ReadOnly = true;
            // 
            // time12
            // 
            this.time12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time12.HeaderText = "7:30";
            this.time12.Name = "time12";
            this.time12.ReadOnly = true;
            // 
            // time13
            // 
            this.time13.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time13.HeaderText = "8:30";
            this.time13.Name = "time13";
            this.time13.ReadOnly = true;
            // 
            // time14
            // 
            this.time14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time14.HeaderText = "9:30";
            this.time14.Name = "time14";
            this.time14.ReadOnly = true;
            // 
            // time15
            // 
            this.time15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time15.HeaderText = "10:30";
            this.time15.Name = "time15";
            this.time15.ReadOnly = true;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(168, 158);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(250, 20);
            this.refreshButton.TabIndex = 28;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(169, 338);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(254, 20);
            this.submitButton.TabIndex = 28;
            this.submitButton.Text = " Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Remaining Hours:";
            // 
            // remainingHoursLabel
            // 
            this.remainingHoursLabel.AutoSize = true;
            this.remainingHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingHoursLabel.Location = new System.Drawing.Point(391, 9);
            this.remainingHoursLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.remainingHoursLabel.Name = "remainingHoursLabel";
            this.remainingHoursLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.remainingHoursLabel.Size = new System.Drawing.Size(35, 13);
            this.remainingHoursLabel.TabIndex = 21;
            this.remainingHoursLabel.Text = "####";
            // 
            // cartLabel1
            // 
            this.cartLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartLabel1.AutoSize = true;
            this.cartLabel1.Location = new System.Drawing.Point(4, 1);
            this.cartLabel1.Name = "cartLabel1";
            this.cartLabel1.Size = new System.Drawing.Size(245, 13);
            this.cartLabel1.TabIndex = 0;
            this.cartLabel1.Text = "label4";
            this.cartLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cartLabel1.Click += new System.EventHandler(this.label4_Click);
            // 
            // cartLabel2
            // 
            this.cartLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartLabel2.AutoSize = true;
            this.cartLabel2.Location = new System.Drawing.Point(4, 24);
            this.cartLabel2.Name = "cartLabel2";
            this.cartLabel2.Size = new System.Drawing.Size(245, 13);
            this.cartLabel2.TabIndex = 1;
            this.cartLabel2.Text = "label5";
            this.cartLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartLabel3
            // 
            this.cartLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartLabel3.AutoSize = true;
            this.cartLabel3.Location = new System.Drawing.Point(4, 47);
            this.cartLabel3.Name = "cartLabel3";
            this.cartLabel3.Size = new System.Drawing.Size(245, 13);
            this.cartLabel3.TabIndex = 2;
            this.cartLabel3.Text = "label6";
            this.cartLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartLabel4
            // 
            this.cartLabel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartLabel4.AutoSize = true;
            this.cartLabel4.Location = new System.Drawing.Point(4, 70);
            this.cartLabel4.Name = "cartLabel4";
            this.cartLabel4.Size = new System.Drawing.Size(245, 13);
            this.cartLabel4.TabIndex = 3;
            this.cartLabel4.Text = "label7";
            this.cartLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cartLabel5
            // 
            this.cartLabel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartLabel5.AutoSize = true;
            this.cartLabel5.Location = new System.Drawing.Point(4, 93);
            this.cartLabel5.Name = "cartLabel5";
            this.cartLabel5.Size = new System.Drawing.Size(245, 13);
            this.cartLabel5.TabIndex = 4;
            this.cartLabel5.Text = "label8";
            this.cartLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::thompson.Properties.Resources.floorplan_stauffer_groundfloor_01;
            this.pictureBox1.Location = new System.Drawing.Point(516, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox2.Image = global::thompson.Properties.Resources.rentSpace_real_transparent;
            this.pictureBox2.ImageLocation = "";
            this.pictureBox2.Location = new System.Drawing.Point(14, -50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(320, 300);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // RentSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(861, 526);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.remainingHoursLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.facilityHeader);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userHeader);
            this.Controls.Add(this.floor);
            this.Controls.Add(this.libPick);
            this.Controls.Add(this.dateChooser);
            this.Controls.Add(this.cartTableLayoutPanel);
            this.Controls.Add(this.bookingGridView);
            this.Controls.Add(this.pictureBox2);
            this.Name = "RentSpace";
            this.Text = "Rent Space";
            this.Load += new System.EventHandler(this.RentSpace_Load);
            this.cartTableLayoutPanel.ResumeLayout(false);
            this.cartTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateChooser;
        private System.Windows.Forms.TableLayoutPanel cartTableLayoutPanel;
        private System.Windows.Forms.ComboBox floor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ComboBox libPick;
        private System.Windows.Forms.Label facilityHeader;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label userHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.DataGridView bookingGridView;
        private System.Windows.Forms.DataGridViewButtonColumn time1;
        private System.Windows.Forms.DataGridViewButtonColumn time2;
        private System.Windows.Forms.DataGridViewButtonColumn time3;
        private System.Windows.Forms.DataGridViewButtonColumn time4;
        private System.Windows.Forms.DataGridViewButtonColumn time5;
        private System.Windows.Forms.DataGridViewButtonColumn time6;
        private System.Windows.Forms.DataGridViewButtonColumn time7;
        private System.Windows.Forms.DataGridViewButtonColumn time8;
        private System.Windows.Forms.DataGridViewButtonColumn time9;
        private System.Windows.Forms.DataGridViewButtonColumn time10;
        private System.Windows.Forms.DataGridViewButtonColumn time11;
        private System.Windows.Forms.DataGridViewButtonColumn time12;
        private System.Windows.Forms.DataGridViewButtonColumn time13;
        private System.Windows.Forms.DataGridViewButtonColumn time14;
        private System.Windows.Forms.DataGridViewButtonColumn time15;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label remainingHoursLabel;
        private System.Windows.Forms.Label cartLabel1;
        private System.Windows.Forms.Label cartLabel2;
        private System.Windows.Forms.Label cartLabel5;
        private System.Windows.Forms.Label cartLabel4;
        private System.Windows.Forms.Label cartLabel3;
    }
}

