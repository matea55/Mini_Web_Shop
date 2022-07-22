namespace MiniWebShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Narudzba")]
    public partial class Narudzba
    {
        [Key]
        public int ID_narudzba { get; set; }

        public DateTime Datum { get; set; }

        public decimal Ukupna_cijena_bez_p { get; set; }

        public decimal Ukupna_cijena_s_p { get; set; }

        public int Kod_za_popust_id { get; set; }

        public int Nacin_placanja_id { get; set; }

        [Required]
        [StringLength(10)]
        public string Broj_kartice { get; set; }

        [Required]
        [StringLength(30)]
        public string Email { get; set; }

        public int Broj_mobitela { get; set; }

        [Required]
        [StringLength(30)]
        public string Adresa_dostave { get; set; }

        [Required]
        [StringLength(30)]
        public string Napomena { get; set; }

        public virtual Nacin_placanja Nacin_placanja { get; set; }

        public virtual Popust_kodovi Popust_kodovi { get; set; }

        public virtual Narudzba_proizvodi Narudzba_proizvodi { get; set; }
    }
}
