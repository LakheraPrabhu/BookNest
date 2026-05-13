using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
#nullable disable

namespace Domain.Entities
{
    public class SwapRequest : BaseEntity
    {
        // Foreign Keys
        public int RequesterId { get; set; }
        public int BookListingId { get; set; }

        // ↓ Navigation Properties
        public User Requester { get; set; }
        // Meaning: "This request was made by ONE User"

        public BookListing BookListing { get; set; }
        // Meaning: "This request is for ONE BookListing"
    }
}
