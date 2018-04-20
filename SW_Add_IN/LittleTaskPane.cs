using System.Windows.Forms;
using System.Runtime.InteropServices;
using ControlsLibrary.Spigot;
using ControlsLibrary.MountingFrame;
using Patterns.Observer;
using System;
using ControlsLibrary.Roof;
using ControlsLibrary.FlapBuilder;

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
            MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;

            if (userControl != null)
            {
                userControl.Dispose();
            }
            if (form != null)
            {
                form.Dispose();
            }

            userControl = new MountingFrame();
            userControl.Dock = DockStyle.Fill;

            form = new Form();
            form.Name = "Построение монтажной рамы";
            form.Size = userControl.Size;
            form.Location = new System.Drawing.Point(500, 300);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Controls.Add(userControl);
            userControl.Show();
            form.Show();
        }

        private static void Instance_ReceivedMessage(Patterns.Observer.MessageEventArgs massage)
        {
            try
            {
                Logger.Instance.ToLog($"Time:{massage.time} Message: {massage.Message}");
                if (massage.Type == MessageType.Error)
                    MessageBox.Show(massage.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buildSpigot_Click(object sender, EventArgs e)
        {
            MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;

            if (userControl != null)
            {
                userControl.Dispose();
            }
            if (form != null)
            {
                form.Dispose();
            }
            userControl = new SpigotControl();
            userControl.Dock = DockStyle.Fill;

            form = new Form();
            form.Name = "Построение вибровставки";
            form.Size = userControl.Size;
            form.Location = new System.Drawing.Point(500, 300);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Controls.Add(userControl);
            userControl.Show();
            form.Show();
        }

        private void buildRoofBtn_Click(object sender, EventArgs e)
        {
            MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;

            if (userControl != null)
            {
                userControl.Dispose();
            }
            if (form != null)
            {
                form.Dispose();
            }

            userControl = new RoofControl();
            userControl.Dock = DockStyle.Fill;

            form = new Form();
            form.Name = "Построение крышы";
            form.Size = userControl.Size;
            form.Location = new System.Drawing.Point(500, 300);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Controls.Add(userControl);
            userControl.Show();
            form.Show();
        }

        private void buildFlapBtn_Click(object sender, EventArgs e)
        {
            MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;

            if (userControl != null)
            {
                userControl.Dispose();
            }
            if (form != null)
            {
                form.Dispose();
            }

            userControl = new FlapBuilderControl();
            userControl.Dock = DockStyle.Fill;

            form = new Form();
            form.Name = "Построение заслонки";
            form.Size = userControl.Size;
            form.Location = new System.Drawing.Point(500, 300);
            form.FormBorderStyle = FormBorderStyle.FixedSingle;
            form.Controls.Add(userControl);
            userControl.Show();
            form.Show();
        }

    }
}