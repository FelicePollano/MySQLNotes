//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySQLNotes
{
    using System;
    using System.Collections.Generic;
    
    public partial class Page
    {
        public int PageId { get; set; }
        public byte[] PageContent { get; set; }
        public string PageName { get; set; }
        public Nullable<System.DateTime> CreationDate { get; set; }
    
        public virtual NoteBook NoteBook { get; set; }
    }
}
