using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarefas.Domain;

namespace Tarefas.Repository.Maps
{
    public class TarefaMap : BaseDomainMap<Tarefa>
    {
        public TarefaMap(): base("tb_tarefa") { }

        public override void Configure(EntityTypeBuilder<Tarefa> builder)
        {
            base.Configure(builder);

            //1 para muitos
            builder.Property(x => x.CategoriaId).HasColumnName("categoria_id").IsRequired();
            builder.HasOne(x => x.Categoria).WithMany().HasForeignKey(x => x.CategoriaId);
            builder.Property(x => x.UsuarioId).HasColumnName("usuario_id").IsRequired();
            builder.HasOne(x => x.Usuario).WithMany().HasForeignKey(x => x.UsuarioId);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Descricao).HasMaxLength(300).HasColumnName("descricao");
        }
    }
}
