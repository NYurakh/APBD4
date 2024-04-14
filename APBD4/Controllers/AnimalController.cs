using APBD4.Models;
using APBD4.Services;
using Microsoft.AspNetCore.Mvc;

namespace APBD4.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AnimalController : ControllerBase
{
    private readonly AnimalService _animalService;

    public AnimalController(AnimalService animalService)
    {
        _animalService = animalService;
    }

    [HttpGet]
    public IEnumerable<Animal> GetAllAnimals() => _animalService.GetAllAnimals();

    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal = _animalService.GetAnimalById(id);
        if (animal == null)
            return NotFound();

        return Ok(animal);
    }

    [HttpPost]
    public IActionResult AddAnimal(Animal animal)
    {
        _animalService.AddAnimal(animal);
        return CreatedAtAction(nameof(GetAnimalById), new { id = animal.Id }, animal);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal animal)
    {
        _animalService.UpdateAnimal(id, animal);
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        _animalService.DeleteAnimal(id);
        return NoContent();
    }
}