using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{

    /// <summary>
    /// A basic type of ammunition, which doesn't add anything specific to it
    /// This includes all types of shells
    /// </summary>
    internal class Shell : IAmmunition
    {
        public string Name {  get; set; }
        public ulong Quantity {  get; set; }
        public double Mass {  get; set; }
        public double Payload {  get; set; }
        public double Diameter {  get; set; }

        public Shell(string name, ulong quantity, double mass, double payload, double diameter)
        {
            Name = name;
            Quantity = quantity;
            Mass = mass;
            Payload = payload;
            Diameter = diameter;
        }

        public override string ToString()
        {
            return $"A batch of {Quantity} artillery shells, of type {Name} each weighing {Mass} kg, with a {Payload} kg payload, and a Caliber of {Diameter} mm"; 
        }
    }
}
