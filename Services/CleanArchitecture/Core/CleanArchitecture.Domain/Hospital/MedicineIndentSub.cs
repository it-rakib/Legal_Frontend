﻿using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicineIndentSub
    {
        public long Id { get; set; }
        public long IndentNo { get; set; }
        public int? ServiceId { get; set; }
        public int? Slno { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Delivery { get; set; }
        public decimal? Used { get; set; }
        public string DeliveryBy { get; set; }
        public DateTime? DeliveryDt { get; set; }
        public string UsedBy { get; set; }
        public DateTime? UsedDt { get; set; }
    }
}
