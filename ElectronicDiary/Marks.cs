//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ElectronicDiary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Marks
    {
        public int Id { get; set; }
        public int Mark { get; set; }
        public int Subject_Id { get; set; }
        public int Student_Id { get; set; }
        public System.DateTime Date { get; set; }
        public string Description { get; set; }
    
        public virtual Students Students { get; set; }
        public virtual Subjects Subjects { get; set; }
    }
}
