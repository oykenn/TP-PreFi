namespace MyThreads
{
    public partial class FrmTrackThread : Form
    {
        public FrmTrackThread()
        {
            InitializeComponent();
        }
        public void MyThreads()
        {
            //labelThreadStarts.Text = "-Thread Starts-";

            Console.WriteLine("-Thread Starts-");

            MyThreadsClass ThreadsClass = new MyThreadsClass();

            Thread threadA = new Thread(new ThreadStart(ThreadsClass.thread1));

            Thread threadB = new Thread(new ThreadStart(ThreadsClass.thread2));

            Thread threadC = new Thread(new ThreadStart(ThreadsClass.thread1));

            Thread threadD = new Thread(new ThreadStart(ThreadsClass.thread2));

            threadA.Priority = ThreadPriority.Highest;
            threadA.Name = "Thread A Process";

            threadB.Priority = ThreadPriority.Normal;
            threadB.Name = "Thread A Process";

            threadC.Priority = ThreadPriority.AboveNormal;
            threadC.Name = "Thread A Process";

            threadD.Priority = ThreadPriority.BelowNormal;
            threadD.Name = "Thread A Process";

            threadA.Start();
            threadB.Start();
            threadC.Start();
            threadD.Start();

            threadA.Join();
            threadB.Join();
            threadC.Join();
            threadD.Join();

            Console.WriteLine("-Ends of Threads-");

            labelThreadStarts.Text = "-Ends of Threads-";
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            MyThreads();
        }
    }
}
