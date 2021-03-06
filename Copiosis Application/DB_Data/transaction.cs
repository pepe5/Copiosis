//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Copiosis_Application.DB_Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class transaction
    {
        public System.Guid transactionID { get; set; }
        public int providerID { get; set; }
        public string providerNotes { get; set; }
        public int receiverID { get; set; }
        public string receiverNotes { get; set; }
        public Nullable<System.DateTime> date { get; set; }
        public int productID { get; set; }
        public string productDesc { get; set; }
        public string status { get; set; }
        public System.DateTime dateAdded { get; set; }
        public int createdBy { get; set; }
        public Nullable<System.DateTime> dateClosed { get; set; }
        public Nullable<double> nbr { get; set; }
        public Nullable<short> satisfaction { get; set; }
        public int productGateway { get; set; }
    
        public virtual product product { get; set; }
        public virtual user user { get; set; }
        public virtual user provider { get; set; }
        public virtual user receiver { get; set; }
    }
}
