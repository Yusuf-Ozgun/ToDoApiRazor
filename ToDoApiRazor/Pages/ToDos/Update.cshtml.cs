using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApiRazor.Data;

namespace ToDoApiRazor.Pages.ToDos
{
    public class UpdateModel : PageModel
    {
        DataContext _ctx;
        public UpdateModel(DataContext ctx)
        {
            _ctx = ctx;
        }

        [BindProperty]
        public ToDos ToDos { get; set; }

        public void OnGet(int? id)
        {
            if (id != null)
            {
                var data = (from todo in _ctx.ToDos
                            where todo.Id == id
                            select todo).SingleOrDefault();
                ToDos = data;
            }
        }
    }
}
