namespace FirstWeb.Models;

public class Band
{
    public int Id { get; set; }
    public string BandName { get; set; }
    public int Year { get; set; }
    
    public List<Song> Songs { get; set; }
}