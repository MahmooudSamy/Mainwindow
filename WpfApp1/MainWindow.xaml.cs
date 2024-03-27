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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool StateClosed = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PART_TITLEBAR_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void PART_MAXIMIZE_RESTORE_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }
            else
            {
                Width = 1080;
                Height = 720;
                WindowState = WindowState.Normal;
            }
        }

        private void PART_MINIMIZE_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void PART_CLOSE_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void Border_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            if(e.ClickCount==2)
            {
                if (WindowState == WindowState.Normal)
                {
                    WindowState = WindowState.Maximized;
                }
                else
                {
                    Width = 1080;
                    Height = 720;
                    WindowState = WindowState.Normal;
                }
            }
            else
            {
                DragMove();
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void TopButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            if(StateClosed)
            {
                Storyboard sb1 = FindResource("OpenMargin") as Storyboard;
                Storyboard sb =FindResource("OpenMenu") as Storyboard;
                sb.Begin();
                sb1.Begin();
            }
            else
            {
                Storyboard sb1 = FindResource("CloseMargin") as Storyboard;
                Storyboard sb = FindResource("CloseMenu") as Storyboard;
                sb.Begin();
                sb1.Begin();
            }
            StateClosed = !StateClosed;
        }

        private void BtnNoty_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
