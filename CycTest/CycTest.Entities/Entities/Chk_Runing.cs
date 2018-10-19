namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chk_Runing
    {
        public string Acc_No { get; set; }
        public string Chk_No { get; set; }
        public int Transaction_ID { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Exp_Date { get; set; }
        public string Status { get; set; }
        public short aflag { get; set; }
        public string Dis { get; set; }
        public System.DateTime entry_date { get; set; }
        public int dv { get; set; }
        public string bnk { get; set; }
        public string brnch { get; set; }
        public string in_acc { get; set; }
        public Nullable<int> flag { get; set; }
        public string Vnum { get; set; }
        public Nullable<int> flg { get; set; }
        public Nullable<int> recpt { get; set; }
    }
}
