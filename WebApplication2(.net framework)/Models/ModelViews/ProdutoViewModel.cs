using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApplication2_.net_framework_.Models.ModelViews
{
    public class ProdutoViewModel
    {
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
        public ProdutoViewModel()
        {
            ProdutoImg = "~/Content/Imagens/icone-utilisateur.png";
        }

        [Key] public int ID_Produtor_Produtos { get; set; }
        public int Id_Categoria { get; set; }

        public int Id_Produtos { get; set; }

        public string ProdutoImg { get; set; }

        public int? Id_Produtor { get; set; }

        public double? Preco { get; set; }

        public int? Quantidade_Disponiveis { get; set; }

        public int? Id_Unidade { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        [StringLength(15)]
        public string Estado { get; set; }


    }
}