using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TodoList.Models
{
    public class Record
    {
        public int RecordId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DeadLine { get; set; }

        public List<TodoItem> TodoItems { get; set; }

    }
}
