namespace MiniWebShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Proizvod")]
    public partial class Proizvod
    {
        [Key]
        public int Id_proizvod { get; set; }

        [Required]
        [StringLength(30)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(30)]
        public string Opis { get; set; }

        public decimal Cijena { get; set; }

        public int Kolicina { get; set; }

        public int Brand_id { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual Narudzba_proizvodi Narudzba_proizvodi { get; set; }
    }
}
