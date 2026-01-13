# WinFormsTestAsync

A simple C# WindowsForms application demonstrating various methods for working with Async and multithreading.
Simulation of "long background processes" is done using Task.Delay (for async processes) and Thread.Sleep (for multithreaded processes). "Background services" have a CancellationToken and can be started and stopped.
A "log" of all processes is displayed in a TextBox. The UI is not blocked, and multiple processes can be run in parallel.

![screenshot](/WinFormsTestAsync/screenshot.png)

Used methods:
- Button Click + async Task.Delay
- Windows Form Timer
- Threading Timer
- Background async service + Invoke + InvokeRequired
- Background async service + IProgress
- Button Click + Task.Run

As a result (in my opinion), the most convenient way to launch "background async processes" and receive feedback from them is to use background async services with notifications via Progress.Report. This is a modern, thread-safe method (it works with both await processes in the UI thread and with processes in another thread), and, unlike Invoke, the code is more compact and readable.