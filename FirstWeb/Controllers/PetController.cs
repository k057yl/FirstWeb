using FirstWeb.Data;
using FirstWeb.Models.DTO;
using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers;

public class PetController : Controller
{
    private readonly AppDbContext _context;
    
    public PetController(AppDbContext context)
    {
        _context = context;
    }
    
    public IActionResult PetPrint(string species, string foodName)
    {
        var pets = _context.Pets
            .Select(p => new PetViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Age = p.Age,
                Species = p.Species,
                Foods = p.Foods.Select(f => new FoodViewModel
                {
                    Id = f.Id,
                    Name = f.Name,
                }).ToList()
            });
        
        if (!string.IsNullOrEmpty(species))
        {
            pets = pets.Where(p => p.Species == species);
        }
        
        if (!string.IsNullOrEmpty(foodName))
        {
            pets = pets.Where(p => p.Foods.Any(f => f.Name == foodName));
        }

        return View(pets.ToList());
    }
    
    /*
    public IActionResult PetPrint(string species, string foodName)
    {
        var pets = _context.Pets
            .Select(p => new PetViewModel
            {
                Id = p.Id,
                Name = p.Name,
                Age = p.Age,
                Species = p.Species,
                Foods = p.Foods.Select(f => new FoodViewModel
                {
                    Id = f.Id,
                    Name = f.Name
                }).ToList()
            });

        if (!string.IsNullOrEmpty(species))
        {
            pets = pets.Where(p => p.Species == species);
        }

        if (!string.IsNullOrEmpty(foodName))
        {
            pets = pets.Where(p => p.Foods.Any(f => f.Name == foodName));
        }

        return View(pets.ToList());
    }
    */
}