using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;
using System;
using System.IO;
using System.Runtime.InteropServices;



namespace SW_Add_IN
{

    [ComVisible(true)]
    public class Class1 : ISwAddin
    {
        public const string SWTASKPANE_PROGID = "SW_Add_IN.Class1";
        public SldWorks SWApplication;
        private int mSWCookie;
        private TaskpaneView mTaskpaneView;
        private LittleTaskPane mTaskpaneHost;

        public bool ConnectToSW(object ThisSW, int Cookie)
        {
            SWApplication = (SldWorks)ThisSW;
            mSWCookie = Cookie;
            // Set-up add-in call back info
            bool result = SWApplication.SetAddinCallbackInfo(0, this, Cookie);
            this.UISetup();
            return true;
        }

        public bool DisconnectFromSW()
        {
            this.UITeardown();
            return true;        }
        private void UITeardown()
        {
            mTaskpaneHost = null;
            mTaskpaneView.DeleteView();
            Marshal.ReleaseComObject(mTaskpaneView);
            mTaskpaneView = null;        }
        private void UISetup()
        {
            string imagePath;
            imagePath = @"\\pdmsrv\SolidWorks Admin\AirVentsCAD_AddIN\THeme.png";
            mTaskpaneView = SWApplication.CreateTaskpaneView2(imagePath, "AirVentsCAD");
            //bool res = mTaskpaneView.AddCustomButton(imagePath, "Just testing");
            mTaskpaneHost = (LittleTaskPane)mTaskpaneView.AddControl(Class1.SWTASKPANE_PROGID, "");
        }


        [ComRegisterFunction()]
        private static void ComRegister(Type t)
        {
            string keyPath = String.Format(@"SOFTWARE\SolidWorks\AddIns\{0:b}", t.GUID);
            using (Microsoft.Win32.RegistryKey rk = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(keyPath))
            {
                rk.SetValue(null, 1); // Load at startup
                rk.SetValue("Title", "AirVentsCAD"); // Title
                rk.SetValue("Description", "Building mounting frame and other stuff."); // Description
            }
        }

        [ComUnregisterFunction()]
        private static void ComUnregister(Type t)
        {
            string keyPath = String.Format(@"SOFTWARE\SolidWorks\AddIns\{0:b}", t.GUID);
            Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree(keyPath);
        }
    }
}