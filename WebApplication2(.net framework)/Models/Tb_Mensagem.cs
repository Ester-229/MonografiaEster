namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Mensagem
    {
        public int Id { get; set; }

        public int? Rementente { get; set; }

        public int? Destinatario { get; set; }

        public string Conteudo_Mensagem { get; set; }

        public DateTime? Data_Pedido { get; set; }

        public virtual Tb_Usuarios Tb_Usuarios { get; set; }

        public virtual Tb_Usuarios Tb_Usuarios1 { get; set; }
    }
}
