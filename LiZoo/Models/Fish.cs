namespace LiZoo.Models
{
    public class Fish : Animal
    {
        public Fish(string name, int age, decimal weight, FoodTypeEnum foodType, bool isFreshwater) : base(name, age, weight, foodType)
        {
            IsFreshwater = isFreshwater;
        }

        public bool IsFreshwater { get; set; }
    }
}
