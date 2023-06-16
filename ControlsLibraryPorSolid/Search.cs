using SolidWorks.Interop.sldworks;
using SolidWorksLibrary;
using System.Windows.Forms;

namespace ControlsLibrary
{
    public partial class Search : Form
    {
        private string pathToSearched;
        private static Search search = new Search();
        public static Search _SEARCH
        {
            get
            {
               // MessageBox.Show(search?.GetHashCode().ToString() + "search.IsDisposed: " + search.IsDisposed);
                if (search.IsDisposed) search = new Search();
                return search;
            }
            set
            {
                if (search == null || search.IsDisposed)
                {
                    //MessageBox.Show("search.IsDisposed: " + search.IsDisposed.ToString());
                    search = new Search();
                }
            }
        }
        

        SldWorks sld;

        private Search()
        {
            InitializeComponent();
            if (sld == null)
            {
                sld = new SldWorks();
                sld.Visible = true;
            }
            new PDMSearch();
        }
        public enum CAller
        {
            Montage,
            Roof,
            Flap,
            Panel,
            Spigot                
        }
         
        public void ShowResults(PathValidity Data)
        {
            textBoxPathASM.Text = string.Empty;
            textBoxPathASM.Text = Data._Path;
            textBoxPathASM.ReadOnly = true;
            if (Data.Exsists)
            {
                pathToSearched = Data._Path;
                buttonOpenASM.Enabled = true;
                textBoxPathASM.Text = pathToSearched;
            }
            else
            {
                buttonOpenASM.Enabled = false;
                textBoxPathASM.Text = "Сборка не найдена!";
            }

            Show();
            int screenH = (Screen.PrimaryScreen.WorkingArea.Top +
              Screen.PrimaryScreen.WorkingArea.Height) / 2;
            int screenW = (Screen.PrimaryScreen.WorkingArea.Left +
                          Screen.PrimaryScreen.WorkingArea.Width) / 2;
            SetDesktopLocation(screenW, screenH);

            TopMost = true;
        }

        public PathValidity PathExistance(int searchedID, CAller whoCalled)
        {

            PathValidity PV;
            string pathAddition = GetFullPath(whoCalled);
            string nameInPDM = pathAddition.Substring(pathAddition.Length - 3, 3);
            string pp;
            
            if (PDMSearch.SearchDoc(nameInPDM + searchedID + ".SLDASM", out pp))           
            {
                PV = new PathValidity(pp, true);
            }
            else
            {
                PV = new PathValidity("Деталь по пути " + pp + ".SLDASM не найдена" , false);
            }
            
            return PV;
        }
        public PathValidity PathExistance(string spigotParams, CAller whoCalled)
        {

            PathValidity PV;
            string pathAddition = GetFullPath(whoCalled);
            string nameInPDM = pathAddition.Substring(pathAddition.Length - 3, 3);
            string pp;

            if (PDMSearch.SearchDoc(nameInPDM + spigotParams + ".SLDASM", out pp))
            {
                PV = new PathValidity(pp, true);
            }
            else
            {
                PV = new PathValidity("Деталь по пути " + pp + ".SLDASM не найдена", false);
            }

            return PV;
        }

        private string GetFullPath(CAller whoCalled)
        {
            switch (whoCalled )
            {
                case CAller.Flap:
                return @"D:\Vents-PDM\Проекты\AirVentsCAD\11 - Регулятор расхода воздуха\11-";


                case CAller.Montage:
                return @"D:\Vents-PDM\Проекты\AirVentsCAD\10 - Рама монтажная\10-";


                case CAller.Roof:
                return @"D:\Vents-PDM\Проекты\AirVentsCAD\15 - Крыша\15-";


                case CAller.Spigot:
                return @"D:\Vents-PDM\Проекты\AirVentsCAD\12 - Вибровставка\12-";


                case CAller.Panel:
                return @"D:\Vents-PDM\Проекты\AirVentsCAD\02 - Панели\02-";

                default: return string.Empty;
            }
        }

        private void buttonOpenASM_Click(object sender, System.EventArgs e)
        {
            try
            {
                sld.OpenDoc6(pathToSearched, 2, 0, "", 0, 0);
            }
            catch (System.Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}