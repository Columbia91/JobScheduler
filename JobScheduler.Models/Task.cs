using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobScheduler.Models
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime FirstStart { get; set; }
        public DateTime NextStart { get; set; }
        public string Type { get; set; }
        public string Period { get; set; }
        public bool OperationResult { get; set; } = true;
    }
}
