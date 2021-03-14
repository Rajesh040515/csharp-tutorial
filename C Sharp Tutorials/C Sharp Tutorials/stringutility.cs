using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorials
{
    public class stringutility
    {

        public static string summarizetext(string text, int maxlength = 0)
        {


            if (text.Length < maxlength)
                return text;
            else
            {

                var words = text.Split(' ');
                var totalchar = 0;
                var summarywords = new List<string>();
                foreach (var word in words)
                {
                    summarywords.Add(word);

                    totalchar += word.Length + 1;
                    if (totalchar > text)
                        break;

                }
                var summary = string.Join("", summarywords + "");
                Console.WriteLine(summary);


            }
        }
    }
}


