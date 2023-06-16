using System;
using System.Windows.Forms;
using System.Collections.Generic;
using ServiceTypes.Constants;
using SolidWorksLibrary.Builders.ElementsCase;
using DataBaseDomian;



namespace ControlsLibrary.FlapBuilder
{
    public partial class FlapBuilderControl : UserControl
    {
        double width, height;
        decimal thickness;


        int flapType;
        bool outside = false;
        PDMWebService.Data.Solid.ElementsCase.FlapBuilder flapBuilder;
        bool test_case = false;
        int materialID;

        //покрытие
        int coatColor, coatClass;
        string coatType;

        public FlapBuilderControl(string pathIps)
        {
            try
            {

                RealiseBuilderBehaviour.PathToStorage += new SolidWorksLibrary.Builders.ElementsCase.ProductBuilderBehavior.IPSPath(() => { return pathIps; });
                InitializeComponent();

                comboBoxFlapType.Items.AddRange(new object[] { 20, 30 });
                comboBoxFlapType.SelectedValueChanged += new System.EventHandler(this.ComboBoxFlapType_SelectedValueChanged);
                comboBoxFlapType.SelectedItem = comboBoxFlapType.Items[0];

                
                comboBoxFlapMaterial.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForFlap(), null);
                comboBoxFlapMaterial.ValueMember = "Key";
                comboBoxFlapMaterial.DisplayMember = "Value";
                comboBoxFlapMaterial.SelectedValueChanged += comboBoxFlapMaterial_SelectedIndexChanged;
                comboBoxFlapMaterial.SelectedIndex = 0;

                comboBoxThickness.Items.Add(0.8);
                comboBoxThickness.SelectedIndex = 0;


                //
                comboBoxColor.DataSource = new BindingSource(SwPlusRepository.Instance.GetRAL(), null);
                comboBoxColor.ValueMember = "RALID";
                comboBoxColor.DisplayMember = "RALName";


                comboBoxCoatType.DataSource = SwPlusRepository.Instance.CoatingType();
                comboBoxCoatClass.DataSource = SwPlusRepository.Instance.CoatingClass();

                comboBoxCoatClass.SelectedIndex = 0;
                comboBoxCoatType.SelectedIndex = 0;
                comboBoxColor.SelectedIndex = 0;

                comboBoxCoatClass.Enabled = false;
                comboBoxCoatType.Enabled = false;


                pictureFrame.Image = Properties.Resources._11_265;
            }
            catch (Exception e)
            {
                MessageBox.Show("FlapBuilderControl  " + e.Message);
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

        private void ComboBoxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillColor((int)comboBoxColor.SelectedValue);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                labelForUserToWait.Visible = true;
                labelForUserToWait.Text = "Выполняеться построение...";
                flapBuilder = new PDMWebService.Data.Solid.ElementsCase.FlapBuilder();

                if (ConvertValues())
                {

                    try
                    {
                        flapBuilder.Build((FlapTypes_e)flapType, new Vector2(width, height), outside, materialID, (double)thickness, test_case, coatColor, coatType, coatClass);
                        labelForUserToWait.Text = "Построение завершено.";
                    }
                    catch
                    {
                       // labelForUserToWait.Text = "Построение было прервано в связи с ошибками.";
                    }
                }
                else
                {
                    labelForUserToWait.Visible = false;
                }

            }
            catch (Exception w)
            {
                MessageBox.Show("button1_Click (Built)   " + w.Message);
            }
        }

        private void comboBoxFlapMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                FillThickness(Convert.ToInt32( comboBoxFlapMaterial.SelectedValue));
            }
            catch (Exception ex)
            {
                MessageBox.Show("comboBoxFlapMaterial_SelectedIndexChanged  " + ex.Message);
            }
        }

        public void FillThickness(int materialThickness)
        {
            try
            {
                comboBoxThickness.Items.Clear();


                switch (materialThickness)
                {
                    case 34269:
                        comboBoxThickness.Items.Add(0.7);
                        break;
                    case 34270:
                        comboBoxThickness.Items.Add(1);
                        break;
                    case 34271:
                        comboBoxThickness.Items.Add(1.2);
                        break;
                    case 34272:
                        comboBoxThickness.Items.Add(1.5);
                        break;
                    case 34274:
                        comboBoxThickness.Items.Add(1);
                        break;
                    case 2400:
                        comboBoxThickness.Items.Add(0.8);
                        break;
                    default:
                        break;
                }
                comboBoxThickness.SelectedIndex = 0;
            }
            catch (Exception w)
            {
                MessageBox.Show("FillThickness " + w.Message);
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (ConvertValues())
                {
                    int searchedID = SwPlusRepository.Instance.Search_Flap(flapType, (int)width, (int)height, materialID, thickness, outside);
                    var res = Search._SEARCH.PathExistance(searchedID, Search.CAller.Flap);
                    Search._SEARCH.ShowResults(res);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }


        private bool ConvertValues()
        {
            try
            {
                outside = checkBox1.Checked;
                width = Convert.ToDouble(textBoxWidth.Text);
                height = Convert.ToDouble(textBoxHeight.Text);
                thickness = Convert.ToDecimal(comboBoxThickness.SelectedItem);
                materialID = (int)comboBoxFlapMaterial.SelectedValue;
                flapType = (int)comboBoxFlapType.SelectedItem;


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

                return true;
            }
            catch (Exception p)
            {
                MessageBox.Show("ConvertValues " + p.Message);
                return false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) test_case = true;
            else { test_case = false; }
        }

        private void ComboBoxFlapType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToInt32( comboBoxFlapType.SelectedValue) == 30)
                {
                    checkBox2.Enabled = true;
                }
                else
                {
                    checkBox2.Enabled = false;
                }
            }
            catch (Exception q)
            {
                MessageBox.Show("ComboBoxFlapType_SelectedValueChanged  " + q.Message);
            }
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            labelForUserToWait.Visible = false;
        }
        private void ON_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }
    }
}