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
    
    public partial class TB_CUS_Files
    {
        public int CUS_Files_ID { get; set; }
        public byte[] CUS_Files_front { get; set; }
        public byte[] CUS_Files_back { get; set; }
        public byte[] CUS_Files_location { get; set; }
        public string CUS_Files_Type { get; set; }
        public string CUS_Files_Files_Name { get; set; }
        public Nullable<int> CUS_Files_FK { get; set; }
    
        public virtual TB_CUST_Person TB_CUST_Person { get; set; }
    }
}
