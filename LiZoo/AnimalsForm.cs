using LiZoo.Models;

namespace LiZoo
{
    public partial class AnimalsForm : Form
    {
        public AnimalsForm(bool isForSelect = false)
        {
            InitializeComponent();

            animalsGridView.DataSource = Database.Animals;

            animalsGridView.Columns[3].Visible = false;
            animalsGridView.Columns[6].Visible = false;

            animalsGridView.Columns[0].HeaderText = "Имя";
            animalsGridView.Columns[1].HeaderText = "Возраст";
            animalsGridView.Columns[2].HeaderText = "Вес";
            animalsGridView.Columns[4].HeaderText = "Пищевое поведение";
            animalsGridView.Columns[5].HeaderText = "Вид";

            if (isForSelect)
            {
                createButton.Visible = false;
                editButton.Visible = false;
                deleteButton.Visible = false;

                animalsGridView.DataSource = new List<Animal>(Database.Animals.Where(a => !a.IsInCage).ToList());
            }
            else
            {
                cancelButton.Visible = false;
                pickButton.Visible = false;
            }    
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AnimalEditForm animalEditForm = new();
            if (animalEditForm.ShowDialog() != DialogResult.OK)
                return;

            Database.Animals.Add(animalEditForm.Animal);

            animalsGridView.DataSource = new List<Animal>(Database.Animals);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (SelectedAnimal is null)
                return;

            Database.Animals.Remove(SelectedAnimal);

            animalsGridView.DataSource = new List<Animal>(Database.Animals);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (SelectedAnimal is null)
                return;

            Animal animalToEdit = SelectedAnimal;
            AnimalEditForm animalEditForm = new(animalToEdit);
            if (animalEditForm.ShowDialog() != DialogResult.OK)
                return;

            Animal editedAnimal = animalEditForm.Animal;
            animalToEdit.Name = editedAnimal.Name;
            animalToEdit.Weight = editedAnimal.Weight;
            animalToEdit.Age = editedAnimal.Age;
            animalToEdit.FoodType = editedAnimal.FoodType;

            if (animalToEdit is Bird bird)
                bird.WingspanMM = ((Bird)editedAnimal).WingspanMM;
            if (animalToEdit is Cat cat)
                cat.CatType = ((Cat)editedAnimal).CatType;
            if (animalToEdit is Fish fish)
                fish.IsFreshwater = ((Fish)editedAnimal).IsFreshwater;

            animalsGridView.DataSource = new List<Animal>(Database.Animals);
        }

        public Animal? SelectedAnimal => animalsGridView.SelectedRows[0]?.DataBoundItem as Animal;

        private void pickButton_Click(object sender, EventArgs e)
        {
            if (SelectedAnimal is null)
                return;

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
