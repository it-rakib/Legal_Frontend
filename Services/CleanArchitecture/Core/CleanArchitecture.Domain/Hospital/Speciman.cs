﻿using System;
using System.Collections.Generic;

namespace Merchandising.Domain.Hospital
{
    public partial class Speciman
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? ModuleId { get; set; }
    }
}
