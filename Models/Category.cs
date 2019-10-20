using System.Collections.Generic;

namespace RpForum.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public HashSet<Board> Boards { get; set; }
    }
}