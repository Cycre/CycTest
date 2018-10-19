namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Un_confirm_KOT
    {
        public Nullable<int> Kot_No { get; set; }
        public Nullable<short> Table_Room { get; set; }
        public string Steward { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
        public string Type { get; set; }
        public string Cashier { get; set; }
        public Nullable<short> Inv_F { get; set; }
        public Nullable<int> Inv_No { get; set; }
        public string Cus { get; set; }
        public Nullable<int> Ref { get; set; }
        public Nullable<short> Pkg_qty { get; set; }
        public Nullable<int> Pkg_charge_q { get; set; }
        public Nullable<decimal> Pkg_Price { get; set; }
        public string pkg_type { get; set; }
        public double Qty { get; set; }
        public Nullable<short> Expr1 { get; set; }
        public Nullable<int> Expr2 { get; set; }
        public short Foc { get; set; }
        public string Descrip { get; set; }
        public string Item_Code { get; set; }
        public Nullable<decimal> price { get; set; }
    }
}
