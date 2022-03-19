using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wundern
{
    internal class WandernEngine
    {

        public static void cursor_new(Vector2 pos) { try { Console.SetCursorPosition(pos.x, pos.y); } catch { return; } }
        public static void cursor_old(int x,int y) { try { Console.SetCursorPosition(x, y); } catch { return; } }

        public static void RunScripts()
        {
            

            foreach (WunderObject wunderObject in WunderObject.sceneObjects)
            {
                foreach (dynamic x in wunderObject.components)
                {
                    try
                    {
                        x.StartMethod();
                    }
                    catch
                    {
                      
                        Debug.Add($"{x} has no StartMethod passing it");
                    }
                    
                }
            }
        }


        public static void InitConsole()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Wandern by Kaab | Github : SchwarzSchlange";
            Console.CursorVisible = false;
        }
    }
}
