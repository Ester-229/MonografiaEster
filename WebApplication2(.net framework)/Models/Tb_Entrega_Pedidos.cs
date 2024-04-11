namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Entrega_Pedidos
    {
        public int Id { get; set; }

        public int? Id_Transportador { get; set; }

        public int? Id_Pedido { get; set; }

        [StringLength(100)]
        public string endereco { get; set; }

        [StringLength(30)]
        public string Contacto { get; set; }

        public DateTime? Data_Hora { get; set; }

        [StringLength(25)]
        public string Estado_Entrega { get; set; }

        public virtual Tb_Pedidos Tb_Pedidos { get; set; }

        public virtual Tb_Usuarios Tb_Usuarios { get; set; }
    }
}
