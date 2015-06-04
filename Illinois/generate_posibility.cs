using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illinois
{
    class generate_posibility
    {
        Random rnd;
        public int posibility10;

        public generate_posibility()
        {
            rnd = new Random();
            posibility10 = rnd.Next(11);
        }

        public generate_posibility(float posibility)
        {
            posibility10 = Convert.ToInt32(posibility * 10);
        }

        public bool yes_or_no()
        {
            int rnd_nmb = rnd.Next(11);
            if (posibility10 != 0)
                return (rnd_nmb <= posibility10);
            else
                return false;
        }
    }
}
