using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Benefit
    {
        public required string Type;
        public int Frequency;
        public int Requirement;
        public decimal Description;
    }
}