namespace 串口助手
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.cbxCheckBitList = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxStopBitList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxDataBitList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxBaudRateList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxSerialPortList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tboxETXChar = new System.Windows.Forms.TextBox();
            this.cbxSplitMessage = new System.Windows.Forms.CheckBox();
            this.cbxReceiveShowTimeStamp = new System.Windows.Forms.CheckBox();
            this.cbxReceiveAutoWrap = new System.Windows.Forms.CheckBox();
            this.radioReceiveHEX = new System.Windows.Forms.RadioButton();
            this.radioReceiveASCII = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboxRepeatTimeSpanList = new System.Windows.Forms.ComboBox();
            this.cbxSendAutoRepeat = new System.Windows.Forms.CheckBox();
            this.radioSendHEX = new System.Windows.Forms.RadioButton();
            this.radioSendASCII = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioSendData = new System.Windows.Forms.RadioButton();
            this.radioSendFile = new System.Windows.Forms.RadioButton();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rtboxSendData = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tboxFile = new System.Windows.Forms.TextBox();
            this.btnBrowseFile = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnClearReceive = new System.Windows.Forms.Button();
            this.rtboxReceive = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpen);
            this.groupBox1.Controls.Add(this.cbxCheckBitList);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbxStopBitList);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbxDataBitList);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxBaudRateList);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbxSerialPortList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 314);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "串口设置";
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(266, 54);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(47, 23);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "打开";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cbxCheckBitList
            // 
            this.cbxCheckBitList.FormattingEnabled = true;
            this.cbxCheckBitList.Location = new System.Drawing.Point(92, 240);
            this.cbxCheckBitList.Name = "cbxCheckBitList";
            this.cbxCheckBitList.Size = new System.Drawing.Size(168, 20);
            this.cbxCheckBitList.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "检验位";
            // 
            // cbxStopBitList
            // 
            this.cbxStopBitList.FormattingEnabled = true;
            this.cbxStopBitList.Location = new System.Drawing.Point(92, 194);
            this.cbxStopBitList.Name = "cbxStopBitList";
            this.cbxStopBitList.Size = new System.Drawing.Size(168, 20);
            this.cbxStopBitList.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "停止位";
            // 
            // cbxDataBitList
            // 
            this.cbxDataBitList.FormattingEnabled = true;
            this.cbxDataBitList.Location = new System.Drawing.Point(92, 148);
            this.cbxDataBitList.Name = "cbxDataBitList";
            this.cbxDataBitList.Size = new System.Drawing.Size(168, 20);
            this.cbxDataBitList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位";
            // 
            // cbxBaudRateList
            // 
            this.cbxBaudRateList.FormattingEnabled = true;
            this.cbxBaudRateList.Location = new System.Drawing.Point(92, 102);
            this.cbxBaudRateList.Name = "cbxBaudRateList";
            this.cbxBaudRateList.Size = new System.Drawing.Size(168, 20);
            this.cbxBaudRateList.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            // 
            // cbxSerialPortList
            // 
            this.cbxSerialPortList.FormattingEnabled = true;
            this.cbxSerialPortList.Location = new System.Drawing.Point(92, 56);
            this.cbxSerialPortList.Name = "cbxSerialPortList";
            this.cbxSerialPortList.Size = new System.Drawing.Size(168, 20);
            this.cbxSerialPortList.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口号";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tboxETXChar);
            this.groupBox2.Controls.Add(this.cbxSplitMessage);
            this.groupBox2.Controls.Add(this.cbxReceiveShowTimeStamp);
            this.groupBox2.Controls.Add(this.cbxReceiveAutoWrap);
            this.groupBox2.Controls.Add(this.radioReceiveHEX);
            this.groupBox2.Controls.Add(this.radioReceiveASCII);
            this.groupBox2.Location = new System.Drawing.Point(13, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 223);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收设置";
            // 
            // tboxETXChar
            // 
            this.tboxETXChar.Location = new System.Drawing.Point(201, 156);
            this.tboxETXChar.Name = "tboxETXChar";
            this.tboxETXChar.Size = new System.Drawing.Size(100, 21);
            this.tboxETXChar.TabIndex = 5;
            this.tboxETXChar.Text = "03";
            // 
            // cbxSplitMessage
            // 
            this.cbxSplitMessage.AutoSize = true;
            this.cbxSplitMessage.Checked = true;
            this.cbxSplitMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSplitMessage.Location = new System.Drawing.Point(64, 158);
            this.cbxSplitMessage.Name = "cbxSplitMessage";
            this.cbxSplitMessage.Size = new System.Drawing.Size(120, 16);
            this.cbxSplitMessage.TabIndex = 4;
            this.cbxSplitMessage.Text = "自动分隔连续消息";
            this.cbxSplitMessage.UseVisualStyleBackColor = true;
            this.cbxSplitMessage.CheckedChanged += new System.EventHandler(this.cbxSplitMessage_CheckedChanged);
            // 
            // cbxReceiveShowTimeStamp
            // 
            this.cbxReceiveShowTimeStamp.AutoSize = true;
            this.cbxReceiveShowTimeStamp.Checked = true;
            this.cbxReceiveShowTimeStamp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxReceiveShowTimeStamp.Location = new System.Drawing.Point(65, 118);
            this.cbxReceiveShowTimeStamp.Name = "cbxReceiveShowTimeStamp";
            this.cbxReceiveShowTimeStamp.Size = new System.Drawing.Size(84, 16);
            this.cbxReceiveShowTimeStamp.TabIndex = 3;
            this.cbxReceiveShowTimeStamp.Text = "显示时间戳";
            this.cbxReceiveShowTimeStamp.UseVisualStyleBackColor = true;
            // 
            // cbxReceiveAutoWrap
            // 
            this.cbxReceiveAutoWrap.AutoSize = true;
            this.cbxReceiveAutoWrap.Checked = true;
            this.cbxReceiveAutoWrap.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxReceiveAutoWrap.Location = new System.Drawing.Point(65, 74);
            this.cbxReceiveAutoWrap.Name = "cbxReceiveAutoWrap";
            this.cbxReceiveAutoWrap.Size = new System.Drawing.Size(72, 16);
            this.cbxReceiveAutoWrap.TabIndex = 2;
            this.cbxReceiveAutoWrap.Text = "自动换行";
            this.cbxReceiveAutoWrap.UseVisualStyleBackColor = true;
            // 
            // radioReceiveHEX
            // 
            this.radioReceiveHEX.AutoSize = true;
            this.radioReceiveHEX.Checked = true;
            this.radioReceiveHEX.Location = new System.Drawing.Point(201, 35);
            this.radioReceiveHEX.Name = "radioReceiveHEX";
            this.radioReceiveHEX.Size = new System.Drawing.Size(41, 16);
            this.radioReceiveHEX.TabIndex = 1;
            this.radioReceiveHEX.TabStop = true;
            this.radioReceiveHEX.Text = "HEX";
            this.radioReceiveHEX.UseVisualStyleBackColor = true;
            // 
            // radioReceiveASCII
            // 
            this.radioReceiveASCII.AutoSize = true;
            this.radioReceiveASCII.Location = new System.Drawing.Point(65, 35);
            this.radioReceiveASCII.Name = "radioReceiveASCII";
            this.radioReceiveASCII.Size = new System.Drawing.Size(53, 16);
            this.radioReceiveASCII.TabIndex = 0;
            this.radioReceiveASCII.Text = "ASCII";
            this.radioReceiveASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboxRepeatTimeSpanList);
            this.groupBox3.Controls.Add(this.cbxSendAutoRepeat);
            this.groupBox3.Controls.Add(this.radioSendHEX);
            this.groupBox3.Controls.Add(this.radioSendASCII);
            this.groupBox3.Location = new System.Drawing.Point(13, 332);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 102);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "发送设置";
            // 
            // cboxRepeatTimeSpanList
            // 
            this.cboxRepeatTimeSpanList.FormattingEnabled = true;
            this.cboxRepeatTimeSpanList.Location = new System.Drawing.Point(176, 66);
            this.cboxRepeatTimeSpanList.Name = "cboxRepeatTimeSpanList";
            this.cboxRepeatTimeSpanList.Size = new System.Drawing.Size(83, 20);
            this.cboxRepeatTimeSpanList.TabIndex = 3;
            // 
            // cbxSendAutoRepeat
            // 
            this.cbxSendAutoRepeat.AutoSize = true;
            this.cbxSendAutoRepeat.Location = new System.Drawing.Point(64, 70);
            this.cbxSendAutoRepeat.Name = "cbxSendAutoRepeat";
            this.cbxSendAutoRepeat.Size = new System.Drawing.Size(72, 16);
            this.cbxSendAutoRepeat.TabIndex = 2;
            this.cbxSendAutoRepeat.Text = "重复发送";
            this.cbxSendAutoRepeat.UseVisualStyleBackColor = true;
            // 
            // radioSendHEX
            // 
            this.radioSendHEX.AutoSize = true;
            this.radioSendHEX.Checked = true;
            this.radioSendHEX.Location = new System.Drawing.Point(200, 31);
            this.radioSendHEX.Name = "radioSendHEX";
            this.radioSendHEX.Size = new System.Drawing.Size(41, 16);
            this.radioSendHEX.TabIndex = 1;
            this.radioSendHEX.TabStop = true;
            this.radioSendHEX.Text = "HEX";
            this.radioSendHEX.UseVisualStyleBackColor = true;
            // 
            // radioSendASCII
            // 
            this.radioSendASCII.AutoSize = true;
            this.radioSendASCII.Location = new System.Drawing.Point(64, 31);
            this.radioSendASCII.Name = "radioSendASCII";
            this.radioSendASCII.Size = new System.Drawing.Size(53, 16);
            this.radioSendASCII.TabIndex = 0;
            this.radioSendASCII.Text = "ASCII";
            this.radioSendASCII.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioSendData);
            this.groupBox4.Controls.Add(this.radioSendFile);
            this.groupBox4.Controls.Add(this.btnSend);
            this.groupBox4.Controls.Add(this.panel1);
            this.groupBox4.Controls.Add(this.panel3);
            this.groupBox4.Location = new System.Drawing.Point(337, 21);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(780, 305);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "发送";
            // 
            // radioSendData
            // 
            this.radioSendData.AutoSize = true;
            this.radioSendData.Checked = true;
            this.radioSendData.Location = new System.Drawing.Point(12, 24);
            this.radioSendData.Name = "radioSendData";
            this.radioSendData.Size = new System.Drawing.Size(71, 16);
            this.radioSendData.TabIndex = 6;
            this.radioSendData.TabStop = true;
            this.radioSendData.Text = "发送数据";
            this.radioSendData.UseVisualStyleBackColor = true;
            this.radioSendData.CheckedChanged += new System.EventHandler(this.radioSendData_CheckedChanged_1);
            // 
            // radioSendFile
            // 
            this.radioSendFile.AutoSize = true;
            this.radioSendFile.Location = new System.Drawing.Point(12, 240);
            this.radioSendFile.Name = "radioSendFile";
            this.radioSendFile.Size = new System.Drawing.Size(71, 16);
            this.radioSendFile.TabIndex = 7;
            this.radioSendFile.Text = "发送文件";
            this.radioSendFile.UseVisualStyleBackColor = true;
            this.radioSendFile.CheckedChanged += new System.EventHandler(this.radioSendFile_CheckedChanged);
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(690, 276);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "发送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtboxSendData);
            this.panel1.Location = new System.Drawing.Point(89, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(685, 212);
            this.panel1.TabIndex = 25;
            // 
            // rtboxSendData
            // 
            this.rtboxSendData.Location = new System.Drawing.Point(10, 10);
            this.rtboxSendData.Name = "rtboxSendData";
            this.rtboxSendData.Size = new System.Drawing.Size(666, 199);
            this.rtboxSendData.TabIndex = 1;
            this.rtboxSendData.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tboxFile);
            this.panel3.Controls.Add(this.btnBrowseFile);
            this.panel3.Location = new System.Drawing.Point(89, 231);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(685, 39);
            this.panel3.TabIndex = 27;
            // 
            // tboxFile
            // 
            this.tboxFile.Location = new System.Drawing.Point(10, 9);
            this.tboxFile.Name = "tboxFile";
            this.tboxFile.Size = new System.Drawing.Size(618, 21);
            this.tboxFile.TabIndex = 4;
            // 
            // btnBrowseFile
            // 
            this.btnBrowseFile.Location = new System.Drawing.Point(634, 7);
            this.btnBrowseFile.Name = "btnBrowseFile";
            this.btnBrowseFile.Size = new System.Drawing.Size(42, 23);
            this.btnBrowseFile.TabIndex = 5;
            this.btnBrowseFile.Text = "...";
            this.btnBrowseFile.UseVisualStyleBackColor = true;
            this.btnBrowseFile.Click += new System.EventHandler(this.btnBrowseFile_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnClearReceive);
            this.groupBox5.Controls.Add(this.rtboxReceive);
            this.groupBox5.Location = new System.Drawing.Point(338, 342);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(780, 321);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "接收";
            // 
            // btnClearReceive
            // 
            this.btnClearReceive.Location = new System.Drawing.Point(689, 292);
            this.btnClearReceive.Name = "btnClearReceive";
            this.btnClearReceive.Size = new System.Drawing.Size(75, 23);
            this.btnClearReceive.TabIndex = 1;
            this.btnClearReceive.Text = "清空";
            this.btnClearReceive.UseVisualStyleBackColor = true;
            this.btnClearReceive.Click += new System.EventHandler(this.btnClearReceive_Click);
            // 
            // rtboxReceive
            // 
            this.rtboxReceive.Location = new System.Drawing.Point(11, 24);
            this.rtboxReceive.Name = "rtboxReceive";
            this.rtboxReceive.Size = new System.Drawing.Size(753, 262);
            this.rtboxReceive.TabIndex = 0;
            this.rtboxReceive.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 666);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1136, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 688);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "串口助手 1.0 (powered by zti)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ComboBox cbxSerialPortList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxCheckBitList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbxStopBitList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxDataBitList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxBaudRateList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxReceiveShowTimeStamp;
        private System.Windows.Forms.CheckBox cbxReceiveAutoWrap;
        private System.Windows.Forms.RadioButton radioReceiveHEX;
        private System.Windows.Forms.RadioButton radioReceiveASCII;
        private System.Windows.Forms.RadioButton radioSendHEX;
        private System.Windows.Forms.RadioButton radioSendASCII;
        private System.Windows.Forms.ComboBox cboxRepeatTimeSpanList;
        private System.Windows.Forms.CheckBox cbxSendAutoRepeat;
        private System.Windows.Forms.TextBox tboxFile;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.RichTextBox rtboxSendData;
        private System.Windows.Forms.Button btnBrowseFile;
        private System.Windows.Forms.RadioButton radioSendData;
        private System.Windows.Forms.RadioButton radioSendFile;
        private System.Windows.Forms.Button btnClearReceive;
        private System.Windows.Forms.RichTextBox rtboxReceive;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.CheckBox cbxSplitMessage;
        private System.Windows.Forms.TextBox tboxETXChar;
    }
}

