namespace DZHotelRoom
{
    partial class HotelForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NumberRoomLabel = new Label();
            PhotoBox = new PictureBox();
            StatusLabel = new Label();
            FioLabel = new Label();
            PanelRight = new Panel();
            NumberLabel = new Label();
            FioPanel = new Panel();
            FIOPersonLabel = new Label();
            StatusPanel = new Panel();
            StatusPersonLabel = new Label();
            ReleaseDatePanel = new Panel();
            ReleasePersonLabel = new Label();
            ReleaseDateLabel = new Label();
            ArrivalDatePanel = new Panel();
            ArrivalPersonLabel = new Label();
            ArrivalDateLabel = new Label();
            ViewButton = new Button();
            PanelLeft = new Panel();
            CheckoutRadioButton = new RadioButton();
            OccupiedRadioButton = new RadioButton();
            FreeRadioButton = new RadioButton();
            ReservedRadioButton = new RadioButton();
            SatusLabel = new Label();
            SearchBox = new TextBox();
            SearchButton = new Button();
            panel1 = new Panel();
            pictureBox = new PictureBox();
            LabelTime = new Label();
            CentralPanel = new Panel();
            MainDataGridView = new DataGridView();
            Timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)PhotoBox).BeginInit();
            PanelRight.SuspendLayout();
            FioPanel.SuspendLayout();
            StatusPanel.SuspendLayout();
            ReleaseDatePanel.SuspendLayout();
            ArrivalDatePanel.SuspendLayout();
            PanelLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            CentralPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).BeginInit();
            SuspendLayout();
            // 
            // NumberRoomLabel
            // 
            NumberRoomLabel.AutoSize = true;
            NumberRoomLabel.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberRoomLabel.ForeColor = SystemColors.ControlLight;
            NumberRoomLabel.Location = new Point(38, 10);
            NumberRoomLabel.Margin = new Padding(4, 0, 4, 0);
            NumberRoomLabel.Name = "NumberRoomLabel";
            NumberRoomLabel.Size = new Size(113, 30);
            NumberRoomLabel.TabIndex = 1;
            NumberRoomLabel.Text = "Номер №";
            // 
            // PhotoBox
            // 
            PhotoBox.BorderStyle = BorderStyle.FixedSingle;
            PhotoBox.Location = new Point(59, 44);
            PhotoBox.Margin = new Padding(4, 3, 4, 3);
            PhotoBox.Name = "PhotoBox";
            PhotoBox.Size = new Size(153, 110);
            PhotoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            PhotoBox.TabIndex = 2;
            PhotoBox.TabStop = false;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.ForeColor = SystemColors.ControlLightLight;
            StatusLabel.Location = new Point(4, 10);
            StatusLabel.Margin = new Padding(4, 0, 4, 0);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(45, 17);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Статус";
            // 
            // FioLabel
            // 
            FioLabel.AutoSize = true;
            FioLabel.Location = new Point(4, 12);
            FioLabel.Margin = new Padding(4, 0, 4, 0);
            FioLabel.Name = "FioLabel";
            FioLabel.Size = new Size(35, 17);
            FioLabel.TabIndex = 4;
            FioLabel.Text = "ФИО";
            // 
            // PanelRight
            // 
            PanelRight.BackColor = SystemColors.ControlDarkDark;
            PanelRight.Controls.Add(NumberLabel);
            PanelRight.Controls.Add(FioPanel);
            PanelRight.Controls.Add(StatusPanel);
            PanelRight.Controls.Add(ReleaseDatePanel);
            PanelRight.Controls.Add(ArrivalDatePanel);
            PanelRight.Controls.Add(ViewButton);
            PanelRight.Controls.Add(PhotoBox);
            PanelRight.Controls.Add(NumberRoomLabel);
            PanelRight.Font = new Font("Comic Sans MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PanelRight.ForeColor = SystemColors.ControlLightLight;
            PanelRight.Location = new Point(644, 47);
            PanelRight.Margin = new Padding(4, 3, 4, 3);
            PanelRight.Name = "PanelRight";
            PanelRight.Size = new Size(290, 476);
            PanelRight.TabIndex = 6;
            // 
            // NumberLabel
            // 
            NumberLabel.AutoSize = true;
            NumberLabel.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NumberLabel.ForeColor = SystemColors.ControlLight;
            NumberLabel.Location = new Point(147, 11);
            NumberLabel.Margin = new Padding(4, 0, 4, 0);
            NumberLabel.Name = "NumberLabel";
            NumberLabel.Size = new Size(0, 30);
            NumberLabel.TabIndex = 10;
            // 
            // FioPanel
            // 
            FioPanel.BorderStyle = BorderStyle.FixedSingle;
            FioPanel.Controls.Add(FIOPersonLabel);
            FioPanel.Controls.Add(FioLabel);
            FioPanel.Location = new Point(27, 213);
            FioPanel.Margin = new Padding(4, 3, 4, 3);
            FioPanel.Name = "FioPanel";
            FioPanel.Size = new Size(248, 40);
            FioPanel.TabIndex = 9;
            // 
            // FIOPersonLabel
            // 
            FIOPersonLabel.AutoSize = true;
            FIOPersonLabel.Location = new Point(65, 12);
            FIOPersonLabel.Name = "FIOPersonLabel";
            FIOPersonLabel.Size = new Size(0, 17);
            FIOPersonLabel.TabIndex = 5;
            // 
            // StatusPanel
            // 
            StatusPanel.BorderStyle = BorderStyle.FixedSingle;
            StatusPanel.Controls.Add(StatusPersonLabel);
            StatusPanel.Controls.Add(StatusLabel);
            StatusPanel.Location = new Point(27, 170);
            StatusPanel.Margin = new Padding(4, 3, 4, 3);
            StatusPanel.Name = "StatusPanel";
            StatusPanel.Size = new Size(248, 36);
            StatusPanel.TabIndex = 8;
            // 
            // StatusPersonLabel
            // 
            StatusPersonLabel.AutoSize = true;
            StatusPersonLabel.Location = new Point(65, 10);
            StatusPersonLabel.Name = "StatusPersonLabel";
            StatusPersonLabel.Size = new Size(0, 17);
            StatusPersonLabel.TabIndex = 4;
            // 
            // ReleaseDatePanel
            // 
            ReleaseDatePanel.BorderStyle = BorderStyle.FixedSingle;
            ReleaseDatePanel.Controls.Add(ReleasePersonLabel);
            ReleaseDatePanel.Controls.Add(ReleaseDateLabel);
            ReleaseDatePanel.Location = new Point(23, 358);
            ReleaseDatePanel.Margin = new Padding(4, 3, 4, 3);
            ReleaseDatePanel.Name = "ReleaseDatePanel";
            ReleaseDatePanel.Size = new Size(160, 43);
            ReleaseDatePanel.TabIndex = 7;
            // 
            // ReleasePersonLabel
            // 
            ReleasePersonLabel.AutoSize = true;
            ReleasePersonLabel.Location = new Point(61, 14);
            ReleasePersonLabel.Name = "ReleasePersonLabel";
            ReleasePersonLabel.Size = new Size(0, 17);
            ReleasePersonLabel.TabIndex = 5;
            // 
            // ReleaseDateLabel
            // 
            ReleaseDateLabel.AutoSize = true;
            ReleaseDateLabel.Location = new Point(0, 0);
            ReleaseDateLabel.Margin = new Padding(4, 0, 4, 0);
            ReleaseDateLabel.Name = "ReleaseDateLabel";
            ReleaseDateLabel.Size = new Size(82, 17);
            ReleaseDateLabel.TabIndex = 0;
            ReleaseDateLabel.Text = "Дата выезда:";
            // 
            // ArrivalDatePanel
            // 
            ArrivalDatePanel.BorderStyle = BorderStyle.FixedSingle;
            ArrivalDatePanel.Controls.Add(ArrivalPersonLabel);
            ArrivalDatePanel.Controls.Add(ArrivalDateLabel);
            ArrivalDatePanel.Location = new Point(23, 294);
            ArrivalDatePanel.Margin = new Padding(4, 3, 4, 3);
            ArrivalDatePanel.Name = "ArrivalDatePanel";
            ArrivalDatePanel.Size = new Size(160, 43);
            ArrivalDatePanel.TabIndex = 6;
            // 
            // ArrivalPersonLabel
            // 
            ArrivalPersonLabel.AutoSize = true;
            ArrivalPersonLabel.Location = new Point(59, 15);
            ArrivalPersonLabel.Name = "ArrivalPersonLabel";
            ArrivalPersonLabel.Size = new Size(0, 17);
            ArrivalPersonLabel.TabIndex = 5;
            // 
            // ArrivalDateLabel
            // 
            ArrivalDateLabel.AutoSize = true;
            ArrivalDateLabel.Location = new Point(0, 0);
            ArrivalDateLabel.Margin = new Padding(4, 0, 4, 0);
            ArrivalDateLabel.Name = "ArrivalDateLabel";
            ArrivalDateLabel.Size = new Size(78, 17);
            ArrivalDateLabel.TabIndex = 0;
            ArrivalDateLabel.Text = "Дата заезда:";
            // 
            // ViewButton
            // 
            ViewButton.BackColor = Color.DimGray;
            ViewButton.Location = new Point(82, 438);
            ViewButton.Margin = new Padding(4, 3, 4, 3);
            ViewButton.Name = "ViewButton";
            ViewButton.Size = new Size(154, 27);
            ViewButton.TabIndex = 5;
            ViewButton.Text = "Просмотр карточки";
            ViewButton.UseVisualStyleBackColor = false;
            ViewButton.Click += ViewButton_Click;
            // 
            // PanelLeft
            // 
            PanelLeft.BackColor = SystemColors.ControlDarkDark;
            PanelLeft.Controls.Add(CheckoutRadioButton);
            PanelLeft.Controls.Add(OccupiedRadioButton);
            PanelLeft.Controls.Add(FreeRadioButton);
            PanelLeft.Controls.Add(ReservedRadioButton);
            PanelLeft.Controls.Add(SatusLabel);
            PanelLeft.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            PanelLeft.ForeColor = SystemColors.ControlLightLight;
            PanelLeft.Location = new Point(1, 47);
            PanelLeft.Margin = new Padding(4, 3, 4, 3);
            PanelLeft.Name = "PanelLeft";
            PanelLeft.Size = new Size(243, 476);
            PanelLeft.TabIndex = 7;
            // 
            // CheckoutRadioButton
            // 
            CheckoutRadioButton.AutoSize = true;
            CheckoutRadioButton.Location = new Point(31, 157);
            CheckoutRadioButton.Margin = new Padding(4, 3, 4, 3);
            CheckoutRadioButton.Name = "CheckoutRadioButton";
            CheckoutRadioButton.Size = new Size(141, 24);
            CheckoutRadioButton.TabIndex = 4;
            CheckoutRadioButton.TabStop = true;
            CheckoutRadioButton.Text = "Выписываются";
            CheckoutRadioButton.UseVisualStyleBackColor = true;
            CheckoutRadioButton.CheckedChanged += CheckoutRadioButton_CheckedChanged;
            // 
            // OccupiedRadioButton
            // 
            OccupiedRadioButton.AutoSize = true;
            OccupiedRadioButton.Location = new Point(31, 118);
            OccupiedRadioButton.Margin = new Padding(4, 3, 4, 3);
            OccupiedRadioButton.Name = "OccupiedRadioButton";
            OccupiedRadioButton.Size = new Size(79, 24);
            OccupiedRadioButton.TabIndex = 3;
            OccupiedRadioButton.TabStop = true;
            OccupiedRadioButton.Text = "Заняты";
            OccupiedRadioButton.UseVisualStyleBackColor = true;
            OccupiedRadioButton.CheckedChanged += OccupiedRadioButton_CheckedChanged;
            // 
            // FreeRadioButton
            // 
            FreeRadioButton.AutoSize = true;
            FreeRadioButton.Location = new Point(31, 81);
            FreeRadioButton.Margin = new Padding(4, 3, 4, 3);
            FreeRadioButton.Name = "FreeRadioButton";
            FreeRadioButton.Size = new Size(107, 24);
            FreeRadioButton.TabIndex = 2;
            FreeRadioButton.TabStop = true;
            FreeRadioButton.Text = "Свободные";
            FreeRadioButton.UseVisualStyleBackColor = true;
            FreeRadioButton.CheckedChanged += FreeRadioButton_CheckedChanged;
            // 
            // ReservedRadioButton
            // 
            ReservedRadioButton.AutoSize = true;
            ReservedRadioButton.Location = new Point(31, 44);
            ReservedRadioButton.Margin = new Padding(4, 3, 4, 3);
            ReservedRadioButton.Name = "ReservedRadioButton";
            ReservedRadioButton.Size = new Size(151, 24);
            ReservedRadioButton.TabIndex = 1;
            ReservedRadioButton.TabStop = true;
            ReservedRadioButton.Text = "Зарезервировано";
            ReservedRadioButton.UseVisualStyleBackColor = true;
            ReservedRadioButton.CheckedChanged += ReservedRadioButton_CheckedChanged;
            // 
            // SatusLabel
            // 
            SatusLabel.AutoSize = true;
            SatusLabel.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SatusLabel.Location = new Point(76, 9);
            SatusLabel.Margin = new Padding(4, 0, 4, 0);
            SatusLabel.Name = "SatusLabel";
            SatusLabel.Size = new Size(81, 30);
            SatusLabel.TabIndex = 0;
            SatusLabel.Text = "Статус";
            // 
            // SearchBox
            // 
            SearchBox.BackColor = SystemColors.ControlDarkDark;
            SearchBox.Font = new Font("Comic Sans MS", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchBox.ForeColor = SystemColors.ControlLightLight;
            SearchBox.Location = new Point(239, 15);
            SearchBox.Margin = new Padding(4, 3, 4, 3);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(516, 28);
            SearchBox.TabIndex = 8;
            SearchBox.Text = "Введите имя гостя...";
            SearchBox.Click += Search_Click;
            // 
            // SearchButton
            // 
            SearchButton.BackColor = Color.DimGray;
            SearchButton.Font = new Font("Comic Sans MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            SearchButton.ForeColor = SystemColors.ControlLightLight;
            SearchButton.Location = new Point(767, 14);
            SearchButton.Margin = new Padding(4, 3, 4, 3);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(88, 28);
            SearchButton.TabIndex = 10;
            SearchButton.Text = "Поиск";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += SearchButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(pictureBox);
            panel1.Controls.Add(LabelTime);
            panel1.Controls.Add(SearchBox);
            panel1.Controls.Add(SearchButton);
            panel1.Location = new Point(1, -3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(933, 57);
            panel1.TabIndex = 11;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = Color.Transparent;
            pictureBox.Image = Properties.Resources.timer;
            pictureBox.Location = new Point(3, 6);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(56, 40);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 12;
            pictureBox.TabStop = false;
            // 
            // LabelTime
            // 
            LabelTime.AutoSize = true;
            LabelTime.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            LabelTime.ForeColor = SystemColors.ButtonHighlight;
            LabelTime.Location = new Point(105, 12);
            LabelTime.Name = "LabelTime";
            LabelTime.Size = new Size(67, 27);
            LabelTime.TabIndex = 11;
            LabelTime.Text = "label1";
            // 
            // CentralPanel
            // 
            CentralPanel.BackColor = SystemColors.ControlDark;
            CentralPanel.Controls.Add(MainDataGridView);
            CentralPanel.Location = new Point(240, 50);
            CentralPanel.Margin = new Padding(4, 3, 4, 3);
            CentralPanel.Name = "CentralPanel";
            CentralPanel.Size = new Size(406, 476);
            CentralPanel.TabIndex = 12;
            // 
            // MainDataGridView
            // 
            MainDataGridView.BackgroundColor = Color.Gray;
            MainDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MainDataGridView.GridColor = SystemColors.InfoText;
            MainDataGridView.Location = new Point(0, 0);
            MainDataGridView.Margin = new Padding(4, 3, 4, 3);
            MainDataGridView.Name = "MainDataGridView";
            MainDataGridView.Size = new Size(404, 470);
            MainDataGridView.TabIndex = 0;
            MainDataGridView.CellMouseDoubleClick += MainDataGridView_CellMouseDoubleClick;
            // 
            // Timer
            // 
            Timer.Interval = 1000;
            Timer.Tick += Timer_Tick;
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(CentralPanel);
            Controls.Add(panel1);
            Controls.Add(PanelLeft);
            Controls.Add(PanelRight);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "HotelForm";
            Text = "HotelForm";
            FormClosed += HotelForm_FormClosing;
            Load += HotelForm_Load;
            ((System.ComponentModel.ISupportInitialize)PhotoBox).EndInit();
            PanelRight.ResumeLayout(false);
            PanelRight.PerformLayout();
            FioPanel.ResumeLayout(false);
            FioPanel.PerformLayout();
            StatusPanel.ResumeLayout(false);
            StatusPanel.PerformLayout();
            ReleaseDatePanel.ResumeLayout(false);
            ReleaseDatePanel.PerformLayout();
            ArrivalDatePanel.ResumeLayout(false);
            ArrivalDatePanel.PerformLayout();
            PanelLeft.ResumeLayout(false);
            PanelLeft.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            CentralPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MainDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label NumberRoomLabel;
        private System.Windows.Forms.PictureBox PhotoBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Panel PanelRight;
        private System.Windows.Forms.Panel PanelLeft;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SatusLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.RadioButton CheckoutRadioButton;
        private System.Windows.Forms.RadioButton OccupiedRadioButton;
        private System.Windows.Forms.RadioButton FreeRadioButton;
        private System.Windows.Forms.RadioButton ReservedRadioButton;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Panel ArrivalDatePanel;
        private System.Windows.Forms.Label ArrivalDateLabel;
        private System.Windows.Forms.Panel ReleaseDatePanel;
        private System.Windows.Forms.Label ReleaseDateLabel;
        private System.Windows.Forms.Panel FioPanel;
        private System.Windows.Forms.Panel StatusPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.DataGridView MainDataGridView;
        private Label LabelTime;
        private Label FIOPersonLabel;
        private Label StatusPersonLabel;
        private Label ReleasePersonLabel;
        private Label ArrivalPersonLabel;
        private System.Windows.Forms.Timer Timer;
        private PictureBox pictureBox;
        private Label NumberLabel;
    }
}
