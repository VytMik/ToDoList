using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class TodoItem
    {
        public int TodoItemId { get; set; }
        public string Title { get; set; }
        public bool IsComplete { get; set; }

        public Record Record { get; set; }
    }
}
