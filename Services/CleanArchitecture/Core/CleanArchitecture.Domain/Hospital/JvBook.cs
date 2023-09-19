﻿using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class JvBook
    {
        public long Id { get; set; }
        public string VoucherNo { get; set; }
        public DateTime? TransDate { get; set; }
        public string Particulers { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? Balance { get; set; }
        public int? CoyId { get; set; }
    }
}
