using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using SystemRecruitmentAgency.DAL;

namespace SystemRecruitmentAgency.Models
{


   

     [Table("Applicant")]
    public class Applicant
    {
      
        public string Firstname { get; set; }
        public string Surname {get;set;}
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ApplicantId { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public string TotalScore { get; set; }
        public string Position { get; set; }
     
    }



     [Table("Answer")]
     public class Answer
     {

         public string ApplicantId { get; set; }
         public int TechnologyId { get; set; }
         public int Score { get; set; }
         [Key]
         [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
         public int AnswerId { get; set; }

     }



     [Table("Technology")]
     public class Technology
     {
         [Key]
         [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
         public int TechnologyId { get; set; }
         public string Name { get; set; }
         public string Description { get; set; }
         public string Category {get;set;}
   
     }



}