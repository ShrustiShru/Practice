using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieDatabase
{
    class Actor
    {
        public int ActorId { get; set; }
        public string ActorName { get; set; }
        public int ActorAge { get; set; }

        public override string ToString()
        {
            return $"{ActorId}   {ActorName}   {ActorAge}";
        }
    }
}
