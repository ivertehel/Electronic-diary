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
    
    public partial class Subjects_Teachers
    {
        public int Id { get; set; }
        public int Teachers_Id { get; set; }
        public int Subjects_Id { get; set; }
    
        public virtual Subjects Subjects { get; set; }
        public virtual Teachers Teachers { get; set; }
    }
}