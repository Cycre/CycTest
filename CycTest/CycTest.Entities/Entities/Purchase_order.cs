namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase_order
    {
        public Nullable<int> Token { get; set; }
        public string Stock_Card { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<decimal> Unit_Price { get; set; }
        public string Cashier { get; set; }
        public string Cust { get; set; }
        public string Model { get; set; }
        public string Chasis { get; set; }
        public string V_Num { get; set; }
        public string Engine { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Sup { get; set; }
        public string sup_acc { get; set; }
        public int ID { get; set; }
        public Nullable<decimal> l_cost { get; set; }
        public string usr { get; set; }
        public Nullable<System.DateTime> dlvry { get; set; }
        public Nullable<decimal> trns { get; set; }
        public Nullable<short> flg { get; set; }
        public Nullable<double> bal { get; set; }
    }
}
