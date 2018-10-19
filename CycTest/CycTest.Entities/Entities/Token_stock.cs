namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Token_stock
    {
        public decimal Unit_Cost { get; set; }
        public short Dr_Qty { get; set; }
        public short Cr_Qty { get; set; }
        public string Status { get; set; }
        public decimal S_Price { get; set; }
        public string Stock_Card { get; set; }
        public short Stores { get; set; }
        public string oparator { get; set; }
        public short flag { get; set; }
        public string Ref { get; set; }
        public Nullable<double> dis { get; set; }
        public short free_q { get; set; }
    }
}
