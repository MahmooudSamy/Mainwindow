using System;
using System.Collections.Generic;
using System.Text;
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

namespace WpfApp1.UserControls
{
    /// <summary>
    /// Interaction logic for SideMenu.xaml
    /// </summary>
    public partial class SideMenu : UserControl
    {
        public SideMenu()
        {
            InitializeComponent();
        }
        private bool StateClosed = true;
        private void TbWhareHouse_Checked(object sender, RoutedEventArgs e)
        {
            
                GridSubItem.Visibility = Visibility.Visible;
                Storyboard sb = FindResource("OpenSubMenu") as Storyboard;
                sb.Begin();
           
        }

        private void TbWhareHouse_Unchecked(object sender, RoutedEventArgs e)
        {
            Storyboard sb = FindResource("CloseSubMenu") as Storyboard;
            sb.Begin();
            GridSubItem.Visibility = Visibility.Collapsed;
        }
    }
}
