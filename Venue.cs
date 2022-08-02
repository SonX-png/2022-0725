using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_0726
{
    public class Venue  //场地
    {
        private string _name;
        private int _laps;
        private int _time;
        private double _chance;

        public Venue(string venueName, int numoflaps, int avveragelaptime, double chanceofrain)
        {
            this.VenueName = venueName;
            this.NumOfLaps = numoflaps;
            this.AvverageLapTime = avveragelaptime;
            this.ChanceOfRain = chanceofrain;
        }
        public string VenueName 
        {
            get { return _name; }
            set { _name = value; }
        }
        public int NumOfLaps {
            get { return _laps; }
            set { _laps = value; }
        }
        public int AvverageLapTime 
        {
            get { return _time; }
            set { _time = value; }
        }
        public double ChanceOfRain 
        {
            get { return _chance; }
            set { _chance = value; }
        }

        public void Nums()
        {
            Console.WriteLine(
                "{0}", this._name);
        }

    }

    /*public class Choose : Venue
    {
        void IISname(name 1);


    }*/




}
