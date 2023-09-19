﻿using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class CashMemoSub
    {
        public long Id { get; set; }
        public long BillNo { get; set; }
        public int? ServiceId { get; set; }
        public int? Slno { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? BuyRate { get; set; }
        public string BatchNo { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal? Total { get; set; }
    }
}
