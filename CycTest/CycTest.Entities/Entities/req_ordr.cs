namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class req_ordr
    {
        public string Code { get; set; }
        public string Description____________________________ { get; set; }
        public decimal R_P { get; set; }
        public decimal W_P { get; set; }
        public string Rack_Location { get; set; }
        public Nullable<double> SumOfDr_Qty { get; set; }
        public Nullable<double> SumOfCr_Qty { get; set; }
        public Nullable<double> Bal { get; set; }
    }
}
