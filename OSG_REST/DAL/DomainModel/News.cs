﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DomainModel
{
    class News
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Picture { get; set; }
        public string Description { get; set; }
        public string Title { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
