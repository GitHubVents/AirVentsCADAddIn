using System;
using System.Windows.Forms;
using DataBaseDomian;
using SolidWorksLibrary;
using System.Collections.Generic;
using SolidWorksLibrary.Builders.ElementsCase.Panels;
using ServiceTypes.Constants;
using SolidWorksLibrary.Builders.ElementsCase;
using System.Runtime.InteropServices;

namespace ControlsLibrary.Panel50
{


    public partial class PanelControl : UserControl
    {
        PanelBuilder panelBuilder;
        PanelType_e pType;
        PanelProfile_e pProfil;
        Vector2 pSize;
        int pInnerMaterial;
        int pOuterMaterial;
        decimal innerThickness = 2;
        decimal outerThickness = 2;
        bool doubleByUser = false;

        int outerCoatClass;
        int outerRALID;
        string outerCoatType;
        int innerCoatClass;
        int innerRALID;
        string innerCoatType;


        public PanelControl(string pathIps)
        {
            RealiseBuilderBehaviour.PathToStorage += new ProductBuilderBehavior.IPSPath(() => { return pathIps; });
            InitializeComponent();

            try
            {
                Dictionary<int, string> panelsType = new Dictionary<int, string>()
                    {
                        { (int)PanelType_e.BlankPanel, "Несьемная глухая" } ,
                        { (int)PanelType_e.RemovablePanel, "Сьемная" }
                    };
                comboBoxPanelType.DataSource = new BindingSource(panelsType, null);
                comboBoxPanelType.ValueMember = "Key";
                comboBoxPanelType.DisplayMember = "Value";


                Dictionary<int, int> pProfil = new Dictionary<int, int>()
                    {
                        { (int)PanelProfile_e.Profile_3_0, (int)PanelProfile_e.Profile_3_0 },
                        { (int)PanelProfile_e.Profile_5_0, (int)PanelProfile_e.Profile_5_0 },
                        { (int)PanelProfile_e.Profile_7_0, (int)PanelProfile_e.Profile_7_0 }
                    };
                comboBoxPanelProfil.DataSource = new BindingSource(pProfil, null);
                comboBoxPanelProfil.ValueMember = "Key";
                comboBoxPanelProfil.DisplayMember = "Value";




                comboBoxOuterMaterial.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForPannels(), null);
                comboBoxOuterMaterial.ValueMember = "Key";
                comboBoxOuterMaterial.DisplayMember = "Value";


                comboBoxInnerMaterila.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForPannels(), null);
                comboBoxInnerMaterila.ValueMember = "Key";
                comboBoxInnerMaterila.DisplayMember = "Value";




                comboBoxColor.DataSource = new BindingSource(SwPlusRepository.Instance.GetRAL(), null);
                comboBoxColor.ValueMember = "RALID";
                comboBoxColor.DisplayMember = "RALName";
                comboBoxColor.SelectedIndex = 0;


                comboBoxCoatType.DataSource = SwPlusRepository.Instance.CoatingType();
                comboBoxCoatClass.DataSource = SwPlusRepository.Instance.CoatingClass();
                comboBoxCoatType.SelectedIndex = 0;
                comboBoxCoatClass.SelectedIndex = 0;
                comboBoxCoatClass.Enabled = false;
                comboBoxCoatType.Enabled = false;


                comboBoxCoatTypeOut.DataSource = SwPlusRepository.Instance.CoatingType();
                comboBoxCoatClassOut.DataSource = SwPlusRepository.Instance.CoatingClass();
                comboBoxCoatTypeOut.SelectedIndex = 0;
                comboBoxCoatClassOut.SelectedIndex = 0;
                comboBoxCoatClassOut.Enabled = false;
                comboBoxCoatTypeOut.Enabled = false;

                comboBoxColorOut.DataSource = new BindingSource(SwPlusRepository.Instance.GetRAL(), null);
                comboBoxColorOut.ValueMember = "RALID";
                comboBoxColorOut.DisplayMember = "RALName";
                comboBoxColorOut.SelectedIndex = 0;


                comboBoxInnerThickness.Items.Add(0.7);
                comboBoxInnerThickness.SelectedIndex = 0;
                comboBoxOuterThicknes.Items.Add(0.7);
                comboBoxOuterThicknes.SelectedIndex = 0;


