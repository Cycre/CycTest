namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class PO_Q
    {
        public Nullable<int> Token { get; set; }
        public string Stock_Card { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Cust { get; set; }
        public string sup_acc { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string TP { get; set; }
        public string Descrip { get; set; }
        public Nullable<decimal> l_cost { get; set; }
        public string usr { get; set; }
        public Nullable<System.DateTime> dlvry { get; set; }
        public Nullable<decimal> trns { get; set; }
    }
}
