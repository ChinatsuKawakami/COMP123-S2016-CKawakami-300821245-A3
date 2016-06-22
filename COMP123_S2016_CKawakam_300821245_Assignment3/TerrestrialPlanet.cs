using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_CKawakam_300821245_Assignment3
{

    /**
     *<summary>
     *This is the TerrestrialPlanet class that extends form Planet(abstract)
     * </summary>
     *@class TerrestrialPlanet 
     *@param
     *@_oxygen{bool}
     */
    public class TerrestrialPlanet:Planet,IHasMoons,IHabitable
    {
        //PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private bool _oxygen;

        //CONSTRUCTOR++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is construcor that takes name , diameter ,mass from Planet class and oxygen as parameters and 
         * passes it to the _oxygen private instance variable.
         * </summary>
         * @constructor TerrestrialPlanet
         * @extends Planet
         * @params {bool}oxygen,{string}name,{double}diameter,{double}mass
         */
        public TerrestrialPlanet(string name,double diameter,double mass,bool oxygen)
            :base(name, diameter,mass)
        {
            this._oxygen = oxygen;
        }

        //INTERFACE METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
        *<summary>
        *This is Interface Method which returns true if MoonCount is greater than 0
        * </summary>
        * @Method:HasMoons
        * @params{bool}checkMoon
        * @return{bool}checkMoon
        */
        public bool HasMoons()
        {
            bool checkMoon = false;
            if(this.MoonCount>0)
            {
                checkMoon = true;
            }
            return checkMoon;
        }

    /**
     *<summary>
     *This is Interface Method which returns true if _oxygen is true
     * </summary>
     * @Method:Habitable
     * @params{bool}checkHabit
     * @return{bool}checkHabit
     */

        public bool Habitable()
        {
            bool checkHabit = false;
            if(this._oxygen == true)
            {
                checkHabit = true;
            }
            return checkHabit;
        }
    }
}
