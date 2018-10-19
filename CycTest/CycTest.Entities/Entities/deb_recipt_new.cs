namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class deb_recipt_new
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
        public Nullable<decimal> Cr { get; set; }
        public Nullable<decimal> Totamt { get; set; }
        public Nullable<decimal> Duet { get; set; }
        public Nullable<double> Invoice_Num { get; set; }
        public string Discription { get; set; }
        public string Chk_No { get; set; }
    }
}
