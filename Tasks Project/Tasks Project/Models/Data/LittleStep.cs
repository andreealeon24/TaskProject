using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks_Project.Models.Data
{
    public class LittleStep
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Owner { get; set; }
        public virtual Step Step { get; set; }
    }
}
