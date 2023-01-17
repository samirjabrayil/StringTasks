using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTasks
{
    internal class Ceaser
    {
        public static string CeaserMethods()
        {
            #region Task 1 (Sezar sifrelenmesini ve desifrelenmesini eden metodlar)
            //Sezar sifreleme/desifrelemesi

            Console.Write("Neqeder herf surusdurmek isteyirsiniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Herf yaxud soz daxil edin: ");
            string s = Console.ReadLine();
            string result = string.Empty;

            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    int b = (s[i] - 64 - n) % 26 + 64;

                    if (b <= 64)
                        b += 64;
                    result+= (char)b;
                    //result += b.ToString();
                }
                else
                {
                    int c = (s[i] - 96 - n) % 26 + 96;

                    if (c <= 96)
                        c += 26;

                    result += (char)c;
                    
                    //result += c.ToString()
                    
                }
            }
            return result;
            #endregion end of Ceaser
        }
    }
}