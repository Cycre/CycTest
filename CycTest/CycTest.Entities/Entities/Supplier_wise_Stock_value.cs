namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplier_wise_Stock_value
    {
        public string Stock_Card { get; set; }
        public Nullable<double> Bal { get; set; }
        public decimal Avg_Cost { get; set; }
        public string Descrip { get; set; }
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public decimal Sales_P_Max { get; set; }
        public string Supplier { get; set; }
    }
}
