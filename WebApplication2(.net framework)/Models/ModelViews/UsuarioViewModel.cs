using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2_.net_framework_.Models.ModelViews
{
    public class UsuarioViewModel
    {

        //public UsuarioViewModel()
        //{
        //    Provincia = CarregarProvincia("");
        //}

    

        public int Id_Provincia { get; set; }

        public int Id_Municipio { get; set; }

        public string Foto { get; set; }

        [StringLength(80)]
        public string Nome { get; set; }

       

        [StringLength(40)]
        public string Endereco { get; set; }

        [StringLength(25)]
        public string Telefone { get; set; }

        [StringLength(25)]
        public string Tel_Secundario { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        public string Biografia { get; set; }
        [StringLength(20, ErrorMessage = "O campo deve ter no máximo 50 caracteres.")]
        [Required(ErrorMessage = "Este campo é obrigatório")]

        public string Username { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [DataType(DataType.Password)]
        [StringLength(10)]
        public string Senha { get; set; }



        //       public List<SelectListItem> CarregarProvincia(string prov)
        //       {
        //           var lista = new List<SelectListItem>();
        //           var provincia = db.Tb_Provincia.ToList();
        //           try
        //           {
        //               foreach (var item in provincia)
        //               {
        //                   var option = new SelectListItem()
        //                   {
        //                       Text = item.Provincia,
        //                       Value = item.Provincia,
        //                       Selected = (item.Provincia == prov)
        //                   };
        //                   lista.Add(option);
        //               }
        //           }
        //           catch (Exception ex)
        //           {
        //               throw;
        //           }
        //return lista;

        //       }
    }
}
