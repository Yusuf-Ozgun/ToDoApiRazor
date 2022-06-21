using Microsoft.AspNetCore.Http;
using System.Collections.Generic;

namespace EenVoudigeToDoApi.Models
{
    public class Board
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDo> ToDos { get; set; }

        public List<User> Users = new();

        //public Board(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //    ToDos = new List<ToDo>();
        //}
        //public Board(int id, string name, List<ToDo> _todos)
        //{
        //    Id=id;
        //    Name = name;
        //    ToDos = _todos;
        //}
    }
}