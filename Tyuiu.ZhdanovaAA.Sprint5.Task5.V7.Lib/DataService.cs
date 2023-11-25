using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.ZhdanovaAA.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if ((Convert.ToDouble(line) >= 0) && (Convert.ToInt32(Convert.ToDouble(line)) == Convert.ToDouble(line)))
                    {
                        break;
                    }
                    else 
                    {
                        continue;
                    }
                }

                long f = 1;
                for (int i = 1; i <= Convert.ToDouble(line); i++)
                {
                    f *= i;
                }
                return Math.Round(Convert.ToDouble(f), 3);
            }
        }
    }
}
