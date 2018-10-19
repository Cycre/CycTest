namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class token_q
    {
        public int Token { get; set; }
        public System.DateTime Date { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Cashier { get; set; }
        public string Customer { get; set; }
        public string Login { get; set; }
    }
}
