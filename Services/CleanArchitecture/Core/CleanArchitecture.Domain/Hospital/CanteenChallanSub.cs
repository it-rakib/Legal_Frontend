﻿using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CanteenChallanSub
    {
        public long Id { get; set; }
        public long ChallanNo { get; set; }
        public int ServiceId { get; set; }
        public int Slno { get; set; }
        public decimal Total { get; set; }
        public decimal BuyRate { get; set; }
        public decimal Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal Vat { get; set; }
    }
}
