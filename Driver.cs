using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2022_0726
{
    public class Driver   //司机
    {
        //public string _name;
        //public int _ranking;


        public string _name;
        public int _ranking;
        public string _specialskill;
        public char _eligibletotace;
        public int _accumlatedscore;
        public int _accumulatedtime;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Ranking
        {
            get { return _ranking; }
            set { _ranking = value; }
        }
        public string SpecialSkill
        {
            get { return _specialskill; }
            set { _specialskill = value; }
        }
        public char EligibleToRace
        {
            get { return _eligibletotace; }
            set { _eligibletotace = value; }
        }
        public int AccumulatedScore
        {
            get { return _accumlatedscore; }
            set { _accumlatedscore = value; }
        }
        public int AccumulatedTime
        {
            get { return _accumulatedtime; }
            set { _accumulatedtime = value; }
        }
        public Driver(string Name, int Ranking, string SpecialSkill, char EligibleToRace, int AccumulatedScore, int AccumulatedTime)
        {
            this.Name = _name;
            this.Ranking = _ranking;
            this.SpecialSkill = _specialskill;
            this.EligibleToRace = _eligibletotace;
            this.AccumulatedScore = _accumlatedscore;
            this.AccumulatedTime = _accumulatedtime;   
        }

        /*public Driver()
        {
        }*/

        public void NumDriver()
        {
            Console.WriteLine("姓名是{0},排名是{1},特殊技能{2},合格率{3},累计积分{4},累计时间{5}",Name,Ranking, SpecialSkill, EligibleToRace, AccumulatedScore, AccumulatedTime);
        }
    }
}

