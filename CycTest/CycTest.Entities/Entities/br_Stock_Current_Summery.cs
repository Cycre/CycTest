namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class br_Stock_Current_Summery
    {
        public string Stock_Card { get; set; }
        public Nullable<double> Sum_Dr_Qty { get; set; }
        public Nullable<double> Sum_Cr_Qty { get; set; }
        public Nullable<double> Bal { get; set; }
        public Nullable<double> MBal { get; set; }
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public string Descrip { get; set; }
        public string Stores { get; set; }
        public Nullable<System.DateTime> LDate { get; set; }
        public Nullable<short> Mreorder { get; set; }
        public short eql { get; set; }
        public int Id { get; set; }
    }
}
