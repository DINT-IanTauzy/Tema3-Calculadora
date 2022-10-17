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

namespace Tema3_Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int num = 1;
            for(int i = 1; i < 4; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Button b = new Button();
                    Viewbox v = new Viewbox();
                    TextBlock t = new TextBlock();
                    t.Text = num.ToString();
                    b.Tag = num.ToString();
                    v.Child = t;
                    b.Content = v;
                    Grid.SetRow(b, i);
                    Grid.SetColumn(b, j);
                    ContenedorGrid.Children.Add(b);
                    num++;
                }
            }
        }

        private void ClickButton(object sender, RoutedEventArgs e)
        {
            Button boton = (Button)sender;
            MostrarNumerosTextBlock.Text += boton.Tag.ToString();
        }

    }
}
