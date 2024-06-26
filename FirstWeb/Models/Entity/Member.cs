namespace FirstWeb.Models.Entity;
public class Member
{
    public int MemberId { get; set; }
    public string MemberName { get; set; }
    public string Instrument { get; set; }

    public ICollection<GroupMember> GroupMembers { get; set; }
}