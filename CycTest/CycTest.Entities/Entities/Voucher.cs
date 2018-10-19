namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Voucher
    {
        public string Acc_No { get; set; }
        public string Pay { get; set; }
        public System.DateTime C_Date { get; set; }
        public System.DateTime W_Date { get; set; }
        public string C_Number { get; set; }
        public decimal Amount { get; set; }
        public string print { get; set; }
        public string des { get; set; }
        public string Address { get; set; }
        public string Bank { get; set; }
        public int Vnum { get; set; }
        public string S_name { get; set; }
        public string inv { get; set; }
        public short flag { get; set; }
        public string Bank_acc { get; set; }
        public short dv { get; set; }
        public string vcat { get; set; }
        public string login { get; set; }
    }
}
