using System;
using System.Windows.Forms;
using SolidWorksLibrary;
using SolidWorksLibrary.Builders.ElementsCase.Panels.Frameless;
using SolidWorksLibrary.Builders.Case;
using SolidWorksLibrary.Builders.ElementsCase;
using DataBaseDomian.Orm;
using System.Data;
using DataBaseDomian;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using ServiceTypes.Constants;

namespace ControlsLibrary.Frameless
{
    public partial class FramelessBlockControl : UserControl
    {
        object[] thicknessRange = new object[] { 0.5, 0.6, 0.8, 1.0, 1.2, 1.5 };
        string[] amplification = new string[] { "-", "Н", "НВ", "НЗ", "НВЗ", "НВЗС", "НВЗСТ", "Т" };
        const int widthFrameOffset = 30;


        AVTypeSizeDataContext av;
        SolidWorksLibrary.Builders.Case.PanelDestination deafSide;


        int roofPanelType, downPanelTypes;
        int roofFlange, downFlange, deafFlange, frontFlange, backFlange;
        double roofWindowWidth, roofWindowHeight, roofWindowOff_X, roofWindowOff_Y;
        double downWindowWidth, downWindowHeight, downWindowOff_X, downWindowOff_Y;
        double deafWindowWidth, deafWindowHeight, deafWindowOff_X, deafWindowOff_Y;

        double frontWindowWidth, frontWindowHeight, frontWindowOff_X, frontWindowOff_Y;
        double backWindowWidth, backWindowHeight, backWindowOff_X, backWindowOff_Y;


        private CutFront cc;
        private CutBack bb;

