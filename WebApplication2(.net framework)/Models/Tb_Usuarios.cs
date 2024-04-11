namespace WebApplication2_.net_framework_.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web;

    public partial class Tb_Usuarios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tb_Usuarios()
        {
            Tb_Entrega_Pedidos = new HashSet<Tb_Entrega_Pedidos>();
            Tb_Mensagem = new HashSet<Tb_Mensagem>();
            Tb_Mensagem1 = new HashSet<Tb_Mensagem>();
            Tb_Notificacoes = new HashSet<Tb_Notificacoes>();
            Tb_Pedidos = new HashSet<Tb_Pedidos>();
            Tb_Produtor_Produtos = new HashSet<Tb_Produtor_Produtos>();
            Tb_Transportador = new HashSet<Tb_Transportador>();
            Foto = "~/Content/Imagem/icone-utilisateur-vert.png";
        }

        [Key]
        public int Id_Usuario { get; set; }

        public string Foto { get; set; }

        [StringLength(80)]
        public string Nome { get; set; }

        public int? Id_tipo_Usuario { get; set; }

        [StringLength(40)]
        public string Endereco { get; set; }

        public int? Id_Municipio { get; set; }

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

      

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Entrega_Pedidos> Tb_Entrega_Pedidos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Mensagem> Tb_Mensagem { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Mensagem> Tb_Mensagem1 { get; set; }

        public virtual Tb_Municipios Tb_Municipios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Notificacoes> Tb_Notificacoes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Pedidos> Tb_Pedidos { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Produtor_Produtos> Tb_Produtor_Produtos { get; set; }

        public virtual Tb_tipo_Usuarios Tb_tipo_Usuarios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tb_Transportador> Tb_Transportador { get; set; } 
        
        [NotMapped]
        public HttpPostedFileBase ImageUpload { get; set; }
    }
}
