using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


namespace UserInput
{
    class User_Input
    {

        public UIElement subGrid(Grid g, int i)
        {
            return g.Children[i];
        }

        public void Validity(Grid g , int r, int c)
        {
            for (int i = 0; i < g.Children.Count; i++)
            {
                if (i == 0)
                {
                    Grid SubInt0 = (Grid)g.Children[i];

                }
                else if(i == 1)
                {
                    Grid SubInt1 = (Grid)g.Children[i];
                }
                else if (i == 2)
                {
                    Grid SubInt2 = (Grid)g.Children[i];
                }
                else if (i == 3)
                {
                    Grid SubInt3 = (Grid)g.Children[i];
                }
                else if (i == 4)
                {
                    Grid SubInt4 = (Grid)g.Children[i];
                }
                else if (i == 5)
                {
                    Grid SubInt5 = (Grid)g.Children[i];
                }
                else if (i == 6)
                {
                    Grid SubInt6 = (Grid)g.Children[i];
                }
                else if (i == 7)
                {
                    Grid SubInt7 = (Grid)g.Children[i];
                }
                else if (i == 8)
                {
                    Grid SubInt8 = (Grid)g.Children[i];
                }
            }
           
            /*for (int i = 0; i < g.Children.Count; i++)
            {

            }
           /* for (int i = 0; i < g.Children.Count; i++)
            {
                TextBox e = (TextBox) g.Children[i];
                if (Grid.GetRow(e) == r && Grid.GetColumn(e) == c)
                {
                    for (int j = 0; j < g.Children.Count; j++)
                    {
                        TextBox f = (TextBox)g.Children[j];

                        if (((Grid.GetRow(f)==Grid.GetRow(e)) && (Grid.GetColumn(f)!= Grid.GetColumn(e)) && f.Text == e.Text) 
                            || ((Grid.GetRow(f) != Grid.GetRow(e)) && (Grid.GetColumn(f) == Grid.GetColumn(e)) && (f.Text == e.Text) && e.Text != null))
                        {
                            MessageBox.Show("Repeat in a row or column");
                            e.Text = null;
                        }
                    }
                }

            }*/

        }
        
    }
}
