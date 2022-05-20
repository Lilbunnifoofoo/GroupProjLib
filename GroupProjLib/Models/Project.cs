using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GroupProjLib.Models {
    public class Project {

        public int Id { get; set; }
        [StringLength(80)]
        public string description { get; set; } = null!;
        public int estimatedHours { get; set; } = 0;
        public int actualHours { get; set; } = 0;
        public string status { get; set; } = null!;

    }
}
