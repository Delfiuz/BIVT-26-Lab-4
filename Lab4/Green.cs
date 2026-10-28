using System;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            int i = 0;
            double sumpos = 0;
            int k = 0;
            while (true)
            {
                if (array[i] > 0)
                {
                    sumpos += array[i];
                    k++;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            i = 0;
            while (true)
            {
                if (array[i] > 0)
                {
                    array[i] = sumpos / k;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
        }



        public int Task2(int[] array)
        {
            int sum = 0;
            int i = 0;
            while (true)
            {
                if (array[i] < 0)
                {
                    break;
                }
                sum += array[i];
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            return sum;
        }



        public int[] Task3(int[] array)
        {
            int i = 0;
            int maxx = -999;
            int maxdex = 0;
            while (true)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    maxdex = i;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            i = 0;
            int minn = 999;
            int mindex = 0;
            while (true)
            {
                if (array[i] < minn)
                {
                    minn = array[i];
                    mindex = i;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            i = 0;
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
            int i = 0;
            int maxx = -999;
            while (true)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            i = 0;
            int minmin = 0;
            while (true)
            {
                if (array[i] < 0)
                {
                    minmin = array[i];
                    break;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            i = 0;
            while (true)
            {
                if (array[i] == maxx)
                {
                    array[i] = minmin;
                }
                if (array[i] == minmin)
                {
                    array[i] = maxx;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
        }



        public int[] Task5(int[] array)
        {
            int i = 0;
            int k = 0;
            int maxx = -999;
            while (true)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                    k++;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            int[] answer = new int[k];
            i = 0;
            int ii = 0;
            while (true)
            {
                if (array[i] == maxx)
                {
                    answer[ii] = i;
                    ii++;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            return answer;
        }



        public void Task6(int[] array)
        {
            int i = 0;
            int maxx = -999;
            while (true)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            i = 0;
            while (true)
            {
                if (array[i] == maxx)
                {
                    array[i] += i;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
        }



        public void Task7(int[] array)
        {
            int i = 0;
            int maxx = -999;
            while (true)
            {
                if (array[i] > maxx)
                {
                    maxx = array[i];
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            i = 0;
            while (true)
            {
                int sum = 0;
                if (array[i] == maxx)
                {
                    for (int j = 0; j < i-1; j++)
                    {
                        sum += array[i]; 
                    }
                    array[i] = sum;
                }
                if (array[i] == array[-1])
                {
                    break;
                }
                i++; ;
            }
        }



        public int Task8(int[] array)
        {
            int length = 0;
            int i = 1;
            int k = 1;
            int kk = 0;
            while (true)
            {
                if (array[i] < array[i-1])
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
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            length = kk;
            return length;
        }



        public void Task9(int[] array)
        {
            int n = 0;
            while (true)
            {
                if (array[n] == array[-1])
                {
                    break;
                }
                n++;
            }
            for (int i = 0; i < n-2; i += 2)
            {
                for (int j = 0; j < n-2; j += 2)
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
            int i = 0;
            int[] arrtwo = array;
            while (true)
            {
                if (array[i] == array[-1])
                {
                    break;
                }
                i++;
            }
            for (int j = 0; j < i; j++)
            {
                for (int l = 0; l < i-j-1; l++)
                {
                    if (array[l] > array[l + 1]){
                        int temp = array[l];
                        array[l] = array[l + 1];
                        array[l + 1] = temp;
                    }
                }
            }
            int ii = 0;
            for (int j = 0; j < i-1; j++)
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
            int[] cleared = new int[ii];
            for (int j = 0; j < i; j++)
            {
                for (int l = j; l < i; l++)
                {
                    if (arrtwo[j] == arrtwo[l])
                    {
                        arrtwo[l] = 9999999;
                    }
                }
            }
            ii = 0;
            for (int j = 0; j < i; j++)
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
            for (int i = 0; i < n; i++)
            {
                A[i] = a + (b - a) / n * i;
                summ += a + (b - a) / n * i;
            }
            for (int i = 0; i < n; i++)
            {
                if (A[i] > summ / n)
                {
                    k++;
                }
            }
            double[] B = new double[k];
            int ii = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > summ / n)
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
            int i = 0;
            int ii = 0;
            int penalty = 0;
            while (true)
            {
                dices[i] -= penalty;
                if (penalty > 5)
                {
                    penalty = 5;
                }
                dices[i] -= penalty;
                if (dices[i]+penalty == 6)
                {
                    penalty++;
                }
                if (dices[i] > 6 - ii)
                {
                    wins++;
                }
                if (dices[i] == dices[-1])
                {
                    break;
                }
                i++;
                if (ii < 5)
                {
                    ii++;
                }
            }
            return wins;
        }
    }
}
