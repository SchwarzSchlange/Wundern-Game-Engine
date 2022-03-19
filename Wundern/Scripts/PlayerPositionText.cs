using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wundern
{
    class PlayerPositionText // Author : Kaab
    {

        public WunderObject Attached; // WunderObject that we script attached

        public void StartMethod()
        {
            
        }

        public void UpdateMethod()
        {
            
            Attached.text = $"[{WunderObject.Find("Player1").position.x}] | [{WunderObject.Find("Player1").position.y}]";
          
        }



    }
}
