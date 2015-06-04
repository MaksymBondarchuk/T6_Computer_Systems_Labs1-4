using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Illinois
{
    public partial class MainForm : Form
    {
        List<unit> units;
        generate_posibility gp;
        int secs = 10;
        double user_poss;
        bool ok_user_poss = false;
        int real_perf = 0;
        int user_compl;
        bool ok_user_compl = false;
        int takts = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            takts++;

            for (int i = 0; i < units.Count(); i++)
            {
                units[i].millisecond_gone();
                if (units[i].queue != 0)
                    real_perf += units[i].perf;
            }

            string sTime = DateTime.Now.ToString("HH:mm:ss.fff tt");
            string sPoss = Convert.ToString(gp.posibility10 / (float)10);
            string sWasG = "no";
            string sUnts = "";
            string sComl = "";

            if (gp.yes_or_no())
            {
                sWasG = "yes";
                task new_task = new task();
                new_task.generate_units();

                if (ok_user_compl)
                    new_task.task_complexity = user_compl;
                sComl = Convert.ToString(new_task.task_complexity);

                for (int i = 0; i < new_task.units.Count(); i++)
                    sUnts += Convert.ToString(new_task.units[i]) + " ";

                float min = units[new_task.units[0]].future_time_float(new_task.task_complexity);
                int min_pos = new_task.units[0];

                units[min_pos].add_task(new_task.task_complexity);

                switch (min_pos)
                {
                    case 0:
                        string[] strs0 = { sUnts, sComl, Convert.ToString(units[0].queue) };
                        ListViewItem item0 = new ListViewItem(strs0);
                        lUnit0.Items.Add(item0);
                        break;
                    case 1:
                        string[] strs1 = { sUnts, sComl, Convert.ToString(units[1].queue) };
                        ListViewItem item1 = new ListViewItem(strs1);
                        lUnit1.Items.Add(item1);
                        break;
                    case 2:
                        string[] strs2 = { sUnts, sComl, Convert.ToString(units[2].queue) };
                        ListViewItem item2 = new ListViewItem(strs2);
                        lUnit2.Items.Add(item2);
                        break;
                    case 3:
                        string[] strs3 = { sUnts, sComl, Convert.ToString(units[3].queue) };
                        ListViewItem item3 = new ListViewItem(strs3);
                        lUnit3.Items.Add(item3);
                        break;
                    default:
                        string[] strs4 = { sUnts, Convert.ToString(new_task.task_complexity), Convert.ToString(units[4].queue) };
                        ListViewItem item4 = new ListViewItem(strs4);
                        lUnit4.Items.Add(item4);
                        break;
                }

                if (0 < lUnit0.Items.Count)
                    lUnit0.EnsureVisible(lUnit0.Items.Count - 1);
                if (0 < lUnit1.Items.Count)
                    lUnit1.EnsureVisible(lUnit1.Items.Count - 1);
                if (0 < lUnit2.Items.Count)
                    lUnit2.EnsureVisible(lUnit2.Items.Count - 1);
                if (0 < lUnit3.Items.Count)
                    lUnit3.EnsureVisible(lUnit3.Items.Count - 1);
                if (0 < lUnit4.Items.Count)
                    lUnit4.EnsureVisible(lUnit4.Items.Count - 1);
            }
            if (0 < lTasks.Items.Count)
                lTasks.EnsureVisible(lTasks.Items.Count - 1);

            string[] strs = { sTime, sPoss, sWasG, sUnts, sComl };
            ListViewItem item = new ListViewItem(strs);
            lTasks.Items.Add(item);
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            units = new List<unit>();

            for (int i = 0; i < 5; i++)
            {
                units.Add(new unit());
                await Task.Delay(10);
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            bStart.Enabled = false;
            bStop.Enabled = true;
            bClear.Enabled = false;

            try
            {
                user_poss = Convert.ToDouble(tUserPoss.Text);
                if (0 <= user_poss && user_poss <= 1)
                    ok_user_poss = true;
            }
            catch
            { }

            try
            {
                user_compl = Convert.ToInt32(tUserCompl.Text);
                if ((new task()).min_complexity <= user_compl && user_compl <= (new task()).max_complexity)
                    ok_user_compl = true;
            }
            catch
            { }

            int perf0 = units[0].max_perf + 1;
            try
            {
                perf0 = Convert.ToInt32(tUnit0Perf.Text);
            }
            catch
            {
                tUnit0Perf.Text = Convert.ToString(units[0].perf);
            }
            if (units[0].min_perf <= perf0 && perf0 <= units[0].max_perf)
                units[0].perf = perf0;
            else
                tUnit0Perf.Text = Convert.ToString(units[0].perf);

            int perf1 = units[0].max_perf + 1;
            try
            {
                perf1 = Convert.ToInt32(tUnit1Perf.Text);
            }
            catch
            {
                tUnit1Perf.Text = Convert.ToString(units[1].perf);
            }
            if (units[0].min_perf <= perf1 && perf1 <= units[0].max_perf)
                units[1].perf = perf1;
            else
                tUnit1Perf.Text = Convert.ToString(units[1].perf);

            int perf2 = units[0].max_perf + 1;
            try
            {
                perf2 = Convert.ToInt32(tUnit2Perf.Text);
            }
            catch
            {
                tUnit2Perf.Text = Convert.ToString(units[2].perf);
            }
            if (units[0].min_perf <= perf2 && perf2 <= units[0].max_perf)
                units[2].perf = perf2;
            else
                tUnit2Perf.Text = Convert.ToString(units[2].perf);

            int perf3 = units[0].max_perf + 1;
            try
            {
                perf3 = Convert.ToInt32(tUnit3Perf.Text);
            }
            catch
            {
                tUnit3Perf.Text = Convert.ToString(units[3].perf);
            }
            if (units[0].min_perf <= perf3 && perf3 <= units[0].max_perf)
                units[3].perf = perf3;
            else
                tUnit3Perf.Text = Convert.ToString(units[3].perf);

            int perf4 = units[0].max_perf + 1;
            try
            {
                perf4 = Convert.ToInt32(tUnit4Perf.Text);
            }
            catch
            {
                tUnit4Perf.Text = Convert.ToString(units[4].perf);
            }
            if (units[0].min_perf <= perf4 && perf4 <= units[0].max_perf)
                units[4].perf = perf4;
            else
                tUnit4Perf.Text = Convert.ToString(units[4].perf);

            gp = new generate_posibility();
            if (ok_user_poss)
                gp.posibility10 = Convert.ToInt32(user_poss * 10);

            _1MSecTimer.Start();
            _10SecTimer.Start();
            _1SecTimer.Start();
        }

        private void bStop_Click(object sender, EventArgs e)
        {
            bStop.Enabled = false;
            bClear.Enabled = true;

            _1MSecTimer.Stop();
            _10SecTimer.Stop();
            _1SecTimer.Stop();
            lTime.Text = "Seconds remain: 0";

            int theor_perf = 0;
            int tasks_performed_all = 0;
            int operations_completed = 0;
            for (int i = 0; i < units.Count(); i++)
            {
                theor_perf += units[i].perf * takts;
                tasks_performed_all += units[i].tasks_completed();
                operations_completed += units[i].abs_queue;
            }
            lESE.Text = "ESE is " + (real_perf / (double)theor_perf).ToString("0.####");
            lTasksNumber.Text = "Tasks completed - " + Convert.ToString(tasks_performed_all);
            lOperationsCompleted.Text = "Operations completed - " + Convert.ToString(operations_completed);
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            secs--;
            lTime.Text = "Seconds remain: " + Convert.ToString(secs);
        }

        private async void bClear_Click(object sender, EventArgs e)
        {
            bClear.Enabled = false;

            lUnit0.Items.Clear();
            lUnit1.Items.Clear();
            lUnit2.Items.Clear();
            lUnit3.Items.Clear();
            lUnit4.Items.Clear();
            lTasks.Items.Clear();
            tUnit0Perf.Text = "";
            tUnit1Perf.Text = "";
            tUnit2Perf.Text = "";
            tUnit3Perf.Text = "";
            tUnit4Perf.Text = "";
            tUserPoss.Text = "1";
            tUserCompl.Text = "";
            for (int i = 4; 0 <= i; i--)
                units.RemoveAt(i);

            for (int i = 0; i < 5; i++)
            {
                units.Add(new unit());
                await Task.Delay(10);
            }

            secs = 10;
            lTime.Text = "Seconds remain: 10";
            lESE.Text = "";
            lTasksNumber.Text = "";
            lOperationsCompleted.Text = "";
            real_perf = 0;
            takts = 0;

            bStart.Enabled = true;
        }
    }
}