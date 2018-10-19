namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice_Details
    {
        public string Acc_No { get; set; }
        public decimal Grand_Tot { get; set; }
        public string Cashier { get; set; }
        public decimal Cash { get; set; }
        public decimal Cheque { get; set; }
        public decimal Credit { get; set; }
        public decimal Discount { get; set; }
        public int Invoice_Num { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime Cr_Date { get; set; }
        public string cr_flag { get; set; }
        public string salesmen { get; set; }
        public string LT { get; set; }
        public string Wht { get; set; }
        public string Order_no { get; set; }
        public short aflag { get; set; }
        public decimal Credit_card { get; set; }
        public decimal cash_res { get; set; }
        public decimal bill_dis_p { get; set; }
        public decimal gift_v { get; set; }
        public decimal bill_dis_amt { get; set; }
        public string custtid { get; set; }
        public string customer { get; set; }
        public string custadd { get; set; }
        public decimal exchange_amt { get; set; }
        public string exchange_recipt { get; set; }
        public decimal Cash_refund { get; set; }
        public int adinv { get; set; }
        public decimal advnce { get; set; }
        public string V_Num { get; set; }
        public int sum_id { get; set; }
        public int str { get; set; }
        public string L { get; set; }
        public short aprvd { get; set; }
        public string ofz { get; set; }
        public int day_id { get; set; }
        public System.DateTime tym { get; set; }
        public string ofzr { get; set; }
        public string Job_no { get; set; }
        public decimal inv_amnt { get; set; }
        public decimal ignr { get; set; }
        public decimal emp_set { get; set; }
        public Nullable<int> Shift { get; set; }
        public string tid { get; set; }
        public Nullable<decimal> Actual_P { get; set; }
        public Nullable<decimal> vat { get; set; }
        public Nullable<decimal> nbt { get; set; }
        public Nullable<int> vat_v { get; set; }
        public Nullable<decimal> pre_bal { get; set; }
        public string VAT_Inv { get; set; }
        public Nullable<decimal> trcost { get; set; }
        public Nullable<int> adinv2 { get; set; }
        public Nullable<decimal> advnce2 { get; set; }
        public string inv { get; set; }
        public Nullable<decimal> htotal { get; set; }
        public Nullable<int> hinterest { get; set; }
        public Nullable<decimal> installment_amt { get; set; }
        public Nullable<decimal> ins_payment { get; set; }
        public Nullable<int> finetaxint { get; set; }
        public Nullable<int> finefreed { get; set; }
        public Nullable<int> interest_freed { get; set; }
        public Nullable<int> no_of_inst { get; set; }
        public string login { get; set; }
        public Nullable<int> stock { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<int> wflag { get; set; }
    }
}
