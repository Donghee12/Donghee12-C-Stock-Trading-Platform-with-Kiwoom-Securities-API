using System.Windows.Forms;
using System.Reflection;

namespace CandlestickChart
{
    public class DoubleBufferedListView : ListView
    {
        public DoubleBufferedListView()
        {
            // DoubleBuffered 속성 강제로 true로 설정
            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance)
                ?.SetValue(this, true, null);

            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
            this.UpdateStyles();
        }
    }
}