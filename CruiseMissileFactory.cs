using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{
    /// <summary>
    /// A factory class which creates Cruise Missiles with some stats, it also has guidance system and range, which doesn't make sense for other types of ammunition
    /// </summary>
    internal class CruiseMissileFactory : IWeaponFactory
    {
        public string Name {  get; set; }
        public ulong Quantity {  get; set; }
        public double Mass {  get; set; }
        public double Payload {  get; set; }
        public double Diameter {  get; set; }
        public double Range {  get; set; }
        public CruiseMissile.GuidanceType Guidance { get; set; }

        /// <summary>
        /// Configure the production-line, using all the parameters a cruise missile needs
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="mass"></param>
        /// <param name="payload"></param>
        /// <param name="diameter"></param>
        /// <param name="range"></param>
        /// <param name="guidance"></param>
        public CruiseMissileFactory(string name, ulong quantity, double mass, double payload, double diameter,double range,CruiseMissile.GuidanceType guidance)
        {
            Name     = name;
            Quantity = quantity;
            Mass     = mass;
            Payload  = payload;
            Diameter = diameter;
            Range    = range;
            Guidance = guidance;
        }

        /// <summary>
        /// Produce the thing this factory makes, in our case: Cruise missiles with the spec we produce
        /// </summary>
        /// <returns>IAmmunition, which in this case refers to a cruise missile</returns>
        public IAmmunition CreateAmmunition()
        {
            return new CruiseMissile(Name, Quantity, Mass, Payload, Diameter, Range, Guidance);
        }
    }
}
