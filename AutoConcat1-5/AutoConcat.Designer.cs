using Microsoft.VisualBasic.PowerPacks;
using System.Windows.Forms;

namespace AutoConcat1_5
{
    partial class AutoConcat
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoConcat));
            this.LAYOUT_Main = new System.Windows.Forms.TableLayoutPanel();
            this.LAYOUT_Main_Left = new System.Windows.Forms.TableLayoutPanel();
            this.LAYOUT_Main_Left_Menu = new System.Windows.Forms.TableLayoutPanel();
            this.Button_Help = new System.Windows.Forms.Button();
            this.Button_Settings = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_SaveProjectAs = new System.Windows.Forms.Button();
            this.Button_NewProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DataRepeater_Projects = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.Label_ProjectTime = new System.Windows.Forms.Label();
            this.savedProjectListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Label_ProjectTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.Button_ProjectSave = new System.Windows.Forms.Button();
            this.Button_ProjectLoad = new System.Windows.Forms.Button();
            this.Button_ProjectDelete = new System.Windows.Forms.Button();
            this.LAYOUT_Main_Right = new System.Windows.Forms.TableLayoutPanel();
            this.LAYOUT_Main_Right_Concat = new System.Windows.Forms.TableLayoutPanel();
            this.LAYOUT_Main_Right_Concat_Input = new System.Windows.Forms.TableLayoutPanel();
            this.Button_PasteInto = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.RichTextBox_In = new System.Windows.Forms.RichTextBox();
            this.LAYOUT_Main_Right_Concat_Output = new System.Windows.Forms.TableLayoutPanel();
            this.Button_CopyFrom = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.RichTextBox_Out = new System.Windows.Forms.RichTextBox();
            this.LAYOUT_Main_Right_Concat_Delimiter = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox_Suffix = new System.Windows.Forms.TextBox();
            this.TextBox_Infix = new System.Windows.Forms.TextBox();
            this.Label_Suffix = new System.Windows.Forms.Label();
            this.Label_Infix = new System.Windows.Forms.Label();
            this.Label_Prefix = new System.Windows.Forms.Label();
            this.Label_Delimiters = new System.Windows.Forms.Label();
            this.ComboBox_Delimiters = new System.Windows.Forms.ComboBox();
            this.TextBox_Prefix = new System.Windows.Forms.TextBox();
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad = new System.Windows.Forms.TableLayoutPanel();
            this.Button_SavePreset = new System.Windows.Forms.Button();
            this.Button_DeletePreset = new System.Windows.Forms.Button();
            this.SecretConcatButton = new System.Windows.Forms.Button();
            this.LAYOUT_Main_Right_Divider = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ComboBox_SelectOperation = new System.Windows.Forms.ComboBox();
            this.DataRepeater_Operations = new Microsoft.VisualBasic.PowerPacks.DataRepeater();
            this.label2 = new System.Windows.Forms.Label();
            this.operationListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Operation_PrePostCheckBox = new System.Windows.Forms.CheckBox();
            this.Operation_BottomButtonBump = new System.Windows.Forms.Button();
            this.Button_TopOperationBump = new System.Windows.Forms.Button();
            this.Button_OperationDelete = new System.Windows.Forms.Button();
            this.TextBox_OperationBot = new System.Windows.Forms.TextBox();
            this.TextBox_OperationTop = new System.Windows.Forms.TextBox();
            this.Label_OperationDesc = new System.Windows.Forms.Label();
            this.Label_OperationTitle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.delimiterPresetListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LAYOUT_Main.SuspendLayout();
            this.LAYOUT_Main_Left.SuspendLayout();
            this.LAYOUT_Main_Left_Menu.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.DataRepeater_Projects.ItemTemplate.SuspendLayout();
            this.DataRepeater_Projects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.savedProjectListBindingSource)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.LAYOUT_Main_Right.SuspendLayout();
            this.LAYOUT_Main_Right_Concat.SuspendLayout();
            this.LAYOUT_Main_Right_Concat_Input.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.LAYOUT_Main_Right_Concat_Output.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.LAYOUT_Main_Right_Concat_Delimiter.SuspendLayout();
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.SuspendLayout();
            this.LAYOUT_Main_Right_Divider.SuspendLayout();
            this.DataRepeater_Operations.ItemTemplate.SuspendLayout();
            this.DataRepeater_Operations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.operationListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimiterPresetListBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LAYOUT_Main
            // 
            this.LAYOUT_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.LAYOUT_Main.ColumnCount = 2;
            this.LAYOUT_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 233F));
            this.LAYOUT_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.16666F));
            this.LAYOUT_Main.Controls.Add(this.LAYOUT_Main_Left, 0, 0);
            this.LAYOUT_Main.Controls.Add(this.LAYOUT_Main_Right, 1, 0);
            this.LAYOUT_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LAYOUT_Main.Location = new System.Drawing.Point(0, 0);
            this.LAYOUT_Main.Name = "LAYOUT_Main";
            this.LAYOUT_Main.RowCount = 1;
            this.LAYOUT_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_Main.Size = new System.Drawing.Size(933, 587);
            this.LAYOUT_Main.TabIndex = 0;
            // 
            // LAYOUT_Main_Left
            // 
            this.LAYOUT_Main_Left.ColumnCount = 1;
            this.LAYOUT_Main_Left.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Left.Controls.Add(this.LAYOUT_Main_Left_Menu, 0, 0);
            this.LAYOUT_Main_Left.Controls.Add(this.label1, 0, 1);
            this.LAYOUT_Main_Left.Controls.Add(this.DataRepeater_Projects, 0, 2);
            this.LAYOUT_Main_Left.Controls.Add(this.tableLayoutPanel5, 0, 3);
            this.LAYOUT_Main_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Left.Location = new System.Drawing.Point(3, 3);
            this.LAYOUT_Main_Left.Name = "LAYOUT_Main_Left";
            this.LAYOUT_Main_Left.RowCount = 4;
            this.LAYOUT_Main_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.LAYOUT_Main_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.LAYOUT_Main_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Left.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.LAYOUT_Main_Left.Size = new System.Drawing.Size(227, 581);
            this.LAYOUT_Main_Left.TabIndex = 0;
            // 
            // LAYOUT_Main_Left_Menu
            // 
            this.LAYOUT_Main_Left_Menu.ColumnCount = 1;
            this.LAYOUT_Main_Left_Menu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Left_Menu.Controls.Add(this.Button_Help, 0, 1);
            this.LAYOUT_Main_Left_Menu.Controls.Add(this.Button_Settings, 0, 0);
            this.LAYOUT_Main_Left_Menu.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.LAYOUT_Main_Left_Menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Left_Menu.Location = new System.Drawing.Point(3, 3);
            this.LAYOUT_Main_Left_Menu.Name = "LAYOUT_Main_Left_Menu";
            this.LAYOUT_Main_Left_Menu.RowCount = 3;
            this.LAYOUT_Main_Left_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LAYOUT_Main_Left_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LAYOUT_Main_Left_Menu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.LAYOUT_Main_Left_Menu.Size = new System.Drawing.Size(221, 106);
            this.LAYOUT_Main_Left_Menu.TabIndex = 0;
            // 
            // Button_Help
            // 
            this.Button_Help.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_Help.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button_Help.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Help.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Help.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Button_Help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Help.ForeColor = System.Drawing.Color.White;
            this.Button_Help.Location = new System.Drawing.Point(3, 38);
            this.Button_Help.Name = "Button_Help";
            this.Button_Help.Size = new System.Drawing.Size(215, 29);
            this.Button_Help.TabIndex = 1;
            this.Button_Help.Text = "Help";
            this.Button_Help.UseVisualStyleBackColor = false;
            this.Button_Help.Click += new System.EventHandler(this.Button_Help_Click);
            // 
            // Button_Settings
            // 
            this.Button_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_Settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Settings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Button_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Settings.ForeColor = System.Drawing.Color.White;
            this.Button_Settings.Location = new System.Drawing.Point(3, 3);
            this.Button_Settings.Name = "Button_Settings";
            this.Button_Settings.Size = new System.Drawing.Size(215, 29);
            this.Button_Settings.TabIndex = 0;
            this.Button_Settings.Text = "Settings";
            this.Button_Settings.UseVisualStyleBackColor = false;
            this.Button_Settings.Click += new System.EventHandler(this.Button_Settings_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.Button_SaveProjectAs, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.Button_NewProject, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(221, 36);
            this.tableLayoutPanel6.TabIndex = 3;
            // 
            // Button_SaveProjectAs
            // 
            this.Button_SaveProjectAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_SaveProjectAs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SaveProjectAs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SaveProjectAs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_SaveProjectAs.ForeColor = System.Drawing.Color.White;
            this.Button_SaveProjectAs.Location = new System.Drawing.Point(113, 3);
            this.Button_SaveProjectAs.Name = "Button_SaveProjectAs";
            this.Button_SaveProjectAs.Size = new System.Drawing.Size(105, 30);
            this.Button_SaveProjectAs.TabIndex = 1;
            this.Button_SaveProjectAs.Text = "Save Project As...";
            this.Button_SaveProjectAs.UseVisualStyleBackColor = false;
            this.Button_SaveProjectAs.Click += new System.EventHandler(this.Button_SaveProjectAs_Click);
            // 
            // Button_NewProject
            // 
            this.Button_NewProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_NewProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_NewProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_NewProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_NewProject.ForeColor = System.Drawing.Color.White;
            this.Button_NewProject.Location = new System.Drawing.Point(3, 3);
            this.Button_NewProject.Name = "Button_NewProject";
            this.Button_NewProject.Size = new System.Drawing.Size(104, 30);
            this.Button_NewProject.TabIndex = 0;
            this.Button_NewProject.Text = "New Project";
            this.Button_NewProject.UseVisualStyleBackColor = false;
            this.Button_NewProject.Click += new System.EventHandler(this.Button_NewProject_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Saved Projects";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataRepeater_Projects
            // 
            this.DataRepeater_Projects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataRepeater_Projects.ForeColor = System.Drawing.Color.White;
            this.DataRepeater_Projects.ItemHeaderVisible = false;
            // 
            // DataRepeater_Projects.ItemTemplate
            // 
            this.DataRepeater_Projects.ItemTemplate.Controls.Add(this.Label_ProjectTime);
            this.DataRepeater_Projects.ItemTemplate.Controls.Add(this.Label_ProjectTitle);
            this.DataRepeater_Projects.ItemTemplate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataRepeater_Projects.ItemTemplate.Size = new System.Drawing.Size(213, 84);
            this.DataRepeater_Projects.Location = new System.Drawing.Point(3, 149);
            this.DataRepeater_Projects.Name = "DataRepeater_Projects";
            this.DataRepeater_Projects.Size = new System.Drawing.Size(221, 395);
            this.DataRepeater_Projects.TabIndex = 0;
            this.DataRepeater_Projects.CurrentItemIndexChanged += new System.EventHandler(this.DataRepeater_Projects_CurrentItemIndexChanged);
            // 
            // Label_ProjectTime
            // 
            this.Label_ProjectTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.savedProjectListBindingSource, "LastSaved", true));
            this.Label_ProjectTime.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ProjectTime.Location = new System.Drawing.Point(0, 54);
            this.Label_ProjectTime.Name = "Label_ProjectTime";
            this.Label_ProjectTime.Size = new System.Drawing.Size(187, 21);
            this.Label_ProjectTime.TabIndex = 6;
            this.Label_ProjectTime.Text = "null";
            // 
            // savedProjectListBindingSource
            // 
            this.savedProjectListBindingSource.AllowNew = false;
            this.savedProjectListBindingSource.DataSource = typeof(AutoConcat1_5.Data.SavedProjectList);
            // 
            // Label_ProjectTitle
            // 
            this.Label_ProjectTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.savedProjectListBindingSource, "Title", true));
            this.Label_ProjectTitle.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ProjectTitle.Location = new System.Drawing.Point(0, 0);
            this.Label_ProjectTitle.Name = "Label_ProjectTitle";
            this.Label_ProjectTitle.Size = new System.Drawing.Size(187, 51);
            this.Label_ProjectTitle.TabIndex = 0;
            this.Label_ProjectTitle.Text = "null";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel5.Controls.Add(this.Button_ProjectSave, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.Button_ProjectLoad, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Button_ProjectDelete, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 547);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(227, 34);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // Button_ProjectSave
            // 
            this.Button_ProjectSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_ProjectSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_ProjectSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ProjectSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_ProjectSave.ForeColor = System.Drawing.Color.White;
            this.Button_ProjectSave.Location = new System.Drawing.Point(3, 3);
            this.Button_ProjectSave.Name = "Button_ProjectSave";
            this.Button_ProjectSave.Size = new System.Drawing.Size(69, 28);
            this.Button_ProjectSave.TabIndex = 0;
            this.Button_ProjectSave.Text = "Save";
            this.Button_ProjectSave.UseVisualStyleBackColor = false;
            this.Button_ProjectSave.Click += new System.EventHandler(this.Button_ProjectSave_Click);
            // 
            // Button_ProjectLoad
            // 
            this.Button_ProjectLoad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_ProjectLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_ProjectLoad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ProjectLoad.ForeColor = System.Drawing.Color.White;
            this.Button_ProjectLoad.Location = new System.Drawing.Point(78, 3);
            this.Button_ProjectLoad.Name = "Button_ProjectLoad";
            this.Button_ProjectLoad.Size = new System.Drawing.Size(69, 28);
            this.Button_ProjectLoad.TabIndex = 1;
            this.Button_ProjectLoad.Text = "Load";
            this.Button_ProjectLoad.UseVisualStyleBackColor = false;
            this.Button_ProjectLoad.Click += new System.EventHandler(this.Button_ProjectLoad_Click);
            // 
            // Button_ProjectDelete
            // 
            this.Button_ProjectDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_ProjectDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_ProjectDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_ProjectDelete.ForeColor = System.Drawing.Color.White;
            this.Button_ProjectDelete.Location = new System.Drawing.Point(153, 3);
            this.Button_ProjectDelete.Name = "Button_ProjectDelete";
            this.Button_ProjectDelete.Size = new System.Drawing.Size(71, 28);
            this.Button_ProjectDelete.TabIndex = 2;
            this.Button_ProjectDelete.Text = "Delete";
            this.Button_ProjectDelete.UseVisualStyleBackColor = false;
            this.Button_ProjectDelete.Click += new System.EventHandler(this.Button_ProjectDelete_Click);
            // 
            // LAYOUT_Main_Right
            // 
            this.LAYOUT_Main_Right.BackColor = System.Drawing.Color.Black;
            this.LAYOUT_Main_Right.ColumnCount = 1;
            this.LAYOUT_Main_Right.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 694F));
            this.LAYOUT_Main_Right.Controls.Add(this.LAYOUT_Main_Right_Concat, 0, 0);
            this.LAYOUT_Main_Right.Controls.Add(this.LAYOUT_Main_Right_Divider, 0, 2);
            this.LAYOUT_Main_Right.Controls.Add(this.DataRepeater_Operations, 0, 4);
            this.LAYOUT_Main_Right.Controls.Add(this.panel2, 0, 3);
            this.LAYOUT_Main_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Right.Location = new System.Drawing.Point(236, 3);
            this.LAYOUT_Main_Right.Name = "LAYOUT_Main_Right";
            this.LAYOUT_Main_Right.RowCount = 5;
            this.LAYOUT_Main_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 307F));
            this.LAYOUT_Main_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.LAYOUT_Main_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.LAYOUT_Main_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 4F));
            this.LAYOUT_Main_Right.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right.Size = new System.Drawing.Size(694, 581);
            this.LAYOUT_Main_Right.TabIndex = 1;
            // 
            // LAYOUT_Main_Right_Concat
            // 
            this.LAYOUT_Main_Right_Concat.BackColor = System.Drawing.Color.Black;
            this.LAYOUT_Main_Right_Concat.ColumnCount = 3;
            this.LAYOUT_Main_Right_Concat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_Main_Right_Concat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 172F));
            this.LAYOUT_Main_Right_Concat.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_Main_Right_Concat.Controls.Add(this.LAYOUT_Main_Right_Concat_Input, 0, 0);
            this.LAYOUT_Main_Right_Concat.Controls.Add(this.LAYOUT_Main_Right_Concat_Output, 2, 0);
            this.LAYOUT_Main_Right_Concat.Controls.Add(this.LAYOUT_Main_Right_Concat_Delimiter, 1, 0);
            this.LAYOUT_Main_Right_Concat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Right_Concat.Location = new System.Drawing.Point(3, 3);
            this.LAYOUT_Main_Right_Concat.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LAYOUT_Main_Right_Concat.Name = "LAYOUT_Main_Right_Concat";
            this.LAYOUT_Main_Right_Concat.RowCount = 1;
            this.LAYOUT_Main_Right_Concat.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 304F));
            this.LAYOUT_Main_Right_Concat.Size = new System.Drawing.Size(688, 304);
            this.LAYOUT_Main_Right_Concat.TabIndex = 0;
            // 
            // LAYOUT_Main_Right_Concat_Input
            // 
            this.LAYOUT_Main_Right_Concat_Input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.LAYOUT_Main_Right_Concat_Input.ColumnCount = 1;
            this.LAYOUT_Main_Right_Concat_Input.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Concat_Input.Controls.Add(this.Button_PasteInto, 0, 1);
            this.LAYOUT_Main_Right_Concat_Input.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.LAYOUT_Main_Right_Concat_Input.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Right_Concat_Input.Location = new System.Drawing.Point(3, 3);
            this.LAYOUT_Main_Right_Concat_Input.Name = "LAYOUT_Main_Right_Concat_Input";
            this.LAYOUT_Main_Right_Concat_Input.RowCount = 2;
            this.LAYOUT_Main_Right_Concat_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Concat_Input.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LAYOUT_Main_Right_Concat_Input.Size = new System.Drawing.Size(252, 298);
            this.LAYOUT_Main_Right_Concat_Input.TabIndex = 0;
            // 
            // Button_PasteInto
            // 
            this.Button_PasteInto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_PasteInto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_PasteInto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_PasteInto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_PasteInto.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_PasteInto.ForeColor = System.Drawing.Color.White;
            this.Button_PasteInto.Location = new System.Drawing.Point(3, 269);
            this.Button_PasteInto.Name = "Button_PasteInto";
            this.Button_PasteInto.Size = new System.Drawing.Size(246, 26);
            this.Button_PasteInto.TabIndex = 1;
            this.Button_PasteInto.Text = "Paste Into";
            this.Button_PasteInto.UseVisualStyleBackColor = false;
            this.Button_PasteInto.Click += new System.EventHandler(this.Button_PasteInto_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.RichTextBox_In, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(246, 260);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // RichTextBox_In
            // 
            this.RichTextBox_In.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.RichTextBox_In.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_In.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_In.ForeColor = System.Drawing.Color.White;
            this.RichTextBox_In.Location = new System.Drawing.Point(3, 3);
            this.RichTextBox_In.Name = "RichTextBox_In";
            this.RichTextBox_In.Size = new System.Drawing.Size(240, 254);
            this.RichTextBox_In.TabIndex = 0;
            this.RichTextBox_In.Text = "";
            this.RichTextBox_In.TextChanged += new System.EventHandler(this.RichTextBox_In_TextChanged);
            // 
            // LAYOUT_Main_Right_Concat_Output
            // 
            this.LAYOUT_Main_Right_Concat_Output.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.LAYOUT_Main_Right_Concat_Output.ColumnCount = 1;
            this.LAYOUT_Main_Right_Concat_Output.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Concat_Output.Controls.Add(this.Button_CopyFrom, 0, 1);
            this.LAYOUT_Main_Right_Concat_Output.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.LAYOUT_Main_Right_Concat_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Right_Concat_Output.Location = new System.Drawing.Point(433, 3);
            this.LAYOUT_Main_Right_Concat_Output.Name = "LAYOUT_Main_Right_Concat_Output";
            this.LAYOUT_Main_Right_Concat_Output.RowCount = 2;
            this.LAYOUT_Main_Right_Concat_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Concat_Output.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LAYOUT_Main_Right_Concat_Output.Size = new System.Drawing.Size(252, 298);
            this.LAYOUT_Main_Right_Concat_Output.TabIndex = 2;
            // 
            // Button_CopyFrom
            // 
            this.Button_CopyFrom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_CopyFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_CopyFrom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_CopyFrom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_CopyFrom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button_CopyFrom.ForeColor = System.Drawing.Color.White;
            this.Button_CopyFrom.Location = new System.Drawing.Point(3, 269);
            this.Button_CopyFrom.Name = "Button_CopyFrom";
            this.Button_CopyFrom.Size = new System.Drawing.Size(246, 26);
            this.Button_CopyFrom.TabIndex = 1;
            this.Button_CopyFrom.Text = "Copy From";
            this.Button_CopyFrom.UseVisualStyleBackColor = false;
            this.Button_CopyFrom.Click += new System.EventHandler(this.Button_CopyFrom_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.RichTextBox_Out, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(246, 260);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // RichTextBox_Out
            // 
            this.RichTextBox_Out.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.RichTextBox_Out.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBox_Out.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RichTextBox_Out.ForeColor = System.Drawing.Color.White;
            this.RichTextBox_Out.Location = new System.Drawing.Point(3, 3);
            this.RichTextBox_Out.Name = "RichTextBox_Out";
            this.RichTextBox_Out.ReadOnly = true;
            this.RichTextBox_Out.Size = new System.Drawing.Size(240, 254);
            this.RichTextBox_Out.TabIndex = 0;
            this.RichTextBox_Out.Text = "";
            // 
            // LAYOUT_Main_Right_Concat_Delimiter
            // 
            this.LAYOUT_Main_Right_Concat_Delimiter.ColumnCount = 1;
            this.LAYOUT_Main_Right_Concat_Delimiter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.TextBox_Suffix, 0, 7);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.TextBox_Infix, 0, 5);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.Label_Suffix, 0, 6);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.Label_Infix, 0, 4);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.Label_Prefix, 0, 2);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.Label_Delimiters, 0, 0);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.ComboBox_Delimiters, 0, 1);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.TextBox_Prefix, 0, 3);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad, 0, 9);
            this.LAYOUT_Main_Right_Concat_Delimiter.Controls.Add(this.SecretConcatButton, 0, 8);
            this.LAYOUT_Main_Right_Concat_Delimiter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Right_Concat_Delimiter.Location = new System.Drawing.Point(261, 3);
            this.LAYOUT_Main_Right_Concat_Delimiter.Name = "LAYOUT_Main_Right_Concat_Delimiter";
            this.LAYOUT_Main_Right_Concat_Delimiter.RowCount = 10;
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.LAYOUT_Main_Right_Concat_Delimiter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Concat_Delimiter.Size = new System.Drawing.Size(166, 298);
            this.LAYOUT_Main_Right_Concat_Delimiter.TabIndex = 1;
            // 
            // TextBox_Suffix
            // 
            this.TextBox_Suffix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.TextBox_Suffix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Suffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Suffix.ForeColor = System.Drawing.Color.White;
            this.TextBox_Suffix.Location = new System.Drawing.Point(3, 179);
            this.TextBox_Suffix.Name = "TextBox_Suffix";
            this.TextBox_Suffix.Size = new System.Drawing.Size(160, 23);
            this.TextBox_Suffix.TabIndex = 3;
            this.TextBox_Suffix.TextChanged += new System.EventHandler(this.TextBox_Suffix_TextChanged);
            // 
            // TextBox_Infix
            // 
            this.TextBox_Infix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.TextBox_Infix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Infix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Infix.ForeColor = System.Drawing.Color.White;
            this.TextBox_Infix.Location = new System.Drawing.Point(3, 127);
            this.TextBox_Infix.Name = "TextBox_Infix";
            this.TextBox_Infix.Size = new System.Drawing.Size(160, 23);
            this.TextBox_Infix.TabIndex = 2;
            this.TextBox_Infix.TextChanged += new System.EventHandler(this.TextBox_Infix_TextChanged);
            // 
            // Label_Suffix
            // 
            this.Label_Suffix.AutoSize = true;
            this.Label_Suffix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Suffix.ForeColor = System.Drawing.Color.White;
            this.Label_Suffix.Location = new System.Drawing.Point(3, 156);
            this.Label_Suffix.Name = "Label_Suffix";
            this.Label_Suffix.Size = new System.Drawing.Size(160, 20);
            this.Label_Suffix.TabIndex = 8;
            this.Label_Suffix.Text = "Suffix";
            this.Label_Suffix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Infix
            // 
            this.Label_Infix.AutoSize = true;
            this.Label_Infix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Infix.ForeColor = System.Drawing.Color.White;
            this.Label_Infix.Location = new System.Drawing.Point(3, 104);
            this.Label_Infix.Name = "Label_Infix";
            this.Label_Infix.Size = new System.Drawing.Size(160, 20);
            this.Label_Infix.TabIndex = 7;
            this.Label_Infix.Text = "Infix";
            this.Label_Infix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Prefix
            // 
            this.Label_Prefix.AutoSize = true;
            this.Label_Prefix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Prefix.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Label_Prefix.ForeColor = System.Drawing.Color.White;
            this.Label_Prefix.Location = new System.Drawing.Point(3, 52);
            this.Label_Prefix.Name = "Label_Prefix";
            this.Label_Prefix.Size = new System.Drawing.Size(160, 20);
            this.Label_Prefix.TabIndex = 3;
            this.Label_Prefix.Text = "Prefix";
            this.Label_Prefix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Delimiters
            // 
            this.Label_Delimiters.AutoSize = true;
            this.Label_Delimiters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label_Delimiters.ForeColor = System.Drawing.Color.White;
            this.Label_Delimiters.Location = new System.Drawing.Point(3, 0);
            this.Label_Delimiters.Name = "Label_Delimiters";
            this.Label_Delimiters.Size = new System.Drawing.Size(160, 20);
            this.Label_Delimiters.TabIndex = 2;
            this.Label_Delimiters.Text = "DELIMITERS";
            this.Label_Delimiters.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBox_Delimiters
            // 
            this.ComboBox_Delimiters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_Delimiters.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_Delimiters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.ComboBox_Delimiters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_Delimiters.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_Delimiters.ForeColor = System.Drawing.Color.White;
            this.ComboBox_Delimiters.FormattingEnabled = true;
            this.ComboBox_Delimiters.Location = new System.Drawing.Point(3, 23);
            this.ComboBox_Delimiters.Name = "ComboBox_Delimiters";
            this.ComboBox_Delimiters.Size = new System.Drawing.Size(160, 23);
            this.ComboBox_Delimiters.TabIndex = 0;
            this.ComboBox_Delimiters.SelectedValueChanged += new System.EventHandler(this.ComboBox_Delimiters_SelectedValueChanged);
            // 
            // TextBox_Prefix
            // 
            this.TextBox_Prefix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.TextBox_Prefix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_Prefix.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Prefix.ForeColor = System.Drawing.Color.White;
            this.TextBox_Prefix.Location = new System.Drawing.Point(3, 75);
            this.TextBox_Prefix.Name = "TextBox_Prefix";
            this.TextBox_Prefix.Size = new System.Drawing.Size(160, 23);
            this.TextBox_Prefix.TabIndex = 1;
            this.TextBox_Prefix.TextChanged += new System.EventHandler(this.TextBox_Prefix_TextChanged);
            // 
            // LAYOUT_Main_Right_Concat_Delimiter_SaveLoad
            // 
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.ColumnCount = 1;
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.Controls.Add(this.Button_SavePreset, 0, 0);
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.Controls.Add(this.Button_DeletePreset, 0, 1);
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.Location = new System.Drawing.Point(0, 236);
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.Margin = new System.Windows.Forms.Padding(0);
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.Name = "LAYOUT_Main_Right_Concat_Delimiter_SaveLoad";
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.RowCount = 2;
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.Size = new System.Drawing.Size(166, 62);
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.TabIndex = 12;
            // 
            // Button_SavePreset
            // 
            this.Button_SavePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Button_SavePreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_SavePreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_SavePreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_SavePreset.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Button_SavePreset.ForeColor = System.Drawing.Color.White;
            this.Button_SavePreset.Location = new System.Drawing.Point(3, 3);
            this.Button_SavePreset.Name = "Button_SavePreset";
            this.Button_SavePreset.Size = new System.Drawing.Size(160, 25);
            this.Button_SavePreset.TabIndex = 0;
            this.Button_SavePreset.Text = "Save Preset";
            this.Button_SavePreset.UseVisualStyleBackColor = false;
            this.Button_SavePreset.Click += new System.EventHandler(this.Button_SavePreset_Click);
            // 
            // Button_DeletePreset
            // 
            this.Button_DeletePreset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.Button_DeletePreset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_DeletePreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_DeletePreset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_DeletePreset.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.Button_DeletePreset.ForeColor = System.Drawing.Color.White;
            this.Button_DeletePreset.Location = new System.Drawing.Point(3, 34);
            this.Button_DeletePreset.Name = "Button_DeletePreset";
            this.Button_DeletePreset.Size = new System.Drawing.Size(160, 25);
            this.Button_DeletePreset.TabIndex = 1;
            this.Button_DeletePreset.Text = "Delete Preset";
            this.Button_DeletePreset.UseVisualStyleBackColor = false;
            this.Button_DeletePreset.Click += new System.EventHandler(this.Button_DeletePreset_Click);
            // 
            // SecretConcatButton
            // 
            this.SecretConcatButton.BackColor = System.Drawing.Color.Transparent;
            this.SecretConcatButton.FlatAppearance.BorderSize = 0;
            this.SecretConcatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SecretConcatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.SecretConcatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SecretConcatButton.ForeColor = System.Drawing.Color.Black;
            this.SecretConcatButton.Location = new System.Drawing.Point(3, 211);
            this.SecretConcatButton.Name = "SecretConcatButton";
            this.SecretConcatButton.Size = new System.Drawing.Size(0, 0);
            this.SecretConcatButton.TabIndex = 13;
            this.SecretConcatButton.TabStop = false;
            this.SecretConcatButton.Text = "This circumvents weirdness with Windows Forms datarepeaters and refreshing data. " +
    "I wish I didn\'t have to implement it like this, but lol";
            this.SecretConcatButton.UseVisualStyleBackColor = false;
            this.SecretConcatButton.Click += new System.EventHandler(this.SecretConcatButton_Click);
            // 
            // LAYOUT_Main_Right_Divider
            // 
            this.LAYOUT_Main_Right_Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.LAYOUT_Main_Right_Divider.ColumnCount = 4;
            this.LAYOUT_Main_Right_Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.LAYOUT_Main_Right_Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.LAYOUT_Main_Right_Divider.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.LAYOUT_Main_Right_Divider.Controls.Add(this.label6, 0, 0);
            this.LAYOUT_Main_Right_Divider.Controls.Add(this.button1, 3, 0);
            this.LAYOUT_Main_Right_Divider.Controls.Add(this.ComboBox_SelectOperation, 2, 0);
            this.LAYOUT_Main_Right_Divider.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LAYOUT_Main_Right_Divider.Location = new System.Drawing.Point(0, 311);
            this.LAYOUT_Main_Right_Divider.Margin = new System.Windows.Forms.Padding(0);
            this.LAYOUT_Main_Right_Divider.Name = "LAYOUT_Main_Right_Divider";
            this.LAYOUT_Main_Right_Divider.RowCount = 1;
            this.LAYOUT_Main_Right_Divider.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.LAYOUT_Main_Right_Divider.Size = new System.Drawing.Size(694, 30);
            this.LAYOUT_Main_Right_Divider.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 30);
            this.label6.TabIndex = 0;
            this.label6.Text = "Operations";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(667, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ComboBox_SelectOperation
            // 
            this.ComboBox_SelectOperation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBox_SelectOperation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBox_SelectOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.ComboBox_SelectOperation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComboBox_SelectOperation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ComboBox_SelectOperation.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.ComboBox_SelectOperation.ForeColor = System.Drawing.Color.White;
            this.ComboBox_SelectOperation.FormattingEnabled = true;
            this.ComboBox_SelectOperation.Location = new System.Drawing.Point(525, 4);
            this.ComboBox_SelectOperation.Margin = new System.Windows.Forms.Padding(10, 4, 3, 0);
            this.ComboBox_SelectOperation.Name = "ComboBox_SelectOperation";
            this.ComboBox_SelectOperation.Size = new System.Drawing.Size(139, 21);
            this.ComboBox_SelectOperation.TabIndex = 0;
            // 
            // DataRepeater_Operations
            // 
            this.DataRepeater_Operations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataRepeater_Operations.ForeColor = System.Drawing.Color.White;
            this.DataRepeater_Operations.ItemHeaderVisible = false;
            // 
            // DataRepeater_Operations.ItemTemplate
            // 
            this.DataRepeater_Operations.ItemTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.label2);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.Operation_PrePostCheckBox);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.Operation_BottomButtonBump);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.Button_TopOperationBump);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.Button_OperationDelete);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.TextBox_OperationBot);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.TextBox_OperationTop);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.Label_OperationDesc);
            this.DataRepeater_Operations.ItemTemplate.Controls.Add(this.Label_OperationTitle);
            this.DataRepeater_Operations.ItemTemplate.ForeColor = System.Drawing.Color.White;
            this.DataRepeater_Operations.ItemTemplate.Size = new System.Drawing.Size(674, 78);
            this.DataRepeater_Operations.Location = new System.Drawing.Point(6, 351);
            this.DataRepeater_Operations.Margin = new System.Windows.Forms.Padding(6);
            this.DataRepeater_Operations.Name = "DataRepeater_Operations";
            this.DataRepeater_Operations.Size = new System.Drawing.Size(682, 224);
            this.DataRepeater_Operations.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.operationListBindingSource, "IntWarningVisible", true));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(222, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "(INTEGER ONLY)";
            this.label2.Visible = false;
            // 
            // operationListBindingSource
            // 
            this.operationListBindingSource.AllowNew = false;
            this.operationListBindingSource.DataSource = typeof(AutoConcat1_5.Data.OperationList);
            // 
            // Operation_PrePostCheckBox
            // 
            this.Operation_PrePostCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Operation_PrePostCheckBox.AutoSize = true;
            this.Operation_PrePostCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.operationListBindingSource, "IsAfterConcat", true));
            this.Operation_PrePostCheckBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Operation_PrePostCheckBox.Location = new System.Drawing.Point(479, 6);
            this.Operation_PrePostCheckBox.Name = "Operation_PrePostCheckBox";
            this.Operation_PrePostCheckBox.Size = new System.Drawing.Size(133, 19);
            this.Operation_PrePostCheckBox.TabIndex = 5;
            this.Operation_PrePostCheckBox.Text = "Process Post-Concat";
            this.Operation_PrePostCheckBox.UseVisualStyleBackColor = true;
            this.Operation_PrePostCheckBox.Click += new System.EventHandler(this.Operation_PrePostCheckBox_Click);
            // 
            // Operation_BottomButtonBump
            // 
            this.Operation_BottomButtonBump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Operation_BottomButtonBump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Operation_BottomButtonBump.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Operation_BottomButtonBump.Location = new System.Drawing.Point(618, 31);
            this.Operation_BottomButtonBump.Name = "Operation_BottomButtonBump";
            this.Operation_BottomButtonBump.Size = new System.Drawing.Size(25, 23);
            this.Operation_BottomButtonBump.TabIndex = 8;
            this.Operation_BottomButtonBump.Text = "v";
            this.Operation_BottomButtonBump.UseVisualStyleBackColor = false;
            this.Operation_BottomButtonBump.Click += new System.EventHandler(this.button3_Click);
            // 
            // Button_TopOperationBump
            // 
            this.Button_TopOperationBump.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_TopOperationBump.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_TopOperationBump.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_TopOperationBump.Location = new System.Drawing.Point(618, 6);
            this.Button_TopOperationBump.Name = "Button_TopOperationBump";
            this.Button_TopOperationBump.Size = new System.Drawing.Size(25, 23);
            this.Button_TopOperationBump.TabIndex = 7;
            this.Button_TopOperationBump.Text = "^";
            this.Button_TopOperationBump.UseVisualStyleBackColor = false;
            this.Button_TopOperationBump.Click += new System.EventHandler(this.button2_Click);
            // 
            // Button_OperationDelete
            // 
            this.Button_OperationDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_OperationDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(66)))), ((int)(((byte)(84)))));
            this.Button_OperationDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_OperationDelete.Location = new System.Drawing.Point(477, 31);
            this.Button_OperationDelete.Name = "Button_OperationDelete";
            this.Button_OperationDelete.Size = new System.Drawing.Size(135, 23);
            this.Button_OperationDelete.TabIndex = 6;
            this.Button_OperationDelete.Text = "Delete";
            this.Button_OperationDelete.UseVisualStyleBackColor = false;
            this.Button_OperationDelete.Click += new System.EventHandler(this.Button_OperationDelete_Click);
            // 
            // TextBox_OperationBot
            // 
            this.TextBox_OperationBot.AcceptsTab = true;
            this.TextBox_OperationBot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_OperationBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.TextBox_OperationBot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_OperationBot.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationListBindingSource, "Text2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBox_OperationBot.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.operationListBindingSource, "Text2Visible", true));
            this.TextBox_OperationBot.ForeColor = System.Drawing.Color.White;
            this.TextBox_OperationBot.Location = new System.Drawing.Point(224, 31);
            this.TextBox_OperationBot.Name = "TextBox_OperationBot";
            this.TextBox_OperationBot.Size = new System.Drawing.Size(233, 23);
            this.TextBox_OperationBot.TabIndex = 3;
            this.TextBox_OperationBot.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_OperationBot_KeyUp);
            // 
            // TextBox_OperationTop
            // 
            this.TextBox_OperationTop.AcceptsTab = true;
            this.TextBox_OperationTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBox_OperationTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.TextBox_OperationTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox_OperationTop.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationListBindingSource, "Text1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.TextBox_OperationTop.DataBindings.Add(new System.Windows.Forms.Binding("Visible", this.operationListBindingSource, "Text1Visible", true));
            this.TextBox_OperationTop.ForeColor = System.Drawing.Color.White;
            this.TextBox_OperationTop.Location = new System.Drawing.Point(224, 4);
            this.TextBox_OperationTop.Name = "TextBox_OperationTop";
            this.TextBox_OperationTop.Size = new System.Drawing.Size(233, 23);
            this.TextBox_OperationTop.TabIndex = 2;
            this.TextBox_OperationTop.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TextBox_OperationTop_KeyUp);
            // 
            // Label_OperationDesc
            // 
            this.Label_OperationDesc.BackColor = System.Drawing.Color.Transparent;
            this.Label_OperationDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationListBindingSource, "Description", true));
            this.Label_OperationDesc.Font = new System.Drawing.Font("Segoe UI", 7.5F);
            this.Label_OperationDesc.Location = new System.Drawing.Point(3, 20);
            this.Label_OperationDesc.Name = "Label_OperationDesc";
            this.Label_OperationDesc.Size = new System.Drawing.Size(214, 41);
            this.Label_OperationDesc.TabIndex = 1;
            this.Label_OperationDesc.Text = "null";
            // 
            // Label_OperationTitle
            // 
            this.Label_OperationTitle.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.operationListBindingSource, "Title", true));
            this.Label_OperationTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.Label_OperationTitle.ForeColor = System.Drawing.Color.White;
            this.Label_OperationTitle.Location = new System.Drawing.Point(3, -1);
            this.Label_OperationTitle.Name = "Label_OperationTitle";
            this.Label_OperationTitle.Size = new System.Drawing.Size(222, 23);
            this.Label_OperationTitle.TabIndex = 0;
            this.Label_OperationTitle.Text = "null";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(55)))), ((int)(((byte)(68)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 341);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(694, 4);
            this.panel2.TabIndex = 22;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // delimiterPresetListBindingSource
            // 
            this.delimiterPresetListBindingSource.DataSource = typeof(AutoConcat1_5.Data.DelimiterPresetList);
            // 
            // AutoConcat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 587);
            this.Controls.Add(this.LAYOUT_Main);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(949, 626);
            this.Name = "AutoConcat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoConcat 2.0.3";
            this.LAYOUT_Main.ResumeLayout(false);
            this.LAYOUT_Main_Left.ResumeLayout(false);
            this.LAYOUT_Main_Left.PerformLayout();
            this.LAYOUT_Main_Left_Menu.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.DataRepeater_Projects.ItemTemplate.ResumeLayout(false);
            this.DataRepeater_Projects.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.savedProjectListBindingSource)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.LAYOUT_Main_Right.ResumeLayout(false);
            this.LAYOUT_Main_Right_Concat.ResumeLayout(false);
            this.LAYOUT_Main_Right_Concat_Input.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.LAYOUT_Main_Right_Concat_Output.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.LAYOUT_Main_Right_Concat_Delimiter.ResumeLayout(false);
            this.LAYOUT_Main_Right_Concat_Delimiter.PerformLayout();
            this.LAYOUT_Main_Right_Concat_Delimiter_SaveLoad.ResumeLayout(false);
            this.LAYOUT_Main_Right_Divider.ResumeLayout(false);
            this.LAYOUT_Main_Right_Divider.PerformLayout();
            this.DataRepeater_Operations.ItemTemplate.ResumeLayout(false);
            this.DataRepeater_Operations.ItemTemplate.PerformLayout();
            this.DataRepeater_Operations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.operationListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delimiterPresetListBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel LAYOUT_Main;
        private TableLayoutPanel LAYOUT_Main_Left;
        private TableLayoutPanel LAYOUT_Main_Right;
        private TableLayoutPanel LAYOUT_Main_Right_Concat;
        private TableLayoutPanel LAYOUT_Main_Left_Menu;
        private Button Button_Settings;
        private Button Button_Help;
        private TableLayoutPanel LAYOUT_Main_Right_Concat_Input;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel LAYOUT_Main_Right_Concat_Output;
        private TableLayoutPanel tableLayoutPanel2;
        private Button Button_PasteInto;
        private Button Button_CopyFrom;
        private Label label1;
        private TableLayoutPanel LAYOUT_Main_Right_Concat_Delimiter;
        private Label Label_Delimiters;
        private ComboBox ComboBox_Delimiters;
        private Label Label_Prefix;
        private Label Label_Suffix;
        private Label Label_Infix;
        private TextBox TextBox_Suffix;
        private TextBox TextBox_Infix;
        private TextBox TextBox_Prefix;
        private TableLayoutPanel LAYOUT_Main_Right_Concat_Delimiter_SaveLoad;
        private Button Button_SavePreset;
        private Button Button_DeletePreset;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private RichTextBox RichTextBox_Out;
        private RichTextBox RichTextBox_In;
        private TableLayoutPanel LAYOUT_Main_Right_Divider;
        private Label label6;
        private DataRepeater DataRepeater_Operations;
        private BindingSource operationListBindingSource;
        private Label Label_OperationTitle;
        private Label Label_OperationDesc;
        private Button Button_OperationDelete;
        private TextBox TextBox_OperationBot;
        private TextBox TextBox_OperationTop;
        private Button button1;
        private Label Label_ProjectTitle;
        private Label Label_ProjectTime;
        private BindingSource savedProjectListBindingSource;
        private Button Operation_BottomButtonBump;
        private Button Button_TopOperationBump;
        private BindingSource delimiterPresetListBindingSource;
        private CheckBox Operation_PrePostCheckBox;
        private ComboBox ComboBox_SelectOperation;
        private DataRepeater DataRepeater_Projects;
        private TableLayoutPanel tableLayoutPanel5;
        private Button Button_ProjectSave;
        private Button Button_ProjectLoad;
        private Button Button_ProjectDelete;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel6;
        private Button Button_SaveProjectAs;
        private Button Button_NewProject;
        private Button SecretConcatButton;
        private Panel panel2;
    }
}
