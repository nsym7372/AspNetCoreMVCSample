using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuickMaster.ViewComponents
{
    using Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    public class ListVIewComponent : ViewComponent
    {
        private readonly MyContext _db;

        public ListVIewComponent(MyContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int price)
        {
            return View(await _db.Books.Where(r => r.Price >= price).ToListAsync());
        }
    }
}
