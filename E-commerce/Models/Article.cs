using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{

    [Table("Article")]
    public partial class Article
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Article()
        {
            Commandes = new HashSet<Commande>();
        }

        [Key]
        public int NumArticle { get; set; }

        [StringLength(100)]
        public string Designation { get; set; }

        public int? PrixU { get; set; }

        public int? Stock { get; set; }

        [StringLength(100)]
        public string Photo { get; set; }

        public int? RefCat { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commandes { get; set; }

        public virtual Categorie Categorie { get; set; }
    }
}