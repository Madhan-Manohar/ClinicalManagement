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
    
    public partial class PrescriptionTbl
    {
        public int PrescId { get; set; }
        public int Doctor { get; set; }
        public int Patient { get; set; }
        public string Medicines { get; set; }
        public int LabTest { get; set; }
        public int Cost { get; set; }
    
        public virtual DoctorTbl DoctorTbl { get; set; }
        public virtual LabTestTbl LabTestTbl { get; set; }
        public virtual PatientTbl PatientTbl { get; set; }
    }
}
