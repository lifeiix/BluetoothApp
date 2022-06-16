namespace BT_UP
{
    partial class FormBT
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
            this.devicesListBox = new System.Windows.Forms.ListBox();
            this.searchDevicesButton = new System.Windows.Forms.Button();
            this.pairDeviceButton = new System.Windows.Forms.Button();
            this.sendFileButton = new System.Windows.Forms.Button();
            this.deviceNameTextBox = new System.Windows.Forms.TextBox();
            this.deviceMacTextBox = new System.Windows.Forms.TextBox();
            this.deviceNameLabel = new System.Windows.Forms.Label();
            this.deviceMacLable = new System.Windows.Forms.Label();
            this.selectDeviceButton = new System.Windows.Forms.Button();
            this.actualDeviceGroupBox = new System.Windows.Forms.GroupBox();
            this.allDevicesGroupBox = new System.Windows.Forms.GroupBox();
            this.authenticateCheckBox = new System.Windows.Forms.CheckBox();
            this.unknownCheckBox = new System.Windows.Forms.CheckBox();
            this.rememberedCheckBox = new System.Windows.Forms.CheckBox();
            this.choosenFileTextBox = new System.Windows.Forms.MaskedTextBox();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.sendFileGroupBox = new System.Windows.Forms.GroupBox();
            this.adaptersGroupBox = new System.Windows.Forms.GroupBox();
            this.chooseAdapterButton = new System.Windows.Forms.Button();
            this.searchAdaptersButton = new System.Windows.Forms.Button();
            this.adaptersListBox = new System.Windows.Forms.ListBox();
            this.adapterNameBox = new System.Windows.Forms.TextBox();
            this.currentAdapterGroup = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.adapterMacBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.disconnectDeviceButton = new System.Windows.Forms.Button();
            this.actualDeviceGroupBox.SuspendLayout();
            this.allDevicesGroupBox.SuspendLayout();
            this.sendFileGroupBox.SuspendLayout();
            this.adaptersGroupBox.SuspendLayout();
            this.currentAdapterGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // devicesListBox
            // 
            this.devicesListBox.FormattingEnabled = true;
            this.devicesListBox.ItemHeight = 15;
            this.devicesListBox.Location = new System.Drawing.Point(11, 20);
            this.devicesListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.devicesListBox.Name = "devicesListBox";
            this.devicesListBox.Size = new System.Drawing.Size(279, 154);
            this.devicesListBox.TabIndex = 0;
            // 
            // searchDevicesButton
            // 
            this.searchDevicesButton.AutoSize = true;
            this.searchDevicesButton.Location = new System.Drawing.Point(11, 234);
            this.searchDevicesButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchDevicesButton.Name = "searchDevicesButton";
            this.searchDevicesButton.Size = new System.Drawing.Size(180, 29);
            this.searchDevicesButton.TabIndex = 1;
            this.searchDevicesButton.Text = "搜索";
            this.searchDevicesButton.UseVisualStyleBackColor = true;
            this.searchDevicesButton.Click += new System.EventHandler(this.searchDevicesButton_Click);
            // 
            // pairDeviceButton
            // 
            this.pairDeviceButton.AutoSize = true;
            this.pairDeviceButton.Location = new System.Drawing.Point(12, 81);
            this.pairDeviceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pairDeviceButton.Name = "pairDeviceButton";
            this.pairDeviceButton.Size = new System.Drawing.Size(121, 29);
            this.pairDeviceButton.TabIndex = 2;
            this.pairDeviceButton.Text = "连接";
            this.pairDeviceButton.UseVisualStyleBackColor = true;
            this.pairDeviceButton.Click += new System.EventHandler(this.pairDeviceButton_Click);
            // 
            // sendFileButton
            // 
            this.sendFileButton.AutoSize = true;
            this.sendFileButton.Enabled = false;
            this.sendFileButton.Location = new System.Drawing.Point(147, 54);
            this.sendFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendFileButton.Name = "sendFileButton";
            this.sendFileButton.Size = new System.Drawing.Size(136, 29);
            this.sendFileButton.TabIndex = 3;
            this.sendFileButton.Text = "发送";
            this.sendFileButton.UseVisualStyleBackColor = true;
            this.sendFileButton.Click += new System.EventHandler(this.sendFileButton_Click);
            // 
            // deviceNameTextBox
            // 
            this.deviceNameTextBox.Enabled = false;
            this.deviceNameTextBox.Location = new System.Drawing.Point(139, 20);
            this.deviceNameTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deviceNameTextBox.Name = "deviceNameTextBox";
            this.deviceNameTextBox.Size = new System.Drawing.Size(132, 25);
            this.deviceNameTextBox.TabIndex = 4;
            // 
            // deviceMacTextBox
            // 
            this.deviceMacTextBox.Enabled = false;
            this.deviceMacTextBox.Location = new System.Drawing.Point(139, 50);
            this.deviceMacTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.deviceMacTextBox.Name = "deviceMacTextBox";
            this.deviceMacTextBox.Size = new System.Drawing.Size(132, 25);
            this.deviceMacTextBox.TabIndex = 5;
            // 
            // deviceNameLabel
            // 
            this.deviceNameLabel.AutoSize = true;
            this.deviceNameLabel.Location = new System.Drawing.Point(8, 23);
            this.deviceNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceNameLabel.Name = "deviceNameLabel";
            this.deviceNameLabel.Size = new System.Drawing.Size(82, 15);
            this.deviceNameLabel.TabIndex = 6;
            this.deviceNameLabel.Text = "设备名称：";
            // 
            // deviceMacLable
            // 
            this.deviceMacLable.AutoSize = true;
            this.deviceMacLable.Location = new System.Drawing.Point(9, 53);
            this.deviceMacLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.deviceMacLable.Name = "deviceMacLable";
            this.deviceMacLable.Size = new System.Drawing.Size(69, 15);
            this.deviceMacLable.TabIndex = 7;
            this.deviceMacLable.Text = "MAC地址:";
            // 
            // selectDeviceButton
            // 
            this.selectDeviceButton.AutoSize = true;
            this.selectDeviceButton.Location = new System.Drawing.Point(145, 234);
            this.selectDeviceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.selectDeviceButton.Name = "selectDeviceButton";
            this.selectDeviceButton.Size = new System.Drawing.Size(212, 29);
            this.selectDeviceButton.TabIndex = 8;
            this.selectDeviceButton.Text = "选择";
            this.selectDeviceButton.UseVisualStyleBackColor = true;
            this.selectDeviceButton.Click += new System.EventHandler(this.selectDeviceButton_Click);
            // 
            // actualDeviceGroupBox
            // 
            this.actualDeviceGroupBox.Controls.Add(this.disconnectDeviceButton);
            this.actualDeviceGroupBox.Controls.Add(this.deviceMacLable);
            this.actualDeviceGroupBox.Controls.Add(this.deviceNameLabel);
            this.actualDeviceGroupBox.Controls.Add(this.deviceMacTextBox);
            this.actualDeviceGroupBox.Controls.Add(this.deviceNameTextBox);
            this.actualDeviceGroupBox.Controls.Add(this.pairDeviceButton);
            this.actualDeviceGroupBox.Enabled = false;
            this.actualDeviceGroupBox.Location = new System.Drawing.Point(667, 33);
            this.actualDeviceGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.actualDeviceGroupBox.Name = "actualDeviceGroupBox";
            this.actualDeviceGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.actualDeviceGroupBox.Size = new System.Drawing.Size(280, 130);
            this.actualDeviceGroupBox.TabIndex = 11;
            this.actualDeviceGroupBox.TabStop = false;
            this.actualDeviceGroupBox.Text = "设备信息";
            // 
            // allDevicesGroupBox
            // 
            this.allDevicesGroupBox.Controls.Add(this.authenticateCheckBox);
            this.allDevicesGroupBox.Controls.Add(this.unknownCheckBox);
            this.allDevicesGroupBox.Controls.Add(this.rememberedCheckBox);
            this.allDevicesGroupBox.Controls.Add(this.selectDeviceButton);
            this.allDevicesGroupBox.Controls.Add(this.searchDevicesButton);
            this.allDevicesGroupBox.Controls.Add(this.devicesListBox);
            this.allDevicesGroupBox.Enabled = false;
            this.allDevicesGroupBox.Location = new System.Drawing.Point(341, 14);
            this.allDevicesGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allDevicesGroupBox.Name = "allDevicesGroupBox";
            this.allDevicesGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.allDevicesGroupBox.Size = new System.Drawing.Size(305, 284);
            this.allDevicesGroupBox.TabIndex = 12;
            this.allDevicesGroupBox.TabStop = false;
            this.allDevicesGroupBox.Text = "设备列表";
            // 
            // authenticateCheckBox
            // 
            this.authenticateCheckBox.AutoSize = true;
            this.authenticateCheckBox.Location = new System.Drawing.Point(15, 179);
            this.authenticateCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.authenticateCheckBox.Name = "authenticateCheckBox";
            this.authenticateCheckBox.Size = new System.Drawing.Size(125, 19);
            this.authenticateCheckBox.TabIndex = 11;
            this.authenticateCheckBox.Text = "Authenticate";
            this.authenticateCheckBox.UseVisualStyleBackColor = true;
            // 
            // unknownCheckBox
            // 
            this.unknownCheckBox.AutoSize = true;
            this.unknownCheckBox.Location = new System.Drawing.Point(125, 205);
            this.unknownCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.unknownCheckBox.Name = "unknownCheckBox";
            this.unknownCheckBox.Size = new System.Drawing.Size(85, 19);
            this.unknownCheckBox.TabIndex = 10;
            this.unknownCheckBox.Text = "Unknown";
            this.unknownCheckBox.UseVisualStyleBackColor = true;
            // 
            // rememberedCheckBox
            // 
            this.rememberedCheckBox.AutoSize = true;
            this.rememberedCheckBox.Location = new System.Drawing.Point(172, 179);
            this.rememberedCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rememberedCheckBox.Name = "rememberedCheckBox";
            this.rememberedCheckBox.Size = new System.Drawing.Size(109, 19);
            this.rememberedCheckBox.TabIndex = 9;
            this.rememberedCheckBox.Text = "Remembered";
            this.rememberedCheckBox.UseVisualStyleBackColor = true;
            // 
            // choosenFileTextBox
            // 
            this.choosenFileTextBox.Enabled = false;
            this.choosenFileTextBox.Location = new System.Drawing.Point(12, 24);
            this.choosenFileTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.choosenFileTextBox.Name = "choosenFileTextBox";
            this.choosenFileTextBox.Size = new System.Drawing.Size(259, 25);
            this.choosenFileTextBox.TabIndex = 13;
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.AutoSize = true;
            this.chooseFileButton.Location = new System.Drawing.Point(11, 54);
            this.chooseFileButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(151, 29);
            this.chooseFileButton.TabIndex = 14;
            this.chooseFileButton.Text = "选择";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.chooseFileButton_Click);
            // 
            // sendFileGroupBox
            // 
            this.sendFileGroupBox.Controls.Add(this.chooseFileButton);
            this.sendFileGroupBox.Controls.Add(this.choosenFileTextBox);
            this.sendFileGroupBox.Controls.Add(this.sendFileButton);
            this.sendFileGroupBox.Enabled = false;
            this.sendFileGroupBox.Location = new System.Drawing.Point(667, 179);
            this.sendFileGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendFileGroupBox.Name = "sendFileGroupBox";
            this.sendFileGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sendFileGroupBox.Size = new System.Drawing.Size(279, 97);
            this.sendFileGroupBox.TabIndex = 15;
            this.sendFileGroupBox.TabStop = false;
            this.sendFileGroupBox.Text = "发送文件";
            // 
            // adaptersGroupBox
            // 
            this.adaptersGroupBox.Controls.Add(this.chooseAdapterButton);
            this.adaptersGroupBox.Controls.Add(this.searchAdaptersButton);
            this.adaptersGroupBox.Controls.Add(this.adaptersListBox);
            this.adaptersGroupBox.Location = new System.Drawing.Point(16, 14);
            this.adaptersGroupBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adaptersGroupBox.Name = "adaptersGroupBox";
            this.adaptersGroupBox.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adaptersGroupBox.Size = new System.Drawing.Size(305, 160);
            this.adaptersGroupBox.TabIndex = 13;
            this.adaptersGroupBox.TabStop = false;
            this.adaptersGroupBox.Text = "适配器列表";
            // 
            // chooseAdapterButton
            // 
            this.chooseAdapterButton.AutoSize = true;
            this.chooseAdapterButton.Location = new System.Drawing.Point(145, 121);
            this.chooseAdapterButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.chooseAdapterButton.Name = "chooseAdapterButton";
            this.chooseAdapterButton.Size = new System.Drawing.Size(183, 29);
            this.chooseAdapterButton.TabIndex = 8;
            this.chooseAdapterButton.Text = "选择";
            this.chooseAdapterButton.UseVisualStyleBackColor = true;
            this.chooseAdapterButton.Click += new System.EventHandler(this.chooseAdapterButton_Click);
            // 
            // searchAdaptersButton
            // 
            this.searchAdaptersButton.AutoSize = true;
            this.searchAdaptersButton.Location = new System.Drawing.Point(11, 121);
            this.searchAdaptersButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchAdaptersButton.Name = "searchAdaptersButton";
            this.searchAdaptersButton.Size = new System.Drawing.Size(193, 29);
            this.searchAdaptersButton.TabIndex = 1;
            this.searchAdaptersButton.Text = "搜索";
            this.searchAdaptersButton.UseVisualStyleBackColor = true;
            this.searchAdaptersButton.Click += new System.EventHandler(this.searchAdaptersButton_Click);
            // 
            // adaptersListBox
            // 
            this.adaptersListBox.FormattingEnabled = true;
            this.adaptersListBox.ItemHeight = 15;
            this.adaptersListBox.Location = new System.Drawing.Point(11, 20);
            this.adaptersListBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adaptersListBox.Name = "adaptersListBox";
            this.adaptersListBox.Size = new System.Drawing.Size(279, 94);
            this.adaptersListBox.TabIndex = 0;
            // 
            // adapterNameBox
            // 
            this.adapterNameBox.Enabled = false;
            this.adapterNameBox.Location = new System.Drawing.Point(145, 27);
            this.adapterNameBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adapterNameBox.Name = "adapterNameBox";
            this.adapterNameBox.Size = new System.Drawing.Size(132, 25);
            this.adapterNameBox.TabIndex = 4;
            // 
            // currentAdapterGroup
            // 
            this.currentAdapterGroup.Controls.Add(this.label3);
            this.currentAdapterGroup.Controls.Add(this.label4);
            this.currentAdapterGroup.Controls.Add(this.adapterMacBox);
            this.currentAdapterGroup.Controls.Add(this.adapterNameBox);
            this.currentAdapterGroup.Controls.Add(this.button3);
            this.currentAdapterGroup.Enabled = false;
            this.currentAdapterGroup.Location = new System.Drawing.Point(16, 181);
            this.currentAdapterGroup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentAdapterGroup.Name = "currentAdapterGroup";
            this.currentAdapterGroup.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.currentAdapterGroup.Size = new System.Drawing.Size(305, 100);
            this.currentAdapterGroup.TabIndex = 12;
            this.currentAdapterGroup.TabStop = false;
            this.currentAdapterGroup.Text = "适配器信息";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 60);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "MAC地址:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "设备名称:";
            // 
            // adapterMacBox
            // 
            this.adapterMacBox.Enabled = false;
            this.adapterMacBox.Location = new System.Drawing.Point(145, 57);
            this.adapterMacBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.adapterMacBox.Name = "adapterMacBox";
            this.adapterMacBox.Size = new System.Drawing.Size(132, 25);
            this.adapterMacBox.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(77, 133);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 29);
            this.button3.TabIndex = 2;
            this.button3.Text = "Paruj urządzenie";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // disconnectDeviceButton
            // 
            this.disconnectDeviceButton.AutoSize = true;
            this.disconnectDeviceButton.Location = new System.Drawing.Point(150, 81);
            this.disconnectDeviceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.disconnectDeviceButton.Name = "disconnectDeviceButton";
            this.disconnectDeviceButton.Size = new System.Drawing.Size(121, 29);
            this.disconnectDeviceButton.TabIndex = 8;
            this.disconnectDeviceButton.Text = "断开";
            this.disconnectDeviceButton.UseVisualStyleBackColor = true;
            this.disconnectDeviceButton.Click += new System.EventHandler(this.disconnectDeviceButton_Click);
            // 
            // FormBT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 307);
            this.Controls.Add(this.currentAdapterGroup);
            this.Controls.Add(this.adaptersGroupBox);
            this.Controls.Add(this.sendFileGroupBox);
            this.Controls.Add(this.allDevicesGroupBox);
            this.Controls.Add(this.actualDeviceGroupBox);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormBT";
            this.Text = "Program do obsługi Bluetooth";
            this.actualDeviceGroupBox.ResumeLayout(false);
            this.actualDeviceGroupBox.PerformLayout();
            this.allDevicesGroupBox.ResumeLayout(false);
            this.allDevicesGroupBox.PerformLayout();
            this.sendFileGroupBox.ResumeLayout(false);
            this.sendFileGroupBox.PerformLayout();
            this.adaptersGroupBox.ResumeLayout(false);
            this.adaptersGroupBox.PerformLayout();
            this.currentAdapterGroup.ResumeLayout(false);
            this.currentAdapterGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox devicesListBox;
        private System.Windows.Forms.Button searchDevicesButton;
        private System.Windows.Forms.Button pairDeviceButton;
        private System.Windows.Forms.Button sendFileButton;
        private System.Windows.Forms.TextBox deviceNameTextBox;
        private System.Windows.Forms.TextBox deviceMacTextBox;
        private System.Windows.Forms.Label deviceNameLabel;
        private System.Windows.Forms.Label deviceMacLable;
        private System.Windows.Forms.Button selectDeviceButton;
        private System.Windows.Forms.GroupBox actualDeviceGroupBox;
        private System.Windows.Forms.GroupBox allDevicesGroupBox;
        private System.Windows.Forms.MaskedTextBox choosenFileTextBox;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.GroupBox sendFileGroupBox;
        private System.Windows.Forms.GroupBox adaptersGroupBox;
        private System.Windows.Forms.Button chooseAdapterButton;
        private System.Windows.Forms.Button searchAdaptersButton;
        private System.Windows.Forms.ListBox adaptersListBox;
        private System.Windows.Forms.TextBox adapterNameBox;
        private System.Windows.Forms.GroupBox currentAdapterGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox adapterMacBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox unknownCheckBox;
        private System.Windows.Forms.CheckBox rememberedCheckBox;
        private System.Windows.Forms.CheckBox authenticateCheckBox;
        private System.Windows.Forms.Button disconnectDeviceButton;
    }
}

