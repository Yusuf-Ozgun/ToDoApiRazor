using ToDoApiRazor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApiRazor.Data;

namespace ToDoApiRazor.Pages.ToDos
{
    public class CreateModel : PageModel
    {
        private readonly DataContext _ctx;
        public CreateModel(DataContext ctx)
        {
            _ctx = ctx;
        }
        
        public async Task<IActionResult> OnPost()
        {
            ToDo.Creatie = DateTime.Now;
            await _ctx.ToDos.AddAsync(ToDo);
            //await _ctx.ToDos.SaveChangesAsync();
            return RedirectToPage("../Index");
        }
        [BindProperty]
        public ToDo ToDo { get; set; }


    }
}
