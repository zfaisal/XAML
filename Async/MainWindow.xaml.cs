using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Async
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Thread.Sleep(5000);

        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("buttonm was clicked");
            ComputeLongProcess();
        }


        private async void ComputeLongProcess()
        {
            Thread.Sleep(5000);
            Message.Text = "Unfrozen";
            await Task.Run(() => Thread.Sleep(12000));
            Message.Text = "Done"; 
        }
    }
}
