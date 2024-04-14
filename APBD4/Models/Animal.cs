namespace APBD4.Models;

public class Animal
{
    private static int _nextId = 1;

    public int Id { get; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string FurColor { get; set; }

    public Animal()
    {
        Id = _nextId++;
    }
}