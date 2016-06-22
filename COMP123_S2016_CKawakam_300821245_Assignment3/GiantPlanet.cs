using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_CKawakam_300821245_Assignment3
{
    /**
     *<summary>
     *This is the GiantPlanet class that extends form Planet(abstract)
     * </summary>
     *@class GiantPlanet 
     *@param
     *@_type{string}
     */
    public class GiantPlanet:Planet,IHasMoons,IHasRings
    {
        //PRIVATE INSTANCE VARIABLES++++++++++++++++++++++++++++++++++++++++++++++++++
        private string _type;

        //PUBLIC INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++++++++
     /**
      * <summary>
      * This is a property for our _type field
      * </summary>
      * @propety{string} Type
      */
        public string Type
        {
            get
            {
                return this._type;
            }
         set{
                this._type = value;
            }
        }//close Type


        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is construcor that takes name , diameter ,mass from Planet class and type as parameters and 
         * passes it to the _type private instance variable.
         * </summary>
         * @constructor GiantPlanet
         * @extends Planet
         * @params {string}type,{string}name,{double}diameter,{double}mass
         */
        public GiantPlanet(string name,double diameter,double mass,string type)
            :base(name,diameter,mass)
        {
            this._type = type;
        }





        //INTERFACE METHOD+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       
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
         *This is Interface Method which returns true if RingCount is greater than 0
         * </summary>
         * @Method:HasRings
         * @params{bool}checkRing
         * @return{bool}checkRing
         */
        public bool HasRings()
        {
            bool checkRing = false;
            if(this.RingCount>0)
            {
                checkRing = true;
            }
            return checkRing;
        }
    }
}
