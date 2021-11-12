using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantCare2._0.Exceptions
{
    internal class DeletionException : Exception
    {
        public string PlantId { get; }
        public DeletionException() { }
        public DeletionException(string message) 
            : base(message) {  }   

        public DeletionException(string message, Exception inner)
            : base(message, inner) {  } 

        public DeletionException(string message, string plantid): this(message)
        {
            PlantId = plantid;
        }
       

    }
}
