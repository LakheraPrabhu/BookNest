using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;
#nullable disable

namespace Domain.Entities
{

//┌─────────────┐         ┌──────────────────┐         ┌──────────────┐
//│    User     │ 1     * │   BookListing    │ 1     1 │     Book     │
//│─────────────│─────────│──────────────────│─────────│──────────────│
//│ Id          │         │ Id               │         │ Id           │
//│ FirstName   │         │ ListingType      │         │ Title        │
//│ Email       │         │ Price            │         │ Author       │
//│             │         │ OwnerId (FK)  ───┼────────▶│              │
//│ BookListings│◀────────┼─ Owner (Nav)     │         │ BookListing  │
//│ SwapRequests│         │ BookId (FK)      │         │  (Nav)       │
//└─────────────┘         │ Book (Nav)    ───┼────────▶└──────────────┘
//       │                │ SwapRequests  ───┼──┐
//       │                └──────────────────┘  │
//       │                                      │
//       │                ┌──────────────────┐  │
//       │                │   SwapRequest    │◀─┘
//       │                │──────────────────│
//       └───────────────▶│ RequesterId (FK) │
//                        │ Requester (Nav)  │
//                        │ BookListingId(FK)│
//                        │ BookListing (Nav)│
//
//                        └──────────────────┘
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        public ICollection<BookListing> BookListings { get; set; }
        public ICollection<SwapRequest> SwapRequests { get; set; }
    }
}
