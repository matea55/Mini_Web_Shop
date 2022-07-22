namespace MiniWebShop.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Narudzba_proizvodi
    {
        [Key]
        public int Id_narudzba_proizvodi { get; set; }

        public int Narudzba_id { get; set; }

        public int Proizvod_id { get; set; }

        public virtual Narudzba Narudzba { get; set; }

        public virtual Proizvod Proizvod { get; set; }
    }
}
