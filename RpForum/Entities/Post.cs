using System;

namespace RpForum.Entities
{
    public class Post : IDomainEntity
    {
        public int Id { get; set; }
        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public Thread Thread { get; set; }
    }
}