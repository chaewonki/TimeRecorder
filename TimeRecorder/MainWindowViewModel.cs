using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;

namespace TimeRecorder
{
    public partial class MainWindowViewModel : ObservableObject
    {
        private int rank = 0;

        [ObservableProperty]
        private string? _currentTime;
        [ObservableProperty]
        private ObservableCollection<RecordBox> _recordBoxCollection = new();

        public MainWindowViewModel()
        {
            UpdateCurrentTime();
        }

        private void UpdateCurrentTime()
        {
            DispatcherTimer timer = new();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            CurrentTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        [RelayCommand]
        private void CheckCurrentTime()
        {
            rank++;
            RecordBoxCollection.Add(new RecordBox(rank, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
        }
    }
}
