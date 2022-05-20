using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace GroupProjLib.Models
{
    public class Resources
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; } 
        public virtual Project Project { get; set; } = null!;
        [StringLength(30)]
        public string Name { get; set; } = null!;
        public int HoursPerDay { get; set; }

    }
}
