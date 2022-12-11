namespace Campus
{
    partial class Form1
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
            this.GenerateCampusBtn = new System.Windows.Forms.Button();
            this.SavedCampusesLabel = new System.Windows.Forms.Label();
            this.SavedCampusesComboBox = new System.Windows.Forms.ComboBox();
            this.RoomNumberTextBox = new System.Windows.Forms.TextBox();
            this.RevenuePeriodComboBox = new System.Windows.Forms.ComboBox();
            this.CloneCampusBtn = new System.Windows.Forms.Button();
            this.SelectedCampusLabel = new System.Windows.Forms.Label();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.RemoveStudentsBtn = new System.Windows.Forms.Button();
            this.CalculateRevenueBtn = new System.Windows.Forms.Button();
            this.ShowInfoBtn = new System.Windows.Forms.Button();
            this.RemoveCampusBtn = new System.Windows.Forms.Button();
            this.KeyStudentTextBox = new System.Windows.Forms.TextBox();
            this.KeyStudentLabel = new System.Windows.Forms.Label();
            this.RoomNumberLabel = new System.Windows.Forms.Label();
            this.SwitchRoomBtn = new System.Windows.Forms.Button();
            this.NumberRoomToWhichTextBox = new System.Windows.Forms.TextBox();
            this.switchLabel = new System.Windows.Forms.Label();
            this.SaveToTXTBtn = new System.Windows.Forms.Button();
            this.ReadTXTFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GenerateCampusBtn
            // 
            this.GenerateCampusBtn.Location = new System.Drawing.Point(12, 29);
            this.GenerateCampusBtn.Name = "GenerateCampusBtn";
            this.GenerateCampusBtn.Size = new System.Drawing.Size(220, 29);
            this.GenerateCampusBtn.TabIndex = 0;
            this.GenerateCampusBtn.Text = "Generate Campus";
            this.GenerateCampusBtn.UseVisualStyleBackColor = true;
            this.GenerateCampusBtn.Click += new System.EventHandler(this.GenerateCampusBtn_Click);
            // 
            // SavedCampusesLabel
            // 
            this.SavedCampusesLabel.AutoSize = true;
            this.SavedCampusesLabel.Location = new System.Drawing.Point(637, 14);
            this.SavedCampusesLabel.Name = "SavedCampusesLabel";
            this.SavedCampusesLabel.Size = new System.Drawing.Size(120, 20);
            this.SavedCampusesLabel.TabIndex = 13;
            this.SavedCampusesLabel.Text = "Saved Campuses";
            // 
            // SavedCampusesComboBox
            // 
            this.SavedCampusesComboBox.FormattingEnabled = true;
            this.SavedCampusesComboBox.Location = new System.Drawing.Point(606, 46);
            this.SavedCampusesComboBox.Name = "SavedCampusesComboBox";
            this.SavedCampusesComboBox.Size = new System.Drawing.Size(151, 28);
            this.SavedCampusesComboBox.TabIndex = 14;
            // 
            // RoomNumberTextBox
            // 
            this.RoomNumberTextBox.Location = new System.Drawing.Point(211, 312);
            this.RoomNumberTextBox.Name = "RoomNumberTextBox";
            this.RoomNumberTextBox.Size = new System.Drawing.Size(125, 27);
            this.RoomNumberTextBox.TabIndex = 16;
            // 
            // RevenuePeriodComboBox
            // 
            this.RevenuePeriodComboBox.FormattingEnabled = true;
            this.RevenuePeriodComboBox.Items.AddRange(new object[] {
            "Month",
            "HalfYear",
            "Year"});
            this.RevenuePeriodComboBox.Location = new System.Drawing.Point(663, 330);
            this.RevenuePeriodComboBox.Name = "RevenuePeriodComboBox";
            this.RevenuePeriodComboBox.Size = new System.Drawing.Size(125, 28);
            this.RevenuePeriodComboBox.TabIndex = 17;
            this.RevenuePeriodComboBox.Text = "Month";
            // 
            // CloneCampusBtn
            // 
            this.CloneCampusBtn.Location = new System.Drawing.Point(558, 80);
            this.CloneCampusBtn.Name = "CloneCampusBtn";
            this.CloneCampusBtn.Size = new System.Drawing.Size(199, 29);
            this.CloneCampusBtn.TabIndex = 18;
            this.CloneCampusBtn.Text = "Clone Selected Campus";
            this.CloneCampusBtn.UseVisualStyleBackColor = true;
            this.CloneCampusBtn.Click += new System.EventHandler(this.CloneCampusBtn_Click);
            // 
            // SelectedCampusLabel
            // 
            this.SelectedCampusLabel.AutoSize = true;
            this.SelectedCampusLabel.Location = new System.Drawing.Point(458, 47);
            this.SelectedCampusLabel.Name = "SelectedCampusLabel";
            this.SelectedCampusLabel.Size = new System.Drawing.Size(123, 20);
            this.SelectedCampusLabel.TabIndex = 19;
            this.SelectedCampusLabel.Text = "Selected Campus";
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Location = new System.Drawing.Point(12, 310);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(170, 29);
            this.AddStudentBtn.TabIndex = 21;
            this.AddStudentBtn.Text = "Add Student(s)";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // RemoveStudentsBtn
            // 
            this.RemoveStudentsBtn.Location = new System.Drawing.Point(12, 265);
            this.RemoveStudentsBtn.Name = "RemoveStudentsBtn";
            this.RemoveStudentsBtn.Size = new System.Drawing.Size(170, 29);
            this.RemoveStudentsBtn.TabIndex = 22;
            this.RemoveStudentsBtn.Text = "Remove Student(s)";
            this.RemoveStudentsBtn.UseVisualStyleBackColor = true;
            this.RemoveStudentsBtn.Click += new System.EventHandler(this.RemoveStudentsBtn_Click);
            // 
            // CalculateRevenueBtn
            // 
            this.CalculateRevenueBtn.Location = new System.Drawing.Point(618, 376);
            this.CalculateRevenueBtn.Name = "CalculateRevenueBtn";
            this.CalculateRevenueBtn.Size = new System.Drawing.Size(170, 29);
            this.CalculateRevenueBtn.TabIndex = 23;
            this.CalculateRevenueBtn.Text = "Calculate Revenue";
            this.CalculateRevenueBtn.UseVisualStyleBackColor = true;
            this.CalculateRevenueBtn.Click += new System.EventHandler(this.CalculateRevenueBtn_Click);
            // 
            // ShowInfoBtn
            // 
            this.ShowInfoBtn.Location = new System.Drawing.Point(621, 116);
            this.ShowInfoBtn.Name = "ShowInfoBtn";
            this.ShowInfoBtn.Size = new System.Drawing.Size(124, 30);
            this.ShowInfoBtn.TabIndex = 24;
            this.ShowInfoBtn.Text = "Show Full Info";
            this.ShowInfoBtn.UseVisualStyleBackColor = true;
            this.ShowInfoBtn.Click += new System.EventHandler(this.ShowInfoBtn_Click);
            // 
            // RemoveCampusBtn
            // 
            this.RemoveCampusBtn.Location = new System.Drawing.Point(549, 153);
            this.RemoveCampusBtn.Name = "RemoveCampusBtn";
            this.RemoveCampusBtn.Size = new System.Drawing.Size(196, 29);
            this.RemoveCampusBtn.TabIndex = 26;
            this.RemoveCampusBtn.Text = "Remove Selected Campus";
            this.RemoveCampusBtn.UseVisualStyleBackColor = true;
            this.RemoveCampusBtn.Click += new System.EventHandler(this.RemoveCampusBtn_Click);
            // 
            // KeyStudentTextBox
            // 
            this.KeyStudentTextBox.Location = new System.Drawing.Point(211, 265);
            this.KeyStudentTextBox.Name = "KeyStudentTextBox";
            this.KeyStudentTextBox.Size = new System.Drawing.Size(125, 27);
            this.KeyStudentTextBox.TabIndex = 27;
            // 
            // KeyStudentLabel
            // 
            this.KeyStudentLabel.AutoSize = true;
            this.KeyStudentLabel.Location = new System.Drawing.Point(342, 274);
            this.KeyStudentLabel.Name = "KeyStudentLabel";
            this.KeyStudentLabel.Size = new System.Drawing.Size(140, 20);
            this.KeyStudentLabel.TabIndex = 28;
            this.KeyStudentLabel.Text = "Students Book (key)";
            // 
            // RoomNumberLabel
            // 
            this.RoomNumberLabel.AutoSize = true;
            this.RoomNumberLabel.Location = new System.Drawing.Point(342, 310);
            this.RoomNumberLabel.Name = "RoomNumberLabel";
            this.RoomNumberLabel.Size = new System.Drawing.Size(125, 20);
            this.RoomNumberLabel.TabIndex = 29;
            this.RoomNumberLabel.Text = "Number of Room";
            // 
            // SwitchRoomBtn
            // 
            this.SwitchRoomBtn.Location = new System.Drawing.Point(12, 220);
            this.SwitchRoomBtn.Name = "SwitchRoomBtn";
            this.SwitchRoomBtn.Size = new System.Drawing.Size(197, 29);
            this.SwitchRoomBtn.TabIndex = 30;
            this.SwitchRoomBtn.Text = "Move Student";
            this.SwitchRoomBtn.UseVisualStyleBackColor = true;
            this.SwitchRoomBtn.Click += new System.EventHandler(this.SwitchRoomBtn_Click);
            // 
            // NumberRoomToWhichTextBox
            // 
            this.NumberRoomToWhichTextBox.Location = new System.Drawing.Point(227, 217);
            this.NumberRoomToWhichTextBox.Name = "NumberRoomToWhichTextBox";
            this.NumberRoomToWhichTextBox.Size = new System.Drawing.Size(125, 27);
            this.NumberRoomToWhichTextBox.TabIndex = 31;
            // 
            // switchLabel
            // 
            this.switchLabel.AutoSize = true;
            this.switchLabel.Location = new System.Drawing.Point(369, 220);
            this.switchLabel.Name = "switchLabel";
            this.switchLabel.Size = new System.Drawing.Size(150, 20);
            this.switchLabel.TabIndex = 32;
            this.switchLabel.Text = "Room to which move";
            // 
            // SaveToTXTBtn
            // 
            this.SaveToTXTBtn.Location = new System.Drawing.Point(12, 116);
            this.SaveToTXTBtn.Name = "SaveToTXTBtn";
            this.SaveToTXTBtn.Size = new System.Drawing.Size(144, 29);
            this.SaveToTXTBtn.TabIndex = 33;
            this.SaveToTXTBtn.Text = "Save Info to TXT";
            this.SaveToTXTBtn.UseVisualStyleBackColor = true;
            this.SaveToTXTBtn.Click += new System.EventHandler(this.SaveToTXTBtn_Click);
            // 
            // ReadTXTFile
            // 
            this.ReadTXTFile.Location = new System.Drawing.Point(208, 116);
            this.ReadTXTFile.Name = "ReadTXTFile";
            this.ReadTXTFile.Size = new System.Drawing.Size(144, 29);
            this.ReadTXTFile.TabIndex = 34;
            this.ReadTXTFile.Text = "Read TXT File";
            this.ReadTXTFile.UseVisualStyleBackColor = true;
            this.ReadTXTFile.Click += new System.EventHandler(this.ReadTXTFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReadTXTFile);
            this.Controls.Add(this.SaveToTXTBtn);
            this.Controls.Add(this.switchLabel);
            this.Controls.Add(this.NumberRoomToWhichTextBox);
            this.Controls.Add(this.SwitchRoomBtn);
            this.Controls.Add(this.RoomNumberLabel);
            this.Controls.Add(this.KeyStudentLabel);
            this.Controls.Add(this.KeyStudentTextBox);
            this.Controls.Add(this.RemoveCampusBtn);
            this.Controls.Add(this.ShowInfoBtn);
            this.Controls.Add(this.CalculateRevenueBtn);
            this.Controls.Add(this.RemoveStudentsBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.SelectedCampusLabel);
            this.Controls.Add(this.CloneCampusBtn);
            this.Controls.Add(this.RevenuePeriodComboBox);
            this.Controls.Add(this.RoomNumberTextBox);
            this.Controls.Add(this.SavedCampusesComboBox);
            this.Controls.Add(this.SavedCampusesLabel);
            this.Controls.Add(this.GenerateCampusBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button GenerateCampusBtn;
        private Label SavedCampusesLabel;
        private ComboBox SavedCampusesComboBox;
        private TextBox RoomNumberTextBox;
        private ComboBox RevenuePeriodComboBox;
        private Button CloneCampusBtn;
        private Label SelectedCampusLabel;
        private Button AddStudentBtn;
        private Button RemoveStudentsBtn;
        private Button CalculateRevenueBtn;
        private Button ShowInfoBtn;
        private Button RemoveCampusBtn;
        private TextBox KeyStudentTextBox;
        private Label KeyStudentLabel;
        private Label RoomNumberLabel;
        private Button SwitchRoomBtn;
        private TextBox NumberRoomToWhichTextBox;
        private Label switchLabel;
        private Button SaveToTXTBtn;
        private Button OpenDirectoryBtn;
        private Button ReadTXTFile;
    }
}