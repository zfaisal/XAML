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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        People ppl ;
        Person p;
        public MainWindow()
        {
            InitializeComponent();
            ppl = new People();
            ppl.p = new Person();
            ppl.p.Id = 89;
             p = new Person { Id = 56 };
            DataContext = ppl;
        }

        private void btn_Change(object sender, RoutedEventArgs e)
        {
           ppl.p.Id = 190;
           //MessageBox.Show(p.Id.ToString());
            //DataContext = ppl;
        }
    }
}
