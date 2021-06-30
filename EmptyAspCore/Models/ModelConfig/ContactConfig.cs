using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Models.ModelConfig
{
    public class ContactConfig : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(m=>m.Id).ValueGeneratedNever();

            builder.Property(m=>m.Email)
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(m=>m.Name)
                .HasMaxLength(100)
                .IsUnicode(false); ;
        }
    }
}
