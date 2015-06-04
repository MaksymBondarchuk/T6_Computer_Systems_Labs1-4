namespace Illinois
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._1MSecTimer = new System.Windows.Forms.Timer(this.components);
            this.bStart = new System.Windows.Forms.Button();
            this.bStop = new System.Windows.Forms.Button();
            this.tUnit0Perf = new System.Windows.Forms.TextBox();
            this.tUnit1Perf = new System.Windows.Forms.TextBox();
            this.tUnit2Perf = new System.Windows.Forms.TextBox();
            this.tUnit3Perf = new System.Windows.Forms.TextBox();
            this.tUnit4Perf = new System.Windows.Forms.TextBox();
            this.lUnit0 = new System.Windows.Forms.ListView();
            this._unit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.t_c = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.unit_d = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lUnit1 = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lUnit2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lUnit3 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lUnit4 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lTasks = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this._10SecTimer = new System.Windows.Forms.Timer(this.components);
            this.lTime = new System.Windows.Forms.Label();
            this._1SecTimer = new System.Windows.Forms.Timer(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tUserPoss = new System.Windows.Forms.TextBox();
            this.lESE = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tUserCompl = new System.Windows.Forms.TextBox();
            this.lTasksNumber = new System.Windows.Forms.Label();
            this.bClear = new System.Windows.Forms.Button();
            this.lOperationsCompleted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _1MSecTimer
            // 
            this._1MSecTimer.Interval = 50;
            this._1MSecTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(12, 201);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(75, 23);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bStop
            // 
            this.bStop.Enabled = false;
            this.bStop.Location = new System.Drawing.Point(88, 201);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(75, 23);
            this.bStop.TabIndex = 2;
            this.bStop.Text = "Stop";
            this.bStop.UseVisualStyleBackColor = true;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // tUnit0Perf
            // 
            this.tUnit0Perf.Location = new System.Drawing.Point(170, 154);
            this.tUnit0Perf.Name = "tUnit0Perf";
            this.tUnit0Perf.Size = new System.Drawing.Size(167, 20);
            this.tUnit0Perf.TabIndex = 16;
            // 
            // tUnit1Perf
            // 
            this.tUnit1Perf.Location = new System.Drawing.Point(501, 154);
            this.tUnit1Perf.Name = "tUnit1Perf";
            this.tUnit1Perf.Size = new System.Drawing.Size(167, 20);
            this.tUnit1Perf.TabIndex = 17;
            // 
            // tUnit2Perf
            // 
            this.tUnit2Perf.Location = new System.Drawing.Point(832, 154);
            this.tUnit2Perf.Name = "tUnit2Perf";
            this.tUnit2Perf.Size = new System.Drawing.Size(167, 20);
            this.tUnit2Perf.TabIndex = 18;
            // 
            // tUnit3Perf
            // 
            this.tUnit3Perf.Location = new System.Drawing.Point(501, 324);
            this.tUnit3Perf.Name = "tUnit3Perf";
            this.tUnit3Perf.Size = new System.Drawing.Size(167, 20);
            this.tUnit3Perf.TabIndex = 19;
            // 
            // tUnit4Perf
            // 
            this.tUnit4Perf.Location = new System.Drawing.Point(832, 324);
            this.tUnit4Perf.Name = "tUnit4Perf";
            this.tUnit4Perf.Size = new System.Drawing.Size(167, 20);
            this.tUnit4Perf.TabIndex = 20;
            // 
            // lUnit0
            // 
            this.lUnit0.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lUnit0.BackColor = System.Drawing.SystemColors.Window;
            this.lUnit0.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._unit,
            this.t_c,
            this.unit_d});
            this.lUnit0.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUnit0.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lUnit0.GridLines = true;
            this.lUnit0.HoverSelection = true;
            this.lUnit0.Location = new System.Drawing.Point(12, 45);
            this.lUnit0.Name = "lUnit0";
            this.lUnit0.Size = new System.Drawing.Size(325, 103);
            this.lUnit0.TabIndex = 23;
            this.lUnit0.UseCompatibleStateImageBehavior = false;
            this.lUnit0.View = System.Windows.Forms.View.Details;
            // 
            // _unit
            // 
            this._unit.Text = "Capable units";
            this._unit.Width = 91;
            // 
            // t_c
            // 
            this.t_c.Text = "Task complexity";
            this.t_c.Width = 104;
            // 
            // unit_d
            // 
            this.unit_d.Text = "Unit workload";
            this.unit_d.Width = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "PU #0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "PU #1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(805, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 30;
            this.label3.Text = "PU #2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "PU #3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(805, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 32;
            this.label5.Text = "PU #4";
            // 
            // lUnit1
            // 
            this.lUnit1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lUnit1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUnit1.GridLines = true;
            this.lUnit1.Location = new System.Drawing.Point(343, 45);
            this.lUnit1.Name = "lUnit1";
            this.lUnit1.Size = new System.Drawing.Size(325, 103);
            this.lUnit1.TabIndex = 37;
            this.lUnit1.UseCompatibleStateImageBehavior = false;
            this.lUnit1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Capable units";
            this.columnHeader10.Width = 91;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Task complexity";
            this.columnHeader11.Width = 104;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Unit workload";
            this.columnHeader12.Width = 93;
            // 
            // lUnit2
            // 
            this.lUnit2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lUnit2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUnit2.GridLines = true;
            this.lUnit2.Location = new System.Drawing.Point(674, 45);
            this.lUnit2.Name = "lUnit2";
            this.lUnit2.Size = new System.Drawing.Size(325, 103);
            this.lUnit2.TabIndex = 38;
            this.lUnit2.UseCompatibleStateImageBehavior = false;
            this.lUnit2.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Capable units";
            this.columnHeader1.Width = 91;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Task complexity";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Unit workload";
            this.columnHeader3.Width = 93;
            // 
            // lUnit3
            // 
            this.lUnit3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.lUnit3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUnit3.GridLines = true;
            this.lUnit3.Location = new System.Drawing.Point(343, 215);
            this.lUnit3.Name = "lUnit3";
            this.lUnit3.Size = new System.Drawing.Size(325, 103);
            this.lUnit3.TabIndex = 39;
            this.lUnit3.UseCompatibleStateImageBehavior = false;
            this.lUnit3.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Capable units";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Task complexity";
            this.columnHeader5.Width = 104;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Unit workload";
            this.columnHeader6.Width = 93;
            // 
            // lUnit4
            // 
            this.lUnit4.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lUnit4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUnit4.GridLines = true;
            this.lUnit4.Location = new System.Drawing.Point(674, 215);
            this.lUnit4.Name = "lUnit4";
            this.lUnit4.Size = new System.Drawing.Size(325, 103);
            this.lUnit4.TabIndex = 40;
            this.lUnit4.UseCompatibleStateImageBehavior = false;
            this.lUnit4.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Capable units";
            this.columnHeader7.Width = 91;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Task complexity";
            this.columnHeader8.Width = 104;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Unit workload";
            this.columnHeader9.Width = 93;
            // 
            // lTasks
            // 
            this.lTasks.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lTasks.BackColor = System.Drawing.SystemColors.Window;
            this.lTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.lTasks.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTasks.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lTasks.GridLines = true;
            this.lTasks.HoverSelection = true;
            this.lTasks.Location = new System.Drawing.Point(343, 399);
            this.lTasks.Name = "lTasks";
            this.lTasks.Size = new System.Drawing.Size(656, 259);
            this.lTasks.TabIndex = 41;
            this.lTasks.UseCompatibleStateImageBehavior = false;
            this.lTasks.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Time";
            this.columnHeader13.Width = 110;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Possibility";
            this.columnHeader14.Width = 109;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Was generated";
            this.columnHeader15.Width = 123;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Capable units";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Task complexity";
            this.columnHeader17.Width = 127;
            // 
            // _10SecTimer
            // 
            this._10SecTimer.Interval = 10000;
            this._10SecTimer.Tick += new System.EventHandler(this.bStop_Click);
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.Location = new System.Drawing.Point(5, 619);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(325, 39);
            this.lTime.TabIndex = 0;
            this.lTime.Text = "Seconds remain: 10";
            // 
            // _1SecTimer
            // 
            this._1SecTimer.Interval = 1000;
            this._1SecTimer.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Enter your PU performance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(340, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(155, 15);
            this.label7.TabIndex = 44;
            this.label7.Text = "Enter your PU performance";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(671, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(155, 15);
            this.label8.TabIndex = 45;
            this.label8.Text = "Enter your PU performance";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(340, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 15);
            this.label9.TabIndex = 46;
            this.label9.Text = "Enter your PU performance";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(671, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(155, 15);
            this.label10.TabIndex = 47;
            this.label10.Text = "Enter your PU performance";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(340, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 15);
            this.label11.TabIndex = 49;
            this.label11.Text = "Enter your task generation possibility";
            // 
            // tUserPoss
            // 
            this.tUserPoss.Location = new System.Drawing.Point(551, 371);
            this.tUserPoss.Name = "tUserPoss";
            this.tUserPoss.Size = new System.Drawing.Size(117, 20);
            this.tUserPoss.TabIndex = 48;
            this.tUserPoss.Text = "1";
            // 
            // lESE
            // 
            this.lESE.AutoSize = true;
            this.lESE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lESE.ForeColor = System.Drawing.Color.Maroon;
            this.lESE.Location = new System.Drawing.Point(5, 489);
            this.lESE.Name = "lESE";
            this.lESE.Size = new System.Drawing.Size(0, 25);
            this.lESE.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(671, 372);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(148, 15);
            this.label12.TabIndex = 52;
            this.label12.Text = "Enter your task complexity";
            // 
            // tUserCompl
            // 
            this.tUserCompl.Location = new System.Drawing.Point(825, 371);
            this.tUserCompl.Name = "tUserCompl";
            this.tUserCompl.Size = new System.Drawing.Size(174, 20);
            this.tUserCompl.TabIndex = 51;
            // 
            // lTasksNumber
            // 
            this.lTasksNumber.AutoSize = true;
            this.lTasksNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTasksNumber.ForeColor = System.Drawing.Color.Maroon;
            this.lTasksNumber.Location = new System.Drawing.Point(5, 528);
            this.lTasksNumber.Name = "lTasksNumber";
            this.lTasksNumber.Size = new System.Drawing.Size(0, 25);
            this.lTasksNumber.TabIndex = 53;
            // 
            // bClear
            // 
            this.bClear.Enabled = false;
            this.bClear.Location = new System.Drawing.Point(12, 230);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(75, 23);
            this.bClear.TabIndex = 57;
            this.bClear.Text = "Clear all";
            this.bClear.UseVisualStyleBackColor = true;
            this.bClear.Click += new System.EventHandler(this.bClear_Click);
            // 
            // lOperationsCompleted
            // 
            this.lOperationsCompleted.AutoSize = true;
            this.lOperationsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOperationsCompleted.ForeColor = System.Drawing.Color.Maroon;
            this.lOperationsCompleted.Location = new System.Drawing.Point(6, 567);
            this.lOperationsCompleted.Name = "lOperationsCompleted";
            this.lOperationsCompleted.Size = new System.Drawing.Size(0, 25);
            this.lOperationsCompleted.TabIndex = 58;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1017, 690);
            this.Controls.Add(this.lOperationsCompleted);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.lTasksNumber);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tUserCompl);
            this.Controls.Add(this.lESE);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tUserPoss);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lTasks);
            this.Controls.Add(this.lUnit4);
            this.Controls.Add(this.lUnit3);
            this.Controls.Add(this.lUnit2);
            this.Controls.Add(this.lUnit1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lUnit0);
            this.Controls.Add(this.tUnit4Perf);
            this.Controls.Add(this.tUnit3Perf);
            this.Controls.Add(this.tUnit2Perf);
            this.Controls.Add(this.tUnit1Perf);
            this.Controls.Add(this.tUnit0Perf);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.bStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Illinois project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer _1MSecTimer;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.TextBox tUnit0Perf;
        private System.Windows.Forms.TextBox tUnit1Perf;
        private System.Windows.Forms.TextBox tUnit2Perf;
        private System.Windows.Forms.TextBox tUnit3Perf;
        private System.Windows.Forms.TextBox tUnit4Perf;
        private System.Windows.Forms.ListView lUnit0;
        private System.Windows.Forms.ColumnHeader _unit;
        private System.Windows.Forms.ColumnHeader t_c;
        private System.Windows.Forms.ColumnHeader unit_d;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lUnit1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ListView lUnit2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lUnit3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ListView lUnit4;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ListView lTasks;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.Timer _10SecTimer;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Timer _1SecTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tUserPoss;
        private System.Windows.Forms.Label lESE;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tUserCompl;
        private System.Windows.Forms.Label lTasksNumber;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Label lOperationsCompleted;
    }
}

