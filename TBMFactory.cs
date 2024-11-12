using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{
    /// <summary>
    /// A factory class which creates Tactical Ballistic Missiles (TBM) with a particular stat
    /// </summary>
    internal class TBMFactory : IWeaponFactory
    {
        /// <summary>
        /// All the stats a tactical ballistic missile uses
        /// </summary>
        public string Name {  get; set; }
        public ulong Quantity {  get; set; }
        public double Mass {  get; set; }
        public double Payload {  get; set; }
        public double Diameter {  get; set; }
        public double Range {  get; set; }
        public double CEP { get; set; }
        
        /// <summary>
        /// Constructor, which takes all the stats we need to produce TBMs from
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="mass"></param>
        /// <param name="payload"></param>
        /// <param name="diameter"></param>
        /// <param name="range"></param>
        public TBMFactory(string name, ulong quantity, double mass, double payload, double diameter,double range,double cep)
        {
            Name = name;
            Quantity = quantity;
            Mass = mass;
            Payload = payload;
            Diameter = diameter;
            Range = range;
            CEP = cep;
        }

        /// <summary>
        /// Produce the thing this factory makes, in our case: Tactical Ballistic Missiles with the spec we produce
        /// </summary>
        /// <returns>IAmmunition, which in this case refers to a TBM</returns>
        public IAmmunition CreateAmmunition()
        {
            return new TBM(Name, Quantity, Mass, Payload, Diameter,Range,CEP);
        }
    }
}
