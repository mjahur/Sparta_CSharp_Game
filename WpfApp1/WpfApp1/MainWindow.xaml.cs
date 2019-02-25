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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NumberAssignment NA = new NumberAssignment();
        public MainWindow()
        {
            NumberAssignment NA = new NumberAssignment();
            NA.callPerm1();

            InitializeComponent();
            for (int i = 0; i < NA.callPerm1().Count; i++)
            {
                int x = i
            }
        }

        private void B_1_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

        }

        private void B_9_DragDelta(object sender, System.Windows.Controls.Primitives.DragDeltaEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void T_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
