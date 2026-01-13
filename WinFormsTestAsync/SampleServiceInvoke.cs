namespace WinFormsTestAsync
{
    public class SampleServiceInvoke
    {
        public event Action<string>? Log;

        public async Task StartAsync(CancellationToken token)
        {
            Log?.Invoke("ServiceInvoke is starting...");

            try
            {
                await Task.Delay(5000, token);
                Log?.Invoke("ServiceInvoke is started!");

                while (true)
                {
                    await Task.Delay(5000, token);
                    string data = $"Data from ServiceInvoke: {DateTime.Now.ToLongTimeString()}";
                    Log?.Invoke(data);
                }
            }
            catch (OperationCanceledException)
            {
                Log?.Invoke("ServiceInvoke cancelled!");
            }
        }
    }
}
