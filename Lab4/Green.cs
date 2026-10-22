using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int cntp = 0;
            double sum = 0;
            int end = array.Length;

            for (int i = 0; i < end; i++)
            {
                if (array[i] > 0)
                {
                    cntp++;
                    sum += array[i];
                }
            }

            if (cntp > 0)
            {
                double sr = sum / cntp;

                for (int i = 0; i < end; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = sr;
                    }
                }
            }

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int cnt = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    cnt++;
                    break;
                }
                sum += array[i] * array[i];
            }
            // end
            if (cnt == 0) sum = 0;
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            int max = array[0];
            int min = array[0];
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
                min = Math.Min(min, array[i]);
            }
            int cmax = -1;
            int cmin = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) cmax = i;
                if (array[i] == min) cmin = i;
            }
            int countminus = 0;
            for (int i = Math.Min(cmax, cmin) + 1; i < Math.Max(cmax, cmin); i++)
            {
                if (array[i] < 0) countminus++;
            }
            negatives = new int[countminus];
            int index = 0;
            for (int i = Math.Min(cmax, cmin) + 1; i < Math.Max(cmax, cmin); i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }
            // end
            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -2 * 10000;
            int cmax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    i = cmax;
                }
            }

            int firstminus = 0;
            int cfirstminus = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    firstminus = array[i];
                    cfirstminus = i;
                    break;
                }
            }
            array[cfirstminus] = max;
            array[cmax] = firstminus;
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = -2 * 100000;
            int count = 0;
            for (int i = 0; i < array.Length; i++) max = Math.Max(max, array[i]);
            for (int i = 0; i < array.Length; i++) if (array[i] == max) count++;
            int index = 0;
            answer = new int[count];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index] = i;
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -2 * 10000;
            int uvelichenie = 1;
            for (int i = 0; i < array.Length; i++) max = Math.Max(max, array[i]);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += uvelichenie;
                    uvelichenie++;
                }
            }


            // end
        }
        public void Task7(int[] array)
        {

            // code here
            int max = -2 * 100000;
            for (int i = 0; i < array.Length; i++) max = Math.Max(max, array[i]);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] == max)
                {
                    int sum = 0;
                    for (int j = i - 1; j >= 0; j--) sum += array[j];
                    array[i] = sum;
                }
            }


            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            length = 1;
            int maxlength = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1]) length++;
                else
                {
                    if (length > maxlength) maxlength = length;
                    length = 1;
                }
            }
            if (length > maxlength) maxlength = length;
            // end

            return maxlength;
        }
        public void Task9(int[] array)
        {

            // code here
            int countchet = 0;
            for (int i = 0; i < array.Length; i++) if (i % 2 == 0) countchet++;
            int[] novi = new int[countchet];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    novi[index] = array[i];
                    index++;
                }
            }
            Array.Sort(novi);
            index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = novi[index];
                    index++;
                }
            }
                // end

            }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here

            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here

            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here

            // end

            return wins;

        }
    }
}