using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Wundern
{
    class LevelLoader
    {
        public static List<Vector2> cls = new List<Vector2>();
        public static void Load(string fileName)
        {
            //level0.wl
         
            var lines = File.ReadAllLines(fileName);

            int LineCount = 0;
            int WordCount = 0;
            foreach(var line in lines)
            {
                Console.WriteLine(line);
                foreach(var word in line)
                {
                    if(word == '#')
                    {
                        cls.Add(new Vector2(WordCount, LineCount));
                    }
                
                    WordCount++;
                }
                WordCount = 0;
                LineCount++;
            }
        }
    }
}
