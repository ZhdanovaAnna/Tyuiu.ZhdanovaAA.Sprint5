using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhdanovaAA.Sprint5.Task6.V19.Lib
{
    public class DataService : ISprint5Task6V19
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    string[] numbers = line.Split(' ');

                    foreach (string num in numbers)
                    {
                        if (Int32.TryParse(num, out int number) && number >= 10 && number <= 99)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
