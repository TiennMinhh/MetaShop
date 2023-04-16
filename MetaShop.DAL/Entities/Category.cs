﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public int? ParentId { get; set; }
        public string? Description { get; set; }
        public string? Image { get; set; }
        public bool Status { get; set; }
        public DateTime? DeletedDate { get; set; }
    }
}
