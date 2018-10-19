namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class KOT_STAFF_QQ
    {
        public int Kot_Num { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Steward { get; set; }
        public string Cashier { get; set; }
        public double Qty { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public Nullable<short> Inv_F { get; set; }
        public string Item_Code { get; set; }
    }
}
