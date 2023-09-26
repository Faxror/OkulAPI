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

        public string aappointedteachers { get; set; }

        public string studentsclassnumber { get; set; }

        public string studentslevel { get; set; }

        public string examnotesone { get; set; }
        public string examnotestwo { get; set; }
        public string examnotesthree { get; set; }
        public string examnotestfour { get; set; }
        public string homeworks { get; set; }
        public int IdentıtyNumber { get; set; }
        public int StudentsPassword { get; set; }

      

    }
}
