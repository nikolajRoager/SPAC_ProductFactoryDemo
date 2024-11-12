using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{

    /// <summary>
    /// A factory class, which produced Shells, and returns them as an IWeapon
    /// </summary>
    internal class ShellFactory : IWeaponFactory
    {
        /// <summary>
        /// All the basic stats, which will get copied unto every one of the Shells we return
        /// </summary>
        public string Name {  get; set; }
        public ulong Quantity {  get; set; }
        public double Mass {  get; set; }
        public double Payload {  get; set; }
        public double Diameter {  get; set; }

        /// <summary>
        /// Configure the factory to produce exactly this kind of shells
        /// </summary>
        /// <param name="name"></param>
        /// <param name="quantity"></param>
        /// <param name="mass"></param>
        /// <param name="payload"></param>
        /// <param name="diameter"></param>
        public ShellFactory(string name, ulong quantity, double mass, double payload, double diameter)
        {
            Name = name;
            Quantity = quantity;
            Mass = mass;
            Payload = payload;
            Diameter = diameter;
        }

        /// <summary>
        /// Return an IAmmunition, in this case refering to a shell, with the specs of a shell we are set up to produce
        /// </summary>
        /// <returns>IAmmunition, refering to a Shell</returns>
        public IAmmunition CreateAmmunition()
        {
            return new Shell(Name, Quantity, Mass, Payload, Diameter);
        }
    }
}
