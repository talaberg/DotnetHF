namespace NyilvLib.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nyilv_db.dokumentumok")]
    public partial class dokumentumok
    {
        public int CegID { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DokumentumID { get; set; }

        [StringLength(50)]
        public string Dokumentum_tipus { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        [StringLength(1023)]
        public string Megjegyzes { get; set; }
    }
}
