using Domain.Common;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
#nullable disable

namespace Domain.Entities
{
    public class BookListing : BaseEntity
    {
        public ListingType ListingType { get; set; }
        public decimal? Price { get; set; }

        // Foreign Keys (become database columns)
        public int OwnerId { get; set; }   // stores User's Id
        public int BookId { get; set; }    // stores Book's Id

        public User Owner { get; set; }

        public Book Book { get; set; }

        public ICollection<SwapRequest> SwapRequests { get; set; }
    }
}
