using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Models.ModelConfig
{
    public class LoanTypeConfig : IEntityTypeConfiguration<LoanType>
    {
        public void Configure(EntityTypeBuilder<LoanType> builder)
        {
            builder.Property(m=>m.Id).ValueGeneratedOnAdd();

            builder.Property(m=>m.Name)
                .HasMaxLength(150)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(m => m.Interest)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsRequired();

            builder.Property(m => m.CreatedAt).
                HasColumnType("DateTime")
                .HasComputedColumnSql("GetDate()");
             
        }
    }
}
