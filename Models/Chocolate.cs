using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW3.Models
{
    public class Chocolate : Sweet
    {
        public ChocolateType TypeChocolate { get; set; }

        public override object Clone()
        {
            return new Chocolate
            {
                Name = Name,
                Price = Price,
                Weight = Weight,
                TypeChocolate = TypeChocolate
            };
        }
    }
}
