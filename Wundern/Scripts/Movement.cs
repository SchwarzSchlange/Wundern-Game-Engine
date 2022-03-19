using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wundern
{
    class Movement // Author : Kaab | Sorry for shity code :/
    {

        public WunderObject Attached;

        public void StartMethod()
        {
           


        }

        public void UpdateMethod()
        {
            Collision collision = Attached.GetComponent<Collision>();

            WunderObject colliding = null;
            if(Keyboard.IsPressed(Keys.A))
            {

                if(!collision.CheckVirtualPosition(Attached.position - new Vector2(1,0),ref colliding))
                {
                    Attached.position = new Vector2(Attached.position.x - 1, Attached.position.y);
                    
                }
                else
                {
                    
                    try
                    {
                        if(colliding != null)
                        {
                            if (colliding.GetComponent<Rigidbody>().mass < Attached.GetComponent<Rigidbody>().mass)
                            {
                                Attached.position = new Vector2(Attached.position.x - 1, Attached.position.y);
                                colliding.position += new Vector2(-1, 0);
                            }
                        }
                      
                    }
                    catch
                    {
                    
                    }
           
                    
                }
              

               
              
            }
            else if(Keyboard.IsPressed(Keys.D))
            {
                if (!collision.CheckVirtualPosition(Attached.position + new Vector2(1, 0), ref colliding))
                {
                    Attached.position = new Vector2(Attached.position.x + 1, Attached.position.y);
                }
                else
                {
                   

                    try
                    {
                        if (colliding != null)
                        {
                            if (colliding.GetComponent<Rigidbody>().mass < Attached.GetComponent<Rigidbody>().mass)
                            {
                                Attached.position = new Vector2(Attached.position.x + 1, Attached.position.y);
                                colliding.position += new Vector2(1, 0);
                            }
                        }
                     
                    }
                    catch
                    {
                     
                    }


                }



            }
            else if (Keyboard.IsPressed(Keys.W))
            {
                if (!collision.CheckVirtualPosition(Attached.position - new Vector2(0, 1), ref colliding))
                {
                    Attached.position = new Vector2(Attached.position.x, Attached.position.y - 1);
                }
                else
                {
                   

                    try
                    {
                        if (colliding != null)
                        {
                            if (colliding.GetComponent<Rigidbody>().mass < Attached.GetComponent<Rigidbody>().mass)
                            {
                                Attached.position = new Vector2(Attached.position.x, Attached.position.y - 1);
                                colliding.position += new Vector2(0, -1);
                            }
                        }
                      
                    }
                    catch
                    {
                   
                    }


                }


            }
            else if (Keyboard.IsPressed(Keys.S))
            {
                if (!collision.CheckVirtualPosition(Attached.position + new Vector2(0, 1), ref colliding))
                {
                    Attached.position = new Vector2(Attached.position.x, Attached.position.y + 1);
                }
                else
                {
                    
                   
                    try
                    {
                        if (colliding != null)
                        {
                            if (colliding.GetComponent<Rigidbody>().mass < Attached.GetComponent<Rigidbody>().mass)
                            {
                                Attached.position = new Vector2(Attached.position.x, Attached.position.y + 1);
                                colliding.position += new Vector2(0, 1);
                            }
                        }
                     
                    }
                    catch
                    {
                   
                    }


                }


            }


          

        }


  


    }
}
