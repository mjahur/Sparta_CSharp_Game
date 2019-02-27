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

        public void UserInput(object sender)
        {
            var button = (Button)sender;

            string x = Interaction.InputBox("Choice", "Enter choice", null);
            if (x == "1" || x == "2" || x == "3" || x == "4" || x == "5" || x == "6" || x == "7" || x == "8" || x == "9")
            {
                button.Background = Brushes.Blue;
                button.Content = Int32.Parse(x);
            }
            else
            {
                MessageBox.Show("You must enter a number between 1 and 9");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_18(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_19(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_20(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_21(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_22(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_23(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_24(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_25(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_26(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_27(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_28(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_29(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_30(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_31(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_32(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_33(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_34(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_35(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_36(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_37(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_38(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_39(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_40(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_41(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_42(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_43(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_44(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_45(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_46(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_47(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_48(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_49(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_50(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_51(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_52(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_53(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_54(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_55(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_56(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }
    }
   
}
