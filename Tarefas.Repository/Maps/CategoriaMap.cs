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
    public class CategoriaMap : BaseDomainMap<Categoria>
    {
        public CategoriaMap(): base("tb_categoria") { }

        public override void Configure(EntityTypeBuilder<Categoria> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("descricao").HasMaxLength(300);
        }
    }
}
