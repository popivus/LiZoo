namespace LiZoo
{
    partial class MenuForm
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
            animalsButton = new Button();
            cagesButton = new Button();
            SuspendLayout();
            // 
            // animalsButton
            // 
            animalsButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            animalsButton.Location = new Point(12, 12);
            animalsButton.Name = "animalsButton";
            animalsButton.Size = new Size(357, 23);
            animalsButton.TabIndex = 0;
            animalsButton.Text = "Животные";
            animalsButton.UseVisualStyleBackColor = true;
            animalsButton.Click += animalsButton_Click;
            // 
            // cagesButton
            // 
            cagesButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cagesButton.Location = new Point(12, 41);
            cagesButton.Name = "cagesButton";
            cagesButton.Size = new Size(357, 23);
            cagesButton.TabIndex = 1;
            cagesButton.Text = "Клетки";
            cagesButton.UseVisualStyleBackColor = true;
            cagesButton.Click += cagesButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 82);
            Controls.Add(cagesButton);
            Controls.Add(animalsButton);
            MinimumSize = new Size(397, 121);
            Name = "MenuForm";
            Text = "Меню";
            ResumeLayout(false);
        }

        #endregion

        private Button animalsButton;
        private Button cagesButton;
    }
}