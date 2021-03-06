namespace MyBlogSite.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanici")]
    public partial class Kullanici
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanici()
        {
            KullaniciRol = new HashSet<KullaniciRol>();
            Makale = new HashSet<Makale>();
        }

        public int KullaniciID { get; set; }

        [Required]
        [StringLength(50)]
        public string AdiSoyadi { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAdi { get; set; }

        [StringLength(200)]
        public string Parola { get; set; }

        [StringLength(50)]
        public string MailAdres { get; set; }

        public bool? Cinsiyet { get; set; }

        public DateTime? DogumTarihi { get; set; }

        public DateTime KayitTarihi { get; set; }

        public int? ResimID { get; set; }

        public bool? Onaylandi { get; set; }

        public bool? Aktif { get; set; }

        public virtual Resim Resim { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KullaniciRol> KullaniciRol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Makale> Makale { get; set; }
    }
}
