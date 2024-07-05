namespace AgeCalculation
{
    partial class AgeCalculation
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
            resetButton = new Button();
            calculationButton = new Button();
            LableBirth = new Label();
            birthTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ageTextBox = new TextBox();
            ageLabel = new Label();
            exitButton = new Button();
            SuspendLayout();
            // 
            // resetButton
            // 
            resetButton.Location = new Point(93, 137);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(75, 23);
            resetButton.TabIndex = 6;
            resetButton.Text = "ریست فرم";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // calculationButton
            // 
            calculationButton.Location = new Point(12, 137);
            calculationButton.Name = "calculationButton";
            calculationButton.Size = new Size(75, 23);
            calculationButton.TabIndex = 5;
            calculationButton.Text = "محاسبه سن";
            calculationButton.UseVisualStyleBackColor = true;
            // 
            // LableBirth
            // 
            LableBirth.AutoSize = true;
            LableBirth.Location = new Point(112, 44);
            LableBirth.Name = "LableBirth";
            LableBirth.Size = new Size(136, 15);
            LableBirth.TabIndex = 2;
            LableBirth.Text = "سال تولد خود را وارد نمایید";
            // 
            // birthTextBox
            // 
            birthTextBox.Location = new Point(12, 41);
            birthTextBox.MaxLength = 4;
            birthTextBox.Name = "birthTextBox";
            birthTextBox.PlaceholderText = "1375";
            birthTextBox.Size = new Size(75, 23);
            birthTextBox.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 12);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(236, 23);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.Value = new DateTime(2024, 7, 6, 0, 0, 0, 0);
            // 
            // ageTextBox
            // 
            ageTextBox.Enabled = false;
            ageTextBox.Location = new Point(12, 93);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.ReadOnly = true;
            ageTextBox.Size = new Size(100, 23);
            ageTextBox.TabIndex = 3;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(200, 96);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(48, 15);
            ageLabel.TabIndex = 4;
            ageLabel.Text = "سن شما";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(173, 137);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "خروج";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // AgeCalculation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 170);
            Controls.Add(exitButton);
            Controls.Add(ageLabel);
            Controls.Add(ageTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(birthTextBox);
            Controls.Add(LableBirth);
            Controls.Add(calculationButton);
            Controls.Add(resetButton);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(260, 170);
            MinimumSize = new Size(260, 170);
            Name = "AgeCalculation";
            Text = "AgeCalculation";
            Load += AgeCalculation_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button resetButton;
        private Button calculationButton;
        private Label LableBirth;
        private TextBox birthTextBox;
        private DateTimePicker dateTimePicker1;
        private TextBox ageTextBox;
        private Label ageLabel;
        private Button exitButton;
    }
}