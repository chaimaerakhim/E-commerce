using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{


    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Commandes = new HashSet<Commande>();
        }

        [Key]
        public int NumClient { get; set; }

        [StringLength(100)]
        public string Login { get; set; }

        [StringLength(100)]
        public string MptPass { get; set; }

        [StringLength(20)]
        public string Nom { get; set; }

        [StringLength(20)]
        public string Prenom { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(20)]
        public string Ville { get; set; }

        [StringLength(20)]
        public string Tel { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Commande> Commandes { get; set; }
    }
}