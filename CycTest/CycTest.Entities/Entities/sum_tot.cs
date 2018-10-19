namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class sum_tot
    {
        public string Stock_Card { get; set; }
        public string Descrip { get; set; }
        public Nullable<double> tdr { get; set; }
        public Nullable<double> bal { get; set; }
        public Nullable<double> SumQ { get; set; }
        public Nullable<double> tcr { get; set; }
        public Nullable<short> Stores { get; set; }
    }
}
