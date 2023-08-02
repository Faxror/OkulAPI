using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Entity
{
    public class School 
    {
        [Key]
        public int ıd { get; set; }
        public string schoolname { get; set; }
    }
}
