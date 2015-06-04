using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illinois
{
    class unit
    {
        public int perf;
        public int queue;
        public int abs_queue;
        public int min_perf = 1;
        public int max_perf = 5;
        List<int> tasks;

        public unit()
        {
            Random rnd = new Random();
            perf = rnd.Next(min_perf, max_perf + 1);
            queue = 0;
            abs_queue = 0;
            tasks = new List<int>();
        }

        public void add_task(int task_complexity)
        {
            queue += task_complexity;
            tasks.Add(task_complexity);
        }

        public float future_time_float(int task_complexity)
        {
            return (queue + task_complexity) / perf;
        }

        public void millisecond_gone()
        {
            queue -= perf;
            if (queue < 0)
                queue = 0;
            if (perf <= queue)
                abs_queue += perf;
        }

        public int tasks_completed()
        {
            int queue_copy = abs_queue;
            int number = 0;
            while (tasks.Count() != 0 && tasks[0] < queue_copy)
            {
                queue_copy -= tasks[0];
                tasks.RemoveAt(0);
                number++;
            }

            return number;
        }
    }
}
