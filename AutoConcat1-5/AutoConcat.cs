using AutoConcat1_5.Data;
using AutoConcat1_5.Function;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoConcat1_5
{
    public partial class AutoConcat : Form
    {
        public AutoConcat()
        {
            InitializeComponent();

            FileInfo file = new FileInfo(ApplicationState.AppDataPath);
            file.Directory.Create();
            if (!ApplicationState.Instance.LoadApplicationFromFile())
            {
                DefaultProject(true);
            }

            Concatenator.SetDataFields(DataRepeater_Operations, RichTextBox_In, RichTextBox_Out, TextBox_Prefix, TextBox_Infix, TextBox_Suffix);

            DataRepeater_Projects.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            DataRepeater_Operations.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            ComboBox_Delimiters.DataBindings.DefaultDataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged;
            DataRepeater_Projects.DataSource = SavedProjectList.Instance;
            DataRepeater_Operations.DataSource = OperationList.Instance;
            ComboBox_Delimiters.DataSource = DelimiterPresetList.Instance;
            ComboBox_Delimiters.DisplayMember = "Title";
            ComboBox_SelectOperation.DataSource = Enum.GetValues(typeof(OperationType));

            SetColors();
            ProjectButtonVisibilityToggle();
        }

        // OVERRIDES //

        // Dark menu bar (Source: https://stackoverflow.com/a/64927217)
        [DllImport("DwmApi")]
        private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case (Keys.Control | Keys.Shift | Keys.S):
                    Button_SaveProjectAs.PerformClick();
                    return true;
                case (Keys.Control | Keys.S):
                    Button_ProjectSave.PerformClick();
                    return true;
                case (Keys.Control | Keys.N):
                    Button_NewProject.PerformClick();
                    return true;

                case Keys.F1:
                    Button_Help.PerformClick();
                    return true;
                case Keys.F2:
                    RichTextBox_In.Focus();
                    return true;
                case Keys.F3:
                    DataRepeater_Projects.Focus();
                    return true;
                case Keys.F4:
                    DataRepeater_Operations.Focus();
                    return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // FUNCTIONS //

        private void ProjectButtonVisibilityToggle()
        {
            if (SavedProjectList.Instance.Count > 0)
            {
                Button_ProjectSave.Enabled = true;
                Button_ProjectLoad.Enabled = true;
                Button_ProjectDelete.Enabled = true;
            }
            else
            {
                Button_ProjectSave.Enabled = false;
                Button_ProjectLoad.Enabled = false;
                Button_ProjectDelete.Enabled = false;
            }
        }

        private Project MakeProjectFromFields(string title)
        {
            List<Operation> plainOpList = new List<Operation>();
            if (OperationList.Instance.Count > 0)
            {
                foreach (var op in OperationList.Instance)
                {
                    plainOpList.Add(op.Clone() as Operation);
                }
            }

            Project prj = new Project(
                title,
                DateTime.Now.ToString("dd/MM/yy HH:mm:ss"),
                plainOpList,
                RichTextBox_In.Text,
                RichTextBox_Out.Text,
                TextBox_Prefix.Text,
                TextBox_Infix.Text,
                TextBox_Suffix.Text
                );
            if (!string.IsNullOrWhiteSpace(ComboBox_Delimiters.Text))
            {
                prj.ChosenDelimiterName = ComboBox_Delimiters.Text;
            }
            return prj;
        }

        private void SetFieldsFromProject(Project project)
        {
            OperationList.Instance.Clear();
            if (project.PlainOperationList.Count > 0)
            {
                foreach (Operation op in project.PlainOperationList)
                {
                    OperationList.Instance.Add(op.Clone() as Operation);
                }
            }

            RichTextBox_In.Text = project.InBox;
            RichTextBox_Out.Text = project.OutBox;
            TextBox_Prefix.Text = project.Prefix;
            TextBox_Infix.Text = project.Infix;
            TextBox_Suffix.Text = project.Suffix;

            if (!string.IsNullOrWhiteSpace(project.ChosenDelimiterName) && DelimiterPresetList.Instance.Count > 0)
            {
                if (ComboBox_Delimiters.FindStringExact(project.ChosenDelimiterName) > -1)
                {
                    ComboBox_Delimiters.SelectedIndex = ComboBox_Delimiters.FindStringExact(project.ChosenDelimiterName);
                }
            }
        }

        private void DefaultProject(bool firstTime)
        {
            RichTextBox_In.Text = "";
            RichTextBox_Out.Text = "";
            TextBox_Prefix.Text = "";
            TextBox_Infix.Text = "";
            TextBox_Suffix.Text = "";

            if (firstTime)
            {
                DelimiterPresetList.Instance.Add(new DelimiterPreset("None", "", "", ""));
                DelimiterPresetList.Instance.Add(new DelimiterPreset("Spaces", "", " ", ""));
                DelimiterPresetList.Instance.Add(new DelimiterPreset("Pipes", "", "|", ""));
                DelimiterPresetList.Instance.Add(new DelimiterPreset("Comma Apostrophe", "'", "','", "'"));
                DelimiterPresetList.Instance.Add(new DelimiterPreset("Comma Quote", "\"", "\",\"", "\""));
            }

            OperationList.Instance.Clear();
            OperationList.Instance.Add(new Operation(OperationType.TrimWhitespace));
        }

        private void SetColors()
        {
            if (ApplicationState.Instance.LightMode == false)
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 1 }, 4) != 0)
                    DwmSetWindowAttribute(Handle, 20, new[] { 1 }, 4);
            }
            else
            {
                if (DwmSetWindowAttribute(Handle, 19, new[] { 0 }, 4) != 0)
                    DwmSetWindowAttribute(Handle, 20, new[] { 0 }, 4);
            }

            Color colBack = new Color();
            Color colLow = new Color();
            Color colMed = new Color();
            Color colHigh = new Color();
            Color colFore = new Color();

            if (ApplicationState.Instance.LightMode == true)
            {
                colBack = Color.FromArgb(210, 210, 210);
                colLow = Color.FromArgb(230, 230, 230);
                colMed = Color.FromArgb(240, 243, 249);
                colHigh = Color.White;
                colFore = Color.Black;
            }
            else
            {
                colBack = Color.Black;
                colLow = Color.FromArgb(32, 31, 37);
                colMed = Color.FromArgb(57, 55, 68);
                colHigh = Color.FromArgb(69, 66, 84);
                colFore = Color.White;
            }

            BackColor = colBack;

            // Textboxes
            RichTextBox_In.BackColor = colHigh;
            RichTextBox_In.ForeColor = colFore;
            RichTextBox_Out.BackColor = colHigh;
            RichTextBox_Out.ForeColor = colFore;
            TextBox_Infix.BackColor = colMed;
            TextBox_Infix.ForeColor = colFore;
            TextBox_Prefix.BackColor = colMed;
            TextBox_Prefix.ForeColor = colFore;
            TextBox_Suffix.BackColor = colMed;
            TextBox_Suffix.ForeColor = colFore;
            TextBox_OperationBot.BackColor = colHigh;
            TextBox_OperationBot.ForeColor = colFore;
            TextBox_OperationTop.BackColor = colHigh;
            TextBox_OperationTop.ForeColor = colFore;

            // Buttons
            Button_CopyFrom.BackColor = colHigh;
            Button_CopyFrom.ForeColor = colFore;
            Button_PasteInto.BackColor = colHigh;
            Button_PasteInto.ForeColor = colFore;

            Button_Help.BackColor = colHigh;
            Button_Help.ForeColor = colFore;
            Button_Settings.BackColor = colHigh;
            Button_Settings.ForeColor = colFore;
            Button_NewProject.BackColor = colHigh;
            Button_NewProject.ForeColor = colFore;
            Button_ProjectSave.BackColor = colHigh;
            Button_ProjectSave.ForeColor = colFore;
            Button_SaveProjectAs.BackColor = colHigh;
            Button_SaveProjectAs.ForeColor = colFore;
            Button_ProjectLoad.BackColor = colHigh;
            Button_ProjectLoad.ForeColor = colFore;
            Button_ProjectDelete.BackColor = colHigh;
            Button_ProjectDelete.ForeColor = colFore;

            Button_DeletePreset.BackColor = colMed;
            Button_DeletePreset.ForeColor = colFore;
            Button_SavePreset.BackColor = colMed;
            Button_SavePreset.ForeColor = colFore;

            Button_OperationDelete.BackColor = colHigh;
            Button_OperationDelete.ForeColor = colFore;
            Button_TopOperationBump.BackColor = colHigh;
            Button_TopOperationBump.ForeColor = colFore;
            Operation_BottomButtonBump.BackColor = colHigh;
            Operation_BottomButtonBump.ForeColor = colFore;

            button1.BackColor = colHigh;
            button1.ForeColor = colFore;

            // Layout panels
            tableLayoutPanel4.BackColor = colHigh;
            tableLayoutPanel3.BackColor = colHigh;
            LAYOUT_Main_Right.BackColor = colBack;
            LAYOUT_Main_Right_Concat.BackColor = colBack;
            LAYOUT_Main_Right_Concat_Input.BackColor = colLow;
            LAYOUT_Main_Right_Concat_Output.BackColor = colLow;
            panel2.BackColor = colHigh;

            // EXCEPTIONS
            if (ApplicationState.Instance.LightMode == true)
            {
                DataRepeater_Operations.ItemTemplate.BackColor = colHigh;
                DataRepeater_Projects.ItemTemplate.BackColor = colHigh;
                LAYOUT_Main_Right_Divider.BackColor = colMed;
                LAYOUT_Main.BackColor = colMed;
                LAYOUT_Main_Left.BackColor = colMed;
            }
            else
            {
                DataRepeater_Operations.ItemTemplate.BackColor = colLow;
                DataRepeater_Projects.ItemTemplate.BackColor = colLow;
                LAYOUT_Main_Right_Divider.BackColor = colLow;
                LAYOUT_Main.BackColor = colLow;
                LAYOUT_Main_Left.BackColor = colLow;
            }

            // Labels
            Label_Delimiters.ForeColor = colFore;
            Label_Infix.ForeColor = colFore;
            Label_Suffix.ForeColor = colFore;
            Label_Prefix.ForeColor = colFore;
            Label_OperationDesc.ForeColor = colFore;
            Label_OperationTitle.ForeColor = colFore;
            Label_ProjectTime.ForeColor = colFore;
            Label_ProjectTitle.ForeColor = colFore;
            label1.ForeColor = colFore;
            label2.ForeColor = colFore;
            label6.ForeColor = colFore;

            // Combobox
            ComboBox_Delimiters.BackColor = colHigh;
            ComboBox_Delimiters.ForeColor = colFore;
            ComboBox_SelectOperation.BackColor = colHigh;
            ComboBox_SelectOperation.ForeColor = colFore;

            // Misc
            DataRepeater_Projects.ItemTemplate.ForeColor = colFore;
            Operation_PrePostCheckBox.ForeColor = colFore;
        }

        // EVENTS //

        private void ComboBox_Delimiters_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DelimiterPresetList.Instance.Count > 0)
            {
                DelimiterPresetList delimiterList = ComboBox_Delimiters.DataSource as DelimiterPresetList;
                DelimiterPreset delimiters = delimiterList[ComboBox_Delimiters.SelectedIndex];
                TextBox_Prefix.Text = delimiters.Prefix;
                TextBox_Infix.Text = delimiters.Infix;
                TextBox_Suffix.Text = delimiters.Suffix;
            }
        }

        private void Button_SavePreset_Click(object sender, EventArgs e)
        {
            using (MessageBox_SaveDelimiterPreset messageBox_SaveDelimiterPreset = new MessageBox_SaveDelimiterPreset())
            {
                if (messageBox_SaveDelimiterPreset.ShowDialog(this) == DialogResult.OK)
                {
                    string newPresetTitle = messageBox_SaveDelimiterPreset.textBox1.Text;
                    DelimiterPresetList.Instance.Add(new DelimiterPreset(newPresetTitle, TextBox_Prefix.Text, TextBox_Infix.Text, TextBox_Suffix.Text));
                    ApplicationState.Instance.SaveApplicationToFile();
                    if (DelimiterPresetList.Instance.Count > 0)
                    {
                        Button_DeletePreset.Enabled = true;
                    }
                    else
                    {
                        Button_DeletePreset.Enabled = false;
                    }
                    ComboBox_Delimiters.SelectedIndex = ComboBox_Delimiters.FindStringExact(newPresetTitle);
                }
            }
        }

        private void Button_DeletePreset_Click(object sender, EventArgs e)
        {
            if (DelimiterPresetList.Instance.Count > 0)
            {
                using (MessageBox_DeleteDelimiterPreset messageBox_DeleteDelimiterPreset = new MessageBox_DeleteDelimiterPreset())
                {
                    if (messageBox_DeleteDelimiterPreset.ShowDialog(this) == DialogResult.OK)
                    {
                        DelimiterPresetList delimiterList = ComboBox_Delimiters.DataSource as DelimiterPresetList;
                        delimiterList.RemoveAt(ComboBox_Delimiters.SelectedIndex);
                        ApplicationState.Instance.SaveApplicationToFile();
                        if (DelimiterPresetList.Instance.Count > 0)
                        {
                            Button_DeletePreset.Enabled = true;
                        }
                        else
                        {
                            Button_DeletePreset.Enabled = false;
                        }
                    }
                }
            }
        }

        private void Button_CopyFrom_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(RichTextBox_Out.Text))
            {
                Clipboard.SetText(RichTextBox_Out.Text);
            }
        }

        private void Button_PasteInto_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Clipboard.GetText()))
            {
                RichTextBox_In.Text = Clipboard.GetText();
            }
        }

        private void RichTextBox_In_TextChanged(object sender, EventArgs e)
        {
            Concatenator.Concatenate();
        }

        private void TextBox_Prefix_TextChanged(object sender, EventArgs e)
        {
            Concatenator.Concatenate();
        }

        private void TextBox_Infix_TextChanged(object sender, EventArgs e)
        {
            Concatenator.Concatenate();
        }

        private void TextBox_Suffix_TextChanged(object sender, EventArgs e)
        {
            Concatenator.Concatenate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OperationList.Instance.BumpItemUp(DataRepeater_Operations.CurrentItemIndex);
            SecretConcatButton.PerformClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperationList.Instance.BumpItemDown(DataRepeater_Operations.CurrentItemIndex);
            SecretConcatButton.PerformClick();
        }

        private void Button_OperationDelete_Click(object sender, EventArgs e)
        {
            OperationList.Instance.RemoveAt(DataRepeater_Operations.CurrentItemIndex);
            SecretConcatButton.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperationList.Instance.Add(new Operation((OperationType)ComboBox_SelectOperation.SelectedItem));
            SecretConcatButton.PerformClick();
        }

        private void DataRepeater_Projects_CurrentItemIndexChanged(object sender, EventArgs e)
        {
            ProjectButtonVisibilityToggle();
        }

        private void Button_ProjectDelete_Click(object sender, EventArgs e)
        {
            if (SavedProjectList.Instance.Count > 0)
            {
                using (MessageBox_DeleteProject messageBox_DeleteDelimiterPreset = new MessageBox_DeleteProject())
                {
                    if (messageBox_DeleteDelimiterPreset.ShowDialog(this) == DialogResult.OK)
                    {
                        SavedProjectList.Instance.RemoveAt(DataRepeater_Projects.CurrentItemIndex);
                        ApplicationState.Instance.SaveApplicationToFile();
                    }
                }
            }
        }

        private void Button_ProjectLoad_Click(object sender, EventArgs e)
        {
            using (MessageBox_LoadProject messageBox_SaveDelimiterPreset = new MessageBox_LoadProject())
            {
                if (messageBox_SaveDelimiterPreset.ShowDialog(this) == DialogResult.OK)
                {
                    SetFieldsFromProject(SavedProjectList.Instance[DataRepeater_Projects.CurrentItemIndex]);
                }
            }
        }

        private void Button_ProjectSave_Click(object sender, EventArgs e)
        {
            if (SavedProjectList.Instance.Count > 0)
            {
                using (MessageBox_SaveProject messageBox_SaveProject = new MessageBox_SaveProject())
                {
                    if (messageBox_SaveProject.ShowDialog(this) == DialogResult.OK)
                    {
                        SavedProjectList.Instance[DataRepeater_Projects.CurrentItemIndex].Update(MakeProjectFromFields(SavedProjectList.Instance[DataRepeater_Projects.CurrentItemIndex].Title));
                        ApplicationState.Instance.SaveApplicationToFile();
                    }
                }
            }
        }

        private void TextBox_OperationTop_KeyUp(object sender, KeyEventArgs e)
        {
            SecretConcatButton.PerformClick();
        }

        private void SecretConcatButton_Click(object sender, EventArgs e)
        {
            Concatenator.Concatenate();
        }

        private void TextBox_OperationBot_KeyUp(object sender, KeyEventArgs e)
        {
            SecretConcatButton.PerformClick();
        }

        private void Operation_PrePostCheckBox_Click(object sender, EventArgs e)
        {
            SecretConcatButton.PerformClick();
        }

        private void Button_SaveProjectAs_Click(object sender, EventArgs e)
        {
            using (MessageBox_SaveProjectAs messageBox_SaveDelimiterPreset = new MessageBox_SaveProjectAs())
            {
                if (messageBox_SaveDelimiterPreset.ShowDialog(this) == DialogResult.OK)
                {
                    string projectTitle = messageBox_SaveDelimiterPreset.textBox1.Text;
                    SavedProjectList.Instance.Add(MakeProjectFromFields(projectTitle));
                    ApplicationState.Instance.SaveApplicationToFile();
                }
            }
        }

        private void Button_NewProject_Click(object sender, EventArgs e)
        {
            using (MessageBox_NewProject messageBox_SaveDelimiterPreset = new MessageBox_NewProject())
            {
                if (messageBox_SaveDelimiterPreset.ShowDialog(this) == DialogResult.OK)
                {
                    DefaultProject(false);
                }
            }
        }

        private void Button_Help_Click(object sender, EventArgs e)
        {
            ManualViewer viewer = new ManualViewer();
            viewer.Show();
        }

        private void Button_Settings_Click(object sender, EventArgs e)
        {
            using (SettingsMenu settingsMenu = new SettingsMenu())
            {
                settingsMenu.ShowDialog(this);
            }
            ApplicationState.Instance.SaveApplicationToFile();
        }
    }
}