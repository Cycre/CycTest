namespace CycTest.Entities.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Account_Posting
    {
        public short P_Code { get; set; }
        public string PName { get; set; }
        public short B_Code { get; set; }
        public short T_Code { get; set; }
        public short H_Code { get; set; }
        public string L_Code { get; set; }
        public string Link { get; set; }
        public string Pay { get; set; }
        public Nullable<short> acp { get; set; }
    }
}
