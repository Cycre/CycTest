namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usr_catq
    {
        public Nullable<long> p_id { get; set; }
        public Nullable<long> Cat_id { get; set; }
        public string cat { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public long ID { get; set; }
        public string R_Category { get; set; }
        public Nullable<int> subcat_id { get; set; }
    }
}
