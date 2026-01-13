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
                Log?.Invoke("Подключено!");

                while (true)
                {
                    await Task.Delay(5000, token);
                    string data = $"Данные от сервиса1: {DateTime.Now.ToLongTimeString()}";
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
