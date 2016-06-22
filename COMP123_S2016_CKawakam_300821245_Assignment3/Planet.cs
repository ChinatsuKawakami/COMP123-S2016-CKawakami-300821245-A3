using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_CKawakam_300821245_Assignment3
{
    /**
     *<summary>
     *This is the Planet class (abstruct)
     * </summary>
     *@class Planet 
     *@param
     *@_diameter{double},_mass{double},_moonCount{int},_name{string},_orbitalPeriod{double},_ringCount{int},_rorationPeriod{double}
     */
    public abstract class Planet
    {
       //PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private double _diameter;//readonly
        private double _mass;//readon;y
        private int _moonCount;
        private string _name;//readonly
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC INSTANCE PROPETIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
       
        /**
         * <summary>
         * This is a property for our _diameter field
         * </summary>
         * @propety{double} Diameter
         */
        public double Diameter//ReadOnly
        {
            get
            {
               return this._diameter;
            }
        }//close Diameter


        /**
         * <summary>
         * This is a property for our _mass field
         * </summary>
         * @propety{double} Mass
         */
        public double Mass // ReadOnly
        {
            get
            {
                return this._mass;
            }
        }//close Mass


        /**
         * <summary>
         * This is a property for our _moonCount field
         * </summary>
         * @propety{int} Diameter
         */
        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }//close MoonCount


        /**
         * <summary>
         * This is a property for our _name field
         * </summary>
         * @propety{string} Name
         */
        public string Name // ReadOnly
        {
            get
            {
                return this._name;
            }
        }//close Name

        /**
         * <summary>
         * This is a property for our _orbitalPeriod field
         * </summary>
         * @propety{double} OrbitalPeriod
         */
        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPeriod;
            }
            set
            {
                this._orbitalPeriod = value;
            }
        }//close OrbitalPeriod


        /**
         * <summary>
         * This is a property for our _ringCount field
         * </summary>
         * @propety{int} RingCount
         */
        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }

        }//close RingCount


        /**
         * <summary>
         * This is a property for our _rotationPeriod field
         * </summary>
         * @propety{double} RotationPeriod
         */
        public double RotationPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }//close RorationPeriod

        //CONSTRUCTOR+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        /**
         * <summary>
         * This is constructor that takes name , diameter,and mass as parameters and passes
         * it to the _name, _diameter, _mass private instance variable.
         * </summary>
         * @constructor:Planet
         * @params:{string}name,{double}diameter,{double}mass
         */
        public Planet (string name,double diameter,double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }
       /**
        * <summary>
        * This is ToString Method to console Name, Diameter,and Mass
        * </summary>
        * @Method: ToString
        * @param:{string}
        * @returns {string}
        */
         public override string ToString()
         {
             string str = String.Format("+++++++++++++++++++++++++++++++\n+Name:" + this.Name + "\n+Diameter:" + this.Diameter + "\n+Mass:" + this.Mass + "\n+++++++++++++++++++++++++++++++");
             return str;
         }
    }
}
