namespace WinFormsTestAsync
{
    public class SampleServiceProgress
    {
        public async Task StartAsync(IProgress<string> pr, CancellationToken t)
        {
            pr.Report("ServiceProgress is starting...");

            try
            {
                await Task.Delay(5000, t);

                while (t.IsCancellationRequested == false)
                {
                    pr.Report($"Data from ServiceProgress: {DateTime.Now.ToString()}");
                    await Task.Delay(4000, t);
                }
            }
            catch (OperationCanceledException)
            {
                pr.Report("ServiceProgress cancelled!");
            }
        }
    }
}
