namespace FirstWeb.Models.Entity;
public class GroupSong
{
    public int GroupId { get; set; }
    public Group Group { get; set; }

    public int SongId { get; set; }
    public Song Song { get; set; }
}