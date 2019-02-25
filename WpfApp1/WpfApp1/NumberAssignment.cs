using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public List<int> callPerm1()
        {
            Perm1 = new List<int>();
            for (int i = 0; i < 81; i++)
            {
                Perm1.Add(0);

            }

            Perm1[0] = 2;
            Perm1[5] = 5;
            Perm1[10] = 6;
            Perm1[15] = 5;
            Perm1[16] = 9;
            Perm1[18] = 5;
            Perm1[19] = 9;
            Perm1[20] = 4;
            Perm1[21] = 3;
            Perm1[25] = 7;
            Perm1[28] = 3;
            Perm1[29] = 2;
            Perm1[31] = 5;
            Perm1[33] = 7;
            Perm1[36] = 4;
            Perm1[40] = 8;
            Perm1[44] = 9;
            Perm1[47] = 7;
            Perm1[49] = 3;
            Perm1[51] = 6;
            Perm1[52] = 5;
            Perm1[55] = 5;
            Perm1[59] = 7;
            Perm1[60] = 9;
            Perm1[61] = 6;
            Perm1[62] = 4;
            Perm1[64] = 4;
            Perm1[65] = 9;
            Perm1[70] = 8;
            Perm1[75] = 9;
            Perm1[80] = 5;
            return Perm1;
             
        }
    }
}