        public FramelessBlockControl()
        {
            try
            {

                InitializeComponent();

                //типоразмер
                av = new AVTypeSizeDataContext();


                #region Working directory

                cmbBoxSection.DataSource = new string[] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"};

                int[] flanges = { 20, 30 };
                cmbBoxRoofFlange.DataSource = flanges;
                cmbBoxDownFlange.DataSource = flanges;
                cmbBoxDeafFlange.DataSource = flanges;
                

                System.Collections.Generic.Dictionary<int, string> roofPanels = new System.Collections.Generic.Dictionary<int, string>() {
                    { 21, "Без крыши" }, { 22, "Односкатная" } };
                cmbBoxRoofPanelTypes.DataSource = new BindingSource(roofPanels, null);
                cmbBoxRoofPanelTypes.ValueMember = "Key";
                cmbBoxRoofPanelTypes.DisplayMember = "Value";



                System.Collections.Generic.Dictionary<int, string> downPanels = new System.Collections.Generic.Dictionary<int, string>() {
                { 30, "Без опор" }, { 31, "Рама монтажная" }, {32, "Ножки опопрные" } };
                cmbBoxDownPanelType.DataSource = new BindingSource(downPanels, null);
                cmbBoxDownPanelType.ValueMember = "Key";
                cmbBoxDownPanelType.DisplayMember = "Value";


                cmbBoxInnnerThick.Items.AddRange(thicknessRange);
                cmbBoxOuterThick.Items.AddRange(thicknessRange);


                cmbBoxOuterMaterial.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForPannels(), null);
                cmbBoxOuterMaterial.ValueMember = "Key";
                cmbBoxOuterMaterial.DisplayMember = "Value";

                cmbBoxInnerMaterial.DataSource = new BindingSource(SwPlusRepository.Instance.MaterialsForPannels(), null);
                cmbBoxInnerMaterial.ValueMember = "Key";
                cmbBoxInnerMaterial.DisplayMember = "Value";

                System.Collections.Generic.Dictionary<int, string> scotchCollection
                    = new System.Collections.Generic.Dictionary<int, string>() { { 1, "Со скотчем" }, { 2, "Без скотча" } };
                cmbBoxScotch.DataSource = new BindingSource(scotchCollection, null);
                cmbBoxScotch.ValueMember = "Key";
                cmbBoxScotch.DisplayMember = "Value";


                cmbBoxTypeSize.DataSource = new BindingSource(av.StandardSizes, null);
                cmbBoxTypeSize.DisplayMember = "Type";
                cmbBoxTypeSize.ValueMember = "SizeID";

                

                DataTable dtSSPannelTypes = new DataTable();
                dtSSPannelTypes.Columns.AddRange(new DataColumn[] { new DataColumn("Key", typeof(int)),
                                                                            new DataColumn("Value", typeof(string ))});
                dtSSPannelTypes.Columns.Add("Удалить", typeof(DataGridViewButtonCell));

                DataRow dr = dtSSPannelTypes.NewRow();
                dr["Key"] = (int)PanelType_e.RemovablePanel;
                dr["Value"] = GetDescription(PanelType_e.RemovablePanel); //Enum.GetName(typeof(PanelType_e), PanelType_e.RemovablePanel);
                dtSSPannelTypes.Rows.Add(dr);

                DataRow dr1 = dtSSPannelTypes.NewRow();
                dr1["Key"] = (int)PanelType_e.Сьемная_без_ручки;
                dr1["Value"] = Enum.GetName(typeof(PanelType_e), PanelType_e.Сьемная_без_ручки);
                dtSSPannelTypes.Rows.Add(dr1);

                DataRow dr2 = dtSSPannelTypes.NewRow();
                dr2["Key"] = (int)PanelType_e.УсилПанель;
                dr2["Value"] = Enum.GetName(typeof(PanelType_e), PanelType_e.УсилПанель);
                dtSSPannelTypes.Rows.Add(dr2);

                DataRow dr3 = dtSSPannelTypes.NewRow();
                dr3["Key"] = (int)PanelType_e.Профиль;
                dr3["Value"] = Enum.GetName(typeof(PanelType_e), PanelType_e.Профиль);
                dtSSPannelTypes.Rows.Add(dr3);

                dtSSPannelTypes.AcceptChanges();


                DataGridViewComboBoxColumn colTypes = (DataGridViewComboBoxColumn)serviceSidePannels.Columns[0];
                
                colTypes.DataSource = dtSSPannelTypes;
                colTypes.ValueMember = "Key";
                colTypes.DisplayMember = "Value";
                serviceSidePannels.CellValueChanged += ServiceSidePannels_CellValueChanged;


                cmbBoxAmplification.DataSource = amplification;

                cmbBoxAmplification.SelectedIndex = 0;
                cmbBoxOuterThick.SelectedIndex = 0;
                cmbBoxInnnerThick.SelectedIndex = 0;
                cmbBoxOuterMaterial.SelectedIndex = 0;
                cmbBoxInnerMaterial.SelectedIndex = 0;
                cmbBoxDownPanelType.SelectedIndex = 0;
                cmbBoxRoofPanelTypes.SelectedIndex = 0;
                cmbBoxScotch.SelectedIndex = 0;
                cmbBoxTypeSize.SelectedIndex = 0;


                this.cmbBoxScotch.SelectedIndexChanged += new System.EventHandler(this.cmbBoxScotch_SelectedIndexChanged);
                this.cmbBoxRoofPanelTypes.SelectedIndexChanged += new System.EventHandler(this.cmbBoxRoofPanelTypes_SelectedIndexChanged);
                this.cmbBoxInnerMaterial.SelectedIndexChanged += new System.EventHandler(this.cmbBoxInnerMaterial_SelectedIndexChanged);
                this.cmbBoxOuterMaterial.SelectedIndexChanged += new System.EventHandler(this.OutputMaterial_SelectedIndexChanged);
                this.cmbBoxDownPanelType.SelectedIndexChanged += CmbBoxDownPanelType_SelectedIndexChanged;
                this.cmbBoxTypeSize.SelectedIndexChanged += new System.EventHandler(this.cmbBoxTypeSize_SelectedIndexChanged);
                SetTypeSize((int)cmbBoxTypeSize.SelectedValue);



                labelAllowToBuiltBttn.Visible = false;
                #endregion ends here


                ////////////////////////
                cc = new CutFront();
                bb = new CutBack();
                tabPage5.Controls.Add(cc);
                tabPage5.Controls.Add(bb);
                InitializeLittleControls();

                
                bb.AccessBuildButton += AllowWindowBackCut;
                bb.IsOffsetPossible += IsOffsetBackPossible;
                bb.resize += InitializeLittleControls;
                bb.setFlange += SetBackFlange;
                bb.backPanelChecked += backPanelChecked;

                cc.AccessBuildButton += AllowWindowFrontCut;
                cc.IsOffsetPossible += IsOffsetFrontPossible;
                cc.resize += InitializeLittleControls;
                cc.setFlange += SetFrontFlange;
                cc.add += frontPanelCheck_add;
            }
            catch (Exception eee)
            {
                throw eee;
            }
        }

        private void ServiceSidePannels_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                DataGridViewComboBoxCell cell = serviceSidePannels.CurrentCell as DataGridViewComboBoxCell;

                int rowToOperate = e.RowIndex;

