using LiZoo.Models;

namespace LiZoo
{
    public partial class Form1 : Form
    {
        public List<Animal> Animals { get; set; }

        public Form1()
        {
            InitializeComponent();

            Animals = [];
            animalsGridView.DataSource = Animals;

            animalsGridView.Columns[3].Visible = false;

            animalsGridView.Columns[0].HeaderText = "Имя";
            animalsGridView.Columns[1].HeaderText = "Возраст";
            animalsGridView.Columns[2].HeaderText = "Вес";
            animalsGridView.Columns[4].HeaderText = "Пищевое поведение";
            animalsGridView.Columns[5].HeaderText = "Вид";
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            AnimalEditForm animalEditForm = new();
            if (animalEditForm.ShowDialog() != DialogResult.OK)
                return;

            Animals.Add(animalEditForm.Animal);

            animalsGridView.DataSource = new List<Animal>(Animals);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (animalsGridView.SelectedRows.Count == 0)
                return;

            Animal animalToDelete = (Animal)animalsGridView.SelectedRows[0].DataBoundItem;
            Animals.Remove(animalToDelete);

            animalsGridView.DataSource = new List<Animal>(Animals); ;
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (animalsGridView.SelectedRows.Count == 0)
                return;

            Animal animalToEdit = (Animal)animalsGridView.SelectedRows[0].DataBoundItem;
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

            animalsGridView.DataSource = new List<Animal>(Animals); ;
        }
    }
}
