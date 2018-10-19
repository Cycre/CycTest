namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class debtors_discount
    {
        public int Sales_restrun { get; set; }
        public int Invoice_num { get; set; }
        public decimal Discount { get; set; }
        public System.DateTime date { get; set; }
        public string des { get; set; }
        public string Acc_No { get; set; }
    }
}
