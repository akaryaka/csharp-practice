using System.Data;
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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // проходим циклом по всем элементам внутри MainRoot, т.е. <Grid>
            foreach (UIElement el in MainRoot.Children)
            {
                // делаем проверку на кнопку
                if (el is Button)
                {
                    // добавляем метод клика
                    ((Button)el).Click += Button_Click;
                }
            }
        }
        // метод клика по кнопке
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // получаем надпись с кнопки
            string str = (string)((Button)e.OriginalSource).Content;
            // если кликаем по кнопке C - очищаем поле вывода чисел
            if (str == "C")
            {
                output.Text = "";
            } else if (str == "=")
            {
                // чтобы использовать DataTable необходимо импортировать его
                // используя using System.Data;
                // метод Compute берет строку вида 5+5 с любым мат. действием и возвращает результат
                string value = new DataTable().Compute(output.Text, null).ToString();
                output.Text = value;
            }
            else
            {
                // записываем значение с кнопки в поле вывода
                output.Text += str;
            }
        }
    }
}