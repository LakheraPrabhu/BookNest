using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; } // it is null because there can be some scenarios where table may not get updated even once
    }
}
