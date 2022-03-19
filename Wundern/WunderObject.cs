using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wundern
{
    class WunderObject
    {
        public static List<WunderObject> sceneObjects = new List<WunderObject>();

        public static WunderObject Find(string name)
        {
            return sceneObjects.Find(x => x.name == name);
        }

        public static List<WunderObject> FindByPosition(Vector2 pos)
        {
            try
            {
              
                return sceneObjects.FindAll(x => x.position == pos);
            }
            catch
            {
                return null;
            }
            
        }

        public int id { get; private set; }
        public string name { get; set; }
        public string text { get; set; }
        public bool isCollide { get; set; }
        public Vector2 position { get; set; }
        public List<object> components = new List<object>();



        public WunderObject(string _n,string _t,bool isCol,Vector2 _p)
        {
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            this.id = rand.Next(1, 9999);
            this.name = _n;
            this.isCollide = isCol;
            this.text = _t;
            this.position = _p;
            
            

            sceneObjects.Add(this);
            this.components.Add(new Self());

        }


        public void AddComponent(dynamic component)
        {
            component.Attached = this;
            components.Add(component);
        }

        public T GetComponent<T>()
        {
            
            return (T)components.FindAll(x => x.GetType() == typeof(T))[0];

        
          

            
        }

    }
}
