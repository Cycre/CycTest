namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Stock_Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> Old_ID { get; set; }
        public string FLAGT { get; set; }
    }
}
