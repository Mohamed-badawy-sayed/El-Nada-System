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
    
    public partial class TB_CUS_Img
    {
        public int CUS_Img_id { get; set; }
        public byte[] CUS_Img_front { get; set; }
        public byte[] CUS_Img_back { get; set; }
        public byte[] CUS_Img_img { get; set; }
        public Nullable<int> CUS_Img_fk { get; set; }
    
        public virtual TB_CUST_Person TB_CUST_Person { get; set; }
    }
}
