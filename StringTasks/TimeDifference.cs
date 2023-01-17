using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    internal class TimeDifference
    {
        internal int[] DiffTime(string time1, string time2)
        {
            // : silinmesi
            char sp1 = time1[2];
            char sp2 = time1[5];
            string[] timeN = time1.Split(sp1, sp2);

            char sp3 = time2[2];
            char sp4 = time2[5];
            string[] timeM = time2.Split(sp3, sp4);

            //Alinan ededden massiv yaranmasi
            int[] FirstTime = new int[timeN.Length];
            int[] SecondTime = new int[timeN.Length];
            int[] tdiff = new int[timeN.Length];
            int f = 0;

            for (int i = 0; i < timeN.Length; i++)
            {
                FirstTime[i] = int.Parse(timeN[i]);
                SecondTime[i] = int.Parse(timeM[i]);
            }

            for (int i = timeN.Length - 1; i <= 0; i--)
            {
                tdiff[i] = FirstTime[i] - SecondTime[i];

                if (i >= timeN.Length - 2)
                {
                    if (tdiff[i] < 0)
                    {
                        SecondTime[SecondTime.Length - 2 - f] -= 1;
                        tdiff[timeN.Length - 1 - f] = 60 + tdiff[timeN.Length - 1 - f];
                    }
                }
            }
            return tdiff; 


        }
    }
}
