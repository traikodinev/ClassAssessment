//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassAssessment.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Users
    {
        public Users()
        {
            this.Assessments = new HashSet<Assessments>();
            this.Assessments1 = new HashSet<Assessments>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string Roles { get; set; }
    
        public virtual ICollection<Assessments> Assessments { get; set; }
        public virtual ICollection<Assessments> Assessments1 { get; set; }
    }
}
