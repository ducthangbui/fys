//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class File
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public File()
        {
            this.Messages = new HashSet<Message>();
        }
    
        public int FileId { get; set; }
        public Nullable<int> UserFileId { get; set; }
        public Nullable<int> TargetFileId { get; set; }
        public Nullable<int> TargetFileType { get; set; }
        public string FileLink { get; set; }
        public Nullable<int> MessageId { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Message> Messages { get; set; }
    }
}
