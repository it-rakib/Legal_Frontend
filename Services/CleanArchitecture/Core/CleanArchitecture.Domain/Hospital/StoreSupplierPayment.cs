﻿using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class StoreSupplierPayment
    {
        public long Id { get; set; }
        public int SupplierId { get; set; }
        public decimal Amount { get; set; }
        public string PaymentMode { get; set; }
        public int EnteredBy { get; set; }
        public DateTime TransDate { get; set; }
        public string Remarks { get; set; }
    }
}
