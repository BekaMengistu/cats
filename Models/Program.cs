using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cats.Models
{
    public partial class Program
    {
        public Program()
        {
           
        }
        [Key]
        public int ProgramID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LongName { get; set; }
      
    }
}
