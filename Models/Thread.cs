using System;
using System.Collections;
using System.Collections.Generic;

namespace RpForum.Models
{
    public class Thread : IDomainEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime CreateDate { get; set; }

        public HashSet<Post> Posts { get; set; }

        public Board Board { get; set; }
    }
}