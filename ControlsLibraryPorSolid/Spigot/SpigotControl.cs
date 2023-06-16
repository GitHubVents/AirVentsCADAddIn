using System;
using System.Windows.Forms;
using DataBaseDomian;
using PDMWebService.Data.Solid.ElementsCase;

namespace ControlsLibrary.Spigot
{
    public partial class SpigotControl : UserControl
    {
        int width, height;
        int spigotType;
        
        public SpigotControl(string pathIps)
        {

            RealiseBuilderBehaviour.PathToStorage += new SolidWorksLibrary.Builders.ElementsCase.ProductBuilderBehavior.IPSPath(() => { return pathIps; });
            InitializeComponent();
            pictureSpigot.Image = Properties.Resources._12_30_1300_600;
            comboBoxSpigotType.SelectedIndex = 0;
        }

        public void Build(object sender, EventArgs e)
        {

            SpigotBuilder spigot = new SpigotBuilder();
            if (ConvertValues())
            {
                try
                {
                    labelForUserToWait.Visible = true;
                    labelForUserToWait.Text = "Выполняеться построение...";
                    spigot.Build(spigotType, width, height);// метод из библиотеки SolidWorksLibrary
                    labelForUserToWait.Text = "Построение завершено.";
                }
                catch (Exception)
                {
                    labelForUserToWait.Text = "Построение было прервано в связи с ошибками.";
                }
            }
            else
            {
                labelForUserToWait.Visible = false;
            }
        }

        private void comboBoxSpigotType_SelectedIndexChanged(object sender, EventArgs e)
        {            
            spigotType = Convert.ToInt32(comboBoxSpigotType.SelectedItem);
        }
        private bool ConvertValues()
        {
            try
            {
                width = Convert.ToInt32(txtBoxWidth.Text);
                height = Convert.ToInt32(txtBoxHeight.Text);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некоректные данные");
                return false;
                throw;
            }
        }


        private void ON_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != ','))
            {
                e.Handled = true;
            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {

                if (ConvertValues())
                {
                    int searchedID = SwPlusRepository.Instance.Search_Spigot(spigotType, width, height);
                    PathValidity res;

                    if (searchedID == 0)
                        res = new PathValidity("", false);
                    else
                    {
                        res = Search._SEARCH.PathExistance(spigotType.ToString() + "-" + width.ToString() + "-" + height.ToString(), Search.CAller.Spigot);
                    }
                    Search._SEARCH.ShowResults(res);
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void Value_TextChanged(object sender, EventArgs e)
        {
            labelForUserToWait.Visible = false;
        }
    }
}