using Microsoft.AspNetCore.Http;
using ToDoApiRazor.Models;

namespace EenVoudigeToDoApi.Models
{
    public class ToDo
    {
        public int Id { get; set; }
        public string Titel { get; set; }
        public DateTime Creatie { get; set; }
        public DateTime LaatsteAanpassing { get; set; }
        public DateTime VervalDatum { get; set; }
        public int BoardId { get; set; }
        public ToDoEnum ToDoEnum { get; set; }

        //#region Ctor
        //public ToDo(int id, string titel, DateTime creatie, DateTime laatsteAanpassing, DateTime vervalDatum)
        //{
        //    Id = id;
        //    Titel = titel;
        //    Creatie = creatie;
        //    LaatsteAanpassing = laatsteAanpassing;
        //    VervalDatum = vervalDatum;
        //}
        //#endregion
    }
}
