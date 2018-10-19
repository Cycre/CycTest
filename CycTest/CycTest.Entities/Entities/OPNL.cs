namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class OPNL
    {
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public string Descrip { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public decimal Avg_Cost { get; set; }
        public int Invoice_Num { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
    }
}
