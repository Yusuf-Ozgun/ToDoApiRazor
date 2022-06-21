using EenVoudigeToDoApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ToDoApiRazor.Data;

namespace ToDoApiRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _ctx;
        public IEnumerable<Board> Boards { get; set; }
        public IndexModel(DataContext ctx)
        {
            _ctx = ctx;

        }
        public void OnGet()
        {
            Boards = _ctx.Boards.Include(b => b.ToDos).ToList();
        }
    }
}