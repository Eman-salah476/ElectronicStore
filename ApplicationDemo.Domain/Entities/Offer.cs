﻿using ApplicationDemo.Domain.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationDemo.Domain.Entities
{
    public class Offer
    {
        public Guid Id { get; set; }
        [ForeignKey("Device")]
        public Guid DeviceId { get; set; }
        public OfferType Type { get; set; }
        public bool Active { get; set; }
        public DateTime ExpireDate { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Device Device { get; set; }
    }
}
