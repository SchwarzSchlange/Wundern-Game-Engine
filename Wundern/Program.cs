/*  Made By Kaab
 * 
 *  Github : SchwarzSchlange
 * 
 *  Project : Wundern
 *  
 *  Type : ConsoleEngine
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Wundern
{
    class Program
    {

   

        static void Main(string[] args)
        {
            
            WandernEngine.InitConsole();

            Debug.Start(); // Debug Panel Open

            LevelLoader.Load("level0.wl"); // Load Level To Scene


            ObjectInit();
            WandernEngine.RunScripts(); // Call every Start of scripts
            RenderEngine.RenderThread = new Thread(new ThreadStart(RenderEngine.UpdateAll));
            RenderEngine.RenderThread.Start();
 
       
        }

  

        private static void ObjectInit() // Pre wunderobject init
        {
            
            WunderObject player1 = new WunderObject("Player1","O",true, new Vector2(2, 2));
            player1.AddComponent(new Collision());
            player1.AddComponent(new Rigidbody());
            player1.AddComponent(new Movement());
            player1.GetComponent<Rigidbody>().mass = 10;

        }
    }
}
