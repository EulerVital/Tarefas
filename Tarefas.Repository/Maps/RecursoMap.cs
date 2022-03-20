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
    public class RecursoMap : BaseDomainMap<Recurso>
    {
        public RecursoMap(): base("tb_recurso") { }

        public override void Configure(EntityTypeBuilder<Recurso> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Recursos).HasColumnName("tipo_recurso").IsRequired();
            builder.Property(x => x.Descricao).HasColumnName("descricao");
        }
    }
}
