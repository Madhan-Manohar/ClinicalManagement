//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClinicalManagement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ReceptionistTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ReceptionistTbl()
        {
            this.PatientTbls = new HashSet<PatientTbl>();
        }
    
        public int RecId { get; set; }
        public string RecName { get; set; }
        public string RecEmail { get; set; }
        public string RecAdd { get; set; }
        public string RecPhone { get; set; }
        public string RecPassword { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PatientTbl> PatientTbls { get; set; }
    }
}
