using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace assignment7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private Random m_Random = new Random();

        public void HeavyWork()
        {
            // generate value between 0 and 10
            double secondsToSleep = m_Random.NextDouble() * 10;
            // simulate important work
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(secondsToSleep));
        }
        public Task HeavyWorkAsync()
        {
            // run HeavyWork asynchronously
            return Task.Run(() => HeavyWork());
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            label.Content = "Operation has started";
            Task[] heavyWorkTasks = new Task[]
            {
                HeavyWorkAsync(),
                HeavyWorkAsync(),
                HeavyWorkAsync()
            };
            Task countdownTask = Task.Delay(8000);

            Task work = Task.WhenAll(heavyWorkTasks);
            await Task.WhenAny(new List<Task>() { work, countdownTask });

            if(countdownTask.IsCompleted)
            {
                label.Content = "Work is still being done";
            }
            await work;
            label.Content = "Completed";
        }
    }
}
