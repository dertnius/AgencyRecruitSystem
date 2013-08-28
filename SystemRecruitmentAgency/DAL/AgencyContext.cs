using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SystemRecruitmentAgency.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions; 

namespace SystemRecruitmentAgency.DAL
{
    public class AgencyContext:DbContext 
    {

            public DbSet<Applicant> Applicants { get; set; }
            public DbSet<Answer> Answers { get; set; }
            public DbSet<Technology> Technologies { get; set; }
      
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}

