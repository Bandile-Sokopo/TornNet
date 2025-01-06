using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Benefit
    {
        public int Id {get; set;}
        public required string Type {get; set;}
        public int Frequency {get; set;}
        public int Requirement {get; set;}
        public required string Description {get; set;}
    }
}