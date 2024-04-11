namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Pedidos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Pedidos()
        {
            Tb_Detalhes_Pedidos = new HashSet<Tb_Detalhes_Pedidos>();
            Tb_Entrega_Pedidos = new HashSet<Tb_Entrega_Pedidos>();
            Tb_Pagamentos = new HashSet<Tb_Pagamentos>();
        }

        [Key]
        public int Id_Pedido { get; set; }

        public int? Comprador { get; set; }

        public int? Vendedor { get; set; }

        public double? Total { get; set; }

        public int? ID_status { get; set; }

        public DateTime? Data_Pedido { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Detalhes_Pedidos> Tb_Detalhes_Pedidos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Entrega_Pedidos> Tb_Entrega_Pedidos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Pagamentos> Tb_Pagamentos { get; set; }

        public virtual Tb_status_Pedidos Tb_status_Pedidos { get; set; }

        public virtual Tb_Usuarios Tb_Usuarios { get; set; }
    }
}
