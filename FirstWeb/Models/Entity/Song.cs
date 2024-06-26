namespace FirstWeb.Models.Entity;
public class Song
{
    public int SongId { get; set; }
    public string SongName { get; set; }

    public ICollection<GroupSong> GroupSongs { get; set; }
}