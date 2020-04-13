namespace UserSave
{
    partial class UserSaveHome
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.MailAddressLabel = new System.Windows.Forms.Label();
            this.MailAddressCheckBox = new System.Windows.Forms.CheckBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.MailAddressTextBox = new System.Windows.Forms.TextBox();
            this.ChoiceGroupBox = new System.Windows.Forms.GroupBox();
            this.FreeRadioButton = new System.Windows.Forms.RadioButton();
            this.BussinessRadioButton = new System.Windows.Forms.RadioButton();
            this.UnlimitedLabel = new System.Windows.Forms.Label();
            this.EnableComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonGroupPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusText = new System.Windows.Forms.ToolStripStatusLabel();
            this.ChoiceGroupBox.SuspendLayout();
            this.ButtonGroupPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(110, 25);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 19);
            this.IdTextBox.TabIndex = 1;
            // 
            // MailAddressLabel
            // 
            this.MailAddressLabel.AutoSize = true;
            this.MailAddressLabel.Location = new System.Drawing.Point(24, 98);
            this.MailAddressLabel.Name = "MailAddressLabel";
            this.MailAddressLabel.Size = new System.Drawing.Size(69, 12);
            this.MailAddressLabel.TabIndex = 2;
            this.MailAddressLabel.Text = "メールアドレス";
            // 
            // MailAddressCheckBox
            // 
            this.MailAddressCheckBox.AutoSize = true;
            this.MailAddressCheckBox.Location = new System.Drawing.Point(26, 64);
            this.MailAddressCheckBox.Name = "MailAddressCheckBox";
            this.MailAddressCheckBox.Size = new System.Drawing.Size(140, 16);
            this.MailAddressCheckBox.TabIndex = 4;
            this.MailAddressCheckBox.Text = "メールアドレスを送信する";
            this.MailAddressCheckBox.UseVisualStyleBackColor = true;
            this.MailAddressCheckBox.CheckedChanged += new System.EventHandler(this.MailAddressCheckBox_CheckedChanged);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(24, 28);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(16, 12);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Text = "ID";
            // 
            // MailAddressTextBox
            // 
            this.MailAddressTextBox.Location = new System.Drawing.Point(110, 95);
            this.MailAddressTextBox.Name = "MailAddressTextBox";
            this.MailAddressTextBox.Size = new System.Drawing.Size(131, 19);
            this.MailAddressTextBox.TabIndex = 6;
            // 
            // ChoiceGroupBox
            // 
            this.ChoiceGroupBox.Controls.Add(this.BussinessRadioButton);
            this.ChoiceGroupBox.Controls.Add(this.FreeRadioButton);
            this.ChoiceGroupBox.Location = new System.Drawing.Point(29, 128);
            this.ChoiceGroupBox.Name = "ChoiceGroupBox";
            this.ChoiceGroupBox.Size = new System.Drawing.Size(270, 68);
            this.ChoiceGroupBox.TabIndex = 7;
            this.ChoiceGroupBox.TabStop = false;
            this.ChoiceGroupBox.Text = "グループ";
            // 
            // FreeRadioButton
            // 
            this.FreeRadioButton.AutoSize = true;
            this.FreeRadioButton.Location = new System.Drawing.Point(16, 31);
            this.FreeRadioButton.Name = "FreeRadioButton";
            this.FreeRadioButton.Size = new System.Drawing.Size(47, 16);
            this.FreeRadioButton.TabIndex = 0;
            this.FreeRadioButton.TabStop = true;
            this.FreeRadioButton.Text = "無料";
            this.FreeRadioButton.UseVisualStyleBackColor = true;
            // 
            // BussinessRadioButton
            // 
            this.BussinessRadioButton.AutoSize = true;
            this.BussinessRadioButton.Location = new System.Drawing.Point(143, 31);
            this.BussinessRadioButton.Name = "BussinessRadioButton";
            this.BussinessRadioButton.Size = new System.Drawing.Size(60, 16);
            this.BussinessRadioButton.TabIndex = 1;
            this.BussinessRadioButton.TabStop = true;
            this.BussinessRadioButton.Text = "ビジネス";
            this.BussinessRadioButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BussinessRadioButton.UseVisualStyleBackColor = true;
            this.BussinessRadioButton.CheckedChanged += new System.EventHandler(this.BussinessRadioButton_CheckedChanged);
            // 
            // UnlimitedLabel
            // 
            this.UnlimitedLabel.AutoSize = true;
            this.UnlimitedLabel.Location = new System.Drawing.Point(27, 199);
            this.UnlimitedLabel.Name = "UnlimitedLabel";
            this.UnlimitedLabel.Size = new System.Drawing.Size(91, 12);
            this.UnlimitedLabel.TabIndex = 8;
            this.UnlimitedLabel.Text = "無制限で使えます";
            // 
            // EnableComboBox
            // 
            this.EnableComboBox.FormattingEnabled = true;
            this.EnableComboBox.Location = new System.Drawing.Point(29, 234);
            this.EnableComboBox.Name = "EnableComboBox";
            this.EnableComboBox.Size = new System.Drawing.Size(121, 20);
            this.EnableComboBox.TabIndex = 9;
            // 
            // ButtonGroupPanel
            // 
            this.ButtonGroupPanel.Controls.Add(this.CloseButton);
            this.ButtonGroupPanel.Controls.Add(this.SaveButton);
            this.ButtonGroupPanel.Controls.Add(this.statusStrip1);
            this.ButtonGroupPanel.Location = new System.Drawing.Point(29, 275);
            this.ButtonGroupPanel.Name = "ButtonGroupPanel";
            this.ButtonGroupPanel.Size = new System.Drawing.Size(407, 55);
            this.ButtonGroupPanel.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.SaveButton.Location = new System.Drawing.Point(0, 0);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(104, 33);
            this.SaveButton.TabIndex = 0;
            this.SaveButton.Text = "保存";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.CloseButton.Location = new System.Drawing.Point(104, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(104, 33);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.Text = "閉じる";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusText});
            this.statusStrip1.Location = new System.Drawing.Point(0, 33);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(407, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusText
            // 
            this.StatusText.Name = "StatusText";
            this.StatusText.Size = new System.Drawing.Size(51, 17);
            this.StatusText.Text = "ステータス";
            // 
            // UserSaveHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 396);
            this.Controls.Add(this.ButtonGroupPanel);
            this.Controls.Add(this.EnableComboBox);
            this.Controls.Add(this.UnlimitedLabel);
            this.Controls.Add(this.ChoiceGroupBox);
            this.Controls.Add(this.MailAddressTextBox);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.MailAddressCheckBox);
            this.Controls.Add(this.MailAddressLabel);
            this.Controls.Add(this.IdTextBox);
            this.Name = "UserSaveHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ユーザー登録";
            this.ChoiceGroupBox.ResumeLayout(false);
            this.ChoiceGroupBox.PerformLayout();
            this.ButtonGroupPanel.ResumeLayout(false);
            this.ButtonGroupPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label MailAddressLabel;
        private System.Windows.Forms.CheckBox MailAddressCheckBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox MailAddressTextBox;
        private System.Windows.Forms.GroupBox ChoiceGroupBox;
        private System.Windows.Forms.RadioButton BussinessRadioButton;
        private System.Windows.Forms.RadioButton FreeRadioButton;
        private System.Windows.Forms.Label UnlimitedLabel;
        private System.Windows.Forms.ComboBox EnableComboBox;
        private System.Windows.Forms.Panel ButtonGroupPanel;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusText;
    }
}

