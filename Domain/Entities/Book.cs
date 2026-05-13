using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Book : BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;
        public string? ISBN { get; set; }
        public string? Publisher { get; set; }
        public int? PublishedYear { get; set; }
        public string? Language { get; set; }
        public string? Description { get; set; }
        public BookCondition Condition { get; set; }

        // Navigation Property
        public BookListing? BookListing { get; set; }
    }
}
