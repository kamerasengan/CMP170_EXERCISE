namespace FinalProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        public int ID { get; set; }

        [Required]
        [StringLength(200)]
        public string Tittle { get; set; }

        [Required]
        [StringLength(200)]
        public string Author { get; set; }

        [Required]
        [StringLength(200)]
        public string Publisher { get; set; }

        public int TypeID { get; set; }

        public int Pages { get; set; }

        public double Rate { get; set; }

        public virtual BookType BookType { get; set; }
    }
}
