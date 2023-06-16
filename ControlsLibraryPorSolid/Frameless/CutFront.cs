using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ControlsLibrary.Frameless
{
    public partial class CutFront : UserControl
    {

        public delegate void ResizeUserControl();
        public delegate void FlangeChoice(int value);
        public delegate bool ShowHideControls(int? x, int? y);
        public delegate bool IsOffsetPosible(ref int? x, ref int? y);
        public delegate void FrontPanelChecked(bool value);

        public event ResizeUserControl resize;
        public event ShowHideControls AccessBuildButton;
        public event IsOffsetPosible IsOffsetPossible;
        public event FlangeChoice setFlange;
        public event FrontPanelChecked add;


        public CutFront()
        {
            InitializeComponent();
            this.Size = groupBoxFrontP.Size + new System.Drawing.Size(0, 5);
            
            this.frontWindow_CheckedChanged(null, null);
            this.offsetFrontMaxX.Visible = false;
            this.offsetFrontMaxY.Visible = false;
            cmbBoxFrontFlange.DataSource = new List<int>{ 20, 30 };
            cmbBoxFrontFlange.SelectedIndexChanged += CmbBoxFrontFlange_SelectedIndexChanged;
            cmbBoxFrontFlange.SelectedIndex = 0;
        }

        private void CmbBoxFrontFlange_SelectedIndexChanged(object sender, EventArgs e)
        {
            int value = (int)cmbBoxFrontFlange.SelectedValue;
            setFlange?.Invoke(value);
        }

        private void frontWindow_CheckedChanged(object sender, EventArgs e)
        {

            if (frontWindow.Checked)
            {
                this.Height = 250;//185
                resize?.Invoke();
                add?.Invoke(frontWindow.Checked);
            }
            else
            {
                this.Height = 44;
                resize?.Invoke();
                add?.Invoke(frontWindow.Checked);
            }
        }

        private void textBoxFrontWindowWidth_TextChanged(object sender, EventArgs e)
        {
            int value = 0;
            try { value = Convert.ToInt32(textBoxFrontWindowWidth.Text); }
            catch (FormatException)
            {/* MessageBox.Show("Данные введены в недопустимом формате");*/ }
        
            AccessBuildButton?.Invoke(value, null);
        }

        private void textBoxFrontWindowHeight_TextChanged(object sender, EventArgs e)
        {
            int value = 0;

            try {
                    value = Convert.ToInt32(textBoxFrontWindowHeight.Text);
                }
            catch (FormatException)
            { /*MessageBox.Show("Данные введены в недопустимом формате"); */}

            AccessBuildButton.Invoke(null, value);
        }

        private void textBoxFrontWindowOff_X_TextChanged(object sender, EventArgs e)
        {
            int? value = null;
            int? emptyV = null;


            try {
                    value = Convert.ToInt32(textBoxFrontWindowOff_X.Text);
                }
            catch (FormatException) { }


            if (IsOffsetPossible != null)
            {
                if (!IsOffsetPossible.Invoke(ref value, ref emptyV))
                {
                    offsetFrontMaxX.Visible = true;
                    offsetFrontMaxX.Text = string.Concat(" < " + value);
                }
                else
                {
                    offsetFrontMaxX.Visible = false;
                }
            }
        }

        private void textBoxFrontWindowOff_Y_TextChanged(object sender, EventArgs e)
        {
            int? value = null;
            int? emptyV = null;


            try { value = Convert.ToInt32(textBoxFrontWindowOff_Y.Text); }
            catch (FormatException) { }


            if (IsOffsetPossible != null)
            {
                if (!IsOffsetPossible.Invoke(ref emptyV, ref value))
                {
                    offsetFrontMaxY.Visible = true;
                    offsetFrontMaxY.Text = string.Concat(" < " + value);
                }
                else
                {
                    offsetFrontMaxY.Visible = false;
                }
            }
        }

        private void cmbBoxFrontFlange_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int val = (int)cmbBoxFrontFlange.SelectedValue;

                setFlange?.Invoke(val);
            }
            catch
            {
            }
        }

        private void offsetFrontMaxX_Click(object sender, EventArgs e)
        {

        }
    }
}
