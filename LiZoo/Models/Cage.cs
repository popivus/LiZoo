namespace LiZoo.Models
{
    public class Cage
    {
        public Cage(int id, int maxCountAnimals)
        {
            Id = id;
            if (maxCountAnimals < 1 || maxCountAnimals > 50)
                throw new Exception("Некорректное максимальное количество животных в клетке (норма: от 1 до 50)");

            MaxCountAnimals = maxCountAnimals;
            _animals = [];
        }

        public int Id { get; }

        public int MaxCountAnimals { get; }

        private readonly List<Animal> _animals;

        public void PutAnimal(Animal animal)
        {
            if (animal.IsInCage)
                throw new Exception("Это животное уже находится в клетке");

            if (_animals.Count >= MaxCountAnimals)
                throw new Exception("Клетка уже заполнена");

            if (_animals.Count != 0 && animal.GetType() != _animals.FirstOrDefault()!.GetType())
                throw new Exception("В клетке могут быть животные только одного вида");

            animal.IsInCage = true;
            _animals.Add(animal);
        }

        public void RemoveAnimal(Animal existingAnimal)
        {
            if (!_animals.Contains(existingAnimal))
                throw new Exception("В клетке нет такого животного");

            existingAnimal.IsInCage = false;
            _animals.Remove(existingAnimal);
        }

        public void ClearCage()
        {
            _animals.ForEach(a => a.IsInCage = false);
            _animals.Clear();
        }

        public IEnumerable<Animal> GetAnimals() => _animals;

        public string AnimalsInCageString => _animals.Any() ? string.Join(", ", _animals.Select(a => a.Name)) : "Нет животных";
    }
}
