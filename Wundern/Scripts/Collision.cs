using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Wundern
{
    class Collision // Author : Kaab
    {

        public WunderObject Attached; // WunderObject that we script attached
        public int TotalColliding = 0; 


        public void StartMethod()
        {
            //On start
        }

        public void UpdateMethod()
        {
            var y = WunderObject.sceneObjects.FindAll(x => Vector2.IsEqual(x.position,Attached.position) && x.id != Attached.id);
            Debug.SetStatus($"Player In Object : {y.Count}");
            TotalColliding = y.Count;


            
        }


        public bool CheckVirtualPosition(Vector2 virtual_pos,ref WunderObject CollidingWith)
        {
            var y = WunderObject.sceneObjects.FindAll(x => Vector2.IsEqual(x.position, virtual_pos) && x.id != Attached.id);
            
            if(y.Count >= 1 && y[0].isCollide)
            {
                CollidingWith = y[0];
                return true;
            }
            else
            {
                if(LevelLoader.cls.FindAll(position => Vector2.IsEqual(position,virtual_pos)).Count >= 1)
                {
                
                    CollidingWith = null;
                    return true;
                }
                else
                {
                    
                    CollidingWith = null;
                    return false;
                }

            }

        }


    }
}
