//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace xedu.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public long id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string reset_link { get; set; }
        public Nullable<System.DateTime> reset_date { get; set; }
        public Nullable<bool> is_locked { get; set; }
        public Nullable<long> id_giao_vien { get; set; }
        public Nullable<long> id_truong { get; set; }
        public Nullable<long> id_xsoft { get; set; }
        public string avatar_image_link { get; set; }
    }
}
