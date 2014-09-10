//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PLMPackLib.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class MajorationSet
    {
        public MajorationSet()
        {
            this.Majorations = new HashSet<Majoration>();
        }
    
        public int ID { get; set; }
        public int ComponentID { get; set; }
        public int CardboardProfileID { get; set; }
        public int Order { get; set; }
    
        public virtual CardboardProfile CardboardProfile { get; set; }
        public virtual Component Component { get; set; }
        public virtual ICollection<Majoration> Majorations { get; set; }
    }
}