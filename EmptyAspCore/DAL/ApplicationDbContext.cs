using EmptyAspCore.Models;
using EmptyAspCore.Models.ModelConfig;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmptyAspCore.DAL
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<LoanType> LoanTypes { get; set; }
        public DbSet<LoanRequest> LoanRequests { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        

        public ApplicationDbContext(DbContextOptions options)
           : base(options)
        {
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new LoanTypeConfig());
            modelBuilder.ApplyConfiguration(new LoanRequestConfig());
            modelBuilder.ApplyConfiguration(new ApplicantConfig());
        


        }

        
        public DbSet<EmptyAspCore.Models.Person> Person { get; set; }
        
    }
}
