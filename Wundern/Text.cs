using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wundern
{
    class Text : WunderObject
    {
     


        public Text(string _n, string _t, bool isCol, Vector2 _p) : base(_n,_t,isCol,_p)
        {
            this.isCollide = false;
            this.name = _n;
            this.text = _t;
            this.position = _p;
         

        }
    }
}
