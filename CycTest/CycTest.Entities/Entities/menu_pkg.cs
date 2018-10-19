namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class menu_pkg
    {
        public string pkg { get; set; }
        public string item_code { get; set; }
        public Nullable<double> qty { get; set; }
        public Nullable<short> Daily { get; set; }
    }
}
