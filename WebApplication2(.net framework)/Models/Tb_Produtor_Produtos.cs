namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class Tb_Produtor_Produtos
    {
        public Tb_Produtor_Produtos()
        {
            ProdutoImg = "~/Content/Imagem/icone-utilisateur-vert.png";
        }
        [Key] public int ID_Produtor_Produtos { get; set; }

        public string ProdutoImg { get; set; }

        public int? Id_Produtos { get; set; }

        public int? Id_Produtor { get; set; }

        public double? Preco { get; set; }

        public int? Quantidade_Disponiveis { get; set; }

        public int? Id_Unidade { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        [StringLength(15)]
        public string Estado { get; set; }

        public DateTime? Data_Criacao { get; set; }

        public virtual Tb_Usuarios Tb_Usuarios { get; set; }

        public virtual Tb_Produtos Tb_Produtos { get; set; }

        public virtual Tb_Produtos Tb_Produtos1 { get; set; }

        public virtual Tb_Produtos Tb_Produtos2 { get; set; }

        public virtual Tb_Unidade_de_Medida Tb_Unidade_de_Medida { get; set; }

        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
