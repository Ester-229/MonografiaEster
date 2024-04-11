namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Tb_Notificacoes
    {
        public int Id { get; set; }

        public int? Id_Pessoa { get; set; }

        public string Notificacão { get; set; }

        public DateTime? Data_Hora { get; set; }

        public virtual Tb_Usuarios Tb_Usuarios { get; set; }
    }
}
