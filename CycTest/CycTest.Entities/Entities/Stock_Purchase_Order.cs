namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Purchase_Order
    {
        public string Stock_Card { get; set; }
        public Nullable<int> P_Order { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Type { get; set; }
        public Nullable<double> Discount { get; set; }
        public string Name { get; set; }
        public string Descrip { get; set; }
        public string Expr1 { get; set; }
        public string Cat_Name { get; set; }
        public Nullable<decimal> pPrice { get; set; }
        public Nullable<double> unit_vat { get; set; }
        public Nullable<double> L_dis { get; set; }
        public int ID { get; set; }
        public string Job { get; set; }
        public string Stores { get; set; }
        public Nullable<double> foc { get; set; }
        public string usr { get; set; }
        public Nullable<decimal> trns { get; set; }
        public Nullable<decimal> vat { get; set; }
        public Nullable<int> po { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string TP { get; set; }
        public Nullable<decimal> new_cost { get; set; }
        public Nullable<decimal> value { get; set; }
        public Nullable<decimal> Dis_Amt { get; set; }
        public Nullable<decimal> L_Amt { get; set; }
        public Nullable<decimal> R_price { get; set; }
        public Nullable<decimal> unit_Price { get; set; }
        public Nullable<decimal> W_price { get; set; }
        public Nullable<double> Dr_ml { get; set; }
        public Nullable<double> Cr_ml { get; set; }
        public string br { get; set; }
    }
}
