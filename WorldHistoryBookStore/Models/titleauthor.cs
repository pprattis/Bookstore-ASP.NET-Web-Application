//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WorldHistoryBookStore.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class titleauthor
    {
        public string au_id { get; set; }
        public string title_id { get; set; }
        public Nullable<byte> au_ord { get; set; }
        public Nullable<int> royaltyper { get; set; }
    
        public virtual author author { get; set; }
        public virtual title title { get; set; }
    }
}
