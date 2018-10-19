namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Chk_Return_Q
    {
        public string Acc_No { get; set; }
        public int Transaction_ID { get; set; }
        public decimal Amount { get; set; }
        public System.DateTime Exp_Date { get; set; }
        public string status { get; set; }
        public string Name { get; set; }
        public string div { get; set; }
        public string Chk_No { get; set; }
        public string HName { get; set; }
        public string address { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public System.DateTime entry_date { get; set; }
        public string Dis { get; set; }
        public string Division { get; set; }
    }
}
