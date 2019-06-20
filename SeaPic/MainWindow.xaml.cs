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
using System.Windows.Annotations;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media.Animation;

namespace SeaPic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Menu button flag to open or close stack panel, if FALSE it is open
        private bool menuButtonFlag = false;
        #endregion
        #region Public
        #endregion
        #region Private
        #endregion
        public MainWindow()
        {
            InitializeComponent();

        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (menuButtonFlag && MenuStackPanel.Height <= 55)
            {
                DoubleAnimation da = new DoubleAnimation();
                da.From = 50;
                da.To = 871;
                da.Duration = TimeSpan.FromSeconds(0.5);
                MenuStackPanel.BeginAnimation(StackPanel.HeightProperty, da);
                menuButtonFlag = false;
            }
            else if (MenuStackPanel.Height >= 865)
            {
                DoubleAnimation da1 = new DoubleAnimation();
                da1.From = MenuStackPanel.ActualHeight;
                da1.To = 50;
                da1.Duration = TimeSpan.FromSeconds(0.5);
                MenuStackPanel.BeginAnimation(StackPanel.HeightProperty, da1);
                menuButtonFlag = true;
            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
