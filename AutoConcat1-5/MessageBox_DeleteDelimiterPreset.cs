using AutoConcat1_5.Data;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoConcat1_5
{
    public partial class MessageBox_DeleteDelimiterPreset : Form
    {
        public MessageBox_DeleteDelimiterPreset()
        {
            InitializeComponent();
            button1.Select();

            Color colMed = new Color();
            Color colHigh = new Color();
            Color colFore = new Color();

            if (ApplicationState.Instance.LightMode == true)
            {
                colMed = Color.FromArgb(240, 240, 240);
                colHigh = Color.White;
                colFore = Color.Black;
            }
            else
            {
                colMed = Color.FromArgb(57, 55, 68);
                colHigh = Color.FromArgb(69, 66, 84);
                colFore = Color.White;
            }

            button1.BackColor = colHigh;
            button1.ForeColor = colFore;
            Button_OperationPre.BackColor = colHigh;
            Button_OperationPre.ForeColor = colFore;
            label1.ForeColor = colFore;

            if (ApplicationState.Instance.LightMode == false)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.White;
            }
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
