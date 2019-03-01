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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Medium.xaml
    /// </summary>
    public partial class Medium : Window
    {
        FunctionalityMedium funct;
        public Medium()
        {
            InitializeComponent();
            funct = new FunctionalityMedium(SudokuGridMedium);
            funct.BuildSudokuGrid(funct.SudokuArray);
            foreach (Button item in SudokuGridMedium.Children)
            {
                item.Click += button_Click;
            }
             void button_Click(object sender, RoutedEventArgs e)
            {
                funct.UserInput(sender);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (funct.getGridChild(i, j).Foreground == Brushes.White)
                        {
                            funct.getGridChild(i, j).Content = null;
                            funct.getGridChild(i, j).Background = Brushes.LightSteelBlue;
                            funct.getGridChild(i, j).IsEnabled = true;
                            funct.SudokuArray[i, j] = 0;
                        }
                    }
                }

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (funct.getGridChild(i, j).Foreground == Brushes.White)
                    {
                        funct.getGridChild(i, j).Content = null;
                        funct.getGridChild(i, j).Background = Brushes.LightSteelBlue;
                        funct.getGridChild(i, j).IsEnabled = true;
                        funct.SudokuArray[i, j] = 0;
                    }
                }
            }
        }
    }
}
