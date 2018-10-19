namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Opt_invoices
    {
        public int Invoice_Num { get; set; }
        public string salesmen { get; set; }
        public string cr_flag { get; set; }
        public string Cashier { get; set; }
        public decimal Cash { get; set; }
        public decimal Cheque { get; set; }
        public decimal Credit { get; set; }
        public decimal Discount { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Credit_card { get; set; }
        public System.DateTime Cr_Date { get; set; }
        public int adinv { get; set; }
        public decimal advnce { get; set; }
        public string Job_no { get; set; }
        public System.DateTime tym { get; set; }
        public string Expr1 { get; set; }
        public decimal inv_amnt { get; set; }
        public string customer { get; set; }
        public decimal cash_res { get; set; }
        public Nullable<int> Ref { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public Nullable<int> vat_v { get; set; }
        public string VAT_Inv { get; set; }
        public string br { get; set; }
    }
}
