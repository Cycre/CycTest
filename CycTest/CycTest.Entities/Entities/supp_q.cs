namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class supp_q
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string NIC { get; set; }
        public string Mobile { get; set; }
        public string TP { get; set; }
        public string Note { get; set; }
        public string Acc_No { get; set; }
        public string group { get; set; }
        public Nullable<int> flag { get; set; }
        public string Contact_Person { get; set; }
        public Nullable<decimal> cr_lmt { get; set; }
        public Nullable<double> cr_dyz { get; set; }
        public Nullable<short> csh { get; set; }
        public Nullable<short> chq { get; set; }
        public string chq_fvr { get; set; }
        public Nullable<short> acp { get; set; }
    }
}
