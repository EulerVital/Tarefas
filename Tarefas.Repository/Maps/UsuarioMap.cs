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
    public class UsuarioMap : BaseDomainMap<Usuario>
    {
        public UsuarioMap(): base("tb_usuario") { }

        public override void Configure(EntityTypeBuilder<Usuario> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(100).IsRequired();
            builder.Property(x => x.Email).HasColumnName("email").HasMaxLength(300).IsRequired();
            builder.Property(x => x.Senha).HasColumnName("senha").HasMaxLength(100).IsRequired();
        }
    }
}
