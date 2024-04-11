namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Municipios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Municipios()
        {
            Tb_Usuarios = new HashSet<Tb_Usuarios>();
        }

        [Key]
        public int Id_Municipio { get; set; }

        [StringLength(80)]
        public string Municipio { get; set; }

        public int? Id_Provincia { get; set; }

        public virtual Tb_Provincia Tb_Provincia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Usuarios> Tb_Usuarios { get; set; }
    }
}
