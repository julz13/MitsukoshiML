
namespace MitsukoshiML
{
    partial class config
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPOST = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtGET = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAPIkey = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSecretKey = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtXMLPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContractNo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPOSNo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(443, 393);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.label17);
            this.tabPage1.Controls.Add(this.txtComName);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.txtPOSNo);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.txtContractNo);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.txtXMLPath);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(435, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "WBOX Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtSecretKey);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtAPIkey);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.txtGET);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtPOST);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(435, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mall Linking Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Tomato;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(475, 41);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Tomato;
            this.panel2.Location = new System.Drawing.Point(-3, 504);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(475, 10);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(116, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Browse the location where XML file is located.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(124, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "For inserting of data.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 17);
            this.label6.TabIndex = 6;
            // 
            // txtPOST
            // 
            this.txtPOST.Location = new System.Drawing.Point(124, 68);
            this.txtPOST.Name = "txtPOST";
            this.txtPOST.Size = new System.Drawing.Size(285, 23);
            this.txtPOST.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Post API:*";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(12, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 55);
            this.panel3.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.LightCoral;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(234, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 40);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(343, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 40);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Firebrick;
            this.panel4.Location = new System.Drawing.Point(236, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 40);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Location = new System.Drawing.Point(345, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(90, 40);
            this.panel5.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(124, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "For retrieving/viewing of data.";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(155, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 17);
            this.label9.TabIndex = 10;
            // 
            // txtGET
            // 
            this.txtGET.Location = new System.Drawing.Point(124, 126);
            this.txtGET.Name = "txtGET";
            this.txtGET.Size = new System.Drawing.Size(285, 23);
            this.txtGET.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(26, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Get API:*";
            // 
            // txtAPIkey
            // 
            this.txtAPIkey.Location = new System.Drawing.Point(124, 225);
            this.txtAPIkey.Name = "txtAPIkey";
            this.txtAPIkey.Size = new System.Drawing.Size(285, 23);
            this.txtAPIkey.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(26, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 20);
            this.label11.TabIndex = 12;
            this.label11.Text = "apiKey:*";
            // 
            // txtSecretKey
            // 
            this.txtSecretKey.Location = new System.Drawing.Point(124, 269);
            this.txtSecretKey.Name = "txtSecretKey";
            this.txtSecretKey.Size = new System.Drawing.Size(285, 23);
            this.txtSecretKey.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(26, 269);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "secretKey:*";
            // 
            // txtXMLPath
            // 
            this.txtXMLPath.Location = new System.Drawing.Point(119, 264);
            this.txtXMLPath.Name = "txtXMLPath";
            this.txtXMLPath.Size = new System.Drawing.Size(239, 23);
            this.txtXMLPath.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "xml API:*";
            // 
            // txtContractNo
            // 
            this.txtContractNo.Location = new System.Drawing.Point(145, 55);
            this.txtContractNo.Name = "txtContractNo";
            this.txtContractNo.Size = new System.Drawing.Size(257, 23);
            this.txtContractNo.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(33, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "ContractNo:*";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MitsukoshiML.Properties.Resources.cogs_gear_setting_icon_127225;
            this.pictureBox2.Location = new System.Drawing.Point(20, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 34);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::MitsukoshiML.Properties.Resources.Windows_Close_Program_22531;
            this.btnClose.Location = new System.Drawing.Point(426, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::MitsukoshiML.Properties.Resources.blue_download_alt_folder_12391;
            this.button3.Location = new System.Drawing.Point(362, 257);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 37);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Maroon;
            this.label14.Location = new System.Drawing.Point(44, 178);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(340, 15);
            this.label14.TabIndex = 16;
            this.label14.Text = "-------Note: Required. Make sure that there is no space.-------";
            // 
            // txtPOSNo
            // 
            this.txtPOSNo.Location = new System.Drawing.Point(145, 124);
            this.txtPOSNo.Name = "txtPOSNo";
            this.txtPOSNo.Size = new System.Drawing.Size(257, 23);
            this.txtPOSNo.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 124);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(73, 20);
            this.label15.TabIndex = 11;
            this.label15.Text = "POS No:*";
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(145, 195);
            this.txtComName.Name = "txtComName";
            this.txtComName.Size = new System.Drawing.Size(257, 23);
            this.txtComName.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(33, 195);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 13;
            this.label16.Text = "Comp. Name:*";
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.Control;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label17.Location = new System.Drawing.Point(142, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(257, 32);
            this.label17.TabIndex = 15;
            this.label17.Text = "Contract number based on POS Assignment Setup.";
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.SystemColors.Control;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label18.Location = new System.Drawing.Point(142, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(257, 32);
            this.label18.TabIndex = 16;
            this.label18.Text = "POS number based on POS Assignment Setup.";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.SystemColors.Control;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label19.Location = new System.Drawing.Point(143, 219);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(257, 21);
            this.label19.TabIndex = 17;
            this.label19.Text = "Company Code provided by NOAH.";
            // 
            // config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(468, 514);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "config";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPOST;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContractNo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtXMLPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSecretKey;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtAPIkey;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtGET;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPOSNo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label label16;
    }
}