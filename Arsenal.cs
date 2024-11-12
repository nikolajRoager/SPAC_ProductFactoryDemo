using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{
    /// <summary>
    /// A demonstration class for containing stuff, it reads a list of factories, and asks the factories to fill the list of ammunition
    /// AT NO POINT does the Arsenal care or know about the things stored here, it only knows it implements the Ammunition interface
    /// </summary>
    internal class Arsenal
    {
        IList<IAmmunition> Ammunitions { get; set; }

        /// <summary>
        /// Read all factories, and get all ammunition from these factories
        /// </summary>
        /// <param name="factories"></param>
        public Arsenal(IEnumerable<IWeaponFactory> factories)
        {
            Ammunitions = factories.Select((f)=>f.CreateAmmunition()).ToList();
        }

        /// <summary>
        /// Show that things are working by printing everything
        /// </summary>
        public void Print()
        {
        Console.WriteLine("The arsenal contains:");
            foreach (var Weapon in Ammunitions)
                Console.WriteLine($"\t{Weapon}");
        }
    }
}
