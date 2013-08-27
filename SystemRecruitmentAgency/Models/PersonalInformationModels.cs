using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemRecruitmentAgency.Models
{



    public class ApplicationsSystem : DbContext
    {
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Technology> Technologies { get; set; }
    }


     [Table("Applicant")]
    public class Applicant
    {

        public string Firstname { get; set; }
        public string Surname {get;set;}
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int AppId { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string TotalScore { get; set; }
        
    }



     [Table("Answer")]
     public class Answer
     {

         public string AppId { get; set; }
         public int TechId { get; set; }
         public int Score { get; set; }
         [Key]
         [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
         public int AnsId { get; set; }

     }



     [Table("Technology")]
     public class Technology
     {

         public string CategoryName { get; set; }
         public string Description { get; set; }
         [Key]
         [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
         public int TechId { get; set; }
     }



}