namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class debtors_recipts
    {
        public string Acc_No { get; set; }
        public string Name { get; set; }
        public string address { get; set; }
        public string TP { get; set; }
        public int Re_Num { get; set; }
        public string Cashier { get; set; }
        public string Invoice_nos { get; set; }
        public decimal Cash { get; set; }
        public decimal Cheque { get; set; }
        public string Cheque_No { get; set; }
        public System.DateTime Date { get; set; }
        public string V_Num { get; set; }
        public decimal SR { get; set; }
        public short aprvd { get; set; }
        public Nullable<decimal> bpay { get; set; }
        public Nullable<decimal> hpay { get; set; }
    }
}
