namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chk_Dip_Filter
    {
        public string TName { get; set; }
        public Nullable<decimal> SDr { get; set; }
        public Nullable<decimal> SCr { get; set; }
        public string Chk_No { get; set; }
        public Nullable<decimal> Bal { get; set; }
        public string L_Code { get; set; }
        public string PName { get; set; }
        public Nullable<System.DateTime> FirstOfDate { get; set; }
    }
}
