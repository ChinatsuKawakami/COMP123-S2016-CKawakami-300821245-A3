using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2016_CKawakam_300821245_Assignment3
{
    public abstract class Planet
    {
       //Private Fields+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private double _diameter;//readonly
        private double _mass;//readon;y
        private int _moonCount;
        private string _name;//readonly
        private double _orbitalPeriod;
        private int _ringCount;
        private double _rotationPeriod;

        //PUBLIC PROPETIES+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public double Diameter//ReadOnly
        {
            get
            {
               return this._diameter;
            }
        }//close Diameter

        public double Mass // ReadOnly
        {
            get
            {
                return this._mass;
            }
        }//close Mass

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

        public string Name // ReadOnly
        {
            get
            {
                return this._name;
            }
        }//close Name

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


    }
}
