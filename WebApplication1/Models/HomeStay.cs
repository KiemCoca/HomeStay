//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HomeStay
    {
        public int ID_HomeStay { get; set; }
        public string Name { get; set; }
        public string Summary { get; set; }
        public Nullable<int> IDLocation { get; set; }
        public Nullable<decimal> Price { get; set; }
        public string Adress { get; set; }
        public Nullable<int> Sale { get; set; }
        public string Description { get; set; }
        public string TypeHourse { get; set; }
        public Nullable<int> Baths { get; set; }
        public Nullable<int> Beds { get; set; }
        public Nullable<int> Garages { get; set; }
    }
}
