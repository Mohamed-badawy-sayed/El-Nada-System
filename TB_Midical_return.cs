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
    
    public partial class TB_Midical_return
    {
        public int Midical_return_ID { get; set; }
        public Nullable<int> Midical_return_tool { get; set; }
        public Nullable<System.DateTime> Midical_return_date { get; set; }
        public Nullable<int> Midical_return_recever { get; set; }
    
        public virtual TB_Medical_give TB_Medical_give { get; set; }
    }
}
