namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale_return
    {
        public string Stock_Card { get; set; }
        public Nullable<int> Sales_return { get; set; }
        public Nullable<int> P_Order { get; set; }
        public string reson { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Type { get; set; }
        public Nullable<double> Discount { get; set; }
        public string ename { get; set; }
        public string Descrip { get; set; }
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public string Expr1 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string div { get; set; }
        public string Stores { get; set; }
        public int M_inv { get; set; }
        public string Expr2 { get; set; }
    }
}
