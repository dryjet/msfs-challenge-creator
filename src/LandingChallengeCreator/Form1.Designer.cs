namespace LandingChallengeCreator
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnDeploy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numWindFrom = new System.Windows.Forms.NumericUpDown();
            this.numWindKnots = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLatitude = new System.Windows.Forms.MaskedTextBox();
            this.txtLongitude = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtFlight = new System.Windows.Forms.DateTimePicker();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbRunwayDesignator = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRunway = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIcao = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAirspeed = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAltitude = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtHeading = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtFlaps = new System.Windows.Forms.MaskedTextBox();
            this.cmbAirplane = new System.Windows.Forms.ComboBox();
            this.btnNewApproach = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setPackageFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.numWindFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindKnots)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 394);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnDeploy
            // 
            this.btnDeploy.Location = new System.Drawing.Point(603, 438);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(130, 23);
            this.btnDeploy.TabIndex = 1;
            this.btnDeploy.Text = "Deploy approach";
            this.btnDeploy.UseVisualStyleBackColor = true;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "@";
            // 
            // numWindFrom
            // 
            this.numWindFrom.Location = new System.Drawing.Point(30, 51);
            this.numWindFrom.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numWindFrom.Name = "numWindFrom";
            this.numWindFrom.Size = new System.Drawing.Size(120, 20);
            this.numWindFrom.TabIndex = 5;
            this.numWindFrom.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.numWindFrom.Validated += new System.EventHandler(this.numWindFrom_Validated);
            // 
            // numWindKnots
            // 
            this.numWindKnots.Location = new System.Drawing.Point(180, 51);
            this.numWindKnots.Name = "numWindKnots";
            this.numWindKnots.Size = new System.Drawing.Size(120, 20);
            this.numWindKnots.TabIndex = 6;
            this.numWindKnots.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numWindKnots.Validated += new System.EventHandler(this.numWindKnots_Validated);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Wind from";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "knots";
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(30, 49);
            this.txtLatitude.Mask = "L000\\° 00\\\' 00\\.00\"";
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(100, 20);
            this.txtLatitude.TabIndex = 9;
            this.txtLatitude.Validated += new System.EventHandler(this.txtLatitude_Validated);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(152, 49);
            this.txtLongitude.Mask = "L000\\° 00\\\' 00\\.00\"";
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(100, 20);
            this.txtLongitude.TabIndex = 10;
            this.txtLongitude.Validated += new System.EventHandler(this.txtLongitude_Validated);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.dtFlight);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.cmbRunwayDesignator);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtRunway);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIcao);
            this.groupBox1.Location = new System.Drawing.Point(232, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 109);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Airport";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(199, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Date of flight";
            // 
            // dtFlight
            // 
            this.dtFlight.Location = new System.Drawing.Point(202, 81);
            this.dtFlight.Name = "dtFlight";
            this.dtFlight.Size = new System.Drawing.Size(274, 20);
            this.dtFlight.TabIndex = 17;
            this.dtFlight.Validated += new System.EventHandler(this.dtFlight_Validated);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(30, 29);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(446, 20);
            this.txtName.TabIndex = 16;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // cmbRunwayDesignator
            // 
            this.cmbRunwayDesignator.FormattingEnabled = true;
            this.cmbRunwayDesignator.Items.AddRange(new object[] {
            " ",
            "L",
            "C",
            "R"});
            this.cmbRunwayDesignator.Location = new System.Drawing.Point(140, 80);
            this.cmbRunwayDesignator.Name = "cmbRunwayDesignator";
            this.cmbRunwayDesignator.Size = new System.Drawing.Size(37, 21);
            this.cmbRunwayDesignator.TabIndex = 15;
            this.cmbRunwayDesignator.Validated += new System.EventHandler(this.cmbRunwayDesignator_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Runway";
            // 
            // txtRunway
            // 
            this.txtRunway.Location = new System.Drawing.Point(108, 81);
            this.txtRunway.Mask = "00";
            this.txtRunway.Name = "txtRunway";
            this.txtRunway.Size = new System.Drawing.Size(26, 20);
            this.txtRunway.TabIndex = 13;
            this.txtRunway.Validated += new System.EventHandler(this.txtRunway_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "ICAO";
            // 
            // txtIcao
            // 
            this.txtIcao.Location = new System.Drawing.Point(30, 81);
            this.txtIcao.Mask = "LLLL";
            this.txtIcao.Name = "txtIcao";
            this.txtIcao.Size = new System.Drawing.Size(48, 20);
            this.txtIcao.TabIndex = 0;
            this.txtIcao.Validated += new System.EventHandler(this.txtIcao_Validated);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAirspeed);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.txtAltitude);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtHeading);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtLatitude);
            this.groupBox2.Controls.Add(this.txtLongitude);
            this.groupBox2.Location = new System.Drawing.Point(232, 151);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(501, 86);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Approach";
            // 
            // txtAirspeed
            // 
            this.txtAirspeed.Location = new System.Drawing.Point(428, 49);
            this.txtAirspeed.Mask = "000\\k\\t\\s";
            this.txtAirspeed.Name = "txtAirspeed";
            this.txtAirspeed.Size = new System.Drawing.Size(48, 20);
            this.txtAirspeed.TabIndex = 23;
            this.txtAirspeed.Validated += new System.EventHandler(this.txtAirspeed_Validated);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(425, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Airspeed";
            // 
            // txtAltitude
            // 
            this.txtAltitude.Location = new System.Drawing.Point(354, 49);
            this.txtAltitude.Mask = "00009\\f\\t";
            this.txtAltitude.Name = "txtAltitude";
            this.txtAltitude.Size = new System.Drawing.Size(48, 20);
            this.txtAltitude.TabIndex = 21;
            this.txtAltitude.Validated += new System.EventHandler(this.txtAltitude_Validated);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Altitude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Heading";
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(278, 49);
            this.txtHeading.Mask = "000\\°";
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(48, 20);
            this.txtHeading.TabIndex = 17;
            this.txtHeading.Validated += new System.EventHandler(this.txtHeading_Validated);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(149, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Longitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Latitude";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numWindKnots);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.numWindFrom);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(232, 344);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(501, 88);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Weather";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(232, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.txtFlaps);
            this.groupBox4.Controls.Add(this.cmbAirplane);
            this.groupBox4.Location = new System.Drawing.Point(232, 243);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(500, 95);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Airplane";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Flaps";
            // 
            // txtFlaps
            // 
            this.txtFlaps.Location = new System.Drawing.Point(30, 65);
            this.txtFlaps.Mask = "000\\%";
            this.txtFlaps.Name = "txtFlaps";
            this.txtFlaps.Size = new System.Drawing.Size(48, 20);
            this.txtFlaps.TabIndex = 20;
            this.txtFlaps.Validated += new System.EventHandler(this.txtFlaps_Validated);
            // 
            // cmbAirplane
            // 
            this.cmbAirplane.FormattingEnabled = true;
            this.cmbAirplane.Items.AddRange(new object[] {
            "Airbus A320 Neo Asobo",
            "Boeing 747-8i Asobo",
            "Bonanza G36 Asobo"});
            this.cmbAirplane.Location = new System.Drawing.Point(30, 19);
            this.cmbAirplane.Name = "cmbAirplane";
            this.cmbAirplane.Size = new System.Drawing.Size(446, 21);
            this.cmbAirplane.TabIndex = 0;
            this.cmbAirplane.SelectedIndexChanged += new System.EventHandler(this.cmbAirplane_SelectedIndexChanged);
            // 
            // btnNewApproach
            // 
            this.btnNewApproach.Location = new System.Drawing.Point(12, 438);
            this.btnNewApproach.Name = "btnNewApproach";
            this.btnNewApproach.Size = new System.Drawing.Size(214, 23);
            this.btnNewApproach.TabIndex = 16;
            this.btnNewApproach.Text = "New approach...";
            this.btnNewApproach.UseVisualStyleBackColor = true;
            this.btnNewApproach.Click += new System.EventHandler(this.btnNewApproach_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPackageFolderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setPackageFolderToolStripMenuItem
            // 
            this.setPackageFolderToolStripMenuItem.Name = "setPackageFolderToolStripMenuItem";
            this.setPackageFolderToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.setPackageFolderToolStripMenuItem.Text = "Set Package Folder";
            this.setPackageFolderToolStripMenuItem.Click += new System.EventHandler(this.setPackageFolderToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(744, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 492);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnNewApproach);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeploy);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Landing Challenge Creator";
            ((System.ComponentModel.ISupportInitialize)(this.numWindFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWindKnots)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnDeploy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numWindFrom;
        private System.Windows.Forms.NumericUpDown numWindKnots;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox txtLatitude;
        private System.Windows.Forms.MaskedTextBox txtLongitude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtIcao;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtRunway;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbRunwayDesignator;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtAltitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox txtHeading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbAirplane;
        private System.Windows.Forms.MaskedTextBox txtAirspeed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox txtFlaps;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtFlight;
        private System.Windows.Forms.Button btnNewApproach;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setPackageFolderToolStripMenuItem;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

