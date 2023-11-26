using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
namespace Tyuiu.PoznyakIA.Sprint5.Task6.V9.Lib
{
    public class DataService : ISprint5Task6V9
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0, res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line = reader.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == ' ')
                    {
                        if (count == 3)
                        {
                            res++;
                            count = 0;
                        }
                        count = 0;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            return res;
        }
    }
}

