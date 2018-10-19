namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class rep_wise_out
    {
        public string HName { get; set; }
        public Nullable<decimal> SDr { get; set; }
        public Nullable<decimal> SCr { get; set; }
        public Nullable<double> Invoice_Num { get; set; }
        public string status { get; set; }
        public Nullable<decimal> Bal { get; set; }
        public string L_Code { get; set; }
        public Nullable<System.DateTime> FirstOfDate { get; set; }
        public string PName { get; set; }
        public string salesmen { get; set; }
        public string div { get; set; }
        public string Division { get; set; }
    }
}
