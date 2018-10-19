namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class gatepass_report_in
    {
        public string Descrip { get; set; }
        public string Stock_Card { get; set; }
        public string Rack_Location { get; set; }
        public Nullable<int> Dr_Qty { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Sup_Acc { get; set; }
        public Nullable<double> Discount { get; set; }
        public string Type { get; set; }
        public Nullable<double> Invoice { get; set; }
        public string Login { get; set; }
        public string Ref { get; set; }
        public Nullable<double> Grn { get; set; }
        public string Job { get; set; }
        public string cashier { get; set; }
        public Nullable<double> Sales_return { get; set; }
        public Nullable<double> Gatepass { get; set; }
        public Nullable<short> flag { get; set; }
        public string Status { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public string Branch { get; set; }
    }
}
