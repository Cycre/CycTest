namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Invoice_reportx
    {
        public string Name { get; set; }
        public string Acc_No { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public string Stock_Card { get; set; }
        public string Descrip { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public Nullable<decimal> line_dis { get; set; }
        public Nullable<decimal> unit_Price { get; set; }
        public string SN { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public int ID { get; set; }
        public Nullable<double> foc { get; set; }
        public Nullable<decimal> Act_prze { get; set; }
        public Nullable<short> job_flag { get; set; }
        public Nullable<double> Nx { get; set; }
        public Nullable<double> Vx { get; set; }
        public string VAT_NO { get; set; }
        public Nullable<decimal> R_price { get; set; }
        public string Caption { get; set; }
        public decimal Sales_P_Max { get; set; }
        public string salesmen { get; set; }
        public int Invoice_Num { get; set; }
        public string cr_flag { get; set; }
        public Nullable<decimal> vat { get; set; }
        public Nullable<decimal> nbt { get; set; }
        public string L { get; set; }
        public string Cashier { get; set; }
        public decimal Cash { get; set; }
        public string LT { get; set; }
        public Nullable<int> flag { get; set; }
        public Nullable<int> wflag { get; set; }
        public decimal Cheque { get; set; }
        public decimal Credit { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Discount { get; set; }
        public string Division { get; set; }
    }
}
