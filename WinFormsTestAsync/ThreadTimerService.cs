namespace WinFormsTestAsync
{
    public class ThreadTimerService
    {
        private System.Threading.Timer _timer;
        private IProgress<string> _progress;
        private CancellationTokenSource _cts;
        private bool _isRunning = false;

        public ThreadTimerService(IProgress<string> handler)
        {
            _progress = handler;
        }

        public void Start()
        {
            if (_isRunning) return;

            _cts = new CancellationTokenSource();
            _timer = new System.Threading.Timer(OnTick, null, 0, 3000);
            _isRunning = true;

            _progress.Report("Threading Timer starter!");
        }

        public void Stop()
        {
            if (!_isRunning) return;

            _cts.Cancel();
            _timer.Dispose();
            _cts.Dispose();
            _progress.Report("Service stopped");
        }

        private async void OnTick(object? state)
        {
            try
            {
                _cts.Token.ThrowIfCancellationRequested();
                _progress.Report($"Loading: {DateTime.Now.ToString()}");
                await Task.Delay(2000, _cts.Token);
                _progress.Report($"Loaded! {DateTime.Now.ToString()}");
            }
            catch (OperationCanceledException)
            {
                _progress.Report("Threading Timer cancelled!");
                _timer.Dispose();
            }
        }
    }
}
