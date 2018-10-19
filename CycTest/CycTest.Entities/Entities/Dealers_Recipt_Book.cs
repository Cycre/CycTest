namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Dealers_Recipt_Book
    {
        public int Re_Num { get; set; }
        public string Acc_No { get; set; }
        public decimal Cash { get; set; }
        public decimal Cheque { get; set; }
        public string Cheque_No { get; set; }
        public System.DateTime Date { get; set; }
        public string Cashier { get; set; }
        public string Credit_Acc { get; set; }
    }
}
