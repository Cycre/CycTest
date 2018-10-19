namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chk_Filter
    {
        public string PName { get; set; }
        public Nullable<decimal> SDr { get; set; }
        public Nullable<decimal> SCr { get; set; }
        public string Chk_No { get; set; }
        public Nullable<decimal> Bal { get; set; }
        public string L_Code { get; set; }
    }
}
