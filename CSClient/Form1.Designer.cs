namespace CSClient
{
    partial class MainForm
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
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.ReadBtn = new System.Windows.Forms.Button();
            this.Label7 = new System.Windows.Forms.Label();
            this.TxtSize = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TxtDump = new System.Windows.Forms.TextBox();
            this.TxtDB = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.DisconnectBtn = new System.Windows.Forms.Button();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.TxtSlot = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TxtRack = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.TxtIP = new System.Windows.Forms.TextBox();
            this.TextError = new System.Windows.Forms.TextBox();
            this.FieldBtn = new System.Windows.Forms.Button();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.TxtOffset = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtValue = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(314, 37);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(89, 12);
            this.Label11.TabIndex = 41;
            this.Label11.Text = "Rack=0, Slot=0";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(314, 25);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(83, 12);
            this.Label10.TabIndex = 40;
            this.Label10.Text = "See HW Config";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(314, 13);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(89, 12);
            this.Label9.TabIndex = 39;
            this.Label9.Text = "Rack=0, Slot=2";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(232, 25);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(71, 12);
            this.Label8.TabIndex = 38;
            this.Label8.Text = "S7400/WinAC";
            // 
            // ReadBtn
            // 
            this.ReadBtn.Enabled = false;
            this.ReadBtn.Location = new System.Drawing.Point(14, 102);
            this.ReadBtn.Name = "ReadBtn";
            this.ReadBtn.Size = new System.Drawing.Size(97, 21);
            this.ReadBtn.TabIndex = 37;
            this.ReadBtn.Text = "DB Read";
            this.ReadBtn.UseVisualStyleBackColor = true;
            this.ReadBtn.Click += new System.EventHandler(this.ReadBtn_Click);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(196, 104);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 12);
            this.Label7.TabIndex = 36;
            this.Label7.Text = "Size (Bytes)";
            // 
            // TxtSize
            // 
            this.TxtSize.Enabled = false;
            this.TxtSize.Location = new System.Drawing.Point(264, 102);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.Size = new System.Drawing.Size(45, 21);
            this.TxtSize.TabIndex = 29;
            this.TxtSize.Text = "124";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(119, 104);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(17, 12);
            this.Label6.TabIndex = 35;
            this.Label6.Text = "DB";
            // 
            // TxtDump
            // 
            this.TxtDump.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtDump.BackColor = System.Drawing.Color.White;
            this.TxtDump.Enabled = false;
            this.TxtDump.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDump.ForeColor = System.Drawing.Color.Black;
            this.TxtDump.Location = new System.Drawing.Point(15, 128);
            this.TxtDump.Multiline = true;
            this.TxtDump.Name = "TxtDump";
            this.TxtDump.ReadOnly = true;
            this.TxtDump.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtDump.Size = new System.Drawing.Size(581, 251);
            this.TxtDump.TabIndex = 34;
            // 
            // TxtDB
            // 
            this.TxtDB.Enabled = false;
            this.TxtDB.Location = new System.Drawing.Point(146, 102);
            this.TxtDB.Name = "TxtDB";
            this.TxtDB.Size = new System.Drawing.Size(45, 21);
            this.TxtDB.TabIndex = 28;
            this.TxtDB.Text = "1";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(232, 37);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(71, 12);
            this.Label5.TabIndex = 33;
            this.Label5.Text = "S71200/1500";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(232, 13);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(35, 12);
            this.Label4.TabIndex = 32;
            this.Label4.Text = "S7300";
            // 
            // DisconnectBtn
            // 
            this.DisconnectBtn.Enabled = false;
            this.DisconnectBtn.Location = new System.Drawing.Point(122, 62);
            this.DisconnectBtn.Name = "DisconnectBtn";
            this.DisconnectBtn.Size = new System.Drawing.Size(100, 21);
            this.DisconnectBtn.TabIndex = 31;
            this.DisconnectBtn.Text = "Disconnect";
            this.DisconnectBtn.UseVisualStyleBackColor = true;
            this.DisconnectBtn.Click += new System.EventHandler(this.DisconnectBtn_Click);
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(12, 62);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(100, 21);
            this.ConnectBtn.TabIndex = 26;
            this.ConnectBtn.Text = "Connect";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(178, 6);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(29, 12);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Slot";
            // 
            // TxtSlot
            // 
            this.TxtSlot.Location = new System.Drawing.Point(178, 23);
            this.TxtSlot.Name = "TxtSlot";
            this.TxtSlot.Size = new System.Drawing.Size(44, 21);
            this.TxtSlot.TabIndex = 25;
            this.TxtSlot.Text = "2";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(122, 6);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(29, 12);
            this.Label2.TabIndex = 27;
            this.Label2.Text = "Rack";
            // 
            // TxtRack
            // 
            this.TxtRack.Location = new System.Drawing.Point(122, 23);
            this.TxtRack.Name = "TxtRack";
            this.TxtRack.Size = new System.Drawing.Size(44, 21);
            this.TxtRack.TabIndex = 23;
            this.TxtRack.Text = "0";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 6);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(65, 12);
            this.Label1.TabIndex = 24;
            this.Label1.Text = "IP Address";
            // 
            // TxtIP
            // 
            this.TxtIP.Location = new System.Drawing.Point(12, 23);
            this.TxtIP.Name = "TxtIP";
            this.TxtIP.Size = new System.Drawing.Size(100, 21);
            this.TxtIP.TabIndex = 22;
            this.TxtIP.Text = "192.168.10.110";
            // 
            // TextError
            // 
            this.TextError.BackColor = System.Drawing.Color.White;
            this.TextError.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextError.ForeColor = System.Drawing.Color.Black;
            this.TextError.Location = new System.Drawing.Point(0, 517);
            this.TextError.Name = "TextError";
            this.TextError.ReadOnly = true;
            this.TextError.Size = new System.Drawing.Size(605, 21);
            this.TextError.TabIndex = 21;
            // 
            // FieldBtn
            // 
            this.FieldBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FieldBtn.Location = new System.Drawing.Point(14, 486);
            this.FieldBtn.Name = "FieldBtn";
            this.FieldBtn.Size = new System.Drawing.Size(101, 21);
            this.FieldBtn.TabIndex = 42;
            this.FieldBtn.Text = "Field Get";
            this.FieldBtn.UseVisualStyleBackColor = true;
            this.FieldBtn.Click += new System.EventHandler(this.FieldBtn_Click);
            // 
            // CBType
            // 
            this.CBType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBType.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBType.FormattingEnabled = true;
            this.CBType.Items.AddRange(new object[] {
            "Byte    8 Bit Word                     (All)",
            "Word   16 Bit Word                     (All)",
            "DWord  32 Bit Word                     (All)",
            "LWord  64 Bit Word                     (S71500)",
            "USint   8 Bit Unsigned Integer         (S71200/1500)",
            "UInt   16 Bit Unsigned Integer         (S71200/1500)",
            "UDInt  32 Bit Unsigned Integer         (S71200/1500)",
            "ULint  64 Bit Unsigned Integer         (S71500)",
            "Sint    8 Bit Signed Integer           (S71200/1500)",
            "Int    16 Bit Signed Integer           (All)",
            "DInt   32 Bit Signed Integer           (S71200/1500)",
            "LInt   64 Bit Signed Integer           (S71500)",
            "Real   32 Bit Floating point           (All)",
            "LReal  64 Bit Floating point           (S71200/1500)",
            "Time   32 Bit Time elapsed ms          (All)",
            "LTime  64 Bit Time Elapsed ns          (S71500)",
            "Date   16 Bit days from 1990/1/1       (All)",
            "TOD    32 Bit ms elapsed from midnight (All)",
            "DT      8 Byte Date and Time           (All)",
            "LTOD   64 Bit time of day (ns)         (S71500)",
            "DTL    12 Byte Date and Time Long      (S71200/1500)",
            "LDT    64 Bit ns elapsed from 1970/1/1 (S71500)"});
            this.CBType.Location = new System.Drawing.Point(15, 405);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(409, 22);
            this.CBType.TabIndex = 43;
            // 
            // TxtOffset
            // 
            this.TxtOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtOffset.Location = new System.Drawing.Point(15, 453);
            this.TxtOffset.Name = "TxtOffset";
            this.TxtOffset.Size = new System.Drawing.Size(100, 21);
            this.TxtOffset.TabIndex = 44;
            this.TxtOffset.Text = "0";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 390);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 45;
            this.label12.Text = "Field Type";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 438);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 12);
            this.label13.TabIndex = 46;
            this.label13.Text = "Offset";
            // 
            // TxtValue
            // 
            this.TxtValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtValue.Location = new System.Drawing.Point(125, 453);
            this.TxtValue.Name = "TxtValue";
            this.TxtValue.Size = new System.Drawing.Size(299, 21);
            this.TxtValue.TabIndex = 47;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(122, 438);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 12);
            this.label16.TabIndex = 50;
            this.label16.Text = "Field Value";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(122, 491);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(335, 12);
            this.label14.TabIndex = 51;
            this.label14.Text = "(From the above buffer - Refresh with DBRead if needed)";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(452, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 21);
            this.button1.TabIndex = 52;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 21);
            this.button2.TabIndex = 53;
            this.button2.Text = "GetPlcDateTime";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(411, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 12);
            this.label15.TabIndex = 54;
            this.label15.Text = "label15";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(320, 95);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 21);
            this.button3.TabIndex = 55;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(411, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 12);
            this.label17.TabIndex = 56;
            this.label17.Text = "label17";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(486, 62);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 21);
            this.button4.TabIndex = 57;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(473, 99);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 12);
            this.label18.TabIndex = 58;
            this.label18.Text = "label18";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(546, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 12);
            this.label19.TabIndex = 59;
            this.label19.Text = "github";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 538);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TxtValue);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TxtOffset);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.FieldBtn);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.ReadBtn);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.TxtDump);
            this.Controls.Add(this.TxtDB);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.DisconnectBtn);
            this.Controls.Add(this.ConnectBtn);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.TxtSlot);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TxtRack);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TxtIP);
            this.Controls.Add(this.TextError);
            this.MaximumSize = new System.Drawing.Size(621, 92310);
            this.MinimumSize = new System.Drawing.Size(621, 38);
            this.Name = "MainForm";
            this.Text = "C# Simple Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Button ReadBtn;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox TxtSize;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox TxtDump;
        internal System.Windows.Forms.TextBox TxtDB;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button DisconnectBtn;
        internal System.Windows.Forms.Button ConnectBtn;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox TxtSlot;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox TxtRack;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox TxtIP;
        internal System.Windows.Forms.TextBox TextError;
        private System.Windows.Forms.Button FieldBtn;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.TextBox TxtOffset;
        internal System.Windows.Forms.Label label12;
        internal System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtValue;
        internal System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

