using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entities
{
    public class RMagzineDTO
    {
        public string name { get; set; }
        public string file { get; set; }
        public string category { get; set; }
    }
    public class MagzineDTO
    {
        public string category { get; set; }
        public List<SMagzineDTO> dtos {get;set;}
    }
    public class SMagzineDTO
    {
        public string name { get; set; }
        public string file { get; set; }
    }
}