                this.comboBoxInnerMaterila.SelectedIndexChanged += new System.EventHandler(this.comboBoxInnerMaterila_SelectedIndexChanged);
                this.comboBoxOuterMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxOuterMaterial_SelectedIndexChanged);
                this.comboBoxColor.SelectedIndexChanged += ComboBoxColor_SelectedIndexChanged;
                this.comboBoxColorOut.SelectedIndexChanged += ComboBoxColorOut_SelectedIndexChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
                throw ex;
            }
        }

        private void ComboBoxColorOut_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillColor((int)comboBoxColorOut.SelectedValue, comboBoxCoatClassOut, comboBoxCoatTypeOut);
        }

        private void comboBoxOuterMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillThickness((int)comboBoxOuterMaterial.SelectedValue, comboBoxOuterThicknes);
        }
        private void comboBoxInnerMaterila_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillThickness((int)comboBoxInnerMaterila.SelectedValue, comboBoxInnerThickness);
        }

        private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillColor((int)comboBoxColor.SelectedValue, comboBoxCoatClass, comboBoxCoatType);
        }
        private void FillColor(int coatCo9lor, ComboBox @class, ComboBox type)
        {
            if (coatCo9lor == 214)
            {
                @class.Enabled = false;
                type.Enabled = false;
            }
            else
            {
                @class.Enabled = true;
                type.Enabled = true;
            }
        }

        public void FillThickness(int materialThickness, ComboBox cmb)
        {

            cmb.Items.Clear();

            switch (materialThickness)
            {

                case 2400:
                    cmb.Items.Clear();
                    cmb.Items.Add(0.8);
                    break;
                default:
                    cmb.Items.Clear();
                    cmb.Items.AddRange(new object[] { 0.7 });
                    break;
            }
            cmb.SelectedIndex = 0;
        }
        private void btnPanelBuild_Click(object sender, EventArgs e)
        {
            labelForUserToWait.Visible = true;
            labelForUserToWait.Text = "Выполняеться построение...";
            panelBuilder = new PanelBuilder();
            
            
            if (ConvertValues())
            {
                try
                {
                    panelBuilder.Build(pType, pProfil, pSize, pOuterMaterial, pInnerMaterial, outerThickness, innerThickness, outerRALID, outerCoatType, outerCoatClass, innerRALID, innerCoatType, innerCoatClass, doubleByUser);
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
            };
        }



        private bool ConvertValues()
        {
            double width, lenght;
            try
            {
                pType = (PanelType_e)comboBoxPanelType.SelectedValue;

                pProfil = (PanelProfile_e)comboBoxPanelProfil.SelectedValue;

                width = Convert.ToDouble(textBoxWidth.Text);
                lenght = Convert.ToDouble(textBoxLenth.Text);
                pSize = new Vector2(width, lenght);

                pOuterMaterial = (int)comboBoxOuterMaterial.SelectedValue;
                pInnerMaterial = (int)comboBoxInnerMaterila.SelectedValue;

                innerThickness = Convert.ToDecimal(comboBoxInnerThickness.Text);
                outerThickness = Convert.ToDecimal(comboBoxOuterThicknes.Text);

                outerRALID = (int)comboBoxColorOut.SelectedValue;
                innerRALID = (int)comboBoxColor.SelectedValue;




                if (outerRALID == 214)
                {
                    outerCoatClass = 0;
                    outerCoatType = 0.ToString();
                }
                    else
                    {
                        outerCoatClass = (int)comboBoxCoatClassOut.SelectedValue;
                        outerCoatType = (string)comboBoxCoatTypeOut.SelectedValue;
                    }

                if (innerRALID == 214)
                {
                    innerCoatClass = 0;
                    innerCoatType = 0.ToString();
                }
                    else
                    {
                        innerCoatClass = (int)comboBoxCoatClass.SelectedValue;
                        innerCoatType = (string)comboBoxCoatType.SelectedValue;
                    }
                

                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible to create the model. The input values are inappropriate.");
                return false;
            }
        }

        private void checkBoxDouble_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDouble.Checked)
            {
                doubleByUser = true;
            }
            else
            {
                doubleByUser = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
                if (ConvertValues())
                {

                    int searchedID = SwPlusRepository.Instance.Search_Panel((int)pType, (int)pSize.X, (int)pSize.Y, (int)pProfil, pOuterMaterial, pInnerMaterial, outerThickness, innerThickness);
                    var res = Search._SEARCH.PathExistance(searchedID, Search.CAller.Panel);
                    Search._SEARCH.ShowResults(res);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void comboBoxOuterMaterial_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            KeyValuePair<int, string> op = ( KeyValuePair<int, string>)comboBoxOuterMaterial.SelectedItem;

            toolTip1.SetToolTip(comboBoxOuterMaterial, op.Value);
        }

        private void comboBoxInnerMaterila_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            KeyValuePair<int, string> op = (KeyValuePair<int, string>)comboBoxInnerMaterila.SelectedItem;

            toolTip1.SetToolTip(comboBoxInnerMaterila, op.Value);
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