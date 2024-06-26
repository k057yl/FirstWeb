using FirstWeb.Data;
using FirstWeb.Models.DTO;
using FirstWeb.Models.Entity;

public class GroupService
{
    private readonly AppDbContext _context;

    public GroupService(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<GroupDTO> GetAllGroups()
    {
        return _context.Groups
            .Select(group => new GroupDTO
            {
                GroupId = group.GroupId,
                GroupName = group.GroupName,
            })
            .ToList();
    }

    public GroupDTO GetGroupById(int id)
    {
        var group = _context.Groups.Find(id);
        if (group == null) return null;

        return new GroupDTO
        {
            GroupId = group.GroupId,
            GroupName = group.GroupName,
        };
    }

    public GroupDTO SaveGroup(GroupDTO groupDTO)
    {
        var group = new Group
        {
            GroupId = groupDTO.GroupId,
            GroupName = groupDTO.GroupName,
        };

        _context.Groups.Add(group);
        _context.SaveChanges();

        groupDTO.GroupId = group.GroupId;

        return groupDTO;
    }
}