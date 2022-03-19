using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wundern
{
    class Debug
    {
        private static Form DebugForm;
        private static Thread DebugThread;
        private static ListBox listBox;
        private static Label label;
        private static TrackBar fps;

        public static void Start() // TO Start Panel
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            DebugThread = new Thread(new ThreadStart(DThread));
            DebugThread.Start();
        }

        private static void DThread()
        {
           
            DebugForm = new Form();
            

            DebugForm.Text = "Debug";
            DebugForm.ShowIcon = false;
            DebugForm.FormBorderStyle = FormBorderStyle.FixedSingle;
         
            DebugForm.StartPosition = FormStartPosition.CenterScreen;

            label = new Label();
            label.Text = "Debug Label";
            label.Dock = DockStyle.Top;

            listBox = new ListBox();
            listBox.Dock = DockStyle.Fill;

            fps = new TrackBar();
            
            fps.Maximum = 1000;
            fps.Minimum = 1;
            fps.Value = 10;
            fps.TickStyle = TickStyle.None;
            

            fps.Dock = DockStyle.Bottom;
            fps.ValueChanged += (object e,EventArgs ea) =>
            {
                RenderEngine.RenderDelay = fps.Value;
            };

            DebugForm.Controls.Add(listBox);
            DebugForm.Controls.Add(label);
            DebugForm.Controls.Add(fps);
            DebugForm.ShowDialog();
        }

      
        public static void Add(string x)
        {
         
            listBox.Items.Add(x); 
            listBox.SelectedIndex = listBox.Items.Count - 1;
            listBox.SelectedIndex = -1;

            
        }


        public static void SetStatus(string text)
        {
            label.Text = text;
        }

        public async static void Clear(int wait)
        {
       
            await Task.Delay(wait);
            listBox.Items.Clear();
           
        }

        public static void Stop()
        {
            listBox.Items.Clear();
            DebugThread.Abort();
            DebugForm.Close();
        }
    }
}
