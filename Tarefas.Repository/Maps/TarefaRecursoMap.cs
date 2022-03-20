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
    public class TarefaRecursoMap : BaseDomainMap<TarefaRecurso>
    {
        public TarefaRecursoMap(): base("tb_tarefa_recurso") { }

        public override void Configure(EntityTypeBuilder<TarefaRecurso> builder)
        {
            base.Configure(builder);

            builder.Property(X => X.Favorito).IsRequired().HasColumnName("favorito").HasDefaultValue(false);
            builder.Property(x => x.RecursoId).IsRequired().HasColumnName("recurso_id");
            builder.Property(x => x.TarefaId).IsRequired().HasColumnName("tarefa_id");

            builder.HasOne(x => x.Tarefa).WithMany().HasForeignKey(x => x.TarefaId);
            builder.HasOne(x => x.Recurso).WithMany().HasForeignKey(x => x.RecursoId);

        }
    }
}
