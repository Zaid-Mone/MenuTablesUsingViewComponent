using MenuTables.Data;
using Microsoft.AspNetCore.Mvc;

namespace MenuTables.Components
{
    public class TableMenu:ViewComponent
    {
        private readonly DataDbContext _context;

        public TableMenu(DataDbContext context)
        {
            _context = context;
        }


        public IViewComponentResult Invoke()
        {
            var menus = _context.TblMenus
                .Where(q=>q.IsDeleted==false)
                .ToList();
            return View(menus);
        }
    }
}
