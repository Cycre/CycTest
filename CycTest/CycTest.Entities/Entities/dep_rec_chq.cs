namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class dep_rec_chq
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
        public string Chk_No { get; set; }
        public decimal Amount { get; set; }
        public Nullable<decimal> Bpay { get; set; }
        public System.DateTime entry_date { get; set; }
        public System.DateTime Exp_Date { get; set; }
    }
}
