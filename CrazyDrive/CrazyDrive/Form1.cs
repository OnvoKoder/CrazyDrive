using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CrazyDrive
{
    public partial class Form1 : Form
    {
        Thread t1, t2, t3, t4;
       static Random rnd;
        public delegate void HelpToCall(Button button);
        HelpToCall helper;
        int x;
        int[] y=new int[4];
        ButtonComparable[] btn;
        public Form1()
        {
            rnd = new Random();
            helper = new HelpToCall(Motion);
            InitializeComponent();
             btn = new ButtonComparable[] { button1, button2, button3, button4 };
        }
        //событие на движение конопк
        private void StartBtn_Click(object sender, EventArgs e)
        {
            //координаты х у всех кнопок одинаковы,а вот координаты y разные
            x = button1.Location.X;
            y[0] = button1.Location.Y;
            y[1] = button2.Location.Y;
            y[2] = button3.Location.Y;
            y[3] = button4.Location.Y;

            //так как мы объявили в одном месте потоки, поэтому можем проверить только
            // один из потоков
            if (t1 == null)
            {
                t1 = new Thread(Movement1);
                t2 = new Thread(Movement2);
                t3 = new Thread(Movement3);
                t4 = new Thread(Movement4);
                t1.IsBackground = true;
                t2.IsBackground = true;
                t3.IsBackground = true;
                t4.IsBackground = true;
            //запускаем потоки
                t1.Start();
                t2.Start();
                t3.Start();
                t4.Start();
            }
            else
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                t4.Resume();
            }
            StartBtn.Enabled = false;
            SuspendBtn.Enabled = true;
            StopBtn.Enabled = true;
        }
        //метод движение кнопок
        void Motion(Button button)
        {
            button.Location = new Point(button.Location.X + rnd.Next(1,6), button.Location.Y);
            Lider();
            Finish(button);
        }
        void Lider()
        {
            Array.Sort(btn);
            btn[0].BackColor = Color.Magenta;
            for(int i = 1; i < btn.Length; i++)
            {
                btn[i].BackColor = SystemColors.Control;
            }
        }
        void Movement1()
        {
            while (true)
            {
                Invoke(helper, button1);
                Thread.Sleep(rnd.Next(30,100));
            }
        }
        void Movement2()
        {
            while (true)
            {
                Invoke(helper, button2);
                Thread.Sleep(rnd.Next(30, 100));
            }
        }
        void Movement3()
        {
            while (true)
            {
                Invoke(helper, button3);
                Thread.Sleep(rnd.Next(30, 100));
            }
        }
        void Movement4()
        {
            while (true)
            {
                Invoke(helper, button4);
                Thread.Sleep(rnd.Next(30, 100));
            }
        }
        //событие, которое прекращает гонку 
        private void StopBtn_Click(object sender, EventArgs e)
        {
            SuspendBtn_Click(sender, e);
            Reset();
            StartBtn.Enabled = true;
            ResumeBtn.Enabled = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SuspendBtn_Click(sender, e);
        }

        private void Reset()
        {
            button1.Location = new Point(x, y[0]);
            button2.Location = new Point(x, y[1]);
            button3.Location = new Point(x, y[2]);
            button4.Location = new Point(x, y[3]);
            foreach(ButtonComparable bc in btn)
            {
                bc.BackColor = SystemColors.Control;
            }
        }
        private void Finish(Button btn)
        {
            if (btn.Location.X+btn.Width > Finish_PB.Location.X)
            {
                SuspendBtn_Click(new object(), new EventArgs());
                MessageBox.Show($"Выиграла кнопка {btn.Text}");
            }
        }
        //событие, которое останавливает движение кнопок
        private void SuspendBtn_Click(object sender, EventArgs e)
        {
            //так как мы объявили в одном месте потоки, поэтому можем проверить только
            // один из потоков
            if (t1 != null)
            {
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();
                t4.Suspend();
            }
            SuspendBtn.Enabled = false;
            ResumeBtn.Enabled = true;
        }
        //событие, которое возобновляет движение кнопок
        private void ResumeBtn_Click(object sender, EventArgs e)
        {
            t1.Resume();
            t2.Resume();
            t3.Resume();
            t4.Resume();
            SuspendBtn.Enabled = true;
            ResumeBtn.Enabled = false;
        }


    }
}
