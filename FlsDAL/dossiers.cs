//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlsDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class dossiers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dossiers()
        {
            this.formulaire_act = new HashSet<formulaire_act>();
            this.formulaire_cda = new HashSet<formulaire_cda>();
            this.formulaire_cfp = new HashSet<formulaire_cfp>();
            this.formulaire_ecv = new HashSet<formulaire_ecv>();
            this.formulaire_seo = new HashSet<formulaire_seo>();
            this.formulaire_sfa = new HashSet<formulaire_sfa>();
        }
    
        public int Id { get; set; }
        public int IdMedecinAppelant { get; set; }
        public int IdUser { get; set; }
        public string NumeroAnonymatGlobal { get; set; }
    
        public virtual appelant_medecins appelant_medecins { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_act> formulaire_act { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_cda> formulaire_cda { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_cfp> formulaire_cfp { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_ecv> formulaire_ecv { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_seo> formulaire_seo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<formulaire_sfa> formulaire_sfa { get; set; }
        public virtual global_users global_users { get; set; }
    }
}
