using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OkulYönetimAPI.Entity
{
    public class Schools
    {
        [Key]
        public int id { get; set; }

        public string schoolname { get; set; }
        public string schooladress { get; set; }
        public int schoolphone { get; set; }


    }
}
