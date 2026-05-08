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

namespace TrainApp_example1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        double x = 0;   // 열차 x축 위치
        double y = 0;   // 열차 y축 위치
        double speed = 5;

        public MainWindow()
        {
            InitializeComponent();

            // 0.1초마다 실행
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Train_Tick;
            timer.Start();
        }

        private void Train_Tick(object sender, EventArgs e)
        {
            // 위치 증가
            x += speed*3;
            y += speed;

            // 화면이 x축 밖으로 나가면 다시 왼쪽으로
            if (x > this.Width)
            {
                x = -Train.Width;
            }

            // 화면이 y축 밖으로 나가면 다시 위쪽으로
            if (y > this.Height)
            {
                y = -Train.Height;
            }

            // Canvas 위치 이동
            Canvas.SetLeft(Train, x);
            Canvas.SetTop(Train, y);
        }

    }
}