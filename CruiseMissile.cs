using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{
    /// <summary>
    /// A class for all types of cruise missiles, it is intended to include any type of Cruise missiles
    /// Includes both V1, Oniks, Amraam and more
    /// </summary>
    internal class CruiseMissile : IAmmunition
    {
        public string Name {  get; set; }
        public ulong Quantity {  get; set; }
        public double Mass {  get; set; }
        public double Payload {  get; set; }
        public double Diameter {  get; set; }
        public double Range {  get; set; }

        public enum GuidanceType {Unguided,RadarHoming,Heatseaking}
        public GuidanceType Guidance { get; set; }

        public override string ToString()
        {
            return $"A batch of {Quantity} {Guidance} Cruise Missiles, of type {Name} each weighing {Mass} kg, with a {Payload} kg payload, and a Diameter of {Diameter} cm, and a range {Range}"; 
        }



        public CruiseMissile(string name, ulong quantity, double mass, double payload, double diameter,double range,GuidanceType guidance)
        {
            Name     = name;
            Quantity = quantity;
            Mass     = mass;
            Payload  = payload;
            Diameter = diameter;
            Range    = range;
            Guidance = guidance;
        }
    }
}
