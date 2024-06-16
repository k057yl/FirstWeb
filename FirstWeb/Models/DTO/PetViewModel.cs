namespace FirstWeb.Models.DTO;

public class PetViewModel
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    
    public List<FoodViewModel> Foods { get; set; } = new List<FoodViewModel>();
}