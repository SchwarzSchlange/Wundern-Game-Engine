using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wundern
{
    internal class RenderEngine
    {


        public static Thread RenderThread;
        public static int RenderDelay = 50;

        public static void UpdateAll()
        {
            while(true)
            {
                Clear();
                CallUpdate(); // Call every update of script in RENDER_DELAY ms
                Render();
                Thread.Sleep(RenderDelay);
            }
        }


        private static void CallUpdate()
        {
            foreach(var x in WunderObject.sceneObjects)
            {
                foreach(dynamic y in x.components)
                {
                    try
                    {
                        y.UpdateMethod();
                    }
                    catch { }
                }
            }
        }

        private static void Clear()
        {

            foreach (dynamic ob in WunderObject.sceneObjects)
            {

                for (int i = 0; i <= ob.text.Length; i++)
                {
                    WandernEngine.cursor_old(ob.position.x + i, ob.position.y);

                    Console.Write(" ");

                    i++;
                }
            }
        }

        private static void Render()
        {
            foreach (dynamic ob in WunderObject.sceneObjects)
            {
                WandernEngine.cursor_old(ob.position.x,ob.position.y);       
                Console.Write(ob.text);
            }
        }
    }
}
