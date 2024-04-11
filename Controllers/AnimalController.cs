using Microsoft.AspNetCore.Mvc;

namespace REST_API1.Controllers;


[Route("api/animals")]
[ApiController]
public class AnimalController : ControllerBase
{

    private static readonly List<Animal> _animals = new()
    {
        new Animal(1, "Marek", "Kot", 1500, "czarny"),
        new Animal(2, "Czarek", "Pies", 5000, "szary"),
        new Animal(3, "Michal", "Kot", 2100, "bialy"),
        new Animal(4, "Pawel", "Pies", 4500, "brazowy"),
        new Animal(5, "Daniel", "Malpa", 1500, "brozowy"),
        
    };
    
    

    [HttpGet]
    public IActionResult getAnimals()
    {
        return Ok(_animals);
    }

    [HttpGet("{id:int}")]
    public IActionResult getAnimal(int id)
    {
        var animal = _animals.FirstOrDefault(an => an.id == id);
        if (animal == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        return Ok(animal);
    }


    [HttpPost]
    public IActionResult createAnimal(Animal animal)
    {
        _animals.Add(animal);
        return StatusCode(StatusCodes.Status201Created);
    }


    [HttpPut("{id:int}")]
    public IActionResult updateAnimal(int id, Animal animal)
    {
        var animalToEdit = _animals.FirstOrDefault(an => an.id == id);
        if (animalToEdit == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }
        _animals.Remove(animalToEdit);
        _animals.Add(animal);
        return NoContent();
    }


    [HttpDelete("{id:int}")]
    public IActionResult deleteAnimal(int id)
    {
        var toDelete = _animals.FirstOrDefault(an => an.id == id);
        if (toDelete == null)
        {
            return NotFound($"Animal with id {id} was not found");
        }

        _animals.Remove(toDelete);
        
        return NoContent();
    }



}