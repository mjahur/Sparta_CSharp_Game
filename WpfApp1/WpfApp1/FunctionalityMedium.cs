using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfApp1
{
    class FunctionalityMedium
    {
        Grid gd;
        public FunctionalityMedium(Grid x)
        {
            gd = x;
            SudokuArray = ChooseSudokuArray();
        }
        public int[,] SudokuArray;
        public bool EachBoxFullfillCondition(int[,] array, int i, int j)
        {
            if (array[i, j] != 0 && getGridChild(i, j).Background != Brushes.Red
)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Button getGridChild(int r, int c)
        {
            for (int i = 0; i < gd.Children.Count; i++)
            {
                Button e = (Button)gd.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                    return e;
            }
            return null;
        }

        public int[,] ChooseSudokuArray()
        {
            Random rnd = new Random();
            int x = rnd.Next(5);
            if (x == 0)
            {
                SudokuArray = new int[9, 9]{
                   {8,7,6,9,0,0,0,0,0},
                   {0,1,0,0,0,6,0,0,0},
                   {0,4,0,3,0,5,8,0,0},
                   {4,0,0,0,0,0,2,1,0},
                   {0,9,0,5,0,0,0,0,0},
                   {0,5,0,0,4,0,3,0,6},
                   {0,2,9,0,0,0,0,0,8},
                   {0,0,4,6,9,0,1,7,3},
                   {0,0,0,0,0,1,0,0,4},
                  };
            }
            else if (x == 1)
            {
                SudokuArray = new int[9, 9]
                  {
                   {0,0,6,0,0,0,3,0,0},
                   {0,5,0,0,0,0,0,8,0},
                   {1,0,0,0,0,0,0,0,7},
                   {0,8,0,0,9,0,0,4,0},
                   {0,0,9,2,7,1,5,0,0},
                   {0,0,0,4,0,6,0,0,0},
                   {0,0,1,8,0,3,9,0,0},
                   {9,0,0,0,0,0,0,0,6},
                   {6,4,8,0,0,0,2,7,3},
                  };

            }
            else if (x == 2)
            {
                SudokuArray = new int[9, 9]
                  {
                   {7,0,9,4,1,2,0,0,3},
                   {2,8,6,9,0,0,0,4,0},
                   {0,1,0,0,8,0,0,2,0},
                   {0,0,4,2,0,0,8,3,6},
                   {8,0,0,0,4,7,0,5,9},
                   {0,0,5,0,0,1,2,0,0},
                   {0,0,0,0,3,8,0,0,0},
                   {0,3,0,6,0,4,0,0,2},
                   {9,0,0,7,2,0,3,0,0},
                  };

            }
            else if (x == 3)
            {
                SudokuArray = new int[9, 9]
                  {
                   {3,4,0,0,0,9,0,0,1},
                   {0,1,9,0,0,0,2,0,0},
                   {6,0,5,0,1,0,9,4,0},
                   {0,5,0,3,0,7,1,0,0},
                   {2,0,0,6,0,1,0,5,0},
                   {1,3,0,0,0,0,6,9,0},
                   {5,0,0,0,2,0,7,0,6},
                   {4,0,0,0,0,0,0,3,5},
                   {0,0,7,1,0,0,4,2,0},
                  };

            }
            else if (x == 4)
            {
                SudokuArray = new int[9, 9]
                  {
                   {1,2,7,6,9,3,4,8,0},
                   {0,8,0,0,2,0,1,0,0},
                   {9,0,0,1,0,0,0,3,0},
                   {0,1,9,2,7,6,0,0,0},
                   {0,0,0,8,0,0,6,0,0},
                   {0,5,2,0,0,0,9,0,8},
                   {0,0,0,3,0,5,0,6,9},
                   {0,9,0,0,0,0,0,1,0},
                   {3,7,6,9,0,2,0,0,0},
                  };
            }
            return SudokuArray;
        }

        public void BuildSudokuGrid(int[,] array)
        {

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (array[i, j] != 0)
                    {
                        getGridChild(i, j).Content = array[i, j];
                        getGridChild(i, j).Foreground = Brushes.BlueViolet;
                        getGridChild(i, j).FontSize = 30;
                    }
                    if (array[i, j] == 0)
                    {
                        getGridChild(i, j).Foreground = Brushes.White;
                        getGridChild(i, j).FontSize = 30;
                    }
                }
            }
        }

        public void LoopThroughChosenBox(int r, int c, int x, int y)
        {
            if ((x == 0 || x == 3 || x == 6) && (y == 0 || y == 3 || y == 6))
            {
                for (int i = x; i < x + 3; i++)
                {
                    for (int j = y; j < y + 3; j++)
                    {
                        if (SudokuArray[r, c] == SudokuArray[i, j] & r != i & c != j)
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
            if (button.Foreground != Brushes.BlueViolet && getGridChild(Grid.GetRow(button), Grid.GetColumn(button)) != getGridChild(9,3))
            {

                string x = Interaction.InputBox("Enter choice (enter 0 to clear)", "Choice", null);
                if (x == "1" || x == "2" || x == "3" || x == "4" || x == "5" || x == "6" || x == "7" || x == "8" || x == "9" || x == "0")
                {
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            getGridChild(i, j).Background = Brushes.LightSteelBlue;
                            getGridChild(i, j).IsEnabled = true;
                        }
                    }

                    if (x == "0")
                    {
                        SudokuArray[r, c] = Int32.Parse(x);
                        button.Content = null;
                    }
                    else
                    {//Assign value entered by user + Update Array with new value

                        SudokuArray[r, c] = Int32.Parse(x);
                        button.Content = SudokuArray[r, c];


                        //Highlight repeats in row and columns and disable all else.
                        for (int i = 0; i < 9; i++)
                        {
                            if (SudokuArray[i, c] == SudokuArray[r, c] && i != r)
                            {
                                button.Background = Brushes.Red;
                                getGridChild(i, c).Background = Brushes.Red;

                            }
                            if (SudokuArray[r, i] == SudokuArray[r, c] && i != c)
                            {
                                button.Background = Brushes.Red;
                                getGridChild(r, i).Background = Brushes.Red;

                            }
                        }
                        //Highlight repeats in box and disable all else.
                        int k;
                        int l;
                        if (r == 0 || r == 1 || r == 2)
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
                            foreach (Button item in gd.Children)
                            {

                                if (getGridChild(Grid.GetRow(item), Grid.GetColumn(item)).Background == Brushes.LightSteelBlue && getGridChild(9, 3) != getGridChild(Grid.GetRow(item), Grid.GetColumn(item)))
                                {
                                    item.IsEnabled = false;
                                }
                            }
                        }

                    }

                    bool win = true;
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {
                            if (SudokuArray[i, j] != 0)
                            {
                                win = win && true;
                            }
                            else
                            {
                                win = win && false;
                            }
                        }
                    }
                    if (win == true)
                    {
                        MessageBox.Show("You win");
                    }


                }
                else
                {
                    MessageBox.Show("You must enter a number between 0 and 9");
                }
            }

        }
        

        
    }
}
