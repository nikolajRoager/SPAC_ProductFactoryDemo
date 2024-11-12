using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{
    /// <summary>
    /// In this example, the products are all ammunition
    /// 
    /// In this example, all products have a Name, Quantity, and Mass, payload, and Diameter
    /// </summary>
    internal interface IAmmunition
    {
        string Name { get; set; }
        ulong Quantity { get; set; }
        double Mass { get; set; }
        double Payload { get; set; }
        double Diameter {  get; set; }

        public string ToString();
    }
}
