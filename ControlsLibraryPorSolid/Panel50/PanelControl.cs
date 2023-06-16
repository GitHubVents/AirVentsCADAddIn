using System;
using System.Windows.Forms;
using DataBaseDomian;
using SolidWorksLibrary.Builders.ElementsCase.Panels;
using ServiceTypes.Constants;
using SolidWorksLibrary.Builders.ElementsCase;
using System.Collections.Generic;

namespace ControlsLibrary.Panel50
{
    //[ComVisible(true), Guid("F8358B23-3E51-453C-8EF8-9ABD22525214"), ProgId("IPS.EditContextMenu")]
    //[ClassInterface(ClassInterfaceType.None)]
    public partial class PanelControl : UserControl
    {
        PanelBuilder panelBuilder;

        PanelType_e pType;
        PanelProfile_e pProfil;
        Vector2 pSize;
        int pInnerMaterial;
        int pOuterMaterial;
        double innerThickness;
        double outerThickness;


        int outerCoatClass;
        int outerRALID;
        string outerCoatType;
        int innerCoatClass;
        int innerRALID;
        string innerCoatType;



        public PanelControl()
        {
            InitializeComponent();

            //try
            //{
            //    Dictionary<int, string> panelsType = new Dictionary<int, string>()
            //    {
            //        { (int)PanelType_e.BlankPanel, "Несьемная глухая" } ,
            //        { (int)PanelType_e.RemovablePanel, "Сьемная" } ,
            //        { (int)PanelType_e.FrontPanel, "Торцевая"}
            //    };
            //    comboBoxPanelType.DataSource = new BindingSource(panelsType, null);
            //    comboBoxPanelType.ValueMember = "Key";
            //    comboBoxPanelType.DisplayMember = "Value";


            //    Dictionary<int, int> pProfil = new Dictionary<int, int>()
            //    {
            //        { (int)PanelProfile_e.Profile_3_0, (int)PanelProfile_e.Profile_3_0 },
            //        { (int)PanelProfile_e.Profile_5_0, (int)PanelProfile_e.Profile_5_0 },
            //        { (int)PanelProfile_e.Profile_7_0, (int)PanelProfile_e.Profile_7_0 }
            //    };
            //    comboBoxPanelProfil.DataSource = new BindingSource(pProfil, null);
            //    comboBoxPanelProfil.ValueMember = "Key";
            //    comboBoxPanelProfil.DisplayMember = "Value";





            //    comboBoxOuterMaterial.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForFrame(), null);
            //    comboBoxOuterMaterial.ValueMember = "Key";
            //    comboBoxOuterMaterial.DisplayMember = "Value";


            //    comboBoxInnerMaterila.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForFrame(), null);
            //    comboBoxInnerMaterila.ValueMember = "Key";
            //    comboBoxInnerMaterila.DisplayMember = "Value";




            //    comboBoxColor.DataSource = new BindingSource(SwPlusRepository.Instance.GetRAL(), null);
            //    comboBoxColor.ValueMember = "RALID";
            //    comboBoxColor.DisplayMember = "RALName";
            //    comboBoxColor.SelectedIndex = 0;


            //    comboBoxCoatType.DataSource = SwPlusRepository.Instance.CoatingType();
            //    comboBoxCoatClass.DataSource = SwPlusRepository.Instance.CoatingClass();
            //    comboBoxCoatType.SelectedIndex = 0;
            //    comboBoxCoatClass.SelectedIndex = 0;
            //    comboBoxCoatClass.Enabled = false;
            //    comboBoxCoatType.Enabled = false;


            //    comboBoxCoatTypeOut.DataSource = SwPlusRepository.Instance.CoatingType();
            //    comboBoxCoatClassOut.DataSource = SwPlusRepository.Instance.CoatingClass();
            //    comboBoxCoatTypeOut.SelectedIndex = 0;
            //    comboBoxCoatClassOut.SelectedIndex = 0;
            //    comboBoxCoatClassOut.Enabled = false;
            //    comboBoxCoatTypeOut.Enabled = false;

            //    comboBoxColorOut.DataSource = new BindingSource(SwPlusRepository.Instance.GetRAL(), null);
            //    comboBoxColorOut.ValueMember = "RALID";
            //    comboBoxColorOut.DisplayMember = "RALName";
            //    comboBoxColorOut.SelectedIndex = 0;

            //    FillThickness((int)comboBoxInnerMaterila.SelectedValue, comboBoxInnerThickness);
            //    FillThickness((int)comboBoxOuterMaterial.SelectedValue, comboBoxOuterMaterial);

            this.comboBoxInnerMaterila.SelectedIndexChanged += new System.EventHandler(this.comboBoxInnerMaterila_SelectedIndexChanged);
            this.comboBoxOuterMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxOuterMaterial_SelectedIndexChanged);
            this.comboBoxColor.SelectedIndexChanged += ComboBoxColor_SelectedIndexChanged;
            this.comboBoxColorOut.SelectedIndexChanged += ComboBoxColorOut_SelectedIndexChanged;
        //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    MessageBox.Show(ex.StackTrace);
            //    throw ex;
            //}
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
                case 1800:
                    cmb.Items.Add(2);
                    break;
                case 2100:
                    cmb.Items.Add(2);
                    cmb.Items.Add(3);
                    break;
                case 18400:
                    cmb.Items.Add(4);
                    break;
                default:
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
                    
                    panelBuilder.Build((PanelType_e)pType, (PanelProfile_e)pProfil, pSize, pOuterMaterial, pInnerMaterial, outerThickness, innerThickness, outerCoatClass, outerRALID, outerCoatType, innerCoatClass, innerRALID, innerCoatType);
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

                innerThickness = Convert.ToDouble(comboBoxInnerThickness.Text);
                outerThickness = Convert.ToDouble(comboBoxOuterThicknes.Text);

                outerRALID = (int)comboBoxColorOut.SelectedValue;
                innerRALID = (int)comboBoxColor.SelectedValue;

                outerCoatClass = (int)comboBoxCoatClassOut.SelectedValue;
                innerCoatClass = (int)comboBoxCoatClass.SelectedValue;

                outerCoatType = (string)comboBoxCoatTypeOut.SelectedValue;
                innerCoatType = (string)comboBoxCoatType.SelectedValue;



                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible to create the model. The input values are inappropriate.");
                return false;
            }
        }
    }
}