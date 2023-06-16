using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlsLibrary.Frameless
{
    public partial class CutBack : UserControl
    {

        public delegate void FlangeChoice(int value);
        public delegate bool ShowHideControls( int? x, int? y);
        public delegate bool IsOffsetPosible(ref int? x, ref int? y);
        public delegate void AddBackPanel(bool add);


        public delegate void ResizeUserControl();
        public event ResizeUserControl resize;
        public event ShowHideControls AccessBuildButton;
        public event IsOffsetPosible IsOffsetPossible;
        public event FlangeChoice setFlange;
        public event AddBackPanel backPanelChecked;



        public CutBack()
        {
            InitializeComponent();
            this.Size = groupBoxBackP.Size - new System.Drawing.Size(0, 7);
            this.backWindow_CheckedChanged(null, null);
            this.offsetBackMaxX.Visible = false;
            this.offsetBackMaxY.Visible = false;
            cmbBoxBackFlange.DataSource = new List<int> { 20, 30 };
            cmbBoxBackFlange.SelectedIndex = 0;
        }



        private void backWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (backWindow.Checked)
            {
                this.Height = 180;//250
                resize?.Invoke();
                backPanelChecked?.Invoke(backWindow.Checked);
            }
            else
            {
                this.Height = 40;
                resize?.Invoke();
                backPanelChecked?.Invoke(backWindow.Checked);
            }
        }

        private void textBoxBackWindowWidth_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try { value = Convert.ToInt32(textBoxBackWindowWidth.Text); }
            catch (FormatException)
            {}
            
            AccessBuildButton?.Invoke(value, null);
        }
        private void textBoxBackWindowHeight_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try { value = Convert.ToInt32(textBoxBackWindowHeight.Text); }
            catch (FormatException)
            {}
          
            AccessBuildButton?.Invoke(null, value);
        }

        private void textBoxBackWindowOff_X_TextChanged(object sender, EventArgs e)
        {
            int? value = null;
            int? emptyV = null;


            try { value = Convert.ToInt32(textBoxBackWindowOff_X.Text); }
            catch (FormatException) { }


            if (IsOffsetPossible != null)
            {
                if (!IsOffsetPossible.Invoke(ref value, ref emptyV))
                {
                    offsetBackMaxX.Visible = true;
                    offsetBackMaxX.Text = string.Concat(" < " + value);
                }
                else
                {
                    offsetBackMaxX.Visible = false;
                }
            }
        }
        private void textBoxBackWindowOff_Y_TextChanged(object sender, EventArgs e)
        {
            int? value = null;
            int? emptyV = null;


            try { value = Convert.ToInt32(textBoxBackWindowOff_Y.Text); }
            catch (FormatException) { }


            if (IsOffsetPossible != null)
            {
                if (!IsOffsetPossible.Invoke(ref emptyV, ref value))
                {
                    offsetBackMaxY.Visible = true;
                    offsetBackMaxY.Text = string.Concat(" < " + value);
                }
                else
                {
                    offsetBackMaxY.Visible = false;
                }
            }
        }

        private void cmbBoxBackFlange_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                int val = (int)cmbBoxBackFlange.SelectedValue;

                setFlange?.Invoke(val);
            }
            catch
            {}
        }
    }
}