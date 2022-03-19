using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Wundern
{
    class Keyboard
    {
        [DllImport("user32.dll")]
        public static extern int GetAsyncKeyState(System.Windows.Forms.Keys vKeys);



        public static bool IsPressed(System.Windows.Forms.Keys key)
        {
            byte[] result = BitConverter.GetBytes(GetAsyncKeyState(key));

            if (result[0] == 1)
            {
                return true;

            }
            else
            {
                return false;
            }


        }
    }
}
