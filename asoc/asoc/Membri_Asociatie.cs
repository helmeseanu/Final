//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace asoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class Membri_Asociatie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Membri_Asociatie()
        {
            this.Apartamente = new HashSet<Apartamente>();
            this.Carduri = new HashSet<Carduri>();
            this.Conturi_de_Utilizator = new HashSet<Conturi_de_Utilizator>();
        }
    
        public int ID { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string Numar_telefon { get; set; }
        public string Emai { get; set; }
        public string Functie { get; set; }
        public System.DateTime Data_Inscriere { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Apartamente> Apartamente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Carduri> Carduri { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conturi_de_Utilizator> Conturi_de_Utilizator { get; set; }
    }
}
