﻿using Microsoft.AspNetCore.Http;

namespace EenVoudigeToDoApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BoardId { get; set; }


        //public User(int id, string name)
        //{
        //    Id = id;
        //    Name = name;
        //    ToDos = new List<ToDo>();
        //    Boards = new List<Board>();

        //}
        //public User(int id, string name, List<ToDo> _todos, List<Board> _boards)
        //{
        //    Id=id;
        //    Name = name;
        //    ToDos = _todos;
        //    Boards = _boards;
        //}
    }
}