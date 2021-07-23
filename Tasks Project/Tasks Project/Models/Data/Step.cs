using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Tasks_Project.Models.Data;

namespace Tasks_Project.Models
{
    public class Step
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(30)")]
        public string Owner { get; set; }
        public virtual Task Task { get; set; }
        public List<LittleStep> LittleSteps { get; set; }
    }
}
