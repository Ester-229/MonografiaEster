namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Unidade_de_Medida
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Unidade_de_Medida()
        {
            Tb_Produtor_Produtos = new HashSet<Tb_Produtor_Produtos>();
            Tb_Transportador = new HashSet<Tb_Transportador>();
        }

        [Key]
        public int Id_Unidade { get; set; }

        [StringLength(80)]
        public string Unidade_de_Medida { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Produtor_Produtos> Tb_Produtor_Produtos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Transportador> Tb_Transportador { get; set; }
    }
}
