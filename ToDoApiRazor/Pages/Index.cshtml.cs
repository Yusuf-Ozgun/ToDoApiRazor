using EenVoudigeToDoApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using ToDoApiRazor.Data;

namespace ToDoApiRazor.Pages
{
    public class IndexModel : PageModel
    {
        private readonly DataContext _ctx;
        public IEnumerable<Board> Boards { get; set; }
        public void OnGet()
        {

        }
    }
}