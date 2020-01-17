using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Source : https://galdin.dev/blog/producing-and-consuming-infinite-tasks-in-csharp/
/// </summary>
namespace ProducingAndConsumingInfiniteTasks
{
    public partial class Form1 : Form
    {
        dynamic cts;

        public Form1()
        {
            InitializeComponent();
        }
        

        private async void BtnStartInfinityLoop_Click(object sender, EventArgs e)
        {
            // Create a cancellation token source to get a cancellation token
            cts = new CancellationTokenSource();

            BtnStartInfinityLoop.Enabled = false;
            BtnStopInfinityLoop.Enabled = true;

            // Create a ConsumeTasks task
            // It's probably running right now...
            var task = ConsumeTasks(cts.Token);
            await task;
        }

        private async Task ConsumeTasks(CancellationToken cancel)
        {
            foreach (var task in ProduceForever(cancel))
            {
                await task;
            }
        }

        private IEnumerable<Task> ProduceForever(CancellationToken cancel)
        {
            do
            {
                yield return DoTheThing();
            } while (!cancel.IsCancellationRequested);
        }

        private async Task DoTheThing()
        {
            await Task.Delay(1000);
            await Process();
        }

        private Task Process()
        {
            TxtResult.Text = Guid.NewGuid().ToString();
            return Task.CompletedTask;
        }

        private void BtnStopInfinityLoop_Click(object sender, EventArgs e)
        {
            BtnStartInfinityLoop.Enabled = true;
            BtnStopInfinityLoop.Enabled = false;

            // We quit by cancelling the task
            cts.Cancel();
        }
    }
}
