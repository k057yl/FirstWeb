namespace FirstWeb.Models;

public class Pet
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string Species { get; set; }
    
    public virtual ICollection<Food> Foods { get; set; }
}