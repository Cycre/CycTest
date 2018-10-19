namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class qty_moving_aq
    {
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public string Descrip { get; set; }
        public Nullable<double> bal { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> to { get; set; }
    }
}
