using System;
using Microsoft.Win32.SafeHandles;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            double sumpos = 0;
            int k = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    sumpos += array[i];
                    k++;
                }
            }
            sumpos /= k;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sumpos;
                }
            }
        }



        public int Task2(int[] array)
        {
            int sum = 0;
            int n = array.Length;
            int flag = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    flag = 1;
                }
                if (flag == 0)
                {
                    sum += array[i] * array[i];
                }
            }
            return sum;
        }



        public int[] Task3(int[] array)
        {
            int n = array.Length;
            int maxx = -999;
            int maxdex = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    maxdex = i;
                }
            }
            int minn = 999;
            int mindex = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < minn)
                {
                    minn = array[i];
                    mindex = i;
                }
            }
            int k = 0;
            if (maxdex > mindex)
            {
                for (int j = mindex+1; j < maxdex; j++)
                {
                    if (array[j] < 0)
                    {
                        k++;
                    }
                }
                int[] negatives = new int[k];
                int ii = 0;
                for (int j = mindex + 1; j < maxdex; j++)
                {
                    if (array[j] < 0)
                    {
                        negatives[ii] = array[j];
                        ii++;
                    }
                }
                return negatives;
            }
            else
            {
                for (int j = maxdex + 1; j < mindex; j++)
                {
                    if (array[j] < 0)
                    {
                        k++;
                    }
                }
                int[] negatives = new int[k];
                int ii = 0;
                for (int j = maxdex + 1; j < mindex; j++)
                {
                    if (array[j] < 0)
                    {
                        negatives[ii] = array[j];
                        ii++;
                    }
                }
                return negatives;
            }
        }



        public void Task4(int[] array)
        {
            int n = array.Length;
            int maxx = -999;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                }
                if (array[i] == array[n-1])
                {
                    break;
                }
                i++;
            }
            int minmin = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    minmin = array[i];
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == maxx)
                {
                    array[i] = minmin;
                }
                if (array[i] == minmin)
                {
                    array[i] = maxx;
                }
            }
        }



        public int[] Task5(int[] array)
        {
            int n = array.Length;
            int k = 0;
            int maxx = -999;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= maxx)
                {
                    maxx = array[i];
                }
            }
            for(int i = 0; i < n; i++)
            {
                if (array[i] == maxx)
                {
                    k++;
                }
            }
            int[] answer = new int[k];
            int ii = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == maxx)
                {
                    answer[ii] = i;
                    ii++;
                }
            }
            return answer;
        }



        public void Task6(int[] array)
        {
            int n = array.Length;
            int maxx = -999;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= maxx)
                {
                    maxx = array[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == maxx)
                {
                    array[i] += i;
                }
            }
        }



        public void Task7(int[] array)
        {
            int n = array.Length;
            int maxx = -999;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                }
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] == maxx)
                {
                    array[i] = sum;
                }
                sum += array[i];
            }
        }



        public int Task8(int[] array)
        {
            int length = 0;
            int n = array.Length;
            int k = 1;
            int kk = 0;
            for (int i = 0; i < n-1; i++)
            {
                if (array[i] > array[i+1])
                {
                    k++;
                }
                else
                {
                    if (k > kk)
                    {
                        kk = k;
                    }
                    k = 1;
                }
                i++;
            }
            length = kk;
            return length;
        }



        public void Task9(int[] array)
        {
            int minus = 0;
            int n = array.Length;
            if (n % 2 == 0)
            {
                minus = 2;
            }
            else
            {
                minus = 1;
            }
            for (int i = 0; i < n-minus; i += 2)
            {
                for (int j = 0; j < n-minus; j += 2)
                {
                    if (array[j] > array[j + 2])
                    {
                        int temp = array[j + 2];
                        array[j + 2] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }



        public int[] Task10(int[] array)
        {
            int n = array.Length;
            int[] arrtwo = array;
            for (int j = 0; j < n; j++)
            {
                for (int l = 0; l < n-j-1; l++)
                {
                    if (array[l] > array[l + 1]){
                        int temp = array[l];
                        array[l] = array[l + 1];
                        array[l + 1] = temp;
                    }
                }
            }
            int ii = 0;
            for (int j = 0; j < n-1; j++)
            {
                int flag = 0;
                if (array[j] == array[j + 1])
                {
                    flag = 1;
                }
                if (flag == 0)
                {
                    ii++;
                }
                flag = 0;
            }
            ii++;
            int[] cleared = new int[ii];
            for (int j = 0; j < n; j++)
            {
                for (int l = j+1; l < n; l++)
                {
                    if (arrtwo[j] == arrtwo[l])
                    {
                        arrtwo[l] = 9999999;
                    }
                }
            }
            ii = 0;
            for (int j = 0; j < n; j++)
            {
                if (arrtwo[j] != 9999999)
                {
                    cleared[ii] = arrtwo[j];
                    ii++;
                }
            }
            return cleared;
        }



        public double[] Task11(double a, double b, int n)
        {
            double[] A = new double[n];
            double summ = 0;
            int k = 0;
            int n1 = 0;
            for (int i = 0; i < n; i++)
            {
                A[i] = a + (b - a) / n * i;
                if (A[i] > 0)
                {
                    summ += a + (b - a) / n * i;
                    n1++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (A[i] > summ / n1)
                {
                    k++;
                }
            }
            double[] B = new double[k];
            int ii = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > summ / n1)
                {
                    B[ii] = A[i];
                    ii++;
                }
            }
            return B;
        }



        public int Task12(int[] dices)
        {
            int wins = 0;
            int n = dices.Length;
            int ii = 0;
            int penalty = 0;
            for (int i = 0; i < n; i++)
            {
                dices[i] -= penalty;
                if ((dices[i] + penalty) == 6)
                {
                    penalty++;
                }
                if (dices[i] < 1)
                {
                    dices[i] = 1;
                }
                if (dices[i] > (6 - ii))
                {
                    wins++;
                }
                if (ii < 5)
                {
                    ii++;
                }
            }
            return wins;
        }
    }
}
