namespace WinFormsTestAsync
{
    public partial class Form1 : Form
    {
        private readonly SampleServiceInvoke _service1 = new SampleServiceInvoke();
        private readonly CancellationTokenSource _cts1 = new CancellationTokenSource();

        private readonly SampleServiceProgress _service2 = new SampleServiceProgress();
        private readonly CancellationTokenSource _cts2 = new CancellationTokenSource();

        private readonly ThreadTimerService _timerService;

        private readonly Progress<string> progressLogger;

        public Form1()
        {
            InitializeComponent();

            _service1.Log += OnLog;

            progressLogger = new Progress<string>(msg => LogToTxtbox(msg));
            _timerService = new ThreadTimerService(progressLogger);
        }

        private void OnLog(string obj)
        {
            if (InvokeRequired)
            {
                Invoke(() => OnLog(obj));
                return;
            }
            else
            {
                LogToTxtbox(obj);
            }
        }

        private void LogToTxtbox(string text)
        {
            string time = DateTime.Now.ToLongTimeString();
            textBox1.AppendText($"{time}\t{text}{Environment.NewLine}");
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            LogToTxtbox("Start 1...");
            string result = await ClickHandler("Task 1", 4000);
            LogToTxtbox($"Finished 1! Result: {result}");
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            LogToTxtbox("Start 2...");
            string result = await ClickHandler("Task 2", 3000);
            LogToTxtbox($"Finished 2! Result: {result}");
        }

        private async Task<string> ClickHandler(string data, int delay)
        {
            LogToTxtbox($"Start handler: {data}");
            await Task.Delay(delay);
            return $"Changed text: {data.ToUpper()}";
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {
            LogToTxtbox("Timer tick...");
            await Task.Delay(1100);
            LogToTxtbox("Timer tick end!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            LogToTxtbox("Timer enabled");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            LogToTxtbox("Timer disabled");
        }

        private async void buttonStartServiceInvoke_Click(object sender, EventArgs e)
        {
            await _service1.StartAsync(_cts1.Token);
        }

        private void buttonStopServiceInvoke_Click(object sender, EventArgs e)
        {
            _cts1.Cancel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void buttonStartIProgress_Click(object sender, EventArgs e)
        {
            await _service2.StartAsync(progressLogger, _cts2.Token);
        }

        private void buttonStopIProgress_Click(object sender, EventArgs e)
        {
            _cts2.Cancel();
        }

        private void buttonStartThreadTimer_Click(object sender, EventArgs e)
        {
            _timerService.Start();
        }

        private void buttonStopThreadTimer_Click(object sender, EventArgs e)
        {
            _timerService.Stop();
        }

        private async void buttonTask3run_Click(object sender, EventArgs e)
        {
            buttonTask3run.Enabled = false;
            LogToTxtbox("Preparing Task3 Run...");
            IProgress<string> pr = new Progress<string>(msg => textBox1.AppendText(msg));
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(666);
                    pr.Report($"{i}... ");
                }
            });
            LogToTxtbox($"{Environment.NewLine}Task3 completed!");
            buttonTask3run.Enabled = true;
        }

        private async void buttonTask4run_Click(object sender, EventArgs e)
        {
            buttonTask4run.Enabled = false;
            LogToTxtbox("Preparing Task4 Run...");

            IProgress<string> pr = new Progress<string>(msg => LogToTxtbox(msg));
            await Task.Run(() => LongWork(pr));

            LogToTxtbox("Task4 Run completed");
            buttonTask4run.Enabled = false;
        }

        private void LongWork(IProgress<string> progressReporter)
        {
            progressReporter.Report($"Long work preparing...");
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(2222);
                progressReporter.Report($"{DateTime.Now.Second}... ");
            }
            progressReporter.Report($"Long work completed");
        }
    }
}
