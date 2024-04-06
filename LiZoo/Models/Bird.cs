namespace LiZoo.Models
{
    public class Bird : Animal
    {
        public Bird(string name, int age, decimal weight, FoodTypeEnum foodType,decimal wingspanMM) : base(name, age, weight, foodType)
        {
            WingspanMM = wingspanMM;
        }

        private decimal _wingspanMM;
        public decimal WingspanMM 
        { 
            get => _wingspanMM; 
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Размах крыльев не может быть меньше или равен 0");

                _wingspanMM = value;
            }
        }
    }
}
