namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Detalhes_Pedidos
    {
        [Key]
        public int Id_Detalhes_Pedidos { get; set; }

        public int? Id_Pedido { get; set; }

        public int? Id_Produto { get; set; }

        public int? Quantidade { get; set; }

        [StringLength(50)]
        public string Unidade { get; set; }

        public double? Total { get; set; }

        public virtual Tb_Pedidos Tb_Pedidos { get; set; }

        public virtual Tb_Produtos Tb_Produtos { get; set; }
    }
}
