//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FormotsDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class dossiers1
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dossiers1()
        {
            this.formulaire_act = new HashSet<formulaire_act1>();
            this.formulaire_cda = new HashSet<formulaire_cda1>();
            this.formulaire_cfp = new HashSet<formulaire_cfp1>();
            this.formulaire_ecv = new HashSet<formulaire_ecv1>();
            this.formulaire_seo = new HashSet<formulaire_seo1>();
            this.formulaire_sfa = new HashSet<formulaire_sfa1>();
        }
    
        public int Id { get; set; }
        public int IdMedecinAppelant { get; set; }
        public string NumeroAnonymatGlobal { get; set; }
    
        public virtual appelant_medecins1 appelant_medecins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_act1> formulaire_act { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_cda1> formulaire_cda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_cfp1> formulaire_cfp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_ecv1> formulaire_ecv { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_seo1> formulaire_seo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_sfa1> formulaire_sfa { get; set; }
    }
}