namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kot_Items
    {
        public int ID { get; set; }
        public int Kot_No { get; set; }
        public string Item_Code { get; set; }
        public double Qty { get; set; }
        public Nullable<short> flag { get; set; }
        public short Foc { get; set; }
        public int @ref { get; set; }
        public short st_flag { get; set; }
        public Nullable<decimal> price { get; set; }
    }
}
