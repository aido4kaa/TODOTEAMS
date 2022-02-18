using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Data.Models
{
    public class Plan
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("PlansFK")]
        public int IdUser { get; set; }
        public string Title { get; set; }
        public List<User> Teammates { get; set; }
        
        public bool Complited { get; set; }
    }
}
