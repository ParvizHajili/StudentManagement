﻿using Core.Entities.Abstract;
using Core.Entities.Concrete;

namespace Entities.Concrete
{
    public class Question : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Hit { get; set; }
        public int Likes { get; set; }
        public string PhotoUrl { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
