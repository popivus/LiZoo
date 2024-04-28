using LiZoo.Models;

namespace LiZoo
{
    public partial class CagesForm : Form
    {
        public Cage? SelectedCage => cagesGridView.SelectedRows[0]?.DataBoundItem as Cage;

        public CagesForm()
        {
            InitializeComponent();

            cagesGridView.DataSource = Database.Cages;

            cagesGridView.Columns[0].HeaderText = "Код";
            cagesGridView.Columns[1].HeaderText = "Макс. животных";
            cagesGridView.Columns[2].HeaderText = "Животные";
        }

        private void addCageButton_Click(object sender, EventArgs e)
        {
            Cage newCage = new(Database.Cages.Count + 1, Convert.ToInt32(maxCountUpDown.Value));
            Database.Cages.Add(newCage);

            cagesGridView.DataSource = new List<Cage>(Database.Cages);
        }

        private void deleteCageButton_Click(object sender, EventArgs e)
        {
            if (SelectedCage is null)
                return;

            Database.Cages.Remove(SelectedCage);
            cagesGridView.DataSource = new List<Cage>(Database.Cages);
        }

        private void addAnimalButton_Click(object sender, EventArgs e)
        {
            if (SelectedCage is null)
                return;

            AnimalsForm animalsForm = new(isForSelect: true);

            if (animalsForm.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                SelectedCage.PutAnimal(animalsForm.SelectedAnimal!);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание");
            }

            cagesGridView.DataSource = new List<Cage>(Database.Cages);
        }

        private void clearCage_Click(object sender, EventArgs e)
        {
            if (SelectedCage is null)
                return;

            SelectedCage.ClearCage();
            cagesGridView.DataSource = new List<Cage>(Database.Cages);
        }
    }
}
