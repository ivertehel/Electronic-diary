//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfServiceLibraryED
{
    using System;
    using System.Collections.Generic;
    
    public partial class Schedule
    {
        public int Id { get; set; }
        public int Subjects_Id { get; set; }
        public int Groups_Id { get; set; }
        public int LessonNumber { get; set; }
        public string WeekDay { get; set; }
        public int Teachers_Id { get; set; }
        public string Description { get; set; }
    
        public virtual Groups Groups { get; set; }
        public virtual Subjects Subjects { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}