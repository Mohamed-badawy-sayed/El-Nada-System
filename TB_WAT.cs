//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FWD
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_WAT
    {
        public int ID { get; set; }
        public string WAT_Name { get; set; }
        public Nullable<int> WAT_Cat { get; set; }
        public string WAT_SSN { get; set; }
        public Nullable<int> WAT_Add { get; set; }
        public string WAT_Phone1 { get; set; }
        public string WAT_Phone2 { get; set; }
        public Nullable<int> WAT_Supp_name { get; set; }
        public string WAT_Supp_Phone { get; set; }
        public string WAT_Det { get; set; }
        public Nullable<System.DateTime> WAT_Date_Order { get; set; }
        public string WAT_Done_state { get; set; }
        public Nullable<System.DateTime> WAT_Done_Date { get; set; }
        public Nullable<System.DateTime> WAT_Date_Bairth { get; set; }
    
        public virtual TB_SUPP TB_SUPP { get; set; }
        public virtual TB_WL_CAT TB_WL_CAT { get; set; }
        public virtual TBE_LOC TBE_LOC { get; set; }
    }
}
