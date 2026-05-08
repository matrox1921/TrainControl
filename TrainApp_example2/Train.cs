using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace TrainApp_example2
{
    class Train
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Speed { get; set; }
        public Rectangle Shape { get; set; }
        public bool IsMoving { get; set; }
    }
}
