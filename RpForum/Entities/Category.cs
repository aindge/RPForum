using System.Collections.Generic;

namespace RpForum.Entities
{
    public class Category : IDomainEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public HashSet<Board> Boards { get; set; }
    }
}