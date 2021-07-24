using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasks_Project.Models.Data
{
    public class StepsRelation
    {
        public int Id { get; set; }
        public virtual Step BigStep { get; set; }
        public virtual Step LittleStep { get; set; }
    }
}
