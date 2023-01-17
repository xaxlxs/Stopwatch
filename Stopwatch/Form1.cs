using System.Timers;

namespace Stopwatch
{
    public partial class Stopwatch : Form
    {
        System.Timers.Timer timer;
        int h, m, s, ms;
        

        public Stopwatch()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1;
            timer.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                ms += 1;

                if (ms == 100)
                {
                    ms = 0;
                    s += 1;
                }

                if (s == 60)
                {
                    s = 0;
                    m += 1;
                }

                if (m == 60)
                {
                    m = 0;
                    h += 1;
                }

                time.Text = string.Format("{0}:{1}:{2}:{3}", h.ToString().ToString().PadLeft(2, '0'), m.ToString().ToString().PadLeft(2, '0'), s.ToString().ToString().PadLeft(2, '0'), ms.ToString().ToString().PadLeft(2, '0'));
            }));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            ms = 0;
            time.Text = "00:00:00:00";
        }
    }
}