//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassFun
{
    using System;
    using System.Collections.Generic;
    
    public partial class ScheduledFor
    {
        public int AppointmentID { get; set; }
        public int ClientID { get; set; }
        public string Assignment { get; set; }
        public Nullable<bool> kept { get; set; }
    
        public virtual Appointment Appointment { get; set; }
        public virtual Client Client { get; set; }
    }
}
