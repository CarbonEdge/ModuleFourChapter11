using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleFourChapter11
{
    public class engine
    {
        public int partNumber { get; set; }
        public string EngineName { get; set; }
        public double Torque { get; set; }

        public engine (int id, string name, double hp)
        {
            partNumber = id;
            EngineName = name;
            Torque = hp;
        }
        //overloads begin
        public static engine operator +(engine e1, engine e2)
        {
            engine eg = new engine(e1.partNumber+e2.partNumber, e1.EngineName+e2.EngineName, (e1.Torque+e2.Torque)/2);
            return eg;
        }
        public static engine operator <(engine e1, engine e2)
        {
            if(e1.Torque < e2.Torque)
            {
                return e2;
            }
            else
            {
                return e1;
            }
        }
        public static engine operator >(engine e1, engine e2)
        {
            if (e1.Torque > e2.Torque)
            {
                return e1;
            }
            else
            {
                return e2;
            }
        }
        //overloads end
        public override string ToString()
        {
            return string.Format("Name + Toque: [{0}, {1}]", this.EngineName, this.Torque);
        }
    }
}
