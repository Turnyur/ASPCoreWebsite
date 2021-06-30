using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Models.ModelConfig
{
    public class LoanRequestConfig : IEntityTypeConfiguration<LoanRequest>
    {
        public void Configure(EntityTypeBuilder<LoanRequest> builder)
        {
            builder.Property(m=>m.Id).ValueGeneratedNever();

            builder.Property(m=>m.Amount)
                .IsRequired();


            builder.Property(m => m.RequestDate)
                .IsRequired()
                .HasColumnType("DateTime")
                .HasComputedColumnSql("GetDate()");

            builder.Property(m => m.LoanStatus).HasDefaultValue("pending");

            //Configures Relationship between LoanRequest and LoanType
            builder.HasOne(m => m.LoanType);



           



        }
    }
}
