namespace PromIniGen
{
    partial class PromIniGenForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改這個方法的內容。
        ///
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.promFilePath = new System.Windows.Forms.ComboBox();
            this.browse = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.kVer1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sVer1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rVer1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crc = new System.Windows.Forms.TextBox();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.baudSel = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tagAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tagContent = new System.Windows.Forms.TextBox();
            this.tagGroup = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.needTag = new System.Windows.Forms.CheckBox();
            this.kVer3 = new System.Windows.Forms.TextBox();
            this.kVer2 = new System.Windows.Forms.TextBox();
            this.sVer2 = new System.Windows.Forms.TextBox();
            this.sVer3 = new System.Windows.Forms.TextBox();
            this.rVer2 = new System.Windows.Forms.TextBox();
            this.rVer3 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.fullPath = new System.Windows.Forms.Label();
            this.today = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.dopplerGroup = new System.Windows.Forms.GroupBox();
            this.promOutError = new System.Windows.Forms.Label();
            this.promOutPath = new System.Windows.Forms.TextBox();
            this.browse2 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dopplerAddress = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.dopplerSize = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.v6Doppler = new System.Windows.Forms.CheckBox();
            this.tagGroup.SuspendLayout();
            this.dopplerGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prom File :";
            // 
            // promFilePath
            // 
            this.promFilePath.FormattingEnabled = true;
            this.promFilePath.Location = new System.Drawing.Point(16, 29);
            this.promFilePath.Name = "promFilePath";
            this.promFilePath.Size = new System.Drawing.Size(418, 20);
            this.promFilePath.TabIndex = 1;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(440, 27);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(60, 23);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kernel Version";
            // 
            // kVer1
            // 
            this.kVer1.Location = new System.Drawing.Point(106, 135);
            this.kVer1.MaxLength = 3;
            this.kVer1.Name = "kVer1";
            this.kVer1.Size = new System.Drawing.Size(31, 22);
            this.kVer1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Software Version";
            // 
            // sVer1
            // 
            this.sVer1.Location = new System.Drawing.Point(106, 163);
            this.sVer1.MaxLength = 3;
            this.sVer1.Name = "sVer1";
            this.sVer1.Size = new System.Drawing.Size(31, 22);
            this.sVer1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "Revision";
            // 
            // rVer1
            // 
            this.rVer1.Location = new System.Drawing.Point(106, 191);
            this.rVer1.MaxLength = 4;
            this.rVer1.Name = "rVer1";
            this.rVer1.Size = new System.Drawing.Size(73, 22);
            this.rVer1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "CRC";
            // 
            // crc
            // 
            this.crc.Location = new System.Drawing.Point(106, 219);
            this.crc.MaxLength = 4;
            this.crc.Name = "crc";
            this.crc.Size = new System.Drawing.Size(68, 22);
            this.crc.TabIndex = 6;
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(344, 554);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(75, 23);
            this.ok.TabIndex = 7;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(425, 554);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "Baud Rate";
            // 
            // baudSel
            // 
            this.baudSel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudSel.FormattingEnabled = true;
            this.baudSel.Location = new System.Drawing.Point(106, 109);
            this.baudSel.Name = "baudSel";
            this.baudSel.Size = new System.Drawing.Size(117, 20);
            this.baudSel.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tag Address";
            // 
            // tagAddress
            // 
            this.tagAddress.Location = new System.Drawing.Point(102, 19);
            this.tagAddress.MaxLength = 8;
            this.tagAddress.Name = "tagAddress";
            this.tagAddress.Size = new System.Drawing.Size(100, 22);
            this.tagAddress.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 12);
            this.label8.TabIndex = 5;
            this.label8.Text = "Tag Content";
            // 
            // tagContent
            // 
            this.tagContent.Location = new System.Drawing.Point(102, 47);
            this.tagContent.MaxLength = 8;
            this.tagContent.Name = "tagContent";
            this.tagContent.Size = new System.Drawing.Size(100, 22);
            this.tagContent.TabIndex = 6;
            // 
            // tagGroup
            // 
            this.tagGroup.Controls.Add(this.label17);
            this.tagGroup.Controls.Add(this.label16);
            this.tagGroup.Controls.Add(this.label7);
            this.tagGroup.Controls.Add(this.tagAddress);
            this.tagGroup.Controls.Add(this.label8);
            this.tagGroup.Controls.Add(this.tagContent);
            this.tagGroup.Enabled = false;
            this.tagGroup.Location = new System.Drawing.Point(16, 463);
            this.tagGroup.Name = "tagGroup";
            this.tagGroup.Size = new System.Drawing.Size(484, 76);
            this.tagGroup.TabIndex = 10;
            this.tagGroup.TabStop = false;
            this.tagGroup.Text = "Tag Information";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 12);
            this.label17.TabIndex = 7;
            this.label17.Text = "0x";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(85, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "0x";
            // 
            // needTag
            // 
            this.needTag.AutoSize = true;
            this.needTag.Location = new System.Drawing.Point(16, 443);
            this.needTag.Name = "needTag";
            this.needTag.Size = new System.Drawing.Size(69, 16);
            this.needTag.TabIndex = 11;
            this.needTag.Text = "Need Tag";
            this.needTag.UseVisualStyleBackColor = true;
            this.needTag.CheckedChanged += new System.EventHandler(this.needTag_CheckedChanged);
            // 
            // kVer3
            // 
            this.kVer3.Location = new System.Drawing.Point(190, 135);
            this.kVer3.MaxLength = 3;
            this.kVer3.Name = "kVer3";
            this.kVer3.Size = new System.Drawing.Size(31, 22);
            this.kVer3.TabIndex = 4;
            // 
            // kVer2
            // 
            this.kVer2.Location = new System.Drawing.Point(148, 135);
            this.kVer2.MaxLength = 3;
            this.kVer2.Name = "kVer2";
            this.kVer2.Size = new System.Drawing.Size(31, 22);
            this.kVer2.TabIndex = 4;
            // 
            // sVer2
            // 
            this.sVer2.Location = new System.Drawing.Point(148, 163);
            this.sVer2.MaxLength = 3;
            this.sVer2.Name = "sVer2";
            this.sVer2.Size = new System.Drawing.Size(31, 22);
            this.sVer2.TabIndex = 6;
            // 
            // sVer3
            // 
            this.sVer3.Location = new System.Drawing.Point(190, 163);
            this.sVer3.MaxLength = 3;
            this.sVer3.Name = "sVer3";
            this.sVer3.Size = new System.Drawing.Size(31, 22);
            this.sVer3.TabIndex = 6;
            // 
            // rVer2
            // 
            this.rVer2.Location = new System.Drawing.Point(192, 191);
            this.rVer2.MaxLength = 2;
            this.rVer2.Name = "rVer2";
            this.rVer2.Size = new System.Drawing.Size(31, 22);
            this.rVer2.TabIndex = 6;
            // 
            // rVer3
            // 
            this.rVer3.Location = new System.Drawing.Point(235, 191);
            this.rVer3.MaxLength = 2;
            this.rVer3.Name = "rVer3";
            this.rVer3.Size = new System.Drawing.Size(31, 22);
            this.rVer3.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(139, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(8, 12);
            this.label9.TabIndex = 5;
            this.label9.Text = ".";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(8, 12);
            this.label10.TabIndex = 5;
            this.label10.Text = ".";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(181, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(8, 12);
            this.label11.TabIndex = 5;
            this.label11.Text = ".";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(8, 12);
            this.label12.TabIndex = 5;
            this.label12.Text = ".";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 197);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(8, 12);
            this.label13.TabIndex = 5;
            this.label13.Text = "/";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 197);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(8, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "/";
            // 
            // fullPath
            // 
            this.fullPath.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.fullPath.Location = new System.Drawing.Point(16, 68);
            this.fullPath.Name = "fullPath";
            this.fullPath.Size = new System.Drawing.Size(484, 29);
            this.fullPath.TabIndex = 12;
            // 
            // today
            // 
            this.today.Location = new System.Drawing.Point(272, 190);
            this.today.Name = "today";
            this.today.Size = new System.Drawing.Size(75, 23);
            this.today.TabIndex = 2;
            this.today.Text = "Today";
            this.today.UseVisualStyleBackColor = true;
            this.today.Click += new System.EventHandler(this.today_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "Storage Folder :";
            // 
            // dopplerGroup
            // 
            this.dopplerGroup.Controls.Add(this.promOutError);
            this.dopplerGroup.Controls.Add(this.promOutPath);
            this.dopplerGroup.Controls.Add(this.browse2);
            this.dopplerGroup.Controls.Add(this.label18);
            this.dopplerGroup.Controls.Add(this.label19);
            this.dopplerGroup.Controls.Add(this.label20);
            this.dopplerGroup.Controls.Add(this.dopplerAddress);
            this.dopplerGroup.Controls.Add(this.label21);
            this.dopplerGroup.Controls.Add(this.dopplerSize);
            this.dopplerGroup.Controls.Add(this.label22);
            this.dopplerGroup.Enabled = false;
            this.dopplerGroup.Location = new System.Drawing.Point(12, 276);
            this.dopplerGroup.Name = "dopplerGroup";
            this.dopplerGroup.Size = new System.Drawing.Size(484, 150);
            this.dopplerGroup.TabIndex = 10;
            this.dopplerGroup.TabStop = false;
            this.dopplerGroup.Text = "V6 Doppler Information";
            // 
            // promOutError
            // 
            this.promOutError.AutoSize = true;
            this.promOutError.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.promOutError.ForeColor = System.Drawing.Color.Red;
            this.promOutError.Location = new System.Drawing.Point(6, 61);
            this.promOutError.Name = "promOutError";
            this.promOutError.Size = new System.Drawing.Size(9, 12);
            this.promOutError.TabIndex = 15;
            this.promOutError.Text = ".";
            // 
            // promOutPath
            // 
            this.promOutPath.Location = new System.Drawing.Point(7, 36);
            this.promOutPath.Name = "promOutPath";
            this.promOutPath.Size = new System.Drawing.Size(400, 22);
            this.promOutPath.TabIndex = 14;
            // 
            // browse2
            // 
            this.browse2.Location = new System.Drawing.Point(413, 36);
            this.browse2.Name = "browse2";
            this.browse2.Size = new System.Drawing.Size(64, 23);
            this.browse2.TabIndex = 13;
            this.browse2.Text = "Browse";
            this.browse2.UseVisualStyleBackColor = true;
            this.browse2.Click += new System.EventHandler(this.browse2_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(89, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 12);
            this.label18.TabIndex = 7;
            this.label18.Text = "0x";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(89, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 12);
            this.label19.TabIndex = 7;
            this.label19.Text = "0x";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 97);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(42, 12);
            this.label20.TabIndex = 3;
            this.label20.Text = "Address";
            // 
            // dopplerAddress
            // 
            this.dopplerAddress.Location = new System.Drawing.Point(106, 94);
            this.dopplerAddress.MaxLength = 8;
            this.dopplerAddress.Name = "dopplerAddress";
            this.dopplerAddress.Size = new System.Drawing.Size(100, 22);
            this.dopplerAddress.TabIndex = 4;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 125);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(24, 12);
            this.label21.TabIndex = 5;
            this.label21.Text = "Size";
            // 
            // dopplerSize
            // 
            this.dopplerSize.Location = new System.Drawing.Point(106, 122);
            this.dopplerSize.MaxLength = 8;
            this.dopplerSize.Name = "dopplerSize";
            this.dopplerSize.Size = new System.Drawing.Size(100, 22);
            this.dopplerSize.TabIndex = 6;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 18);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(74, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "Prom.out File :";
            // 
            // v6Doppler
            // 
            this.v6Doppler.AutoSize = true;
            this.v6Doppler.Location = new System.Drawing.Point(12, 256);
            this.v6Doppler.Name = "v6Doppler";
            this.v6Doppler.Size = new System.Drawing.Size(161, 16);
            this.v6Doppler.TabIndex = 11;
            this.v6Doppler.Text = "Add V6 Doppler Information";
            this.v6Doppler.UseVisualStyleBackColor = true;
            this.v6Doppler.CheckedChanged += new System.EventHandler(this.v6Doppler_CheckedChanged);
            // 
            // PromIniGenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 588);
            this.Controls.Add(this.fullPath);
            this.Controls.Add(this.v6Doppler);
            this.Controls.Add(this.dopplerGroup);
            this.Controls.Add(this.needTag);
            this.Controls.Add(this.tagGroup);
            this.Controls.Add(this.baudSel);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.crc);
            this.Controls.Add(this.rVer3);
            this.Controls.Add(this.rVer2);
            this.Controls.Add(this.sVer3);
            this.Controls.Add(this.sVer2);
            this.Controls.Add(this.sVer1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rVer1);
            this.Controls.Add(this.kVer2);
            this.Controls.Add(this.kVer3);
            this.Controls.Add(this.kVer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.today);
            this.Controls.Add(this.browse);
            this.Controls.Add(this.promFilePath);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PromIniGenForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prom Ini File Generator";
            this.Load += new System.EventHandler(this.PromIniGenForm_Load);
            this.tagGroup.ResumeLayout(false);
            this.tagGroup.PerformLayout();
            this.dopplerGroup.ResumeLayout(false);
            this.dopplerGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox promFilePath;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kVer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sVer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rVer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox crc;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox baudSel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tagAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tagContent;
        private System.Windows.Forms.GroupBox tagGroup;
        private System.Windows.Forms.CheckBox needTag;
        private System.Windows.Forms.TextBox kVer3;
        private System.Windows.Forms.TextBox kVer2;
        private System.Windows.Forms.TextBox sVer2;
        private System.Windows.Forms.TextBox sVer3;
        private System.Windows.Forms.TextBox rVer2;
        private System.Windows.Forms.TextBox rVer3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label fullPath;
        private System.Windows.Forms.Button today;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox dopplerGroup;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox dopplerAddress;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox dopplerSize;
        private System.Windows.Forms.CheckBox v6Doppler;
        private System.Windows.Forms.Label promOutError;
        private System.Windows.Forms.TextBox promOutPath;
        private System.Windows.Forms.Button browse2;
        private System.Windows.Forms.Label label22;
    }
}

