using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using UserInput;
using Microsoft.VisualBasic;
using System.Drawing;

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
            BuildSudokuGrid(SudokuArray);


        }


        public Button getGridChild(int r, int c)
        {
            for (int i = 0; i < this.SudokuGrid.Children.Count; i++)
            {
                Button e = (Button) this.SudokuGrid.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    return e;
            }
            return null;
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

        public void BuildSudokuGrid(int[, ] array)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                     if (array[i,j] != 0)
                    {
                        getGridChild(i,j).Content = array[i, j];
                        getGridChild(i, j).Foreground = Brushes.AliceBlue;
                    }
                }
            }
        }

        public void LoopThroughChosenBox(int r, int c, int x, int y)
        { 
            if ((x == 0|| x == 3 || x == 6 ) && (y == 0 || y == 3 || y == 6))
            {
                for (int i = x; i < x + 3; i++)
                {
                    for (int j = y; j < y + 3; j++)
                    {
                        if(SudokuArray[r,c] == SudokuArray[i, j] & r != i & c != j)
                        {
                            getGridChild(r, c).Background = Brushes.Red;
                            getGridChild(i, j).Background = Brushes.Red;
                        }
                    }
                }
            }
            
        }

        public void UserInput(object sender)
        {
            var button = (Button)sender;
            int r = Grid.GetRow(button);
            int c = Grid.GetColumn(button);
            string x = Interaction.InputBox("Enter choice (enter 0 to clear)","Choice", null);
            if (x == "1" || x == "2" || x == "3" || x == "4" || x == "5" || x == "6" || x == "7" || x == "8" || x == "9" || x == "0")
            {
                foreach (Button item in SudokuGrid.Children)
                {
                    item.Background = Brushes.LightSteelBlue;
                }
                foreach (Button item in SudokuGrid.Children)
                {
                    item.IsEnabled = true;
                }
                if (x == "0")
                {
                    button.Content = null;
                    SudokuArray[r, c] = Int32.Parse(x);
                }
                else
                {//Assign value entered by user + Update Array with new value
                   
                    SudokuArray[r, c] = Int32.Parse(x);
                    button.Content = SudokuArray[r,c];
                    
                    
                    //Highlight repeats in row and columns and disable all else.
                    for (int i = 0; i < 9; i++) 
                    {
                                if (SudokuArray[i, c] == SudokuArray[r, c] && i != r)
                                {
                                    button.Background = Brushes.Red;
                                    getGridChild(i, c).Background = Brushes.Red;
                                  
                                }
                                else if (SudokuArray[r, i] == SudokuArray[r, c] && i != c)
                                {
                                    button.Background = Brushes.Red;
                                    getGridChild(r, i).Background = Brushes.Red;
                                   
                                }
                    }
                    //Highlight repeats in box and disable all else.
                    int k;
                    int l;
                    if (r==0 || r== 1 || r==2)
                    {
                         k = 0;
                    }
                    else if (r == 3 || r == 4 || r == 5)
                    {
                         k = 3;
                    }
                    else
                    {
                         k = 6;
                    }

                    if (c == 0 || c == 1 || c == 2)
                    {
                         l = 0;
                    }
                    else if (c == 3 || c == 4 || c == 5)
                    {
                         l = 3;
                    }
                    else
                    {
                         l = 6;
                    }
                    LoopThroughChosenBox(r, c, k, l);

                    if (button.Background == Brushes.Red)
                    {
                        foreach (Button item in SudokuGrid.Children)
                        {

                            if (getGridChild(Grid.GetRow(item), Grid.GetColumn(item)).Background == Brushes.LightSteelBlue)
                            {
                                item.IsEnabled = false;
                            }
                        }
                    }

                    
                 
                }

            }
            else
            {
                MessageBox.Show("You must enter a number between 0 and 9");
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

        private void Button_Click_57(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click_58(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_59(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_60(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_61(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_62(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_63(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_64(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_65(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_66(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_67(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_68(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_69(object sender, RoutedEventArgs e)
        {
            UserInput(sender);
        }

        private void Button_Click_70(object sender, RoutedEventArgs e)
        {
          
        }
    }
   
}
