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

namespace PractRab6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            scaleSlider.ValueChanged += ScaleSlider_ValueChanged;
        }

        private void Close(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Clear(object sender, RoutedEventArgs e)
        {
            TB1.Text = "";
            TB2.Text = "";
        }

        private void ScaleSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            double scaleValue = scaleSlider.Value;

            // Применяем масштабирование к корневому элементу Grid
            // Вы можете также применить масштабирование к другим элементам интерфейса по мере необходимости
            grid1.LayoutTransform = new ScaleTransform(scaleValue, scaleValue);
        }

    }
}
