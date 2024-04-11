namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class Tb_Transportador
    {
        public Tb_Transportador()
        {
            Imagem = "~/Content/Imagem/icone-utilisateur-vert.png";
        }

        [Key] public int Id_Transportador { get; set; }

        public int? Id_Tipo_Veiculo { get; set; }

        public int? Id_Area_Actuacao { get; set; }

        public int? Capacidade_de_Carga { get; set; }

        public double? Preco { get; set; }

        public string Imagem { get; set; }

        public int? Id_Usuario { get; set; }

        public int? Id_Estado { get; set; }

        public virtual Tb_Area_Actuacao Tb_Area_Actuacao { get; set; }

        public virtual Tb_Estado Tb_Estado { get; set; }

        public virtual tb_Tipo_Veiculo tb_Tipo_Veiculo { get; set; }

        public virtual Tb_Unidade_de_Medida Tb_Unidade_de_Medida { get; set; }

        public virtual Tb_Usuarios Tb_Usuarios { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
