using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illinois
{
    class task
    {
        Random rnd;
        public List<int> units;
        public int task_complexity;
        public int min_complexity = 10;
        public int max_complexity = 40;

        public task()
        {
            rnd = new Random();
            task_complexity = rnd.Next(min_complexity, max_complexity + 1);
            units = new List<int>();
        }

        public void generate_units()
        {
            int units_number = rnd.Next(1, 6);
            for (int i = 0; i < units_number; i++)
            {
                int curr = rnd.Next(5);
                while (true)
                {
                    bool was_this = false;
                    for (int j = 0; j < units.Count(); j++)
                        if (curr == units[j])
                            was_this = true;
                    if (!was_this)
                        break;
                    curr = rnd.Next(5);
                }
                units.Add(curr);
            }
            units.Sort();
        }

        public bool is_this_unit(int nmb)
        {
            for (int i = 0; i < units.Count(); i++)
                if (units[i] == nmb)
                    return true;
            return false;
        }
    }
}
