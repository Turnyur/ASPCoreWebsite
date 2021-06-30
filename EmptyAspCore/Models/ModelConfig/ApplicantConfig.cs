using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.Models.ModelConfig
{
    public class ApplicantConfig : IEntityTypeConfiguration<Applicant>
    {
        public void Configure(EntityTypeBuilder<Applicant> builder)
        {
            builder.Property(m=>m.Id).ValueGeneratedNever();

            builder.Property(m=>m.Name)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(m => m.LGA)
                .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(m=>m.State)
                 .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);

            builder.Property(m => m.Address)
                 .IsRequired()
                .HasMaxLength(150)
                .IsUnicode(false);


            builder.Property(m => m.Phone)
                 .IsRequired()
                .HasMaxLength(20)
                .IsUnicode(false);


            builder.Property(m => m.Email)
                 .IsRequired()
                .HasMaxLength(250)
                .IsUnicode(false);



            builder.Property(m => m.Gender)
                 .IsRequired()
                .HasMaxLength(50)
                .IsUnicode(false);


            builder.Property(m => m.BVN)
                 .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false);

            builder.Property(m => m.NIN)
                 .IsRequired()
                .HasMaxLength(11)
                .IsUnicode(false);
          
               


            builder.Property(m => m.CreatedAt)
                .IsRequired()
                .HasColumnType("DateTime")
                .HasComputedColumnSql("GetDate()");

            builder.HasIndex(m => m.BVN).IsUnique();
            builder.HasIndex(m => m.NIN).IsUnique();



            //Configuring the Relationship between Applicant and LoanRequests
            //i.e Applicant has many Loan Request but a Loan Request belongs to an Applicant
            builder.HasMany(m => m.LoanRequests)
                 .WithOne(m => m.Applicant);



           



        }
    }
}
