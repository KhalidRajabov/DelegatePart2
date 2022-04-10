using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePart2.Models
{
    interface IEntity
    {    
        protected static int Id { get; set; }

        public void ShowInfo();
    }
}
