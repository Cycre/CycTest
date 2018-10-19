namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class gatepass_report
    {
        public string Emp { get; set; }
        public string Job { get; set; }
        public string divition { get; set; }
        public string V_Number { get; set; }
        public string Stock_Card { get; set; }
        public string Type { get; set; }
        public string Rack_Location { get; set; }
        public Nullable<double> Dr_Qty { get; set; }
        public Nullable<double> Cr_Qty { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Pending_job { get; set; }
        public Nullable<short> pflag { get; set; }
        public Nullable<int> Invoice { get; set; }
        public string cashier { get; set; }
        public Nullable<decimal> Unit_Cost { get; set; }
        public Nullable<decimal> S_Price { get; set; }
        public Nullable<int> Ref { get; set; }
        public string Descrip { get; set; }
        public string Name { get; set; }
        public string Cat_Name { get; set; }
        public Nullable<int> Gatepass { get; set; }
        public Nullable<short> job_flag { get; set; }
        public string emp_name { get; set; }
        public Nullable<short> emp_number { get; set; }
        public string unloading { get; set; }
        public string loading { get; set; }
        public string v_no { get; set; }
        public Nullable<short> dmg { get; set; }
        public Nullable<int> brnch { get; set; }
    }
}
