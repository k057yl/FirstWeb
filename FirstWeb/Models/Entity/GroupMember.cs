namespace FirstWeb.Models.Entity;
public class GroupMember
{
    public int GroupId { get; set; }
    public Group Group { get; set; }

    public int MemberId { get; set; }
    public Member Member { get; set; }
}