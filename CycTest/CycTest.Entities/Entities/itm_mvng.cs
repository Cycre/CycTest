namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class itm_mvng
    {
        public string Stock_Card { get; set; }
        public string Type { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Invoice { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public Nullable<int> Ref { get; set; }
        public string Descrip { get; set; }
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public string Stores { get; set; }
        public Nullable<System.DateTime> tym { get; set; }
        public Nullable<int> hr { get; set; }
    }
}
