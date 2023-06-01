using System;

namespace Module2HW3.Models
{
    public abstract class Sweet : ICloneable
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public double Price { get; set; }

        public abstract object Clone();
    }
}
