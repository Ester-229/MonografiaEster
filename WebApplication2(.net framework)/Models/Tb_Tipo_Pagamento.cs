namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Tipo_Pagamento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Tipo_Pagamento()
        {
            Tb_Pagamentos = new HashSet<Tb_Pagamentos>();
        }

        [Key]
        public int ID_Tipo_Pagamento { get; set; }

        [StringLength(15)]
        public string Tipo_Pagamento { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Pagamentos> Tb_Pagamentos { get; set; }
    }
}
