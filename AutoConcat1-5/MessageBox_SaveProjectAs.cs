﻿using AutoConcat1_5.Data;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoConcat1_5
{
    public partial class MessageBox_SaveProjectAs : Form
    {
        public MessageBox_SaveProjectAs()
        {
            InitializeComponent();

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

            Button_Accept.BackColor = colHigh;
            Button_Accept.ForeColor = colFore;
            Button_Cancel.BackColor = colHigh;
            Button_Cancel.ForeColor = colFore;
            textBox1.BackColor = colHigh;
            textBox1.ForeColor = colFore;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                Button_Accept.Enabled = true;
            }
            else
            {
                Button_Accept.Enabled = false;
            }
        }
    }
}