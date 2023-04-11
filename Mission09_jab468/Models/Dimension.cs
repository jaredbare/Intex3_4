﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Intex3_4.Models
{
    public partial class Dimension
    {
        public long Id { get; set; }
        public string Dimensiontype { get; set; }
        public string Value { get; set; }
        public int? Dimensionid { get; set; }
    }
}
