namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Info
    {
        public short bst { get; set; }
        public string Stock_Card { get; set; }
        public string Descrip { get; set; }
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public Nullable<int> M_Stock { get; set; }
        public decimal Sales_P { get; set; }
        public Nullable<int> Stock_Book { get; set; }
        public string Rack_Location { get; set; }
        public Nullable<int> Stock_Cat { get; set; }
        public decimal wPrice { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public decimal Sales_P_Max { get; set; }
        public decimal wPrice_Max { get; set; }
        public string RL { get; set; }
        public string SL { get; set; }
        public short Row { get; set; }
        public int Col { get; set; }
        public string Part_No { get; set; }
        public short reorder { get; set; }
        public int Max_ordr { get; set; }
        public Nullable<int> ml { get; set; }
        public Nullable<decimal> pack_sale { get; set; }
        public Nullable<decimal> pack_rest { get; set; }
        public short web { get; set; }
        public string Bar_code { get; set; }
    }
}
