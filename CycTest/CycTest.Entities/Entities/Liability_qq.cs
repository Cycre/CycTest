namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Liability_qq
    {
        public string BName { get; set; }
        public Nullable<decimal> SDr { get; set; }
        public Nullable<decimal> SCr { get; set; }
        public string Sup_Invoice { get; set; }
        public string status { get; set; }
        public Nullable<decimal> Bal { get; set; }
        public string L_Code { get; set; }
        public Nullable<System.DateTime> FirstOfDate { get; set; }
        public string PName { get; set; }
        public string FirstOfjob { get; set; }
    }
}
