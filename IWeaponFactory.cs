using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductFactoryDemo
{
    //Makes any type of ammunition
    internal interface IWeaponFactory
    {
        public IAmmunition CreateAmmunition();
    }
}
