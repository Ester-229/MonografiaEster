using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication2_.net_framework_.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Tb_Area_Actuacao> Tb_Area_Actuacao { get; set; }
        public virtual DbSet<Tb_Categoria> Tb_Categoria { get; set; }
        public virtual DbSet<Tb_Detalhes_Pedidos> Tb_Detalhes_Pedidos { get; set; }
        public virtual DbSet<Tb_Entrega_Pedidos> Tb_Entrega_Pedidos { get; set; }
        public virtual DbSet<Tb_Estado> Tb_Estado { get; set; }
        public virtual DbSet<Tb_Mensagem> Tb_Mensagem { get; set; }
        public virtual DbSet<Tb_Municipios> Tb_Municipios { get; set; }
        public virtual DbSet<Tb_Notificacoes> Tb_Notificacoes { get; set; }
        public virtual DbSet<Tb_Pagamentos> Tb_Pagamentos { get; set; }
        public virtual DbSet<Tb_Pedidos> Tb_Pedidos { get; set; }
        public virtual DbSet<Tb_Produtor_Produtos> Tb_Produtor_Produtos { get; set; }
        public virtual DbSet<Tb_Produtos> Tb_Produtos { get; set; }
        public virtual DbSet<Tb_Provincia> Tb_Provincia { get; set; }
        public virtual DbSet<Tb_status_Pedidos> Tb_status_Pedidos { get; set; }
        public virtual DbSet<Tb_Tipo_Pagamento> Tb_Tipo_Pagamento { get; set; }
        public virtual DbSet<Tb_tipo_Usuarios> Tb_tipo_Usuarios { get; set; }
        public virtual DbSet<tb_Tipo_Veiculo> tb_Tipo_Veiculo { get; set; }
        public virtual DbSet<Tb_Transportador> Tb_Transportador { get; set; }
        public virtual DbSet<Tb_Unidade_de_Medida> Tb_Unidade_de_Medida { get; set; }
        public virtual DbSet<Tb_Usuarios> Tb_Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tb_Area_Actuacao>()
                .Property(e => e.Area_Actuacao)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Categoria>()
                .Property(e => e.Categoria)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Detalhes_Pedidos>()
                .Property(e => e.Unidade)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Entrega_Pedidos>()
                .Property(e => e.endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Entrega_Pedidos>()
                .Property(e => e.Contacto)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Entrega_Pedidos>()
                .Property(e => e.Estado_Entrega)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Estado>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Mensagem>()
                .Property(e => e.Conteudo_Mensagem)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Municipios>()
                .Property(e => e.Municipio)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Notificacoes>()
                .Property(e => e.Notificacão)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Produtor_Produtos>()
                .Property(e => e.ProdutoImg)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Produtor_Produtos>()
                .Property(e => e.Descricao)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Produtor_Produtos>()
                .Property(e => e.Estado)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Produtos>()
                .Property(e => e.Produto)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Produtos>()
                .HasMany(e => e.Tb_Produtor_Produtos)
                .WithOptional(e => e.Tb_Produtos)
                .HasForeignKey(e => e.Id_Produtos);

            modelBuilder.Entity<Tb_Produtos>()
                .HasMany(e => e.Tb_Produtor_Produtos1)
                .WithOptional(e => e.Tb_Produtos1)
                .HasForeignKey(e => e.Id_Produtos);

            modelBuilder.Entity<Tb_Produtos>()
                .HasMany(e => e.Tb_Produtor_Produtos2)
                .WithOptional(e => e.Tb_Produtos2)
                .HasForeignKey(e => e.Id_Produtos);

            modelBuilder.Entity<Tb_Provincia>()
                .Property(e => e.Provincia)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_status_Pedidos>()
                .Property(e => e.status_Pedidos)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Tipo_Pagamento>()
                .Property(e => e.Tipo_Pagamento)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_tipo_Usuarios>()
                .Property(e => e.tipo_Usuario)
                .IsUnicode(false);

            modelBuilder.Entity<tb_Tipo_Veiculo>()
                .Property(e => e.Tipo_Veiculo)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Transportador>()
                .Property(e => e.Imagem)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Unidade_de_Medida>()
                .Property(e => e.Unidade_de_Medida)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Unidade_de_Medida>()
                .HasMany(e => e.Tb_Transportador)
                .WithOptional(e => e.Tb_Unidade_de_Medida)
                .HasForeignKey(e => e.Capacidade_de_Carga);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Foto)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Nome)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Endereco)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Telefone)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Tel_Secundario)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Biografia)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .Property(e => e.Senha)
                .IsUnicode(false);

            modelBuilder.Entity<Tb_Usuarios>()
                .HasMany(e => e.Tb_Entrega_Pedidos)
                .WithOptional(e => e.Tb_Usuarios)
                .HasForeignKey(e => e.Id_Transportador);

            modelBuilder.Entity<Tb_Usuarios>()
                .HasMany(e => e.Tb_Mensagem)
                .WithOptional(e => e.Tb_Usuarios)
                .HasForeignKey(e => e.Destinatario);

            modelBuilder.Entity<Tb_Usuarios>()
                .HasMany(e => e.Tb_Mensagem1)
                .WithOptional(e => e.Tb_Usuarios1)
                .HasForeignKey(e => e.Rementente);

            modelBuilder.Entity<Tb_Usuarios>()
                .HasMany(e => e.Tb_Notificacoes)
                .WithOptional(e => e.Tb_Usuarios)
                .HasForeignKey(e => e.Id_Pessoa);

            modelBuilder.Entity<Tb_Usuarios>()
                .HasMany(e => e.Tb_Pedidos)
                .WithOptional(e => e.Tb_Usuarios)
                .HasForeignKey(e => e.Vendedor);

            modelBuilder.Entity<Tb_Usuarios>()
                .HasMany(e => e.Tb_Produtor_Produtos)
                .WithOptional(e => e.Tb_Usuarios)
                .HasForeignKey(e => e.Id_Produtor);
        }

        public System.Data.Entity.DbSet<WebApplication2_.net_framework_.Models.ModelViews.ProdutoViewModel> ProdutoViewModels { get; set; }
    }
}
