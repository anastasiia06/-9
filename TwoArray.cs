using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp9
{
    internal class TwoArray
    {
        public bool error = false;
        int[,] a;
        int lengthi; 
        int lengthj; 

        public TwoArray(int size1, int size2)
        {
            a = new int[size1, size2];
            lengthi = size1;
            lengthj = size2;
        }

        public int Lengthi
        {
            get { return lengthi; }
        }

        public int Lengthj
        {
            get { return lengthj; }
        }

        public int this[int i, int j]
        {
            get
            {
                if ((i >= 0 && i < lengthi) && (j >= 0 && j < lengthj))
                    return a[i, j];
                else
                {
                    error = true;
                    return 0;
                }
            }
            set
            {
                if ((i >= 0 && i < lengthi) && (j >= 0 && j < lengthj) && value >= 0 && value <= 1000)
                    a[i, j] = value;
                else
                    error = true;
            }
        }

        public int[] Min
        {
            get
            {
                int s = 0;
                int[] summ = new int[lengthi];
                for (int i = 0; i < lengthi; i++)
                {
                    for (int j = 0; j < lengthj; j++)
                    {
                        s += a[i, j];
                    }
                    summ[i] = s;
                    s = 0;
                }

                int min = summ[0];
                int indexMin = 0;
                int[] massiv = new int[summ.Length + 1];

                for (int i = 0; i < summ.Length; i++)
                {
                    if (summ[i] < min)
                    {
                        min = summ[i];
                        indexMin = i;
                    }
                }

                massiv[0] = indexMin;
                for (int i = 0; i < summ.Length; i++)
                {
                    massiv[i + 1] = summ[i];
                }

                return massiv;
            }
        }
    }
}
