namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Produtos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Produtos()
        {
            Tb_Detalhes_Pedidos = new HashSet<Tb_Detalhes_Pedidos>();
            Tb_Produtor_Produtos = new HashSet<Tb_Produtor_Produtos>();
            Tb_Produtor_Produtos1 = new HashSet<Tb_Produtor_Produtos>();
            Tb_Produtor_Produtos2 = new HashSet<Tb_Produtor_Produtos>();
        }

        [Key]
        public int Id_Produto { get; set; }

        [StringLength(60)]
        public string Produto { get; set; }

        public int? Id_Categoria { get; set; }

        public DateTime? Data_Pedido { get; set; }

        public virtual Tb_Categoria Tb_Categoria { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Detalhes_Pedidos> Tb_Detalhes_Pedidos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Produtor_Produtos> Tb_Produtor_Produtos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Produtor_Produtos> Tb_Produtor_Produtos1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Produtor_Produtos> Tb_Produtor_Produtos2 { get; set; }
    }
}
