using LiZoo.Models;

namespace LiZoo
{
    public partial class AnimalEditForm : Form
    {
        public Animal Animal { get; set; }

        public AnimalEditForm(Animal animal)
        {
            InitializeComponent();
            InitializeCatTypes();

            animalTypeComboBox.Enabled = false;

            nameTextBox.Text = animal.Name;
            ageUpDown.Value = animal.Age;
            weightUpDown.Value = animal.Weight;
            foodTypeComboBox.SelectedIndex = (int)animal.FoodType;

            if (animal is Bird bird)
            {
                animalTypeComboBox.SelectedIndex = 0;
                wingspanUpDown.Value = bird.WingspanMM;
            }
            if (animal is Cat cat)
            {
                animalTypeComboBox.SelectedIndex = 1;
                catTypeComboBox.SelectedValue = cat.CatType.Id;
            }
            if (animal is Fish fish)
            {
                animalTypeComboBox.SelectedIndex = 2;
                isFreshwaterCheckBox.Checked = fish.IsFreshwater;
            }
        }

        public AnimalEditForm()
        {
            InitializeComponent();
            InitializeCatTypes();
            animalTypeComboBox.SelectedIndex = 0;
        }

        private void InitializeCatTypes()
        {
            List<CatType> catTypes = new List<CatType>()
            {
                new CatType() { Id = 1, Name = "Домашний кот"},
                new CatType() { Id = 2, Name = "Тигр"},
                new CatType() { Id = 3, Name = "Лев"}
            };
            catTypeComboBox.DataSource = catTypes;
            catTypeComboBox.DisplayMember = "Name";
            catTypeComboBox.ValueMember = "Id";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void animalTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            wingspanLabel.Visible = false;
            wingspanLabel1.Visible = false;
            wingspanUpDown.Visible = false;
            wingspanUpDown.Value = wingspanUpDown.Minimum;

            catTypeLabel.Visible = false;
            catTypeComboBox.Visible = false;
            catTypeComboBox.SelectedItem = null;

            isFreshwaterCheckBox.Visible = false;
            isFreshwaterCheckBox.Checked = false;

            switch (animalTypeComboBox.SelectedIndex)
            {
                case 0:
                    wingspanLabel.Visible = true;
                    wingspanLabel1.Visible = true;
                    wingspanUpDown.Visible = true;
                    break;
                case 1:
                    catTypeLabel.Visible = true;
                    catTypeComboBox.Visible = true;
                    break;
                case 2:
                    isFreshwaterCheckBox.Visible = true;
                    break;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (animalTypeComboBox.SelectedItem is null || 
                string.IsNullOrWhiteSpace(nameTextBox.Text) || 
                foodTypeComboBox.SelectedItem is null  ||
                (animalTypeComboBox.SelectedIndex == 1 && catTypeComboBox.SelectedItem is null))
            {
                MessageBox.Show("Заполните все поля");
                return;
            }

            FoodTypeEnum currentFoodType;
            switch (foodTypeComboBox.SelectedIndex)
            {
                case 0: currentFoodType = FoodTypeEnum.Predator; break;
                case 1: currentFoodType = FoodTypeEnum.Herbivore; break;
                case 2: currentFoodType = FoodTypeEnum.Omnivore; break;
                default: currentFoodType = FoodTypeEnum.Omnivore; break;
            }

            switch (animalTypeComboBox.SelectedIndex)
            {
                case 0:
                    Animal = new Bird(nameTextBox.Text, Convert.ToInt32(ageUpDown.Value), weightUpDown.Value, currentFoodType, wingspanUpDown.Value);
                    break;
                case 1:
                    Animal = new Cat(nameTextBox.Text, Convert.ToInt32(ageUpDown.Value), weightUpDown.Value, currentFoodType, (CatType)catTypeComboBox.SelectedItem);
                    break;
                case 2:
                    Animal = new Fish(nameTextBox.Text, Convert.ToInt32(ageUpDown.Value), weightUpDown.Value, currentFoodType, isFreshwaterCheckBox.Checked);
                    break;
            }

            DialogResult = DialogResult.OK;
        }
    }
}
