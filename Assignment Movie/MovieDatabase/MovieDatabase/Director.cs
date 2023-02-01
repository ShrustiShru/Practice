using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    class Director
    {
        public int DirectorId { get; set; }
        public string DirectorName { get; set; }

        public override string ToString()
        {
            return  $"{DirectorId}   {DirectorName}";
        }
    }
   
}
