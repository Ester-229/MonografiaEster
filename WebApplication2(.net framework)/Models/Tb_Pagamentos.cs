namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Pagamentos
    {
        [Key]
        public int Id_Pagamento { get; set; }

        public int? Id_Pedido { get; set; }

        public int? ID_Tipo_Pagamento { get; set; }

        public double? Total { get; set; }

        public virtual Tb_Pedidos Tb_Pedidos { get; set; }

        public virtual Tb_Tipo_Pagamento Tb_Tipo_Pagamento { get; set; }
    }
}
