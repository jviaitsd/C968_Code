using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PerformanceAssessment
{

    public abstract class Part
    {
        public int PartId { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
