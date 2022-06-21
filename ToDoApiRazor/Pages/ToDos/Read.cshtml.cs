using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ToDoApiRazor.Data;
using ToDoApiRazor.Models;


namespace ToDoApiRazor.Pages.ToDos
{
    public class ReadModel : PageModel
    {
        private readonly DataContext _context;

        public ReadModel(DataContext context) => _context = context;

        public async void OnGet(uint id) => ToDo = await _context.ToDos.FindAsync(id);

        public async void OnGetResolve(uint id)
        {
            var ToDoToUpdate = _context.ToDos.SingleOrDefault(i => i.Id == id);
            if (ToDoToUpdate == null) return;

            ToDoToUpdate.LaatsteAanpassing = DateTime.Now;
            _context.Update(ToDoToUpdate);
            await _context.SaveChangesAsync();
        }

        public ToDo? ToDo { get; private set; }

    }
}
