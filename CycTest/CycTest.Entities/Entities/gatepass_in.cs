namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class gatepass_in
    {
        public Nullable<double> Ref { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<double> Gatepass { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public Nullable<int> Dr_Qty { get; set; }
        public Nullable<int> Cr_Qty { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public string Stock_Card { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public string tid { get; set; }
        public string Job { get; set; }
        public string Branch { get; set; }
    }
}
