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
    
    public partial class formulaire_sfa
    {
        public int Id { get; set; }
        public int IdDossier { get; set; }
        public Nullable<System.DateTime> DtCreation { get; set; }
        public Nullable<System.DateTime> DateBilanSynthese { get; set; }
        public Nullable<int> DureeJourDepuis1ErContact { get; set; }
        public Nullable<int> NombreEntretiensDepuis1ErContact { get; set; }
        public Nullable<double> TempsTotalEnEntretiens { get; set; }
        public string OrientationsMisesEnOeuvre { get; set; }
        public string OrientationsMisesEnOeuvreAutre { get; set; }
        public string OrientationsIdentifiees1ErEntretien { get; set; }
        public string CommentairesLibres { get; set; }
    
        public virtual dossiers dossiers { get; set; }
    }
}
