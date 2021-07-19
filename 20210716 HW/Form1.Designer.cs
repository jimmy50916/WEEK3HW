
namespace _20210716_HW
{
    partial class TaxCalculator
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.yearModeRadioButton = new System.Windows.Forms.RadioButton();
            this.daysModeRadioButton2 = new System.Windows.Forms.RadioButton();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.optionPanel = new System.Windows.Forms.Panel();
            this.carTypeComboBox = new System.Windows.Forms.ComboBox();
            this.CCLabel = new System.Windows.Forms.Label();
            this.carTypeLabel = new System.Windows.Forms.Label();
            this.CCComboBox = new System.Windows.Forms.ComboBox();
            this.alertPanel = new System.Windows.Forms.Panel();
            this.alertLabel = new System.Windows.Forms.Label();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.resetButton = new System.Windows.Forms.Button();
            this.comfirmButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.alertPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // yearModeRadioButton
            // 
            this.yearModeRadioButton.AutoSize = true;
            this.yearModeRadioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yearModeRadioButton.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.yearModeRadioButton.Location = new System.Drawing.Point(53, 10);
            this.yearModeRadioButton.Name = "yearModeRadioButton";
            this.yearModeRadioButton.Size = new System.Drawing.Size(62, 20);
            this.yearModeRadioButton.TabIndex = 0;
            this.yearModeRadioButton.TabStop = true;
            this.yearModeRadioButton.Text = "全年度";
            this.yearModeRadioButton.UseVisualStyleBackColor = true;
            this.yearModeRadioButton.CheckedChanged += new System.EventHandler(this.yearModeRadioButton_CheckedChanged);
            // 
            // daysModeRadioButton2
            // 
            this.daysModeRadioButton2.AutoSize = true;
            this.daysModeRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.daysModeRadioButton2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.daysModeRadioButton2.Location = new System.Drawing.Point(137, 10);
            this.daysModeRadioButton2.Name = "daysModeRadioButton2";
            this.daysModeRadioButton2.Size = new System.Drawing.Size(62, 20);
            this.daysModeRadioButton2.TabIndex = 1;
            this.daysModeRadioButton2.TabStop = true;
            this.daysModeRadioButton2.Text = "依期間";
            this.daysModeRadioButton2.UseVisualStyleBackColor = true;
            this.daysModeRadioButton2.CheckedChanged += new System.EventHandler(this.daysModeRadioButton2_CheckedChanged);
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.Info;
            this.mainPanel.Controls.Add(this.optionPanel);
            this.mainPanel.Controls.Add(this.alertPanel);
            this.mainPanel.Controls.Add(this.titleLabel1);
            this.mainPanel.Controls.Add(this.outputTextBox);
            this.mainPanel.Controls.Add(this.endDateTimePicker);
            this.mainPanel.Controls.Add(this.startDateTimePicker);
            this.mainPanel.Controls.Add(this.resetButton);
            this.mainPanel.Controls.Add(this.comfirmButton);
            this.mainPanel.ForeColor = System.Drawing.SystemColors.MenuText;
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(553, 358);
            this.mainPanel.TabIndex = 2;
            // 
            // optionPanel
            // 
            this.optionPanel.BackColor = System.Drawing.SystemColors.Window;
            this.optionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionPanel.Controls.Add(this.carTypeComboBox);
            this.optionPanel.Controls.Add(this.CCLabel);
            this.optionPanel.Controls.Add(this.carTypeLabel);
            this.optionPanel.Controls.Add(this.CCComboBox);
            this.optionPanel.Controls.Add(this.daysModeRadioButton2);
            this.optionPanel.Controls.Add(this.yearModeRadioButton);
            this.optionPanel.Location = new System.Drawing.Point(3, 71);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(315, 157);
            this.optionPanel.TabIndex = 15;
            // 
            // carTypeComboBox
            // 
            this.carTypeComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.carTypeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.carTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.carTypeComboBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.carTypeComboBox.FormattingEnabled = true;
            this.carTypeComboBox.Items.AddRange(new object[] {
            "自用小客車",
            "營業用小客車",
            "大客車",
            "貨車",
            "曳引車",
            "機車",
            "自用電動小客車",
            "營業用電動小客車",
            "電動機車",
            "電動大客車及貨車"});
            this.carTypeComboBox.Location = new System.Drawing.Point(89, 62);
            this.carTypeComboBox.Name = "carTypeComboBox";
            this.carTypeComboBox.Size = new System.Drawing.Size(201, 24);
            this.carTypeComboBox.TabIndex = 12;
            this.carTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.carTypeComboBox_SelectedIndexChanged);
            // 
            // CCLabel
            // 
            this.CCLabel.AutoSize = true;
            this.CCLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCLabel.Location = new System.Drawing.Point(3, 104);
            this.CCLabel.Name = "CCLabel";
            this.CCLabel.Size = new System.Drawing.Size(82, 32);
            this.CCLabel.TabIndex = 8;
            this.CCLabel.Text = "車子CC數/\r\n馬力(HP、PS)";
            // 
            // carTypeLabel
            // 
            this.carTypeLabel.AutoSize = true;
            this.carTypeLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.carTypeLabel.Location = new System.Drawing.Point(28, 65);
            this.carTypeLabel.Name = "carTypeLabel";
            this.carTypeLabel.Size = new System.Drawing.Size(32, 16);
            this.carTypeLabel.TabIndex = 7;
            this.carTypeLabel.Text = "車種";
            // 
            // CCComboBox
            // 
            this.CCComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CCComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CCComboBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.CCComboBox.ForeColor = System.Drawing.SystemColors.MenuText;
            this.CCComboBox.FormattingEnabled = true;
            this.CCComboBox.Items.AddRange(new object[] {
            "<500cc",
            "501cc - 600cc",
            "601cc - 1200cc",
            "1201cc - 1800cc",
            "1801cc - 2400cc",
            "2401cc - 3000cc",
            "3001cc - 4200cc",
            "4201cc - 5400cc",
            "5401cc - 6600cc",
            "6601cc - 7800cc",
            "7801cc "});
            this.CCComboBox.Location = new System.Drawing.Point(89, 110);
            this.CCComboBox.Name = "CCComboBox";
            this.CCComboBox.Size = new System.Drawing.Size(201, 24);
            this.CCComboBox.TabIndex = 2;
            this.CCComboBox.SelectedIndexChanged += new System.EventHandler(this.CCComboBox_SelectedIndexChanged);
            // 
            // alertPanel
            // 
            this.alertPanel.BackColor = System.Drawing.SystemColors.Window;
            this.alertPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alertPanel.Controls.Add(this.alertLabel);
            this.alertPanel.Location = new System.Drawing.Point(324, 95);
            this.alertPanel.Name = "alertPanel";
            this.alertPanel.Size = new System.Drawing.Size(226, 133);
            this.alertPanel.TabIndex = 14;
            // 
            // alertLabel
            // 
            this.alertLabel.AutoSize = true;
            this.alertLabel.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.alertLabel.ForeColor = System.Drawing.Color.Red;
            this.alertLabel.Location = new System.Drawing.Point(15, 13);
            this.alertLabel.Name = "alertLabel";
            this.alertLabel.Size = new System.Drawing.Size(43, 16);
            this.alertLabel.TabIndex = 9;
            this.alertLabel.Text = "label3";
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.BackColor = System.Drawing.Color.Beige;
            this.titleLabel1.Font = new System.Drawing.Font("微軟正黑體", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.titleLabel1.Location = new System.Drawing.Point(21, 10);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(222, 50);
            this.titleLabel1.TabIndex = 13;
            this.titleLabel1.Text = "牌照稅試算";
            // 
            // outputTextBox
            // 
            this.outputTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.outputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.outputTextBox.CausesValidation = false;
            this.outputTextBox.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputTextBox.Location = new System.Drawing.Point(3, 263);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ReadOnly = true;
            this.outputTextBox.Size = new System.Drawing.Size(547, 92);
            this.outputTextBox.TabIndex = 11;
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.endDateTimePicker.Location = new System.Drawing.Point(338, 56);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.endDateTimePicker.TabIndex = 6;
            // 
            // startDateTimePicker
            // 
            this.startDateTimePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startDateTimePicker.Location = new System.Drawing.Point(338, 28);
            this.startDateTimePicker.Name = "startDateTimePicker";
            this.startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.startDateTimePicker.TabIndex = 5;
            // 
            // resetButton
            // 
            this.resetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.resetButton.Location = new System.Drawing.Point(324, 234);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 4;
            this.resetButton.Text = "取消重填";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // comfirmButton
            // 
            this.comfirmButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comfirmButton.Location = new System.Drawing.Point(161, 234);
            this.comfirmButton.Name = "comfirmButton";
            this.comfirmButton.Size = new System.Drawing.Size(75, 23);
            this.comfirmButton.TabIndex = 3;
            this.comfirmButton.Text = "確定送出";
            this.comfirmButton.UseVisualStyleBackColor = true;
            this.comfirmButton.Click += new System.EventHandler(this.comfirmButton_Click);
            // 
            // TaxCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(584, 381);
            this.Controls.Add(this.mainPanel);
            this.Name = "TaxCalculator";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "TaxCalculator";
            this.Load += new System.EventHandler(this.TaxCalculatorForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.optionPanel.ResumeLayout(false);
            this.optionPanel.PerformLayout();
            this.alertPanel.ResumeLayout(false);
            this.alertPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton yearModeRadioButton;
        private System.Windows.Forms.RadioButton daysModeRadioButton2;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label alertLabel;
        private System.Windows.Forms.Label CCLabel;
        private System.Windows.Forms.Label carTypeLabel;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateTimePicker;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button comfirmButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.ComboBox CCComboBox;
        private System.Windows.Forms.ComboBox carTypeComboBox;
        private System.Windows.Forms.Label titleLabel1;
        private System.Windows.Forms.Panel optionPanel;
        private System.Windows.Forms.Panel alertPanel;
    }
}

