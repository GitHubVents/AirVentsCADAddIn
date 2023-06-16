using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Patterns.Observer;
using ControlsLibrary.Spigot;
using ControlsLibrary.FlapBuilder;
using ControlsLibrary.Roof;
using ControlsLibrary.MountingFrame;
using ControlsLibrary.Frameless;
using ControlsLibrary.Panel50;
using SolidWorksLibrary;

namespace SW_Add_IN
{
    public partial class HeadControl : UserControl
    {

        UserControl userControl;
        

        public HeadControl()
        {
            try
            {
                InitializeComponent();
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                MessageObserver.Instance.ReceivedMessage += Instance_ReceivedMessage;
            }
            catch (Exception e)
            {
                MessageBox.Show("HeadControl");
            }
        }


        private void buildSpigot_Click(object sender, EventArgs e)
        {

            LittleTaskPane.footer.Controls.Clear();
            userControl = new SpigotControl(string.Empty);
            userControl.Dock = DockStyle.Fill;
            LittleTaskPane.footer.Controls.Add(userControl);

            LittleTaskPane.MainMenuVisible = null;
            LittleTaskPane.MainMenuVisible += new LittleTaskPane.HeadMenuOperations(LittleTaskPane.HideMainHead);
            LittleTaskPane.MainMenuVisible(sender, e);
        }

        private void buildRoofBtn_Click(object sender, EventArgs e)
        {
            LittleTaskPane.footer.Controls.Clear();
            userControl = new RoofControl(string.Empty);
            userControl.Dock = DockStyle.Fill;
            LittleTaskPane.footer.Controls.Add(userControl);

            LittleTaskPane.MainMenuVisible = null;
            LittleTaskPane.MainMenuVisible += new LittleTaskPane.HeadMenuOperations(LittleTaskPane.HideMainHead);
            LittleTaskPane.MainMenuVisible(sender, e);

        }

        private void buildFlapBtn_Click(object sender, EventArgs e)
        {

            try
            {

                LittleTaskPane.footer.Controls.Clear();
                userControl = new FlapBuilderControl(string.Empty);
                userControl.Dock = DockStyle.Fill;
                LittleTaskPane.footer.Controls.Add(userControl);

                LittleTaskPane.MainMenuVisible = null;
                LittleTaskPane.MainMenuVisible += new LittleTaskPane.HeadMenuOperations(LittleTaskPane.HideMainHead);
                LittleTaskPane.MainMenuVisible(sender, e);
            }
            catch (Exception w)
            {
                MessageBox.Show(w.Message);
            }
        }


        private void buildMountage_Click_1(object sender, EventArgs e)
        {

            LittleTaskPane.footer.Controls.Clear();
            userControl = new MountingFrame(string.Empty);
            userControl.Dock = DockStyle.Fill;
            LittleTaskPane.footer.Controls.Add(userControl);


            LittleTaskPane.MainMenuVisible = null;
            LittleTaskPane.MainMenuVisible += new LittleTaskPane.HeadMenuOperations(LittleTaskPane.HideMainHead);
            LittleTaskPane.MainMenuVisible(sender, e);
        }

        private static void Instance_ReceivedMessage(Patterns.Observer.MessageEventArgs massage)
        {
            try
            {
                Logger.Instance.ToLog($"Time:{massage.time} Message: {massage.Message}");
                if (massage.Type == MessageType.Error)
                {
                    MessageBox.Show(massage.Message);
                    SolidWorksAdapter.OutLookSendMeALog(@"С:\AirVentsCAD\AddIn\Log.txt", "Some problems with SW_Add-IN");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LittleTaskPane.footer.Controls.Clear();
            userControl = new FramelessBlockControl();
            userControl.Dock = DockStyle.Fill;
            LittleTaskPane.footer.Controls.Add(userControl);


            LittleTaskPane.MainMenuVisible = null;
            LittleTaskPane.MainMenuVisible += new LittleTaskPane.HeadMenuOperations(LittleTaskPane.HideMainHead);
            LittleTaskPane.MainMenuVisible(sender, e);
        }

        private void MainMenu_Click(object sender, EventArgs e)
        {
            LittleTaskPane.MainMenuVisible = null;
            LittleTaskPane.MainMenuVisible += new LittleTaskPane.HeadMenuOperations(LittleTaskPane.ShowMainHead);
            LittleTaskPane.MainMenuVisible(sender, e);
            userControl.Visible = false;
        }

        private void buttonPanel_Click(object sender, EventArgs e)
        {

            LittleTaskPane.footer.Controls.Clear();
            userControl = new PanelControl(string.Empty);
            userControl.Dock = DockStyle.Fill;
            LittleTaskPane.footer.Controls.Add(userControl);


            LittleTaskPane.MainMenuVisible = null;
            LittleTaskPane.MainMenuVisible += new LittleTaskPane.HeadMenuOperations(LittleTaskPane.HideMainHead);
            LittleTaskPane.MainMenuVisible(sender, e);

        }
    }
}
