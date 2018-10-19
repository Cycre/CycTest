namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Cat
    {
        public int ID { get; set; }
        public string Cat_Name { get; set; }
        public Nullable<int> Stock_Book { get; set; }
        public string Cat_Code { get; set; }
        public short Item_No { get; set; }
        public Nullable<int> Old_ID { get; set; }
        public string FLAGT { get; set; }
        public Nullable<double> dis { get; set; }
        public Nullable<decimal> disamt { get; set; }
    }
}
