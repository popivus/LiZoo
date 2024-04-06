namespace LiZoo.Models
{
    public class Cat : Animal
    {
        public Cat(string name, int age, decimal weight, FoodTypeEnum foodType, CatType catType) : base(name, age, weight, foodType)
        {
            CatType = catType;
        }

        public CatType CatType { get; set; }
    }
}
