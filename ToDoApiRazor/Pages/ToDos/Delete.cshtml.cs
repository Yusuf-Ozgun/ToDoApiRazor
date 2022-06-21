using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApiRazor.Data;

namespace ToDoApiRazor.Pages.ToDos
{
    public class DeleteModel : PageModel
    {
        private readonly DataContext _ctx;

        public ActionResult OnGetDelete(int? id)
        {
            if (id != null)
            {
                var data = (from todo in _ctx.ToDos
                            where todo.Id == id
                            select todo).SingleOrDefault();

                _ctx.Remove(data);
                _ctx.SaveChanges();
            }
            return RedirectToPage("../Index");
        }
    }
}
