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
    
    public partial class CardboardQuality
    {
        public int ID { get; set; }
        public int CardboardProfileID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double SurfacicMass { get; set; }
        public double RigidityX { get; set; }
        public double RigidityY { get; set; }
        public double YoungModulus { get; set; }
        public double ECT { get; set; }
    
        public virtual CardboardProfile CardboardProfile { get; set; }
    }
}
