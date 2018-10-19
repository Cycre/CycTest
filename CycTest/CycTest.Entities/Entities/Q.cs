namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Q
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Max_Price { get; set; }
        public decimal R_Min { get; set; }
        public decimal Min_Price { get; set; }
        public decimal W_Min { get; set; }
        public string Rack_Location { get; set; }
        public int iorder { get; set; }
        public Nullable<int> Stock_Cat { get; set; }
        public string sup { get; set; }
        public string sup2 { get; set; }
        public string sup3 { get; set; }
        public string sup4 { get; set; }
        public string sup5 { get; set; }
        public short web { get; set; }
        public Nullable<decimal> Disamt { get; set; }
        public Nullable<decimal> Disp { get; set; }
    }
}
