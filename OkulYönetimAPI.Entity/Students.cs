using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Entity
{
    public class Students 
    {
        [Key]
        public int ıd { get; set; }

        
        public string studentname { get; set; }
        
        public string studentsurname { get; set; }
        
        public string studentnumber { get; set; }
        
        public string studentschool { get; set; }
    }
}
