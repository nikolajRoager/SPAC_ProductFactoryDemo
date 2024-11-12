using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{
    /// <summary>
    /// Any shipment, of some type of tactical ballistic missile
    /// This is intended as a broad  class of any TBMs, for instance both Iskander and ATACMS would be classified in this class
    /// The class includes range and circular error propable (CEP), which doesn't make sense for other types of ammunition like shells
    /// </summary>
    internal class TBM : IAmmunition
    {
        /// <summary>
        /// Mostly inherited data, but range is new
        /// </summary>
        public string Name {  get; set; }
        public ulong Quantity {  get; set; }
        public double Mass {  get; set; }
        public double Payload {  get; set; }
        public double Diameter {  get; set; }
        public double Range {  get; set; }
        public double CEP { get; set; }


        /// <summary>
        /// To check that this works, return a string with our stats
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"A batch of {Quantity} Tactical Ballistic Missiles, of type {Name} each weighing {Mass} kg, with a {Payload} kg payload, and a Diameter of {Diameter} mm, a range {Range} km, and CEP {CEP} m"; 
        }

        /// <summary>
        /// Constructor, sets all data
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="mass"></param>
        /// <param name="payload"></param>
        /// <param name="diameter"></param>
        /// <param name="range"></param>

        public TBM(string name, ulong quantity, double mass, double payload, double diameter,double range,double cep)
        {
            Name = name;
            Quantity = quantity;
            Mass = mass;
            Payload = payload;
            Diameter = diameter;
            Range = range;
            CEP = cep;
        }
    }
}
