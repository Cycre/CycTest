namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales_return_details
    {
        public string Acc_No { get; set; }
        public decimal Grand_Tot { get; set; }
        public string Cashier { get; set; }
        public decimal Cash { get; set; }
        public decimal Cheque { get; set; }
        public decimal Credit { get; set; }
        public decimal Discount { get; set; }
        public int Invoice_Num { get; set; }
        public int Job_No { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Cr_Date { get; set; }
        public string cr_flag { get; set; }
        public string vat { get; set; }
        public string nbt { get; set; }
        public string salesmen { get; set; }
        public string L { get; set; }
        public string LT { get; set; }
        public string Wht { get; set; }
        public string Order_no { get; set; }
        public decimal op { get; set; }
        public int M_inv { get; set; }
        public string type { get; set; }
        public Nullable<int> shift { get; set; }
    }
}
