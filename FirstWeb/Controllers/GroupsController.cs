using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FirstWeb.Data;
using Microsoft.AspNetCore.Mvc.Rendering;

public class GroupsController : Controller
{
    private readonly AppDbContext _context;

    public GroupsController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index(int? groupId)
    {
        var groups = await _context.Groups
            .Include(g => g.GroupMembers)
            .ThenInclude(gm => gm.Member)
            .Include(g => g.GroupSongs)
            .ThenInclude(gs => gs.Song)
            .ToListAsync();

        if (groupId.HasValue)
        {
            groups = groups.Where(g => g.GroupId == groupId.Value).ToList();
            ViewData["SelectedGroupId"] = groupId.Value;
        }
        else
        {
            ViewData["SelectedGroupId"] = null;
        }

        ViewData["Groups"] = new SelectList(await _context.Groups.ToListAsync(), "GroupId", "GroupName");
        return View(groups);
    }
}