                if ((int)cell.Value == (int)PanelType_e.Профиль)
                {

                    DataGridViewComboBoxCell ComboBoxCell = new DataGridViewComboBoxCell();

                    ComboBoxCell.DataSource = Enum.GetNames(typeof(Profiles_ForRemovable_e));
                    serviceSidePannels[1, rowToOperate] = ComboBoxCell;
                }
                else if ((int)cell.Value == (int)PanelType_e.УсилПанель)
                {

                    DataGridViewComboBoxCell ComboBoxCell = new DataGridViewComboBoxCell();

                    ComboBoxCell.DataSource = Enum.GetNames(typeof(AmplificationPanels_e));
                    serviceSidePannels[1, rowToOperate] = ComboBoxCell;
                }
                else
                {
                    DataGridViewTextBoxCell TextCell = new DataGridViewTextBoxCell();
                    serviceSidePannels[1, rowToOperate] = TextCell;
                }
            }
        }


        private void frontPanelCheck_add(bool value)
        {
            FramelessBlock.FrontPanel = value;
        }

        private void backPanelChecked(bool add)
        {
            FramelessBlock.BackPanel = add;
        }

        //Фланцы
        private void SetFrontFlange(int value)
        {
            this.frontFlange = value;
        }
        private void SetBackFlange(int value)
        {
            this.backFlange = value;
        }

        /// <summary>
        /// Смещение выреза
        /// </summary>
        /// <param name="value_off_X">Возвращаемый параметр, чтоб пользователь видел допустимое значение</param>
        /// <param name="value_off_Y">Возвращаемый параметр, чтоб пользователь видел допустимое значение</param>
        /// <returns></returns>
        private bool IsOffsetBackPossible(ref int? value_off_X, ref int? value_off_Y)
        {
            int widthOff_Possible, heightOff_possible;
            GetBlockWidthHeight(out widthOff_Possible, out heightOff_possible);// данные с контролов длина/ширина блока


            if (value_off_X != null)
            {
                widthOff_Possible = widthOff_Possible / 2 - widthFrameOffset - (int)backWindowWidth / 2;//рассчет макс. допустимого смещения
                if (Math.Abs(value_off_X.Value) > widthOff_Possible)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                    value_off_X = widthOff_Possible;
                    backWindowOff_X = 0;
                    return false;
                }
                else
                {
                    backWindowOff_X = (double)value_off_X;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                    return true;
                }
            }

            if (value_off_Y != null)
            {
                heightOff_possible = heightOff_possible / 2 - widthFrameOffset - (int)backWindowHeight / 2;

                if (Math.Abs(value_off_Y.Value) > heightOff_possible)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                    value_off_Y = heightOff_possible;
                    backWindowOff_Y = 0;
                    return false;
                }
                else
                {
                    backWindowOff_Y = (double)value_off_Y;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                    return true;
                }
            }
            return false;
        }
        private bool IsOffsetFrontPossible(ref int? value_X, ref int? value_Y)
        {
            int width, height;
            GetBlockWidthHeight(out width, out height);// данные с контролов длина/ширина блока


            if (value_X != null)
            {
                width = width / 2 - widthFrameOffset - (int)frontWindowWidth / 2;//рассчет макс. допустимого смещения

                if (Math.Abs(value_X .Value)> width)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                    value_X = width;//возвращаемый параметр, чтоб пользователь видел допустимое значение
                    frontWindowOff_X = 0;
                    return false;
                }
                else
                {
                    frontWindowOff_X = (double)value_X;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                    return true;
                }
            }

            if (value_Y != null)
            {
                height = height / 2 - widthFrameOffset - (int)frontWindowHeight / 2;

                if (Math.Abs(value_Y.Value) > height)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                    value_Y = height;
                    frontWindowOff_Y = 0;
                    return false;
                }
                else
                {
                    frontWindowOff_Y = (double)value_Y;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// С учетом того, что торцевая на 40 мм меньше блока
        /// </summary>
        /// <param name="width"></param>
        /// <param name="height"></param>
        private void GetBlockWidthHeight(out int width, out int height)
        {
            width = (Convert.ToInt32(textBoxWidth.Text)) - 40;
            height = (Convert.ToInt32(textBoxHeight.Text)) - 40;
        }

        public void InitializeLittleControls()
        {
            if (cc == null) cc = new CutFront();
            if (bb == null) bb = new CutBack();
            cc.Update();
            bb.Update();
            cc.Location = new System.Drawing.Point(0, 0);
            bb.Location = new System.Drawing.Point(0, cc.Size.Height + 5);
        }


        //Проверяем меньше ли размер выреза размера торцевой выхода, инициализация переменных выреза
        private bool AllowWindowBackCut(int? X, int? Y)
        {
            int width, height;
            GetBlockWidthHeight(out width, out height);// данные с контролов длина/ширина блока


            width = width - 2 * widthFrameOffset; // ширина двух рамок
            height = height - 2 * widthFrameOffset;

            if (X != null)
            {
                if (Math.Abs(X.Value) > width)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                }
                else
                {
                    backWindowWidth = (double)X;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                }
            }


            if (Y != null)
            {
                if (Math.Abs(Y.Value) > height)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                }
                else
                {
                    backWindowHeight = (double)Y;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                }
            }

            return false;
        }
        //Проверяем меньше ли размер выреза размера торцевой входа, инициализация переменных выреза
        private bool AllowWindowFrontCut(int? X, int? Y)
        {
            int width, height;
            GetBlockWidthHeight(out width, out height);// данные с контролов длина/ширина блока


            width = width - 2 * widthFrameOffset; // ширина двух рамок
            height = height - 2 * widthFrameOffset;

            if (X != null)
            {
                if (Math.Abs(X.Value) > width)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                }
                else
                {
                    frontWindowWidth = (double)X;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                }
            }


            if (Y != null)
            {
                if (Math.Abs(Y.Value) > height)
                {
                    labelAllowToBuiltBttn.Visible = true;
                    labelAllowToBuiltBttn.Text = "Размер выреза превысил размер панели!";
                    labelAllowToBuiltBttn.ForeColor = System.Drawing.Color.Red;
                    btnFramelessBuild.Enabled = false;
                    frontWindowHeight = 0;
                }
                else
                {
                    frontWindowHeight = (double)Y;
                    btnFramelessBuild.Enabled = true;
                    labelAllowToBuiltBttn.Visible = false;
                }
            }

            return false;
        }


        private void cmbBoxOuterThick_SelectedIndexChanged(object sender, EventArgs e)
        {
            FramelessBlock.OuterThickness = Convert.ToDouble(cmbBoxOuterThick.SelectedItem);
        }
        private void cmbBoxInnnerThick_SelectedIndexChanged(object sender, EventArgs e)
        {
            FramelessBlock.InnerThickness = Convert.ToDouble(cmbBoxInnnerThick.SelectedItem);
        }



        private void cmbBoxTypeSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTypeSize((int)cmbBoxTypeSize.SelectedValue);
        }
        private void SetTypeSize(int sizeID)
        {
            int? width = 0, height = 0;
            av.GetAV_TypeSize(sizeID, ref width, ref height);

            textBoxWidth.Text = width.ToString();
            textBoxHeight.Text = height.ToString();
        }



        //для отображения в первом рядке длины стороны обслуживания, равной длине установки
        private void serviceSidePannels_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex == 0)
            {
                try
                {
                    int l = Convert.ToInt32(textBoxLength.Text);
                    if (l > 0) serviceSidePannels[1, 0].Value = l.ToString();
                }
                catch
                {
                }
            }
        }


        private void serviceSidePannels_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                if (e.ColumnIndex == 2)
                {
                    try
                    {
                        serviceSidePannels.Rows.RemoveAt(e.RowIndex);
                    }
                    catch
                    {
                        MessageBox.Show("Нельзя удалить пустой рядок");
                    }

                    FramelessBlock.serviseSidePanelsInOrder.Clear();
                }
            }
        }

        private void withFrameCheck_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void DefineThicknessControlsState(int selectedValue, ComboBox cb)
        {
            switch (selectedValue)
            {
                case 1700:
                    cb.Items.Clear();
                    cb.Items.Add(0.7);
                    break;
                case 34269:
                    cb.Items.Clear();
                    cb.Items.Add(0.7);
                    break;
                default:
                    cb.Items.Clear();
                    cb.Items.AddRange(thicknessRange);
                    break;
            }
            cb.SelectedIndex = 0;
        }


        //проверяет длинна стороны обслуживания меньше длины установки
        private void serviceSidePannels_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                try
                {
                    int counter = serviceSidePannels.Rows.Count - 1;//к-во панелей
                    int sumOfServiceSideLenght = 0;
                    int lenghtP = 0;
                    int panelType;

                    for (int i = 0; i < counter; i++)
                    {

                        panelType = (int)(serviceSidePannels.Rows[i].Cells[0].Value != null ? (PanelType_e)serviceSidePannels.Rows[i].Cells[0].Value : 0);

                        DataGridViewCellCollection col = serviceSidePannels.Rows[i].Cells;


                        if (panelType != (int)PanelType_e.Профиль && panelType != (int)PanelType_e.УсилПанель) // панель, а не профиль
                        {
                            string temp = "0";
                            if (col[1].EditedFormattedValue != null)
                                temp = col[1].EditedFormattedValue.ToString();


                            try
                            {
                                int.TryParse(temp, out lenghtP);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("TryParse exception " + ex.Message);
                            }
                            
                            sumOfServiceSideLenght += lenghtP;
                        }
                        else if(panelType == (int)PanelType_e.УсилПанель)
                        {
                            sumOfServiceSideLenght += 130;
                        }
                    }

                    try
                    {
                        if (sumOfServiceSideLenght > Convert.ToInt32(textBoxLength.Text))
                        {
                            MessageBox.Show("Длина стороны обслуживания превысила длину установки: " + sumOfServiceSideLenght + "   " + textBoxLength.Text);

                            btnFramelessBuild.Enabled = false;
                        }
                        else
                        {
                            btnFramelessBuild.Enabled = true;
                        }
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Введите корректною длину установки!");
                    }

                    label40.Text = "Осталось на сьемную сторону:\t" + (Convert.ToInt32(textBoxLength.Text) - sumOfServiceSideLenght).ToString();
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("serviceSidePannels_RowLeave " + ex.StackTrace);
                }
            }
        }


        //все ли ячейки заполнены для стороны обсуживания
        private void tabControl1_Deselecting(object sender, TabControlCancelEventArgs e)
        {
            if (e.TabPageIndex == 2)
            {
                if (GetEmptyGrid())
                    e.Cancel = true;
            }
        }
        private bool GetEmptyGrid()
        {
            try
            {

                DataGridViewRowCollection coll = serviceSidePannels.Rows;

                for(int i = 0; i < coll.Count-1; i++)
                {


                    if (string.IsNullOrWhiteSpace(coll[i].Cells[0].Value?.ToString()) || string.IsNullOrWhiteSpace(coll[i].Cells[1].Value?.ToString()))
                    {
                        i = coll.Count - 1;
                        MessageBox.Show("Заполнены не все поля!");
                        return true;
                    }
                }

                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("GetEmptyGrid: " + e.Message);
                return false;
            }
        }
        

        private void CmbBoxDownPanelType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbBoxDownPanelType.SelectedValue == (int)PanelType_e.РамаМонтажная)
            {
                groupBoxDownFoot.Height = 202;
                withFrameCheck.Enabled = true;
            }
            else
            {
                withFrameCheck.Enabled = false;
                groupBoxDownFoot.Height = 38;
            }
        }
        private void cmbBoxRoofPanelTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int)cmbBoxRoofPanelTypes.SelectedValue == (int)PanelType_e.односкат)
            {
                roofGroupBoxBottom.Height = 202;
                roofFoot.Enabled = true;
            }
            else
            {
                roofGroupBoxBottom.Height = 40;
                roofFoot.Enabled = false;
            }
        }


        private void cmbBoxInnerMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetInnerMaterial((int)cmbBoxInnerMaterial.SelectedValue);
        }
        private void SetInnerMaterial(int material)
        {
            if (material != 1700)
            {
                cmbBoxInnnerThick.Visible = true;
            }
            else
            {
                cmbBoxInnnerThick.Visible = false;
            }
            FramelessBlock.MaterialInner = material;
            DefineThicknessControlsState(material, cmbBoxInnnerThick);
        }
        private void OutputMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetOutMaterial((int)cmbBoxOuterMaterial.SelectedValue);
        }
        private void SetOutMaterial(int material)
        {
            if (material != 1700)
            {
                cmbBoxOuterThick.Visible = true;
            }
            else
            {
                cmbBoxOuterThick.Visible = false;
            }
            FramelessBlock.MaterialOuter = material;
            DefineThicknessControlsState(material, cmbBoxOuterThick);

        }


        private void cmbBoxScotch_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GetThermoStrip((int)cmbBoxScotch.SelectedValue);
            }
            catch (Exception ex)
            {

                //throw ex;
            }
        }
        private void GetThermoStrip(int scotch)
        {
            FramelessBlock.ThermoStrip = (ThermoStrip_e)(scotch);
        }


        private void checkStandard_CheckedChanged(object sender, EventArgs e)
        {
            FramelessBlock.Standart = checkStandard.Checked;

            if (FramelessBlock.Standart)
            {
                textBoxHeight.Enabled = true;
                textBoxWidth.Enabled = true;
            }
            else
            {
                textBoxHeight.Enabled = false;
                textBoxWidth.Enabled = false;
            }
        }

        private void btnFramelessBuild_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxOrder.Text))
                MessageBox.Show("Введите номер заказа!");


            FramelessBlock block = new FramelessBlock();

            GetAllPanels();

            block.GenerateBlock(FramelessBlock.DictionaryOfP, block);
            FramelessBlock.serviseSidePanelsInOrder.RemoveRange(0, FramelessBlock.serviseSidePanelsInOrder.Count);
        }



        private void GetAllPanels()
        {
            FramelessBlock.serviseSidePanelsInOrder.Clear();
            FramelessBlock.DictionaryOfP.Clear();

            try
            {
                if (CollectTextValues())
                {
                    FramelessPanel top;
                    FramelessPanel down;
                    FramelessPanel deaf;
                    FramelessPanel front;
                    FramelessPanel back;


                    top = new FramelessPanel((PanelType_e)roofPanelType, new Vector2(FramelessBlock.BlockSizeZ, FramelessBlock.BlockSizeX),
                            new Vector2(roofWindowWidth, roofWindowHeight), new Vector2(roofWindowOff_X, roofWindowOff_Y),
                            FramelessBlock.ThermoStrip, FramelessBlock.InnerThickness, FramelessBlock.OuterThickness, FramelessBlock.Amplification[PanelDestination.Top]);
                    FramelessBlock.DictionaryOfP.Add(new PanelOnASide(top, PanelDestination.Top));


                    down = new FramelessPanel((PanelType_e)downPanelTypes, new Vector2(FramelessBlock.BlockSizeZ, FramelessBlock.BlockSizeX),
                            new Vector2(downWindowWidth, downWindowHeight), new Vector2(downWindowOff_X, downWindowOff_Y),
                            FramelessBlock.ThermoStrip, FramelessBlock.InnerThickness, FramelessBlock.OuterThickness, FramelessBlock.Amplification[PanelDestination.Down]);
                    FramelessBlock.DictionaryOfP.Add(new PanelOnASide(down, PanelDestination.Down));


                    deaf = new FramelessPanel(PanelType_e.BlankPanel, new Vector2(FramelessBlock.BlockSizeZ, FramelessBlock.BlockSizeY - 40),
                                new Vector2(deafWindowWidth, deafWindowHeight), new Vector2(deafWindowOff_X, deafWindowOff_Y),
                                FramelessBlock.ThermoStrip, FramelessBlock.InnerThickness, FramelessBlock.OuterThickness, FramelessBlock.Amplification[deafSide]);
                    FramelessBlock.DictionaryOfP.Add(new PanelOnASide(deaf, deafSide));

                    object tt = new object();
                    

                    if (FramelessBlock.FrontPanel)
                    {
                        front = new FramelessPanel(PanelType_e.FrontPanel, new SolidWorksLibrary.Builders.ElementsCase.Vector2(FramelessBlock.BlockSizeY - 40, FramelessBlock.BlockSizeX - 40),
                                new SolidWorksLibrary.Builders.ElementsCase.Vector2(frontWindowHeight, frontWindowWidth), new Vector2(frontWindowOff_X, frontWindowOff_Y * (-1)),
                                FramelessBlock.ThermoStrip, FramelessBlock.InnerThickness, FramelessBlock.OuterThickness, FramelessBlock.Amplification[PanelDestination.Front]);
                        FramelessBlock.DictionaryOfP.Add(new PanelOnASide(front, PanelDestination.Front));
                    }

                    if (FramelessBlock.BackPanel)
                    {
                        back = new FramelessPanel(PanelType_e.FrontPanel, new Vector2(FramelessBlock.BlockSizeY - 40, FramelessBlock.BlockSizeX - 40),
                                new Vector2(backWindowHeight, backWindowWidth), new Vector2(backWindowOff_X * (-1), backWindowOff_Y),
                                FramelessBlock.ThermoStrip, FramelessBlock.InnerThickness, FramelessBlock.OuterThickness, FramelessBlock.Amplification[PanelDestination.Back]);
                        FramelessBlock.DictionaryOfP.Add(new PanelOnASide(back, PanelDestination.Back));
                    }
                    GetServiceSidePannels();
                }
            }
            catch(Exception ex) { throw ex; }
        }


        /// <summary>
        /// Collects all service side panels in "left to right" order
        /// </summary>
        private void GetServiceSidePannels()
        {
            
            try
            {
                double sumOfServiceSideLenght = 0; // сторона обслуживания на 2 мм меньше длины блока + 2мм между всеми панелями
                int rowsCount = serviceSidePannels.Rows.Count - 1;//к-во панелей
                FramelessBlock.AmplificationPanels = new bool[3];
                FramelessBlock.AmplificationPanels.Initialize();

                FramelessBlock.AmplificationProfiles = new bool[10];
                FramelessBlock.AmplificationProfilesLenght = new double[10] { 0,0,0,0,0,0,0,0,0,0};
                FramelessBlock.AmplificationProfiles.Initialize();
                
                FramelessPanel onePanel;
                double lenghtP;
                int panelType;
                int profileCounter = 1;
                DataGridViewCellCollection col;


                for (int i = 0; i < rowsCount; i++)
                {


                    panelType = (int)((serviceSidePannels.Rows[i]).Cells[0]).Value;
                    col = serviceSidePannels.Rows[i].Cells;


                    if (panelType != (int)PanelType_e.Профиль && panelType != (int)PanelType_e.УсилПанель)
                    {
                        lenghtP = Convert.ToDouble(col[1].Value);
                        sumOfServiceSideLenght += lenghtP;

                        onePanel = new FramelessPanel((PanelType_e)panelType, new Vector2(lenghtP, FramelessBlock.BlockSizeY - 40),
                                    new Vector2(0, 0), new Vector2(0, 0), FramelessBlock.ThermoStrip,
                                    FramelessBlock.InnerThickness, FramelessBlock.OuterThickness, false);

                        FramelessBlock.serviseSidePanelsInOrder.Add(new ServiceSide(onePanel, i, (lenghtP - 2), i));
                    }
                    else if (panelType == (int)PanelType_e.УсилПанель)
                    {
                        var res = col[1].Value.ToString();
                        object oo = Enum.Parse(typeof(AmplificationPanels_e), res);
                        int pAmplType = (int)oo;

                        sumOfServiceSideLenght += 130;

                        onePanel = new FramelessPanel((PanelType_e)pAmplType, new Vector2(130, FramelessBlock.BlockSizeY - 40),
                                    new Vector2(0, 0), new Vector2(0, 0), FramelessBlock.ThermoStrip,
                                    FramelessBlock.InnerThickness, FramelessBlock.OuterThickness, false);

                        FramelessBlock.serviseSidePanelsInOrder.Add(new ServiceSide(onePanel, i, 130, i));

                        MessageBox.Show("This is усиливающая " + i + " of " + rowsCount);
                        if (i == 0)//первая усиливающая
                        {

                            FramelessBlock.AmplificationPanels[0] = true;
                        }
                        else if (i == rowsCount - 1)
                        {

                            FramelessBlock.AmplificationPanels[1] = true;
                        }
                        else
                        {

                            FramelessBlock.AmplificationPanels[2] = true;//третья усиливающая по центру
                        };

                    }
                    else
                    {

                        var res = col[1].Value.ToString();
                        object oo = Enum.Parse(typeof(Profiles_ForRemovable_e), res);
                        int conf = (int)oo;

                        if (i == 1)//первый профиль
                        {
                            FramelessBlock.AmplificationProfiles[0] = true;
                            FramelessBlock.AmplificationProfilesLenght[0] = sumOfServiceSideLenght;//на каком расстоянии от края будет профиль
                        }
                        else if (i == rowsCount - 2)//последний профиль (но -2 потому что это предпоследний элемент на стороне обслуживания)
                        {

                            FramelessBlock.AmplificationProfiles[9] = true;
                            FramelessBlock.AmplificationProfilesLenght[9] = sumOfServiceSideLenght;
                        }
                        else
                        {
                            FramelessBlock.AmplificationProfiles[profileCounter] = true;
                            FramelessBlock.AmplificationProfilesLenght[profileCounter] = sumOfServiceSideLenght + (panelType == (int)PanelType_e.УсилПанель ? -20 : 20);
                            profileCounter++;
                        }


                        FramelessBlock.serviseSidePanelsInOrder.Add(new ServiceSide(conf, FramelessBlock.BlockSizeY - 40, i));
                    }
                }
                MessageBox.Show(FramelessBlock.AmplificationPanels[0].ToString() + " \n" +
                    FramelessBlock.AmplificationPanels[1].ToString() + "\n" +
                    FramelessBlock.AmplificationPanels[2].ToString());


                if (sumOfServiceSideLenght  > FramelessBlock.BlockSizeZ)
                {
                    MessageBox.Show("Длинна стороны обслуживания превышает длинну установки!");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("EXCEPTION:   " + e.StackTrace);
                throw e;
            }
        }


        private bool CollectTextValues()
        {
            try
            {
                //COMMON BLOCK VALUES
                FramelessBlock.OrderNumber = textBoxOrder.Text != string.Empty ? Convert.ToInt32(textBoxOrder.Text) : 0;
                FramelessBlock.TypeSize = cmbBoxTypeSize.SelectedText != null ? cmbBoxTypeSize.SelectedText : string.Empty;
                FramelessBlock.Section = cmbBoxSection.SelectedItem != null ? cmbBoxSection.SelectedItem.ToString() : string.Empty;


                if (radioButtonServiceLeft.Checked)
                {
                    FramelessBlock.Side = ServiceSide_e.Left;
                    deafSide = PanelDestination.Right;
                }
                else
                {
                    FramelessBlock.Side = ServiceSide_e.Right;
                    deafSide = PanelDestination.Left;
                }

                FramelessBlock.BlockSizeX = textBoxWidth.Text != string.Empty ? Convert.ToInt32(textBoxWidth.Text) : 0;
                FramelessBlock.BlockSizeY = textBoxHeight.Text != string.Empty ? Convert.ToInt32(textBoxHeight.Text) : 0;
                FramelessBlock.BlockSizeZ = textBoxLength.Text != string.Empty ? Convert.ToInt32(textBoxLength.Text) : 0;
                




                //VALUES FOR EACH PANEL
                roofPanelType = cmbBoxRoofPanelTypes.SelectedItem != null ? (int)(cmbBoxRoofPanelTypes.SelectedValue) : 0;
                roofWindowWidth = textBoxRoofWindowWidth.Text != string.Empty ? Convert.ToDouble(textBoxRoofWindowWidth.Text) : 0;
                roofWindowHeight = textBoxRoofWindowHeight.Text != string.Empty ? Convert.ToDouble(textBoxRoofWindowHeight.Text) : 0;
                roofWindowOff_X = textBoxRoofWindowOffX.Text != string.Empty ? Convert.ToDouble(textBoxRoofWindowOffX.Text) : 0;
                roofWindowOff_Y = textBoxRoofWindowOffY.Text != string.Empty ? Convert.ToDouble(textBoxRoofWindowOffY.Text) : 0;
                roofFlange = cmbBoxRoofFlange.SelectedItem != null ? (int)cmbBoxRoofFlange.SelectedItem : 0;

                downPanelTypes = cmbBoxDownPanelType.SelectedItem != null ? (int)cmbBoxDownPanelType.SelectedValue : 0;
                downWindowWidth = textBoxDownWidth.Text != string.Empty ? Convert.ToDouble(textBoxDownWidth.Text) : 0;
                downWindowHeight = textBoxDownHeight.Text != string.Empty ? Convert.ToDouble(textBoxDownHeight.Text) : 0;
                downWindowOff_X = textBoxDownWindowOff_X.Text != string.Empty ? Convert.ToDouble(textBoxDownWindowOff_X.Text) : 0;
                downWindowOff_Y = textBoxDownWindowOff_Y.Text != string.Empty ? Convert.ToDouble(textBoxDownWindowOff_Y.Text) : 0;
                downFlange = cmbBoxDownFlange.SelectedItem != null ? (int)cmbBoxDownFlange.SelectedItem : 0;


                if (FramelessBlock.Side == ServiceSide_e.Right)
                {
                    deafWindowHeight = textBoxDeafWindowWidth.Text != string.Empty ? Convert.ToDouble(textBoxDeafWindowWidth.Text) : 0;//значения длины ширины наоборот, потому что глухая в блоке перевернута
                    deafWindowWidth = textBoxDeafWindowHeight.Text != string.Empty ? Convert.ToDouble(textBoxDeafWindowHeight.Text) : 0;
                }
                else
                {
                    deafWindowHeight = textBoxDeafWindowHeight.Text != string.Empty ? Convert.ToDouble(textBoxDeafWindowHeight.Text) : 0;//значения длины ширины наоборот, потому что глухая в блоке перевернута
                    deafWindowWidth = textBoxDeafWindowWidth .Text != string.Empty ? Convert.ToDouble(textBoxDeafWindowWidth.Text) : 0;
                }
                deafWindowOff_Y = textBoxDeafWindowOff_X.Text != string.Empty ? Convert.ToDouble(textBoxDeafWindowOff_X.Text) : 0;
                deafWindowOff_X = textBoxDeafWindowOff_Y.Text != string.Empty ? Convert.ToDouble(textBoxDeafWindowOff_Y.Text) : 0;
                deafFlange = cmbBoxDeafFlange.SelectedItem != null ? (int)cmbBoxDeafFlange.SelectedItem : 0;
                                
                FramelessBlock.SupportType = downPanelTypes;
                FramelessBlock.ThermoStrip = (ThermoStrip_e)((int)cmbBoxScotch.SelectedValue);

               
                GetAmplification((string)cmbBoxAmplification.SelectedValue);

                return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Convert values: " + ex.Message + Environment.NewLine + ex.StackTrace);
                return false;
            }
        }

        //в каких панелях есть усиливающий профиль
        private void GetAmplification(string selectedValue)
        {
            FramelessBlock.Amplification = new Dictionary<PanelDestination, bool>();
 
            switch (selectedValue)
            {
                case "Н":
                    FramelessBlock.Amplification.Add(PanelDestination.Back, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Down, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Left, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Right, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, false);
                    break;
                case "-":
                    FramelessBlock.Amplification.Add(PanelDestination.Back, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Down, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Left, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Right, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, false);
                    break;
                case "НВ":
                    FramelessBlock.Amplification.Add(PanelDestination.Down, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Back, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Left, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Right, false);
                    break;
                case "НЗ":
                    FramelessBlock.Amplification.Add(PanelDestination.Down, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Back, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, false);

                    if (FramelessBlock.Side == ServiceSide_e.Right)
                    {

                        FramelessBlock.Amplification.Add(PanelDestination.Right, false);
                        FramelessBlock.Amplification.Add(PanelDestination.Left, true);
                    }
                    else
                    {
                        FramelessBlock.Amplification.Add(PanelDestination.Left, false);
                        FramelessBlock.Amplification.Add(PanelDestination.Right, true);
                    }
                    break;
                case "НВЗ":
                    FramelessBlock.Amplification.Add(PanelDestination.Back, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Down, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, false);


                    if (FramelessBlock.Side == ServiceSide_e.Right)
                    {

                        FramelessBlock.Amplification.Add(PanelDestination.Right, false);
                        FramelessBlock.Amplification.Add(PanelDestination.Left, true);
                    }
                    else
                    {
                        FramelessBlock.Amplification.Add(PanelDestination.Left, false);
                        FramelessBlock.Amplification.Add(PanelDestination.Right, true);
                    }
                    break;
                case "НВЗС":

                    FramelessBlock.Amplification.Add(PanelDestination.Back, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Down, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Left, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Right, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, false);
                    break;
                case "НВЗСТ":
                    FramelessBlock.Amplification.Add(PanelDestination.Back, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Down, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Left, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Right, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, true);
                    break;
                case "Т":
                    FramelessBlock.Amplification.Add(PanelDestination.Back, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Front, true);
                    FramelessBlock.Amplification.Add(PanelDestination.Down, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Left, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Right, false);
                    FramelessBlock.Amplification.Add(PanelDestination.Top, false);
                    break;
                default:
                    throw new ArgumentException(selectedValue + " - типа усиления не найдено!");
            }
        }

        private void roofWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (roofWindow.Checked)
            {
                groupBoxRoofWindow.Size = new System.Drawing.Size(260, 180);
                roofGroupBoxBottom.Location = new System.Drawing.Point(0, groupBoxRoofWindow.Location.Y + groupBoxRoofWindow.Size.Height + 5);
            }
            else
            {
                groupBoxRoofWindow.Size = new System.Drawing.Size(260, 40);
                roofGroupBoxBottom.Location = new System.Drawing.Point(0, groupBoxRoofWindow.Location.Y + groupBoxRoofWindow.Size.Height + 5);
            }
        }
        private void downWindow_CheckedChanged(object sender, EventArgs e)
        {

            if (downWindow.Checked)
            {
                groupBoxDownWindow.Size = new System.Drawing.Size(260, 180);
                groupBoxDownFoot.Location = new System.Drawing.Point(0, groupBoxDownWindow.Location.Y + groupBoxDownWindow.Size.Height + 5);
            }
            else
            {
                groupBoxDownWindow.Size = new System.Drawing.Size(260, 40);
                groupBoxDownFoot.Location = new System.Drawing.Point(0, groupBoxDownWindow.Location.Y + groupBoxDownWindow.Size.Height + 5);
            }
        }
        private void deafWindow_CheckedChanged(object sender, EventArgs e)
        {
            if (deafWindow.Checked)
            {
                groupBoxDeafWindow.Height = 180;
            }
            else
            {
                groupBoxDeafWindow.Height = 40;
            }   
        }


        public static string GetDescription(Enum value)
        {
            Type type = value.GetType();
            string name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
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