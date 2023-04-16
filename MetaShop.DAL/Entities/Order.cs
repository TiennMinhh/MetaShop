﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaShop.DAL.Entities
{
    internal class Order
    { 
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Status { get; set; }
        public decimal ShippingFee { get; set; }
        public decimal Total { get; set; }
        public int PaymentId { get; set; }
        public int CouponId { get; set; }
        public int AffiliateId { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CanceledDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Coupon Coupon { get; set; }
        public virtual Product Product { get; set; }
        //public virtual Payment Payment { get; set; }

    }
}
