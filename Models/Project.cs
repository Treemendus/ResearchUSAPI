using System;
using System.ComponentModel.DataAnnotations;

namespace ResearchUSAPI.Models
{
    public class Project
    {
        [Key]
        public int id {get;set;}
        [Required]
        [MaxLength(250)]
        public string name {get;set;}
        [Required]
        public string description {get;set;}
        [Required]
        public DateTime created_on {get;set;}
    }
}