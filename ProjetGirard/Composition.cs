//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetGirard
{
    using System;
    using System.Collections.Generic;
    
    public partial class Composition
    {
        public int NumDossier { get; set; }
        public int CodeOperation { get; set; }
        public Nullable<int> NbUnite { get; set; }
        public Nullable<bool> fini { get; set; }
    
        public virtual Dossier Dossier { get; set; }
        public virtual Operation Operation { get; set; }
    }
}