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
using static System.Windows.Media.Colors;
using System.Drawing;

namespace Calculator;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnCalculateOnClick(object sender, RoutedEventArgs e)
    {
        if (double.TryParse(TxtHeight.Text, out double height) &&
            double.TryParse(TxtWeight.Text, out double weight) &&
        double.TryParse(TxtUglevod.Text, out double uglevod))
        {
        
            double imt = (height * 4) + (weight * 9) + (uglevod * 4);

            TxtResult.Text = $"Всего калорий: {imt}";

            string status = "";
            string recomendations = "";
            
        }
        else
        {
            MessageBox.Show("Пожалуйста, введите корректные значения", "Ошибка ввода");
        }
    }
}