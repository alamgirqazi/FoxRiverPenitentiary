//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace learn_models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Crime_Information
    {
        public Crime_Information()
        {
            this.prisoner_info = new HashSet<prisoner_info>();
        }
    
        public int crime_id { get; set; }
        public string crime_title { get; set; }
        public string crime_punishment { get; set; }
        public string crime_fine { get; set; }
        public bool crime_bail { get; set; }
    
        public virtual ICollection<prisoner_info> prisoner_info { get; set; }
    }
}
