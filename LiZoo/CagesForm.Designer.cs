namespace LiZoo
{
    partial class CagesForm
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
            addCageButton = new Button();
            deleteCageButton = new Button();
            addAnimalButton = new Button();
            clearCage = new Button();
            label1 = new Label();
            maxCountUpDown = new NumericUpDown();
            cagesGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)maxCountUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cagesGridView).BeginInit();
            SuspendLayout();
            // 
            // addCageButton
            // 
            addCageButton.Location = new Point(12, 51);
            addCageButton.Name = "addCageButton";
            addCageButton.Size = new Size(147, 23);
            addCageButton.TabIndex = 1;
            addCageButton.Text = "Создать клетку";
            addCageButton.UseVisualStyleBackColor = true;
            addCageButton.Click += addCageButton_Click;
            // 
            // deleteCageButton
            // 
            deleteCageButton.Location = new Point(12, 91);
            deleteCageButton.Name = "deleteCageButton";
            deleteCageButton.Size = new Size(147, 23);
            deleteCageButton.TabIndex = 2;
            deleteCageButton.Text = "Удалить клетку";
            deleteCageButton.UseVisualStyleBackColor = true;
            deleteCageButton.Click += deleteCageButton_Click;
            // 
            // addAnimalButton
            // 
            addAnimalButton.Location = new Point(12, 150);
            addAnimalButton.Name = "addAnimalButton";
            addAnimalButton.Size = new Size(147, 39);
            addAnimalButton.TabIndex = 3;
            addAnimalButton.Text = "Добавить животное в клетку";
            addAnimalButton.UseVisualStyleBackColor = true;
            addAnimalButton.Click += addAnimalButton_Click;
            // 
            // clearCage
            // 
            clearCage.Location = new Point(12, 195);
            clearCage.Name = "clearCage";
            clearCage.Size = new Size(147, 23);
            clearCage.TabIndex = 4;
            clearCage.Text = "Очистить клетку";
            clearCage.UseVisualStyleBackColor = true;
            clearCage.Click += clearCage_Click;
            // 
            // label1
            // 
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(100, 36);
            label1.TabIndex = 5;
            label1.Text = "Макс. кол-во в клетке:";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // maxCountUpDown
            // 
            maxCountUpDown.Location = new Point(118, 21);
            maxCountUpDown.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            maxCountUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            maxCountUpDown.Name = "maxCountUpDown";
            maxCountUpDown.Size = new Size(41, 23);
            maxCountUpDown.TabIndex = 6;
            maxCountUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cagesGridView
            // 
            cagesGridView.AllowUserToAddRows = false;
            cagesGridView.AllowUserToDeleteRows = false;
            cagesGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cagesGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cagesGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cagesGridView.Location = new Point(165, 12);
            cagesGridView.MultiSelect = false;
            cagesGridView.Name = "cagesGridView";
            cagesGridView.ReadOnly = true;
            cagesGridView.RowHeadersVisible = false;
            cagesGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            cagesGridView.Size = new Size(344, 383);
            cagesGridView.TabIndex = 7;
            // 
            // CagesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 407);
            Controls.Add(cagesGridView);
            Controls.Add(maxCountUpDown);
            Controls.Add(label1);
            Controls.Add(clearCage);
            Controls.Add(addAnimalButton);
            Controls.Add(deleteCageButton);
            Controls.Add(addCageButton);
            Name = "CagesForm";
            Text = "Клетки";
            ((System.ComponentModel.ISupportInitialize)maxCountUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)cagesGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button addCageButton;
        private Button deleteCageButton;
        private Button addAnimalButton;
        private Button clearCage;
        private Label label1;
        private NumericUpDown maxCountUpDown;
        private DataGridView cagesGridView;
    }
}