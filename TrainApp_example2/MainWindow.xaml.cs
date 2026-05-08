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
using static System.Net.Mime.MediaTypeNames;

namespace TrainApp_example2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();

        // 열차가 여러개일 경우, 열차 클래스를 만들고 리스트로 할당하는 것이 좋음
        List<Train> trains = new List<Train>();

        

        public MainWindow()
        {
            InitializeComponent();

            CreateTrain(0, 50, 3);
            CreateTrain(100, 100, 7);
            CreateTrain(200, 150, 10);
            CreateTrain(300, 50, 15);

            // 0.1초마다 실행
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Train_Tick;
            timer.Start();
        }

        private void CreateTrain(double x, double y, double speed)
        {
            Train t = new Train
            {
                X = x,
                Y = y,
                Speed = speed,
                IsMoving = true,
                Shape = new Rectangle
                {
                    Width = 60,
                    Height = 30,
                    Fill = Brushes.Red
                }
            };

            trains.Add(t);
            MainCanvas.Children.Add(t.Shape);
        }
        private void CheckCollision()
        {
            for (int i = 0; i < trains.Count; i++)
            {
                for (int j = i + 1; j < trains.Count; j++)
                {
                    if (i == j) continue;

                    var front = trains[i];
                    var back = trains[j];

                    // 같은 선로
                    if (front.Y == back.Y)
                    {
                        // front가 앞에 있음
                        if (front.X > back.X)
                        {
                            double distance = front.X - back.X;

                            if (distance < 80)
                            {
                                back.IsMoving = false; // 뒤만 멈춤
                            }
                        }
                    }

                }
            }
        }
        private void Train_Tick(object sender, EventArgs e)
        {
            foreach (var t in trains)
            {
                // 신호등 역할
                if (t.IsMoving)
                {
                    t.X += t.Speed;
                }

                if (t.X > this.Width)
                    t.X = -t.Shape.Width;
            }
            // 충돌 감지
            CheckCollision();

            foreach (var t in trains)
            {
                Canvas.SetLeft(t.Shape, t.X);
                Canvas.SetTop(t.Shape, t.Y);
            }
                 
        }
    }

}
