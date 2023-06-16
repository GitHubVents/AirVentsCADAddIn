using System.Windows.Forms;
using System.Runtime.InteropServices;
//using ControlsLibrary.Spigot;
using ControlsLibrary.MountingFrame;
using Patterns.Observer;
using System;
//using ControlsLibrary.Roof;
//using ControlsLibrary.FlapBuilder;

namespace SW_Add_IN
{
    [ComVisible(true)]
    [ProgId(Class1.SWTASKPANE_PROGID)]
    public partial class LittleTaskPane : UserControl
    {
        public static BodyControl footer = new BodyControl();
        static HeadControl head = new HeadControl();


        public delegate void HeadMenuOperations(object o, EventArgs args);
        public static HeadMenuOperations MainMenuVisible;
          

        public static void HideMainHead(object o, EventArgs args)
        {
            head.Location = new System.Drawing.Point(0, (head.Height - 50) * -1);
            footer.Location = new System.Drawing.Point(0, head.Location.Y  + head.Height + 10);
        }
        public static void ShowMainHead(object o, EventArgs args)
        {
            head.Location = new System.Drawing.Point(0, 0);
            footer.Location = new System.Drawing.Point(0, head.Height + 10);
        }



        public LittleTaskPane()
        {
            InitializeComponent();

            head.Location = new System.Drawing.Point(0, 0);
            footer.Location = new System.Drawing.Point(0, head.Height);


            this.Controls.Add(head);
            this.Controls.Add(footer);
        }
       
    }
}