using System.Runtime.InteropServices;
using System.Windows.Forms;
using DataBaseDomian;
using System;
using SolidWorksLibrary.Builders.ElementsCase;
using System.Collections.Generic;

namespace ControlsLibrary.Roof
{
    public partial class RoofControl : UserControl
    {
        int width, length, roofType, materialID, coatColorRAL, coatClass;
        string coatType;

        public RoofControl(string pathIps)
        {

            RealiseBuilderBehaviour.PathToStorage += new SolidWorksLibrary.Builders.ElementsCase.ProductBuilderBehavior.IPSPath(() => { return pathIps; });
            InitializeComponent();
            int[] roofTypes = new int[] {1, 2, 3, 4, 5, 6};
            comboBoxType.DataSource = roofTypes;
            comboBoxType.SelectedIndex = 0;
            comboBoxCoatType.DataSource = SwPlusRepository.Instance.CoatingType();
            comboBoxCoatClass.DataSource = SwPlusRepository.Instance.CoatingClass();
            try
            {
                comboBoxMaterial.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForRoof(), null);
                comboBoxMaterial.ValueMember = "Key";
                comboBoxMaterial.DisplayMember = "Value";

                comboBoxColor.DataSource = new BindingSource(SwPlusRepository.Instance.GetRAL(), null );
                comboBoxColor.ValueMember = "RALID";
                comboBoxColor.DisplayMember = "RALName";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw ex;
            }
            this.comboBoxColor.SelectedIndexChanged += new System.EventHandler(this.comboBoxColor_SelectedIndexChanged);
            comboBoxCoatClass.Enabled = false;
            comboBoxCoatType.Enabled = false;
        }

        
        private void comboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillColor((int)comboBoxColor.SelectedValue);
        }
        //Построение
        private void button1_Click(object sender, EventArgs e)
        {
            if (ConvertValues())
            {

                try
                {
                    labelForUserToWait.Visible = true;
                    labelForUserToWait.Text = "Выполняеться построение...";
                    RoofBuilder roofBuild = new RoofBuilder();
                    roofBuild.Build(roofType, width, length,  materialID, coatColorRAL, coatType, coatClass);
                    labelForUserToWait.Text = "Построение завершено.";
                }
                catch
                {
                    labelForUserToWait.Text = "Построение было прервано в связи с ошибками.";
                }
            }
            else
            {
                labelForUserToWait.Visible = false;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (ConvertValues())
                {
                    int searchedID = SwPlusRepository.Instance.Search_Roof(roofType, width, length, materialID, (materialID == 1700 ? new decimal( 0.7) : new decimal( 0.8)), coatColorRAL, coatType, coatClass);
                    var res = Search._SEARCH.PathExistance(searchedID, Search.CAller.Roof);
                    Search._SEARCH.ShowResults(res);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        private void comboBoxMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {

            KeyValuePair<int, string> op = (KeyValuePair<int, string>)comboBoxMaterial.SelectedItem;
            toolTip1.SetToolTip(this.comboBoxMaterial, op.Value);
        }
            

        private bool ConvertValues()
        {
            try
            {
                width = Convert.ToInt32(txtBoxWidth.Text);
                length = Convert.ToInt32(txtBoxHeight.Text);
                roofType = (int)comboBoxType.SelectedItem;
                materialID = (int)comboBoxMaterial.SelectedValue;

                //под покрытие
                coatColorRAL = (int)comboBoxColor.SelectedValue;
                if (coatColorRAL == 214)
                {
                    coatClass = 0;
                    coatType = "0";
                }
                else
                {
                    coatClass = (int)comboBoxCoatClass.SelectedItem;
                    coatType = (string)comboBoxCoatType.SelectedItem;
                }
                //MessageBox.Show("after convert");
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible to create the model. The input values are inappropriate.");
                return false;
            }
        }

        private void ON_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            labelForUserToWait.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxType.SelectedIndex)
            {
                case 0:
                    pictureRoof.Image = Properties.Resources._01;
                    toolTip1.SetToolTip(this.comboBoxType, "Одинарная");
                    break;
                case 1:
                    pictureRoof.Image = Properties.Resources._02;
                    toolTip1.SetToolTip(this.comboBoxType, "Двойная по ширине");
                    break;
                case 2:
                    pictureRoof.Image = Properties.Resources._03;
                    toolTip1.SetToolTip(this.comboBoxType, "Одинарная с креплением М8");
                    break;
                case 3:
                    pictureRoof.Image = Properties.Resources._04;
                    toolTip1.SetToolTip(this.comboBoxType, "Одинарная с креплением М8 + 170");
                    break;
                case 4:
                    pictureRoof.Image = Properties.Resources._05;
                    toolTip1.SetToolTip(this.comboBoxType, "Одинарная с вылетом 140");
                    break;
                case 5:
                    pictureRoof.Image = Properties.Resources._06;
                    toolTip1.SetToolTip(this.comboBoxType, "Двойная по ширине с вылетом 140");
                    break;

            }
        }

        private void FillColor(int coatCo9lor)
        {
            if (coatCo9lor == 214)
            {
                comboBoxCoatClass.Enabled = false;
                comboBoxCoatType.Enabled = false;
            }
            else
            {
                comboBoxCoatClass.Enabled = true;
                comboBoxCoatType.Enabled = true;
            }
        }
    }

    public class HowerEventARGS : EventArgs
    {
        private int itemIndex = 0;
        public int ItemIndex
        {
            get { return itemIndex; }
            set { itemIndex = value; }
        }


        // Import the GetScrollInfo function from user32.dll
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int GetScrollInfo(IntPtr hWnd, int n,
                                  ref ScrollInfoStruct lpScrollInfo);

        // Win32 constants
        private const int SB_VERT = 1;
        private const int SIF_TRACKPOS = 0x10;
        private const int SIF_RANGE = 0x1;
        private const int SIF_POS = 0x4;
        private const int SIF_PAGE = 0x2;
        private const int SIF_ALL = SIF_RANGE | SIF_PAGE |
                                    SIF_POS | SIF_TRACKPOS;

        private const int SCROLLBAR_WIDTH = 17;
        private const int LISTBOX_YOFFSET = 21;

        // Return structure for the GetScrollInfo method
        [StructLayout(LayoutKind.Sequential)]
        private struct ScrollInfoStruct
        {
            public int cbSize;
            public int fMask;
            public int nMin;
            public int nMax;
            public int nPage;
            public int nPos;
            public int nTrackPos;
        }

        public delegate void HoverEventHandler(object sender, HowerEventARGS e);
    }
}