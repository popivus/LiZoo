namespace LiZoo
{
    partial class AnimalEditForm
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
            label1 = new Label();
            nameTextBox = new TextBox();
            ageUpDown = new NumericUpDown();
            weightUpDown = new NumericUpDown();
            foodTypeComboBox = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            animalTypeComboBox = new ComboBox();
            saveButton = new Button();
            cancelButton = new Button();
            wingspanUpDown = new NumericUpDown();
            wingspanLabel = new Label();
            wingspanLabel1 = new Label();
            catTypeComboBox = new ComboBox();
            catTypeLabel = new Label();
            isFreshwaterCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)ageUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)weightUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wingspanUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 72);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(85, 69);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(167, 23);
            nameTextBox.TabIndex = 1;
            // 
            // ageUpDown
            // 
            ageUpDown.Location = new Point(85, 98);
            ageUpDown.Name = "ageUpDown";
            ageUpDown.Size = new Size(167, 23);
            ageUpDown.TabIndex = 2;
            // 
            // weightUpDown
            // 
            weightUpDown.DecimalPlaces = 2;
            weightUpDown.Location = new Point(85, 127);
            weightUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            weightUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            weightUpDown.Name = "weightUpDown";
            weightUpDown.Size = new Size(167, 23);
            weightUpDown.TabIndex = 3;
            weightUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // foodTypeComboBox
            // 
            foodTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            foodTypeComboBox.FormattingEnabled = true;
            foodTypeComboBox.Items.AddRange(new object[] { "Плотоядное", "Травоядное", "Всеядное" });
            foodTypeComboBox.Location = new Point(85, 156);
            foodTypeComboBox.Name = "foodTypeComboBox";
            foodTypeComboBox.Size = new Size(167, 23);
            foodTypeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 100);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 5;
            label2.Text = "Возраст";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(254, 101);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 6;
            label3.Text = "лет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(254, 129);
            label4.Name = "label4";
            label4.Size = new Size(18, 15);
            label4.TabIndex = 7;
            label4.Text = "кг";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(53, 129);
            label5.Name = "label5";
            label5.Size = new Size(26, 15);
            label5.TabIndex = 8;
            label5.Text = "Вес";
            // 
            // animalTypeComboBox
            // 
            animalTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            animalTypeComboBox.FormattingEnabled = true;
            animalTypeComboBox.Items.AddRange(new object[] { "Птица", "Кошачье", "Рыба" });
            animalTypeComboBox.Location = new Point(85, 12);
            animalTypeComboBox.Name = "animalTypeComboBox";
            animalTypeComboBox.Size = new Size(167, 23);
            animalTypeComboBox.TabIndex = 9;
            animalTypeComboBox.SelectedIndexChanged += animalTypeComboBox_SelectedIndexChanged;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.Location = new Point(436, 220);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(170, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Сохранить";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.Location = new Point(234, 220);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(170, 23);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // wingspanUpDown
            // 
            wingspanUpDown.DecimalPlaces = 2;
            wingspanUpDown.Location = new Point(419, 69);
            wingspanUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            wingspanUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 131072 });
            wingspanUpDown.Name = "wingspanUpDown";
            wingspanUpDown.Size = new Size(167, 23);
            wingspanUpDown.TabIndex = 12;
            wingspanUpDown.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // wingspanLabel
            // 
            wingspanLabel.AutoSize = true;
            wingspanLabel.Location = new Point(317, 72);
            wingspanLabel.Name = "wingspanLabel";
            wingspanLabel.Size = new Size(96, 15);
            wingspanLabel.TabIndex = 13;
            wingspanLabel.Text = "Размах крыльев";
            // 
            // wingspanLabel1
            // 
            wingspanLabel1.AutoSize = true;
            wingspanLabel1.Location = new Point(588, 72);
            wingspanLabel1.Name = "wingspanLabel1";
            wingspanLabel1.Size = new Size(25, 15);
            wingspanLabel1.TabIndex = 14;
            wingspanLabel1.Text = "мм";
            // 
            // catTypeComboBox
            // 
            catTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            catTypeComboBox.FormattingEnabled = true;
            catTypeComboBox.Items.AddRange(new object[] { "Плотоядное", "Травоядное", "Всеядное" });
            catTypeComboBox.Location = new Point(419, 98);
            catTypeComboBox.Name = "catTypeComboBox";
            catTypeComboBox.Size = new Size(167, 23);
            catTypeComboBox.TabIndex = 15;
            // 
            // catTypeLabel
            // 
            catTypeLabel.AutoSize = true;
            catTypeLabel.Location = new Point(322, 101);
            catTypeLabel.Name = "catTypeLabel";
            catTypeLabel.Size = new Size(91, 15);
            catTypeLabel.TabIndex = 16;
            catTypeLabel.Text = "Тип кошачьего";
            // 
            // isFreshwaterCheckBox
            // 
            isFreshwaterCheckBox.AutoSize = true;
            isFreshwaterCheckBox.Location = new Point(322, 131);
            isFreshwaterCheckBox.Name = "isFreshwaterCheckBox";
            isFreshwaterCheckBox.Size = new Size(107, 19);
            isFreshwaterCheckBox.TabIndex = 17;
            isFreshwaterCheckBox.Text = "Пресноводное";
            isFreshwaterCheckBox.UseVisualStyleBackColor = true;
            // 
            // AnimalEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 255);
            Controls.Add(isFreshwaterCheckBox);
            Controls.Add(catTypeLabel);
            Controls.Add(catTypeComboBox);
            Controls.Add(wingspanLabel1);
            Controls.Add(wingspanLabel);
            Controls.Add(wingspanUpDown);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(animalTypeComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(foodTypeComboBox);
            Controls.Add(weightUpDown);
            Controls.Add(ageUpDown);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Name = "AnimalEditForm";
            Text = "Животное";
            ((System.ComponentModel.ISupportInitialize)ageUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)weightUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)wingspanUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameTextBox;
        private NumericUpDown ageUpDown;
        private NumericUpDown weightUpDown;
        private ComboBox foodTypeComboBox;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox animalTypeComboBox;
        private Button saveButton;
        private Button cancelButton;
        private NumericUpDown wingspanUpDown;
        private Label wingspanLabel;
        private Label wingspanLabel1;
        private ComboBox catTypeComboBox;
        private Label catTypeLabel;
        private CheckBox isFreshwaterCheckBox;
    }
}