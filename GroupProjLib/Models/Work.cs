using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupProjLib.Models
{
    public class Work
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public virtual Project Project { get; set; } = null!;
        public int ResourceId { get; set; }
        public virtual Resources Resources { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int Hours { get; set; } = 0;

    }
}
