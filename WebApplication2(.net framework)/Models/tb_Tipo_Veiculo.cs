namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class tb_Tipo_Veiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tb_Tipo_Veiculo()
        {
            Tb_Transportador = new HashSet<Tb_Transportador>();
        }

        [Key]
        public int Id_Tipo_Veiculo { get; set; }

        [StringLength(80)]
        public string Tipo_Veiculo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Transportador> Tb_Transportador { get; set; }
    }
}
