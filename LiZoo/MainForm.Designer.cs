namespace LiZoo
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
            animalsGridView = new DataGridView();
            createButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            ((System.ComponentModel.ISupportInitialize)animalsGridView).BeginInit();
            SuspendLayout();
            // 
            // animalsGridView
            // 
            animalsGridView.AllowUserToAddRows = false;
            animalsGridView.AllowUserToDeleteRows = false;
            animalsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            animalsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            animalsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            animalsGridView.Location = new Point(12, 12);
            animalsGridView.MultiSelect = false;
            animalsGridView.Name = "animalsGridView";
            animalsGridView.ReadOnly = true;
            animalsGridView.RowHeadersVisible = false;
            animalsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            animalsGridView.Size = new Size(776, 390);
            animalsGridView.TabIndex = 0;
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            createButton.Location = new Point(12, 415);
            createButton.Name = "createButton";
            createButton.Size = new Size(75, 23);
            createButton.TabIndex = 1;
            createButton.Text = "Создать";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += createButton_Click;
            // 
            // editButton
            // 
            editButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            editButton.Location = new Point(93, 415);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 2;
            editButton.Text = "Изменить";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            deleteButton.Location = new Point(174, 415);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(createButton);
            Controls.Add(animalsGridView);
            Name = "Form1";
            Text = "Все животные";
            ((System.ComponentModel.ISupportInitialize)animalsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView animalsGridView;
        private Button createButton;
        private Button editButton;
        private Button deleteButton;
    }
}
