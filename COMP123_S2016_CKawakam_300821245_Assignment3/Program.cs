using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * This is driver class
 * Author:Chinatsu Kawakami
 * Date:17th June 2016
 * Date Modified:21th June 2016
 * Student ID:300821245
 * Description:This program calls instance variables from Planet(abstract class),GiantPlanet,and TerrestrialPlanet class
 * and print ToString of GiantPlanet,ToString of TerrestrialPlanet, interface of IHasRings,IHasMoons,and IHabitable.
 * version:0.0.7- Added WaitForAnyKey method in driver class
 */
namespace COMP123_S2016_CKawakam_300821245_Assignment3
{
    /**
     *This is the driver class for our program,Assignment3
     *
     * @class Program
     */
    class Program
    {
        /**
         * The Main method for our driver class program
         * 
         * @constructor:Main
         * @param {string[]}args
         */
        static void Main(string[] args)
        {
            //GiantPlanet Class's object

            GiantPlanet giantPlanet = new GiantPlanet("Jupiter", 10, 10, "ICE");
            giantPlanet.MoonCount = 3;
            Console.WriteLine(giantPlanet.ToString());
            Console.Write("Does the Giant Planet have Moons?:");
            Console.WriteLine(giantPlanet.HasMoons()+"\n");
            Console.Write("Does the Giant Planet have Rings?:");
            Console.WriteLine(giantPlanet.HasRings()+"\n");
            Console.WriteLine();

            bool check = false;
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 20, 20, check);
            terrestrialPlanet.MoonCount = 0;
            Console.WriteLine(terrestrialPlanet.ToString());
            Console.Write("Does the Terrestrial Planet have Moons?:");
            Console.WriteLine(terrestrialPlanet.HasMoons()+"\n");
            Console.Write("Does the Terrestrial Planet have habitable?");
            Console.WriteLine(terrestrialPlanet.Habitable());
            Console.WriteLine();

            WaitForAnyKey();

        }
        /**
         * <summary>
         * The Utility method to wait for console key press from user
         * </summary>
         * @Method: WaitForAnyKey
         * @return {void}
         */
        public static void WaitForAnyKey()
        {
            Console.WriteLine();
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Please Enter any Key to exit");
            Console.ReadKey();
        }
    }
}
