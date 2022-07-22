namespace MiniWebShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Popust_kodovi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Popust_kodovi()
        {
            Narudzbas = new HashSet<Narudzba>();
        }

        [Key]
        public int Id_popust_kodovi { get; set; }

        [Required]
        [StringLength(10)]
        public string Kod { get; set; }

        public decimal Popust { get; set; }

        public short Iskoristen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narudzba> Narudzbas { get; set; }
    }
}
