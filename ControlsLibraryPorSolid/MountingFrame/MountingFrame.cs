using System;
using DataBaseDomian;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using SolidWorksLibrary;

namespace ControlsLibrary.MountingFrame
{
    [ComVisible(true), Guid("F8358B23-3E51-453C-8EF8-9ABD22525214"), ProgId("IPS.EditContextMenu")]
    [ClassInterface(ClassInterfaceType.None)]

    public partial class MountingFrame : UserControl
    {
        int width;
        int length;
        int frameOffset;
        int frameType;
        decimal thickness;
        bool cheched;
        int materialID;
        int coatColor, coatClass;
        string coatType;
        PDMWebService.Data.Solid.ElementsCase.MountingFrameBuilder mountingFrContr;
        
        

        public MountingFrame( string pathIps)
        {
            RealiseBuilderBehaviour.PathToStorage += new SolidWorksLibrary.Builders.ElementsCase.ProductBuilderBehavior.IPSPath(() => { return pathIps; });
            InitializeComponent();
            comboBoxFrameMaterial.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForFrame(), null);
            comboBoxFrameMaterial.ValueMember = "Key";
            comboBoxFrameMaterial.DisplayMember = "Value";


            comboBoxColor.DataSource = new BindingSource(SwPlusRepository.Instance.GetRAL(), null);
            comboBoxColor.ValueMember = "RALID";
            comboBoxColor.DisplayMember = "RALName";


            comboBoxCoatType.DataSource = SwPlusRepository.Instance.CoatingType();
            comboBoxCoatClass.DataSource = SwPlusRepository.Instance.CoatingClass();
            
            comboBoxFrameMaterial.SelectedIndex = 0;
            comboBoxFrameType.SelectedIndex = 0;
            comboBoxCoatClass.SelectedIndex = 0;
            comboBoxCoatType.SelectedIndex = 0;
            comboBoxColor.SelectedIndex = 0;

            comboBoxCoatClass.Enabled = false;
            comboBoxCoatType.Enabled = false;

            FillThickness((int)comboBoxFrameMaterial.SelectedValue);

            this.comboBoxFrameMaterial.SelectedIndexChanged += new System.EventHandler(this.comboBoxFrameMaterial_SelectedIndexChanged);
            this.comboBoxColor.SelectedIndexChanged += ComboBoxColor_SelectedIndexChanged;
        }


        private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillColor((int)comboBoxColor.SelectedValue);
        }

        private void btnFrameBuild_Click(object sender, EventArgs e)
        {
            labelForUserToWait.Visible = true;
            labelForUserToWait.Text = "Выполняеться построение...";
            mountingFrContr = new PDMWebService.Data.Solid.ElementsCase.MountingFrameBuilder();

            if (ConvertValues())
            {
                try
                {
                    mountingFrContr.BuildMountageFrame(width, length, thickness, frameType, frameOffset, materialID, coatColor, coatType, coatClass);
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
            try
            {
                width =  Convert.ToInt32(textBoxWidth.Text);
                length = Convert.ToInt32(textBoxLenth.Text);

                if (cheched)
                {
                    width = width - 40;
                }
                else
                {
                    width = width - 20;
                }

                if (frameType == 3)
                {
                    frameOffset = Convert.ToInt32(textBoxDisplacement.Text);
                }

                //под покрытие
                coatColor = (int)comboBoxColor.SelectedValue;
                if (coatColor == 214)
                {
                    coatClass = 0;
                    coatType = "0";
                }
                else
                {
                    coatClass = (int)comboBoxCoatClass.SelectedItem;
                    coatType = (string)comboBoxCoatType.SelectedItem;
                }

                materialID = (int)comboBoxFrameMaterial.SelectedValue;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Impossible to create the model. The input values are inappropriate.");
                return false;
            }
        }
        private void comboBoxFrameType_SelectedIndexChanged(object sender, EventArgs e)
        {
            frameType = comboBoxFrameType.SelectedIndex;
            string picturePath = string.Empty;
            try
            {
                switch (frameType)
                {
                    case 0:
                        textBoxDisplacement.Enabled = false;
                        textBoxDisplacement.Text = "";
                        pictureFrame.Image = Properties.Resources._10_4_800_650;
                        break;
                    case 1:
                        textBoxDisplacement.Enabled = false;
                        textBoxDisplacement.Text = "";
                        pictureFrame.Image = Properties.Resources._10_4_800_650_01;
                        break;
                    case 2:
                        textBoxDisplacement.Enabled = false;
                        textBoxDisplacement.Text = "";
                        pictureFrame.Image = Properties.Resources._10_4_800_650_02;
                        break;
                    case 3:
                        textBoxDisplacement.Enabled = true;
                        pictureFrame.Image = Properties.Resources._10_4_800_1000_03;
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Exception to load picrure");
            }
            pictureFrame.Show();
            
        }
        private void comboBoxThickness_SelectedIndexChanged(object sender, EventArgs e)
        {
            thickness = Convert.ToDecimal(comboBoxThickness.SelectedItem);
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cheched = checkBox1.Checked;
        }
        private void comboBoxFrameMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillThickness((int)comboBoxFrameMaterial.SelectedValue);
        }
        private void ON_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && ( e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }


        private void Value_TextChanged(object sender, EventArgs e)
        {
            labelForUserToWait.Visible = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                if (ConvertValues())
                {

                    int searchedID = SwPlusRepository.Instance.Search_Frame(frameType, width, length, thickness, frameOffset, coatColor, coatType, coatClass, materialID);
                    var res = Search._SEARCH.PathExistance(searchedID, Search.CAller.Montage);
                    Search._SEARCH.ShowResults(res);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        public void FillThickness(int materialThickness)
        {
           comboBoxThickness.Items.Clear();

            switch (materialThickness)
            {
                case 34273:
                    comboBoxThickness.Items.Add(2);
                    break;
                case 34285:
                    comboBoxThickness.Items.Add(3);
                    break;
                //case 34286:
                //    comboBoxThickness.Items.Add(4);
                //    break;
                default:
                    break;
            }
            comboBoxThickness.SelectedIndex = 0;
        }
    }
}