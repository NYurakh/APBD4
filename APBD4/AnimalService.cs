namespace APBD4;

public class AnimalService
{
    private List<Animal> _animals = new List<Animal>();

    public IEnumerable<Animal> GetAllAnimals() => _animals;

    public Animal GetAnimalById(int id) => _animals.FirstOrDefault(a => a.Id == id);

    public void AddAnimal(Animal animal) => _animals.Add(animal);

    public void UpdateAnimal(int id, Animal animal)
    {
        var existingAnimal = _animals.FirstOrDefault(a => a.Id == id);
        if (existingAnimal == null) return;
        existingAnimal.Name = animal.Name;
        existingAnimal.Category = animal.Category;
        existingAnimal.Weight = animal.Weight;
        existingAnimal.FurColor = animal.FurColor;
    }

    public void DeleteAnimal(int id) => _animals.RemoveAll(a => a.Id == id);
}