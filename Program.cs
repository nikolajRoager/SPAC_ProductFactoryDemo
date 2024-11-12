using ProductFactoryDemo;

class Program
{
    /// <summary>
    /// A demonstration program, which reads products from the arguments, and uses factories to fill a warehouse
    /// 
    /// In this example, the products are all ammunition
    /// 
    /// As a demonstration, I allow 3 products:
    /// ArtilleryShell (no additional information)
    /// TBM with range and CEP
    /// CruiseMissile range, and guidance (an enum)
    /// 
    /// As a demonstration I make a list of factories, and give it to a function which does something (prints everything)
    /// The print function does not know what it is being asked to print, only that it comes from a factory
    /// 
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {

        List<IWeaponFactory> factories = new List<IWeaponFactory> {
        new TBMFactory( "ATACMS",5,1670,214,610,250,9),
        new CruiseMissileFactory( "AIM-120 Amraam",200,161.5,20,178,160,CruiseMissile.GuidanceType.RadarHoming),
        new ShellFactory("M107",1000,43.2,6.8256,155),
        new ShellFactory("M795",500,47,10.8,155)
        };

        //As a demonstration, make a list of factories for different products based on inputs

        //Pass the list of factories to a printing function, we could also pass it to any other function or class, all that function needs to do is depend on the IFactory and IAmmunition
        Arsenal arsenal=new Arsenal(factories);
        arsenal.Print();
    }
}
