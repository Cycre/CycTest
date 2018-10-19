namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Written_Cheque
    {
        public string Acc_No { get; set; }
        public string Pay { get; set; }
        public string Bank { get; set; }
        public System.DateTime C_Date { get; set; }
        public System.DateTime W_Date { get; set; }
        public string C_Number { get; set; }
        public decimal Amount { get; set; }
        public bool cross { get; set; }
        public string print { get; set; }
        public Nullable<short> delete { get; set; }
        public int dv { get; set; }
    }
}
