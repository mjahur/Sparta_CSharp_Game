using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Microsoft.VisualBasic;
using System.Drawing;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Functionality funct;
        public MainWindow()
        {
            InitializeComponent();
            funct = new Functionality(SudokuGrid);
            funct.BuildSudokuGrid(funct.SudokuArray);
            foreach (Button item in SudokuGrid.Children)
            {
                item.Click += button_Click;
            }
            void button_Click(object sender, RoutedEventArgs e)
            {
                bool whenToClose = true;
                funct.UserInput(sender);
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)
                    {
                        if (funct.getGridChild(i,j).Background != Brushes.Red && funct.SudokuArray[i,j] != 0)
                        {
                            whenToClose = whenToClose && true;
                        }
                        else
                        {
                            whenToClose = whenToClose && false;
                        }
                    }

                }
                if(whenToClose == true)
                {

                    this.Close();

                }

            }

        }


        private void Button_Click_95(object sender, RoutedEventArgs e)
        {
            Medium medium = new Medium();
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (funct.getGridChild(i,j).Foreground == Brushes.White)
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
