namespace LiZoo
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void animalsButton_Click(object sender, EventArgs e)
        {
            AnimalsForm animalsForm = new();
            animalsForm.ShowDialog();
        }

        private void cagesButton_Click(object sender, EventArgs e)
        {
            CagesForm cagesForm = new();
            cagesForm.ShowDialog();
        }
    }
}
