using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    class NumberAssignment
    {

        List<int> perm1;
        List<int> perm2;
        List<int> perm3;
        List<int> perm4;

        public List<int> Perm1 { get => perm1; set => perm1 = value; }
        public List<int> Perm2 { get => perm2; set => perm2 = value; }
        public List<int> Perm3 { get => perm3; set => perm3 = value; }
        public List<int> Perm4 { get => perm4; set => perm4 = value; }

        public NumberAssignment()
        {
        }

        public void textChangedEventHandler(object sender, TextChangedEventArgs args)
        {
            
        }
    }
}
