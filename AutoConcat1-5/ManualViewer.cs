using AutoConcat1_5.Data;
using System;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace AutoConcat1_5
{
    public partial class ManualViewer : Form
    {
        public ManualViewer()
        {
            InitializeComponent();

            Assembly assembly = Assembly.GetExecutingAssembly();
            var textStream = assembly.GetManifestResourceStream("AutoConcat1_5.Autoconcat-V2-Manual.html");
            WebBrowser_Manual.DocumentStream = textStream;
        }

        // Dark menu bar (Source: https://stackoverflow.com/a/64927217)
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override void OnHandleCreated(EventArgs e)
        {
            if (ApplicationState.Instance.LightMode == false)
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
        }
    }
}