namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Day_cshbk
    {
        public string L_Code { get; set; }
        public Nullable<decimal> Dr { get; set; }
        public Nullable<decimal> Cr { get; set; }
        public Nullable<decimal> bal { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    }
}
