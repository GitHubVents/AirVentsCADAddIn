using System.Windows.Forms;
using System.Runtime.InteropServices;
using ControlsLibrary;
using ControlsLibrary.MountingFrame;

namespace SW_Add_IN
{
    [ComVisible(true)]
    [ProgId(Class1.SWTASKPANE_PROGID)]
    public partial class LittleTaskPane : UserControl
    {
        UserControl userControl;
        Form form;

        public LittleTaskPane()
        {
            InitializeComponent();
        }

        private void buildMountage_Click(object sender, System.EventArgs e)
        {
            if (userControl != null )
                { userControl.Dispose();}

            if (form != null)
            { form.Dispose(); }


            userControl = new MountingFrame();
            userControl.Dock = DockStyle.Fill;

            form = new Form();
            form.Name = "Построение монтажной рамы";
            form.Size = userControl.Size;
            form.Location = new System.Drawing.Point(500, 300);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Controls.Add(userControl);
            userControl.Show();
            form.ShowDialog();
        }
    }
}