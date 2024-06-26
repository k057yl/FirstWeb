namespace FirstWeb.Models.Entity;

public class Group
{
    public int GroupId { get; set; }
    public string GroupName { get; set; }

    public ICollection<GroupMember> GroupMembers { get; set; }
    public ICollection<GroupSong> GroupSongs { get; set; }
}
