using System.Diagnostics;
using System.Net.Sockets;
using TatehamaInterlocking.Tsuzaki;

namespace TatehamaInterlocking
{
    public partial class MainWindow : Form
    {
        private bool showtsuzakiWindow;
        static private TsuzakiWindow tsuzakiWindow = new TsuzakiWindow();
        static private Socket socket = new Socket(Program.ServerAddress);

        public MainWindow()
        {
            InitializeComponent();
            tsuzakiWindow.Hide();
            showtsuzakiWindow = false;
        }

        static internal Dictionary<string, PictureBox> RouteButtonList = new Dictionary<string, PictureBox>();
        static internal Dictionary<string, Image> RouteButtonImage0 = new Dictionary<string, Image>();
        static internal Dictionary<string, Image> RouteButtonImage1 = new Dictionary<string, Image>();


        /// <summary>
        /// 進路ボタンが押された時走る関数。
        /// </summary>
        /// <param name="Name">進路名称(鯖側)</param>     
        /// <param name="Teihan">定位(F)か反位(T)か</param>
        static internal void ButtonPush(string Name, bool Teihan)
        {
            Debug.WriteLine($"Push:{Name}/{Teihan}");
            Task.Run(async () =>
            {
                string? error;
                if (Teihan)
                {
                    error = await socket.routeOpen(Name);
                }
                else
                {
                    error = await socket.routeCancel(Name);
                }
                if (error.Length > 0)
                {
                    // Todo: エラーメッセージがでるので、それを表示する
                    Debug.WriteLine(error);
                    if (error == "開通中")
                    {
                        RouteSet(Name);
                    }
                    if (error == "閉鎖中")
                    {
                        RouteReset(Name);
                    }
                    if (error == "進入中")
                    {
                        RouteReset(Name);
                    }
                    return;
                }
                // Todo: 該当箇所を光らせる
                if (Teihan)
                {
                    RouteSet(Name);
                }
                else
                {
                    RouteReset(Name);
                }
            });
        }

        /// <summary>
        /// 進路が反位になったときに走らせる関数。
        /// </summary>
        static internal void RouteSet(string Name)
        {
            Debug.WriteLine($"Set:{Name}");
            Debug.WriteLine($"Set:{RouteButtonImage1[Name]}");
            RouteButtonList[Name].Image = RouteButtonImage1[Name];
        }

        /// <summary>
        /// 進路が定位になったときに走らせる関数。
        /// </summary>
        static internal void RouteReset(string Name)
        {
            Debug.WriteLine($"Reset:{Name}");
            Debug.WriteLine($"Set:{RouteButtonImage0[Name]}");
            RouteButtonList[Name].Image = RouteButtonImage0[Name];
        }

        /// <summary>
        /// 列車の在線状況が変化したときに呼ばれる関数。
        /// </summary>   
        /// <param name="Name">回路名称(鯖側)</param>     
        /// <param name="Train">列車番号</param>
        static internal void TrackChenge(string Name, string Train)
        {
            Debug.WriteLine($"Chenge:{Name}/{Train}");
            tsuzakiWindow.TrackChenge(Name, Train);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            showtsuzakiWindow = !showtsuzakiWindow;
            if (showtsuzakiWindow)
            {
                tsuzakiWindow.Show();
            }
            else
            {
                tsuzakiWindow.Hide();
            }
        }
    }
}