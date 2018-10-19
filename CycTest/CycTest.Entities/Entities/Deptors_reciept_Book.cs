namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Deptors_reciept_Book
    {
        public int Re_Num { get; set; }
        public string Acc_No { get; set; }
        public decimal Cash { get; set; }
        public decimal Cheque { get; set; }
        public string Cheque_No { get; set; }
        public System.DateTime Date { get; set; }
        public string Cashier { get; set; }
        public string Invoice_nos { get; set; }
        public Nullable<decimal> ccard { get; set; }
        public string V_Num { get; set; }
        public decimal SR { get; set; }
        public int dv { get; set; }
        public short aprvd { get; set; }
        public string ofzr { get; set; }
        public System.DateTime tym { get; set; }
        public int day_id { get; set; }
        public string ofz { get; set; }
        public Nullable<int> shift { get; set; }
        public Nullable<decimal> hpay { get; set; }
        public string Sup_no { get; set; }
        public string Sup_Acc { get; set; }
        public string Sup_name { get; set; }
        public Nullable<decimal> bpay { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<decimal> tot_due { get; set; }
        public Nullable<decimal> Other { get; set; }
        public string Exp { get; set; }
    }
}
