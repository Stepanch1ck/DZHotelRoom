namespace DZHotelRoom
{
    partial class ViewForm
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
            CardPerxonPanel = new Panel();
            CardPerxonLabel = new Label();
            FIOPersonPanel = new Panel();
            FIOPersonLabelData = new Label();
            FIOPersonLabel = new Label();
            BirthdayPanel = new Panel();
            BirthdayLabelData = new Label();
            BirthdayLabel = new Label();
            AnimalCheckBox = new CheckBox();
            PaymentMetodComboBox = new ComboBox();
            QuantityNumberDayPanel = new Panel();
            QuantityNumberDayLabel = new Label();
            QuantityNumberDayPlusButton = new Button();
            QuantityNumberDayMinusButton = new Button();
            QuantityDayPanel = new Panel();
            QuantityDayLabel = new Label();
            CardPerxonPanel.SuspendLayout();
            FIOPersonPanel.SuspendLayout();
            BirthdayPanel.SuspendLayout();
            QuantityNumberDayPanel.SuspendLayout();
            QuantityDayPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CardPerxonPanel
            // 
            CardPerxonPanel.BackColor = SystemColors.ActiveBorder;
            CardPerxonPanel.BorderStyle = BorderStyle.FixedSingle;
            CardPerxonPanel.Controls.Add(CardPerxonLabel);
            CardPerxonPanel.Location = new Point(100, 16);
            CardPerxonPanel.Margin = new Padding(4);
            CardPerxonPanel.Name = "CardPerxonPanel";
            CardPerxonPanel.Size = new Size(267, 63);
            CardPerxonPanel.TabIndex = 0;
            // 
            // CardPerxonLabel
            // 
            CardPerxonLabel.AutoSize = true;
            CardPerxonLabel.Font = new Font("Comic Sans MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            CardPerxonLabel.ForeColor = SystemColors.ControlLightLight;
            CardPerxonLabel.Location = new Point(24, 12);
            CardPerxonLabel.Margin = new Padding(4, 0, 4, 0);
            CardPerxonLabel.Name = "CardPerxonLabel";
            CardPerxonLabel.Size = new Size(218, 38);
            CardPerxonLabel.TabIndex = 0;
            CardPerxonLabel.Text = " Карточка гостя";
            // 
            // FIOPersonPanel
            // 
            FIOPersonPanel.BackColor = SystemColors.ActiveBorder;
            FIOPersonPanel.BorderStyle = BorderStyle.FixedSingle;
            FIOPersonPanel.Controls.Add(FIOPersonLabelData);
            FIOPersonPanel.Controls.Add(FIOPersonLabel);
            FIOPersonPanel.Location = new Point(45, 143);
            FIOPersonPanel.Margin = new Padding(4);
            FIOPersonPanel.Name = "FIOPersonPanel";
            FIOPersonPanel.Size = new Size(388, 63);
            FIOPersonPanel.TabIndex = 1;
            // 
            // FIOPersonLabelData
            // 
            FIOPersonLabelData.AutoSize = true;
            FIOPersonLabelData.ForeColor = SystemColors.ControlLightLight;
            FIOPersonLabelData.Location = new Point(79, 23);
            FIOPersonLabelData.Name = "FIOPersonLabelData";
            FIOPersonLabelData.Size = new Size(49, 20);
            FIOPersonLabelData.TabIndex = 1;
            FIOPersonLabelData.Text = "label1";
            // 
            // FIOPersonLabel
            // 
            FIOPersonLabel.AutoSize = true;
            FIOPersonLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            FIOPersonLabel.ForeColor = SystemColors.ControlLight;
            FIOPersonLabel.Location = new Point(14, 19);
            FIOPersonLabel.Name = "FIOPersonLabel";
            FIOPersonLabel.Size = new Size(59, 26);
            FIOPersonLabel.TabIndex = 0;
            FIOPersonLabel.Text = " ФИО";
            // 
            // BirthdayPanel
            // 
            BirthdayPanel.BackColor = SystemColors.ActiveBorder;
            BirthdayPanel.BorderStyle = BorderStyle.FixedSingle;
            BirthdayPanel.Controls.Add(BirthdayLabelData);
            BirthdayPanel.Controls.Add(BirthdayLabel);
            BirthdayPanel.Location = new Point(45, 243);
            BirthdayPanel.Margin = new Padding(4);
            BirthdayPanel.Name = "BirthdayPanel";
            BirthdayPanel.Size = new Size(388, 63);
            BirthdayPanel.TabIndex = 2;
            // 
            // BirthdayLabelData
            // 
            BirthdayLabelData.AutoSize = true;
            BirthdayLabelData.ForeColor = SystemColors.ControlLightLight;
            BirthdayLabelData.Location = new Point(171, 23);
            BirthdayLabelData.Name = "BirthdayLabelData";
            BirthdayLabelData.Size = new Size(51, 20);
            BirthdayLabelData.TabIndex = 2;
            BirthdayLabelData.Text = "label2";
            // 
            // BirthdayLabel
            // 
            BirthdayLabel.AutoSize = true;
            BirthdayLabel.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            BirthdayLabel.ForeColor = SystemColors.ControlLight;
            BirthdayLabel.Location = new Point(14, 17);
            BirthdayLabel.Name = "BirthdayLabel";
            BirthdayLabel.Size = new Size(151, 26);
            BirthdayLabel.TabIndex = 0;
            BirthdayLabel.Text = "День рождения";
            // 
            // AnimalCheckBox
            // 
            AnimalCheckBox.AutoSize = true;
            AnimalCheckBox.BackColor = SystemColors.ActiveBorder;
            AnimalCheckBox.Enabled = false;
            AnimalCheckBox.ForeColor = SystemColors.ControlLight;
            AnimalCheckBox.Location = new Point(45, 477);
            AnimalCheckBox.Margin = new Padding(4);
            AnimalCheckBox.Name = "AnimalCheckBox";
            AnimalCheckBox.Size = new Size(231, 24);
            AnimalCheckBox.TabIndex = 3;
            AnimalCheckBox.Text = "Путешествую с животными";
            AnimalCheckBox.UseVisualStyleBackColor = false;
            // 
            // PaymentMetodComboBox
            // 
            PaymentMetodComboBox.BackColor = Color.Silver;
            PaymentMetodComboBox.Enabled = false;
            PaymentMetodComboBox.ForeColor = SystemColors.ControlLightLight;
            PaymentMetodComboBox.FormattingEnabled = true;
            PaymentMetodComboBox.Location = new Point(100, 328);
            PaymentMetodComboBox.Margin = new Padding(4);
            PaymentMetodComboBox.Name = "PaymentMetodComboBox";
            PaymentMetodComboBox.Size = new Size(266, 28);
            PaymentMetodComboBox.TabIndex = 4;
            // 
            // QuantityNumberDayPanel
            // 
            QuantityNumberDayPanel.BackColor = SystemColors.ActiveBorder;
            QuantityNumberDayPanel.BorderStyle = BorderStyle.FixedSingle;
            QuantityNumberDayPanel.Controls.Add(QuantityNumberDayLabel);
            QuantityNumberDayPanel.Controls.Add(QuantityNumberDayPlusButton);
            QuantityNumberDayPanel.Controls.Add(QuantityNumberDayMinusButton);
            QuantityNumberDayPanel.Location = new Point(45, 389);
            QuantityNumberDayPanel.Margin = new Padding(4);
            QuantityNumberDayPanel.Name = "QuantityNumberDayPanel";
            QuantityNumberDayPanel.Size = new Size(172, 49);
            QuantityNumberDayPanel.TabIndex = 5;
            // 
            // QuantityNumberDayLabel
            // 
            QuantityNumberDayLabel.AutoSize = true;
            QuantityNumberDayLabel.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuantityNumberDayLabel.ForeColor = SystemColors.ControlLightLight;
            QuantityNumberDayLabel.Location = new Point(67, 7);
            QuantityNumberDayLabel.Name = "QuantityNumberDayLabel";
            QuantityNumberDayLabel.Size = new Size(30, 33);
            QuantityNumberDayLabel.TabIndex = 2;
            QuantityNumberDayLabel.Text = "0";
            // 
            // QuantityNumberDayPlusButton
            // 
            QuantityNumberDayPlusButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuantityNumberDayPlusButton.Location = new Point(123, 3);
            QuantityNumberDayPlusButton.Name = "QuantityNumberDayPlusButton";
            QuantityNumberDayPlusButton.Size = new Size(46, 43);
            QuantityNumberDayPlusButton.TabIndex = 1;
            QuantityNumberDayPlusButton.Text = "+";
            QuantityNumberDayPlusButton.UseVisualStyleBackColor = true;
            QuantityNumberDayPlusButton.Click += QuantityNumberDayPlusButton_Click;
            // 
            // QuantityNumberDayMinusButton
            // 
            QuantityNumberDayMinusButton.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuantityNumberDayMinusButton.Location = new Point(3, 3);
            QuantityNumberDayMinusButton.Name = "QuantityNumberDayMinusButton";
            QuantityNumberDayMinusButton.Size = new Size(44, 43);
            QuantityNumberDayMinusButton.TabIndex = 0;
            QuantityNumberDayMinusButton.Text = "-";
            QuantityNumberDayMinusButton.UseVisualStyleBackColor = true;
            QuantityNumberDayMinusButton.Click += QuantityNumberDayMinusButton_Click;
            // 
            // QuantityDayPanel
            // 
            QuantityDayPanel.BackColor = SystemColors.ActiveBorder;
            QuantityDayPanel.BorderStyle = BorderStyle.FixedSingle;
            QuantityDayPanel.Controls.Add(QuantityDayLabel);
            QuantityDayPanel.Location = new Point(261, 389);
            QuantityDayPanel.Margin = new Padding(4);
            QuantityDayPanel.Name = "QuantityDayPanel";
            QuantityDayPanel.Size = new Size(172, 49);
            QuantityDayPanel.TabIndex = 6;
            // 
            // QuantityDayLabel
            // 
            QuantityDayLabel.AutoSize = true;
            QuantityDayLabel.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            QuantityDayLabel.ForeColor = SystemColors.ControlLightLight;
            QuantityDayLabel.Location = new Point(13, 14);
            QuantityDayLabel.Name = "QuantityDayLabel";
            QuantityDayLabel.Size = new Size(140, 23);
            QuantityDayLabel.TabIndex = 2;
            QuantityDayLabel.Text = "Количество дней";
            // 
            // ViewForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(467, 600);
            Controls.Add(QuantityDayPanel);
            Controls.Add(QuantityNumberDayPanel);
            Controls.Add(PaymentMetodComboBox);
            Controls.Add(AnimalCheckBox);
            Controls.Add(BirthdayPanel);
            Controls.Add(FIOPersonPanel);
            Controls.Add(CardPerxonPanel);
            Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "ViewForm";
            Text = "ViewForm";
            Load += ViewForm_Load;
            CardPerxonPanel.ResumeLayout(false);
            CardPerxonPanel.PerformLayout();
            FIOPersonPanel.ResumeLayout(false);
            FIOPersonPanel.PerformLayout();
            BirthdayPanel.ResumeLayout(false);
            BirthdayPanel.PerformLayout();
            QuantityNumberDayPanel.ResumeLayout(false);
            QuantityNumberDayPanel.PerformLayout();
            QuantityDayPanel.ResumeLayout(false);
            QuantityDayPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel CardPerxonPanel;
        private Panel FIOPersonPanel;
        private Panel BirthdayPanel;
        private CheckBox AnimalCheckBox;
        private ComboBox PaymentMetodComboBox;
        private Panel QuantityNumberDayPanel;
        private Panel QuantityDayPanel;
        private Label CardPerxonLabel;
        private Label FIOPersonLabel;
        private Label BirthdayLabel;
        private Label FIOPersonLabelData;
        private Label BirthdayLabelData;
        private Button QuantityNumberDayMinusButton;
        private Label QuantityDayLabel;
        private Label QuantityNumberDayLabel;
        private Button QuantityNumberDayPlusButton;
    }
}