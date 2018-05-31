using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_commerce.Models
{


    [Table("Commande")]
    public partial class Commande
    {
        [Key]
        public int NumCmd { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateCmd { get; set; }

        public int? QteArticle { get; set; }

        public int? NumClient { get; set; }

        public int? NumArticle { get; set; }

        public virtual Article Article { get; set; }

        public virtual Client Client { get; set; }
    }
}