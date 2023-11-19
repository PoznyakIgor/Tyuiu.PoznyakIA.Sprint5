using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.PoznyakIA.Sprint5.Task0.V13.Lib
{
    public class DataService : ISprint5Task0V13
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            double z = Math.Round(-1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x, 2);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
