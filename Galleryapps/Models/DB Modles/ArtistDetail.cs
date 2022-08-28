namespace Galleryapps.Models.DB_Modles
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ArtistDetail
    {
        public int Id { get; set; }

        [Required]
        [StringLength(10)]
        public string Fristname { get; set; }

        [StringLength(10)]
        public string Middlename { get; set; }

        [Required]
        [StringLength(10)]
        public string Lastname { get; set; }

        [Required]
        [StringLength(10)]
        public string Address { get; set; }

        public DateTime RegDate { get; set; }
    }
}
