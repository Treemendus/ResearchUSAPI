using System;
using System.ComponentModel.DataAnnotations;

namespace ResearchUSAPI.Models
{
    public class User
    {
        [Key]
        public int user_id {get;set;}
        [Required]
        [MaxLength(100)]
        public string first_name {get;set;}
        [Required]
        [MaxLength(100)]
        public string last_name {get;set;}
        [Required]
        [MaxLength(250)]
        public string email {get;set;}
        [Required]
        public DateTime created_on {get;set;}
        public DateTime? last_login {get;set;}
    }
}