using System;
using System.Collections.Generic;


namespace CycTest.Entities.Entities
{
   
    public partial class A_Log
    {
        public string Usr { get; set; }
        public string Panel { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public Nullable<int> Ordr { get; set; }
        public Nullable<System.TimeSpan> Tym { get; set; }
        public long ID { get; set; }
        public Nullable<int> p_id { get; set; }
        public Nullable<int> h_id { get; set; }
        public Nullable<int> up { get; set; }
    }
}
