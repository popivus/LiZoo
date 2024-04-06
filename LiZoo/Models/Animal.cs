namespace LiZoo.Models
{
    public abstract class Animal
    {
        protected Animal(string name, int age, decimal weight, FoodTypeEnum foodType)
        {
            Name = name;
            Age = age;
            Weight = weight;
            FoodType = foodType;
        }

        public string Name { get; set; }

        private int _age;
        public int Age 
        { 
            get => _age;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Возраст не может быть меньше 0");

                _age = value;
            }
        }


        private decimal _weight;
        public decimal Weight 
        { 
            get => _weight;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Вес не может быть меньше или равен 0");

                _weight = value;
            } 
        }

        public FoodTypeEnum FoodType { get; set; }

        public string FoodTypeStr
        {
            get
            {
                switch (FoodType)
                {
                    case FoodTypeEnum.Predator:
                        return "Хищник";
                    case FoodTypeEnum.Herbivore:
                        return "Травоядное";
                    case FoodTypeEnum.Omnivore:
                        return "Всеядное";
                    default:
                        return "-";
                }    
            }
        }

        public string AnimalType
        {
            get
            {
                if (this is Bird)
                    return "Птица";
                if (this is Cat)
                    return "Кошачий";
                if (this is Fish)
                    return "Рыба";

                return "Неопознанный";
            }
        }
    }
}
