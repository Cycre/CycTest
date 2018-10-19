namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_in
    {
        public Nullable<decimal> Unit_Cost { get; set; }
        public Nullable<int> Dr_Qty { get; set; }
        public Nullable<int> Cr_Qty { get; set; }
        public Nullable<double> Ref { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public string Stock_Card { get; set; }
        public Nullable<int> Stores { get; set; }
        public Nullable<int> Wrt { get; set; }
        public string SN { get; set; }
        public Nullable<decimal> line_dis { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public string tid { get; set; }
        public Nullable<short> flag { get; set; }
        public long ID { get; set; }
        public string finv { get; set; }
        public Nullable<int> stk { get; set; }
        public Nullable<double> packq { get; set; }
        public Nullable<decimal> packp { get; set; }
        public Nullable<double> gt_no { get; set; }
    }
}
