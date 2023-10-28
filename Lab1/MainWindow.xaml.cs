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

namespace Lab1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Semisphere sph;
            int R, A, X, Y;

            try {
                R = Convert.ToInt32(r.Text);
                A = Convert.ToInt32(a.Text);
                X = Convert.ToInt32(x.Text);
                Y = Convert.ToInt32(y.Text);

                if (A == 0) {
                    sph = new Semisphere(R);
                }
                else if ((R == 0) && (A == 0)) {
                    sph = new Semisphere();
                }
                else {
                    sph = new Semisphere(R, A);
                }             

                area.Content = Math.Round(sph.CalculateArea(), 2);
                arc.Content = Math.Round(sph.CalculateArcLength(), 2);
                answer.Content = sph.IsPointInside(X, Y);
            }
            catch {
                MessageBox.Show("Виникла помилка");
            }
        }
    }
}
