using System.Windows;
using System.Windows.Controls;

namespace TimeRecorder
{
    public class RecordBox : Control
    {
        public string? Rank { get; set; }
        public string? CheckedTime { get; set; }

        static RecordBox()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(RecordBox), new FrameworkPropertyMetadata(typeof(RecordBox)));
        }

        public RecordBox(int rank, string checkedTime)
        {
            Rank = "#" + rank.ToString();
            CheckedTime = checkedTime;
        }
    }
}
