using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4._6
{
    class Accauntant
    {
        public bool AskForBonus(Post worker, int hours)
        {
            bool flag=false;
            if (hours > (int)worker)
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
        }
        public void Prem(bool f)
        {
            if (f)
            {
                Console.WriteLine("Премия пологается в этом месяце");
            }
            else
            {
                Console.WriteLine("Премия не пологается в этом месяце");
            }
        }
    }
}
