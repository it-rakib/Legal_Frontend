﻿using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class MedicinePurchaseRequisitionSupplierSub
    {
        public long Id { get; set; }
        public int? PurReqNo { get; set; }
        public int? Slno { get; set; }
        public int? ServiceId { get; set; }
        public decimal? Balance { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? Price { get; set; }
        public decimal? LastPrice { get; set; }
        public decimal? LastMonthSale { get; set; }
        public decimal? OrderQty { get; set; }
        public int? SalesConsiderDays { get; set; }
        public int? SaleConsiderQuantity { get; set; }
        public int? AvgSalesConsiderDays { get; set; }
        public int? AvgSaleConsiderQuantity { get; set; }
        public int? StockConsiderDays { get; set; }
        public int? StockConsiderQuantity { get; set; }
        public decimal? RequiredQuantity { get; set; }
        public decimal? CurrentStock { get; set; }
    }
}
