namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class net_sale_opnl
    {
        public Nullable<int> Invoice { get; set; }
        public Nullable<int> Sales_return { get; set; }
        public string Descrip { get; set; }
        public string reson { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Name { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public string Type { get; set; }
        public string div { get; set; }
        public string bname { get; set; }
        public string Cat_Name { get; set; }
        public decimal limit { get; set; }
        public Nullable<decimal> avg_cost { get; set; }
        public Nullable<double> foc { get; set; }
        public string ename { get; set; }
    }
}
