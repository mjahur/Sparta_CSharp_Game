using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using UserInput;
using Microsoft.VisualBasic;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User_Input ui = new User_Input();
        public MainWindow()
        {
            InitializeComponent();
            BuildSudokuGrid();


        }

        int[,] SudokuArray = new int[9, 9]
        {
            {5,0,0,1,0,0,0,0,0},
            {0,9,6,0,0,0,8,2,0},
            {0,0,0,0,0,7,0,0,9},
            {0,0,0,0,0,3,0,0,6},
            {0,7,4,0,0,0,9,1,0},
            {2,0,0,5,0,0,0,0,0},
            {7,0,0,6,0,0,0,0,0},
            {0,8,3,0,0,0,5,7,0},
            {0,0,0,0,0,4,0,0,1},
        };

        public Button getGridChild(int r, int c)
        {
            for (int i = 0; i < SudokuGrid.Children.Count; i++)
            {
                Button e = (Button) SudokuGrid.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    return e;
            }
            return null;
        }

        public void BuildSudokuGrid()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                     if (SudokuArray[i,j] != 0)
                    {
                        getGridChild(i, j).Content = SudokuArray[i, j];
                    }
                }
            }
        }

        public void SubGridValidity()
        {
            foreach (var item in this.SudokuGrid.Children)
            {
                Grid subgrid = (Grid)item;
                for (int i = 0; i < subgrid.Children.Count; i++)
                {
                    TextBox e = (TextBox)subgrid.Children[i];
                    for (int j = 0; j < subgrid.Children.Count; j++)
                    {
                        TextBox f = (TextBox)subgrid.Children[j];

                        if (f != e && f.Text == e.Text)
                        {
                            e.Text = null;
                        }
                    }
                }
            }
        }

        public void UserInput()
        {
            Interaction.InputBox("Select ", "Title", "Default Text");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            HashSet<int> numbers = new HashSet<int>();
            var button = (Button)sender;

            for (int i = 1; i < 10; i++)
            {
                numbers.Add(i);
            }
                string x = Interaction.InputBox("Choice", "Enter choice", null);
            if(x == "1" || x == "2" || x == "3" || x == "4" || x == "5" || x == "6" || x == "7" || x == "8" || x == "9")
            {
                button. = Brushes.Blue;
                button.Content = Int32.Parse(x);
            }
            else
            {
                MessageBox.Show("You must enter a number between 1 and 9");
            }
        }
    }
   
}
