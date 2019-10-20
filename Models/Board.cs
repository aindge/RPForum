using System.Collections.Generic;

namespace RpForum.Models
{
    public class Board
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public HashSet<Thread> Threads { get; set; }

        public Category Category { get; set; }
    }
}