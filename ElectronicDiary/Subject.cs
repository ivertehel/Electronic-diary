//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectronicDiary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Subject
    {
        public Subject()
        {
            this.Subjects_Teachers = new HashSet<Subjects_Teachers>();
            this.Marks = new HashSet<Mark>();
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Subjects_Teachers> Subjects_Teachers { get; set; }
        public virtual ICollection<Mark> Marks { get; set; }
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
