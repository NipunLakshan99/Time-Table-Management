
namespace TimeTable
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYearSemesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this._time_table_managementDataSet80 = new TimeTable._time_table_managementDataSet80();
            this.txtAddGroupNo = new System.Windows.Forms.ComboBox();
            this.txtAddSubGroupNo = new System.Windows.Forms.ComboBox();
            this.txtAddAYS = new System.Windows.Forms.ComboBox();
            this.txtAddSubGroupId = new System.Windows.Forms.TextBox();
            this.txtAddGroupId = new System.Windows.Forms.TextBox();
            this.txtAddProg = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.txtMSID = new System.Windows.Forms.TextBox();
            this.txtMAYS = new System.Windows.Forms.ComboBox();
            this.txtMGI = new System.Windows.Forms.ComboBox();
            this.txtSGI = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.academicYearSemesterDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.programmeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupIDDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this._time_table_managementDataSet81 = new TimeTable._time_table_managementDataSet81();
            this.btnMClear = new System.Windows.Forms.Button();
            this.btnMUpdate = new System.Windows.Forms.Button();
            this.txtMGN = new System.Windows.Forms.TextBox();
            this.txtMSGN = new System.Windows.Forms.TextBox();
            this.txtMProg = new System.Windows.Forms.ComboBox();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbGRoom = new System.Windows.Forms.ComboBox();
            this.locationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._time_table_managementDataSet62 = new TimeTable._time_table_managementDataSet62();
            this.label37 = new System.Windows.Forms.Label();
            this.btnSaveG = new System.Windows.Forms.Button();
            this.btnClearG = new System.Windows.Forms.Button();
            this.cmbGroup = new System.Windows.Forms.ComboBox();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._time_table_managementDataSet60 = new TimeTable._time_table_managementDataSet60();
            this.cmbSubGroup = new System.Windows.Forms.ComboBox();
            this.studentBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this._time_table_managementDataSet61 = new TimeTable._time_table_managementDataSet61();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subGroupIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationGroupBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._time_table_managementDataSet63 = new TimeTable._time_table_managementDataSet63();
            this.studentTableAdapter = new TimeTable._time_table_managementDataSet60TableAdapters.StudentTableAdapter();
            this.studentTableAdapter1 = new TimeTable._time_table_managementDataSet61TableAdapters.StudentTableAdapter();
            this.locationTableAdapter = new TimeTable._time_table_managementDataSet62TableAdapters.LocationTableAdapter();
            this.locationGroupTableAdapter = new TimeTable._time_table_managementDataSet63TableAdapters.LocationGroupTableAdapter();
            this.studentTableAdapter2 = new TimeTable._time_table_managementDataSet80TableAdapters.StudentTableAdapter();
            this.studentTableAdapter3 = new TimeTable._time_table_managementDataSet81TableAdapters.StudentTableAdapter();
            this.teacherTableAdapter = new TimeTable._time_table_managementDataSet82TableAdapters.TeacherTableAdapter();
            this.sessionTableAdapter = new TimeTable._time_table_managementDataSet83TableAdapters.SessionTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet80)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet81)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet62)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet60)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet61)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationGroupBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet63)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(951, 577);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.txtAddGroupNo);
            this.tabPage1.Controls.Add(this.txtAddSubGroupNo);
            this.tabPage1.Controls.Add(this.txtAddAYS);
            this.tabPage1.Controls.Add(this.txtAddSubGroupId);
            this.tabPage1.Controls.Add(this.txtAddGroupId);
            this.tabPage1.Controls.Add(this.txtAddProg);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(943, 551);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD STUDENT GROUPS";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.academicYearSemesterDataGridViewTextBoxColumn,
            this.programmeDataGridViewTextBoxColumn,
            this.groupNumberDataGridViewTextBoxColumn,
            this.subGroupNumberDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn1,
            this.subGroupIDDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.studentBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(24, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(742, 172);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            this.studentIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // academicYearSemesterDataGridViewTextBoxColumn
            // 
            this.academicYearSemesterDataGridViewTextBoxColumn.DataPropertyName = "Academic_Year_Semester";
            this.academicYearSemesterDataGridViewTextBoxColumn.HeaderText = "Academic_Year_Semester";
            this.academicYearSemesterDataGridViewTextBoxColumn.Name = "academicYearSemesterDataGridViewTextBoxColumn";
            // 
            // programmeDataGridViewTextBoxColumn
            // 
            this.programmeDataGridViewTextBoxColumn.DataPropertyName = "Programme";
            this.programmeDataGridViewTextBoxColumn.HeaderText = "Programme";
            this.programmeDataGridViewTextBoxColumn.Name = "programmeDataGridViewTextBoxColumn";
            // 
            // groupNumberDataGridViewTextBoxColumn
            // 
            this.groupNumberDataGridViewTextBoxColumn.DataPropertyName = "Group_Number";
            this.groupNumberDataGridViewTextBoxColumn.HeaderText = "Group_Number";
            this.groupNumberDataGridViewTextBoxColumn.Name = "groupNumberDataGridViewTextBoxColumn";
            // 
            // subGroupNumberDataGridViewTextBoxColumn
            // 
            this.subGroupNumberDataGridViewTextBoxColumn.DataPropertyName = "Sub_Group_Number";
            this.subGroupNumberDataGridViewTextBoxColumn.HeaderText = "Sub_Group_Number";
            this.subGroupNumberDataGridViewTextBoxColumn.Name = "subGroupNumberDataGridViewTextBoxColumn";
            // 
            // groupIDDataGridViewTextBoxColumn1
            // 
            this.groupIDDataGridViewTextBoxColumn1.DataPropertyName = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn1.HeaderText = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn1.Name = "groupIDDataGridViewTextBoxColumn1";
            // 
            // subGroupIDDataGridViewTextBoxColumn1
            // 
            this.subGroupIDDataGridViewTextBoxColumn1.DataPropertyName = "Sub_Group_ID";
            this.subGroupIDDataGridViewTextBoxColumn1.HeaderText = "Sub_Group_ID";
            this.subGroupIDDataGridViewTextBoxColumn1.Name = "subGroupIDDataGridViewTextBoxColumn1";
            // 
            // studentBindingSource2
            // 
            this.studentBindingSource2.DataMember = "Student";
            this.studentBindingSource2.DataSource = this._time_table_managementDataSet80;
            // 
            // _time_table_managementDataSet80
            // 
            this._time_table_managementDataSet80.DataSetName = "_time_table_managementDataSet80";
            this._time_table_managementDataSet80.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtAddGroupNo
            // 
            this.txtAddGroupNo.FormattingEnabled = true;
            this.txtAddGroupNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.txtAddGroupNo.Location = new System.Drawing.Point(650, 23);
            this.txtAddGroupNo.Name = "txtAddGroupNo";
            this.txtAddGroupNo.Size = new System.Drawing.Size(108, 26);
            this.txtAddGroupNo.TabIndex = 16;
            // 
            // txtAddSubGroupNo
            // 
            this.txtAddSubGroupNo.FormattingEnabled = true;
            this.txtAddSubGroupNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.txtAddSubGroupNo.Location = new System.Drawing.Point(650, 77);
            this.txtAddSubGroupNo.Name = "txtAddSubGroupNo";
            this.txtAddSubGroupNo.Size = new System.Drawing.Size(108, 26);
            this.txtAddSubGroupNo.TabIndex = 16;
            // 
            // txtAddAYS
            // 
            this.txtAddAYS.FormattingEnabled = true;
            this.txtAddAYS.Items.AddRange(new object[] {
            "Y1S1",
            "Y1S2",
            "Y2S1",
            "Y2S2",
            "Y3S1",
            "Y3S2",
            "Y4S1",
            "Y4S2"});
            this.txtAddAYS.Location = new System.Drawing.Point(284, 29);
            this.txtAddAYS.Name = "txtAddAYS";
            this.txtAddAYS.Size = new System.Drawing.Size(149, 26);
            this.txtAddAYS.TabIndex = 15;
            // 
            // txtAddSubGroupId
            // 
            this.txtAddSubGroupId.Location = new System.Drawing.Point(326, 180);
            this.txtAddSubGroupId.Name = "txtAddSubGroupId";
            this.txtAddSubGroupId.Size = new System.Drawing.Size(232, 26);
            this.txtAddSubGroupId.TabIndex = 14;
            // 
            // txtAddGroupId
            // 
            this.txtAddGroupId.Location = new System.Drawing.Point(326, 138);
            this.txtAddGroupId.Name = "txtAddGroupId";
            this.txtAddGroupId.Size = new System.Drawing.Size(232, 26);
            this.txtAddGroupId.TabIndex = 13;
            // 
            // txtAddProg
            // 
            this.txtAddProg.FormattingEnabled = true;
            this.txtAddProg.Items.AddRange(new object[] {
            "IT",
            "",
            "BM",
            "",
            "EN",
            "",
            "HS",
            "",
            "CAM"});
            this.txtAddProg.Location = new System.Drawing.Point(284, 81);
            this.txtAddProg.Name = "txtAddProg";
            this.txtAddProg.Size = new System.Drawing.Size(149, 26);
            this.txtAddProg.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(483, 232);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 33);
            this.button3.TabIndex = 8;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.Location = new System.Drawing.Point(273, 232);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(596, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "GENERATE ID";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(161, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "SUB GROUP ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(181, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "GROUP ID";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(450, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "SUB GROUP NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(450, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "GROUP NUMBER";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(20, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "PROGRAMME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ACADEMIC YEAR SEMESTER";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtMSID);
            this.tabPage2.Controls.Add(this.txtMAYS);
            this.tabPage2.Controls.Add(this.txtMGI);
            this.tabPage2.Controls.Add(this.txtSGI);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnMClear);
            this.tabPage2.Controls.Add(this.btnMUpdate);
            this.tabPage2.Controls.Add(this.txtMGN);
            this.tabPage2.Controls.Add(this.txtMSGN);
            this.tabPage2.Controls.Add(this.txtMProg);
            this.tabPage2.Controls.Add(this.btnMDelete);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(943, 551);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MANAGE STUDENT GROUPS";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(11, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "Student ID";
            // 
            // txtMSID
            // 
            this.txtMSID.Location = new System.Drawing.Point(244, 6);
            this.txtMSID.Name = "txtMSID";
            this.txtMSID.Size = new System.Drawing.Size(178, 26);
            this.txtMSID.TabIndex = 36;
            // 
            // txtMAYS
            // 
            this.txtMAYS.FormattingEnabled = true;
            this.txtMAYS.Location = new System.Drawing.Point(244, 52);
            this.txtMAYS.Name = "txtMAYS";
            this.txtMAYS.Size = new System.Drawing.Size(178, 26);
            this.txtMAYS.TabIndex = 35;
            // 
            // txtMGI
            // 
            this.txtMGI.FormattingEnabled = true;
            this.txtMGI.Location = new System.Drawing.Point(619, 42);
            this.txtMGI.Name = "txtMGI";
            this.txtMGI.Size = new System.Drawing.Size(145, 26);
            this.txtMGI.TabIndex = 34;
            // 
            // txtSGI
            // 
            this.txtSGI.FormattingEnabled = true;
            this.txtSGI.Location = new System.Drawing.Point(619, 75);
            this.txtSGI.Name = "txtSGI";
            this.txtSGI.Size = new System.Drawing.Size(145, 26);
            this.txtSGI.TabIndex = 33;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn1,
            this.academicYearSemesterDataGridViewTextBoxColumn1,
            this.programmeDataGridViewTextBoxColumn1,
            this.groupNumberDataGridViewTextBoxColumn1,
            this.subGroupNumberDataGridViewTextBoxColumn1,
            this.groupIDDataGridViewTextBoxColumn2,
            this.subGroupIDDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.studentBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(14, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 203);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // studentIDDataGridViewTextBoxColumn1
            // 
            this.studentIDDataGridViewTextBoxColumn1.DataPropertyName = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn1.HeaderText = "Student_ID";
            this.studentIDDataGridViewTextBoxColumn1.Name = "studentIDDataGridViewTextBoxColumn1";
            this.studentIDDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // academicYearSemesterDataGridViewTextBoxColumn1
            // 
            this.academicYearSemesterDataGridViewTextBoxColumn1.DataPropertyName = "Academic_Year_Semester";
            this.academicYearSemesterDataGridViewTextBoxColumn1.HeaderText = "Academic_Year_Semester";
            this.academicYearSemesterDataGridViewTextBoxColumn1.Name = "academicYearSemesterDataGridViewTextBoxColumn1";
            // 
            // programmeDataGridViewTextBoxColumn1
            // 
            this.programmeDataGridViewTextBoxColumn1.DataPropertyName = "Programme";
            this.programmeDataGridViewTextBoxColumn1.HeaderText = "Programme";
            this.programmeDataGridViewTextBoxColumn1.Name = "programmeDataGridViewTextBoxColumn1";
            // 
            // groupNumberDataGridViewTextBoxColumn1
            // 
            this.groupNumberDataGridViewTextBoxColumn1.DataPropertyName = "Group_Number";
            this.groupNumberDataGridViewTextBoxColumn1.HeaderText = "Group_Number";
            this.groupNumberDataGridViewTextBoxColumn1.Name = "groupNumberDataGridViewTextBoxColumn1";
            // 
            // subGroupNumberDataGridViewTextBoxColumn1
            // 
            this.subGroupNumberDataGridViewTextBoxColumn1.DataPropertyName = "Sub_Group_Number";
            this.subGroupNumberDataGridViewTextBoxColumn1.HeaderText = "Sub_Group_Number";
            this.subGroupNumberDataGridViewTextBoxColumn1.Name = "subGroupNumberDataGridViewTextBoxColumn1";
            // 
            // groupIDDataGridViewTextBoxColumn2
            // 
            this.groupIDDataGridViewTextBoxColumn2.DataPropertyName = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn2.HeaderText = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn2.Name = "groupIDDataGridViewTextBoxColumn2";
            // 
            // subGroupIDDataGridViewTextBoxColumn2
            // 
            this.subGroupIDDataGridViewTextBoxColumn2.DataPropertyName = "Sub_Group_ID";
            this.subGroupIDDataGridViewTextBoxColumn2.HeaderText = "Sub_Group_ID";
            this.subGroupIDDataGridViewTextBoxColumn2.Name = "subGroupIDDataGridViewTextBoxColumn2";
            // 
            // studentBindingSource3
            // 
            this.studentBindingSource3.DataMember = "Student";
            this.studentBindingSource3.DataSource = this._time_table_managementDataSet81;
            // 
            // _time_table_managementDataSet81
            // 
            this._time_table_managementDataSet81.DataSetName = "_time_table_managementDataSet81";
            this._time_table_managementDataSet81.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnMClear
            // 
            this.btnMClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMClear.Location = new System.Drawing.Point(220, 160);
            this.btnMClear.Name = "btnMClear";
            this.btnMClear.Size = new System.Drawing.Size(101, 30);
            this.btnMClear.TabIndex = 31;
            this.btnMClear.Text = "CLEAR";
            this.btnMClear.UseVisualStyleBackColor = false;
            this.btnMClear.Click += new System.EventHandler(this.btnMClear_Click);
            // 
            // btnMUpdate
            // 
            this.btnMUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMUpdate.Location = new System.Drawing.Point(535, 160);
            this.btnMUpdate.Name = "btnMUpdate";
            this.btnMUpdate.Size = new System.Drawing.Size(101, 30);
            this.btnMUpdate.TabIndex = 30;
            this.btnMUpdate.Text = "UPDATE";
            this.btnMUpdate.UseVisualStyleBackColor = false;
            this.btnMUpdate.Click += new System.EventHandler(this.btnMUpdate_Click);
            // 
            // txtMGN
            // 
            this.txtMGN.Location = new System.Drawing.Point(619, 113);
            this.txtMGN.Name = "txtMGN";
            this.txtMGN.Size = new System.Drawing.Size(145, 26);
            this.txtMGN.TabIndex = 29;
            // 
            // txtMSGN
            // 
            this.txtMSGN.Location = new System.Drawing.Point(619, 10);
            this.txtMSGN.Name = "txtMSGN";
            this.txtMSGN.Size = new System.Drawing.Size(145, 26);
            this.txtMSGN.TabIndex = 28;
            // 
            // txtMProg
            // 
            this.txtMProg.FormattingEnabled = true;
            this.txtMProg.Location = new System.Drawing.Point(244, 103);
            this.txtMProg.Name = "txtMProg";
            this.txtMProg.Size = new System.Drawing.Size(178, 26);
            this.txtMProg.TabIndex = 24;
            // 
            // btnMDelete
            // 
            this.btnMDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMDelete.Location = new System.Drawing.Point(378, 160);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(101, 30);
            this.btnMDelete.TabIndex = 21;
            this.btnMDelete.Text = "DELETE";
            this.btnMDelete.UseVisualStyleBackColor = false;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(447, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 16);
            this.label7.TabIndex = 20;
            this.label7.Text = "SUB GROUP ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(447, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "GROUP ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(447, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "SUB GROUP NUMBER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(447, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "GROUP NUMBER";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(11, 108);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 16);
            this.label11.TabIndex = 16;
            this.label11.Text = "PROGRAMME";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(11, 57);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(217, 16);
            this.label12.TabIndex = 15;
            this.label12.Text = "ACADEMIC YEAR SEMESTER";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.cmbGRoom);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.btnSaveG);
            this.tabPage3.Controls.Add(this.btnClearG);
            this.tabPage3.Controls.Add(this.cmbGroup);
            this.tabPage3.Controls.Add(this.cmbSubGroup);
            this.tabPage3.Controls.Add(this.label35);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.dataGridView6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(943, 551);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ADD ROOM FOR GROUP";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cmbGRoom
            // 
            this.cmbGRoom.DataSource = this.locationBindingSource;
            this.cmbGRoom.DisplayMember = "Room_name";
            this.cmbGRoom.FormattingEnabled = true;
            this.cmbGRoom.Location = new System.Drawing.Point(354, 119);
            this.cmbGRoom.Name = "cmbGRoom";
            this.cmbGRoom.Size = new System.Drawing.Size(256, 21);
            this.cmbGRoom.TabIndex = 147;
            this.cmbGRoom.ValueMember = "Room_name";
            // 
            // locationBindingSource
            // 
            this.locationBindingSource.DataMember = "Location";
            this.locationBindingSource.DataSource = this._time_table_managementDataSet62;
            // 
            // _time_table_managementDataSet62
            // 
            this._time_table_managementDataSet62.DataSetName = "_time_table_managementDataSet62";
            this._time_table_managementDataSet62.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label37.Location = new System.Drawing.Point(149, 117);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(117, 20);
            this.label37.TabIndex = 146;
            this.label37.Text = "ROOM NAME";
            // 
            // btnSaveG
            // 
            this.btnSaveG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSaveG.Location = new System.Drawing.Point(658, 31);
            this.btnSaveG.Name = "btnSaveG";
            this.btnSaveG.Size = new System.Drawing.Size(75, 33);
            this.btnSaveG.TabIndex = 145;
            this.btnSaveG.Text = "SAVE";
            this.btnSaveG.UseVisualStyleBackColor = false;
            this.btnSaveG.Click += new System.EventHandler(this.btnSaveG_Click);
            // 
            // btnClearG
            // 
            this.btnClearG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClearG.Location = new System.Drawing.Point(658, 104);
            this.btnClearG.Name = "btnClearG";
            this.btnClearG.Size = new System.Drawing.Size(75, 33);
            this.btnClearG.TabIndex = 144;
            this.btnClearG.Text = "CLEAR";
            this.btnClearG.UseVisualStyleBackColor = false;
            this.btnClearG.Click += new System.EventHandler(this.btnClearG_Click);
            // 
            // cmbGroup
            // 
            this.cmbGroup.DataSource = this.studentBindingSource;
            this.cmbGroup.DisplayMember = "Group_ID";
            this.cmbGroup.FormattingEnabled = true;
            this.cmbGroup.Location = new System.Drawing.Point(354, 31);
            this.cmbGroup.Name = "cmbGroup";
            this.cmbGroup.Size = new System.Drawing.Size(256, 21);
            this.cmbGroup.TabIndex = 143;
            this.cmbGroup.ValueMember = "Group_ID";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this._time_table_managementDataSet60;
            // 
            // _time_table_managementDataSet60
            // 
            this._time_table_managementDataSet60.DataSetName = "_time_table_managementDataSet60";
            this._time_table_managementDataSet60.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cmbSubGroup
            // 
            this.cmbSubGroup.DataSource = this.studentBindingSource1;
            this.cmbSubGroup.DisplayMember = "Sub_Group_ID";
            this.cmbSubGroup.FormattingEnabled = true;
            this.cmbSubGroup.Location = new System.Drawing.Point(354, 73);
            this.cmbSubGroup.Name = "cmbSubGroup";
            this.cmbSubGroup.Size = new System.Drawing.Size(256, 21);
            this.cmbSubGroup.TabIndex = 142;
            this.cmbSubGroup.ValueMember = "Sub_Group_ID";
            // 
            // studentBindingSource1
            // 
            this.studentBindingSource1.DataMember = "Student";
            this.studentBindingSource1.DataSource = this._time_table_managementDataSet61;
            // 
            // _time_table_managementDataSet61
            // 
            this._time_table_managementDataSet61.DataSetName = "_time_table_managementDataSet61";
            this._time_table_managementDataSet61.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label35.Location = new System.Drawing.Point(149, 29);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(154, 20);
            this.label35.TabIndex = 141;
            this.label35.Text = "GROUP NUMBER";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label36.Location = new System.Drawing.Point(149, 71);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(196, 20);
            this.label36.TabIndex = 140;
            this.label36.Text = "SUB GROUP NUMBER";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AutoGenerateColumns = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.groupIDDataGridViewTextBoxColumn,
            this.subGroupIDDataGridViewTextBoxColumn,
            this.roomNameDataGridViewTextBoxColumn});
            this.dataGridView6.DataSource = this.locationGroupBindingSource;
            this.dataGridView6.Location = new System.Drawing.Point(202, 162);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.Size = new System.Drawing.Size(443, 213);
            this.dataGridView6.TabIndex = 139;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupIDDataGridViewTextBoxColumn
            // 
            this.groupIDDataGridViewTextBoxColumn.DataPropertyName = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn.HeaderText = "Group_ID";
            this.groupIDDataGridViewTextBoxColumn.Name = "groupIDDataGridViewTextBoxColumn";
            // 
            // subGroupIDDataGridViewTextBoxColumn
            // 
            this.subGroupIDDataGridViewTextBoxColumn.DataPropertyName = "Sub_Group_ID";
            this.subGroupIDDataGridViewTextBoxColumn.HeaderText = "Sub_Group_ID";
            this.subGroupIDDataGridViewTextBoxColumn.Name = "subGroupIDDataGridViewTextBoxColumn";
            // 
            // roomNameDataGridViewTextBoxColumn
            // 
            this.roomNameDataGridViewTextBoxColumn.DataPropertyName = "Room_Name";
            this.roomNameDataGridViewTextBoxColumn.HeaderText = "Room_Name";
            this.roomNameDataGridViewTextBoxColumn.Name = "roomNameDataGridViewTextBoxColumn";
            // 
            // locationGroupBindingSource
            // 
            this.locationGroupBindingSource.DataMember = "LocationGroup";
            this.locationGroupBindingSource.DataSource = this._time_table_managementDataSet63;
            // 
            // _time_table_managementDataSet63
            // 
            this._time_table_managementDataSet63.DataSetName = "_time_table_managementDataSet63";
            this._time_table_managementDataSet63.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter1
            // 
            this.studentTableAdapter1.ClearBeforeFill = true;
            // 
            // locationTableAdapter
            // 
            this.locationTableAdapter.ClearBeforeFill = true;
            // 
            // locationGroupTableAdapter
            // 
            this.locationGroupTableAdapter.ClearBeforeFill = true;
            // 
            // studentTableAdapter2
            // 
            this.studentTableAdapter2.ClearBeforeFill = true;
            // 
            // studentTableAdapter3
            // 
            this.studentTableAdapter3.ClearBeforeFill = true;
            // 
            // teacherTableAdapter
            // 
            this.teacherTableAdapter.ClearBeforeFill = true;
            // 
            // sessionTableAdapter
            // 
            this.sessionTableAdapter.ClearBeforeFill = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 477);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet80)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet81)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet62)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet60)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet61)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.locationGroupBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._time_table_managementDataSet63)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox txtAddProg;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtAddSubGroupId;
        private System.Windows.Forms.TextBox txtAddGroupId;
        private System.Windows.Forms.TextBox txtMGN;
        private System.Windows.Forms.TextBox txtMSGN;
        private System.Windows.Forms.ComboBox txtMProg;
        private System.Windows.Forms.Button btnMDelete;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnMClear;
        private System.Windows.Forms.Button btnMUpdate;
        private System.Windows.Forms.ComboBox txtAddAYS;
        private System.Windows.Forms.ComboBox txtAddGroupNo;
        private System.Windows.Forms.ComboBox txtAddSubGroupNo;
        private System.Windows.Forms.ComboBox txtMAYS;
        private System.Windows.Forms.ComboBox txtMGI;
        private System.Windows.Forms.ComboBox txtSGI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMSID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbGRoom;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button btnSaveG;
        private System.Windows.Forms.Button btnClearG;
        private System.Windows.Forms.ComboBox cmbGroup;
        private System.Windows.Forms.ComboBox cmbSubGroup;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.DataGridView dataGridView6;
        private _time_table_managementDataSet60 _time_table_managementDataSet60;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private _time_table_managementDataSet60TableAdapters.StudentTableAdapter studentTableAdapter;
        private _time_table_managementDataSet61 _time_table_managementDataSet61;
        private System.Windows.Forms.BindingSource studentBindingSource1;
        private _time_table_managementDataSet61TableAdapters.StudentTableAdapter studentTableAdapter1;
        private _time_table_managementDataSet62 _time_table_managementDataSet62;
        private System.Windows.Forms.BindingSource locationBindingSource;
        private _time_table_managementDataSet62TableAdapters.LocationTableAdapter locationTableAdapter;
        private _time_table_managementDataSet63 _time_table_managementDataSet63;
        private System.Windows.Forms.BindingSource locationGroupBindingSource;
        private _time_table_managementDataSet63TableAdapters.LocationGroupTableAdapter locationGroupTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNameDataGridViewTextBoxColumn;
        private _time_table_managementDataSet80 _time_table_managementDataSet80;
        private System.Windows.Forms.BindingSource studentBindingSource2;
        private _time_table_managementDataSet80TableAdapters.StudentTableAdapter studentTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicYearSemesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn programmeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupIDDataGridViewTextBoxColumn1;
        private _time_table_managementDataSet81 _time_table_managementDataSet81;
        private System.Windows.Forms.BindingSource studentBindingSource3;
        private _time_table_managementDataSet81TableAdapters.StudentTableAdapter studentTableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn academicYearSemesterDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn programmeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupIDDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn subGroupIDDataGridViewTextBoxColumn2;
        private _time_table_managementDataSet82TableAdapters.TeacherTableAdapter teacherTableAdapter;
        private _time_table_managementDataSet83TableAdapters.SessionTableAdapter sessionTableAdapter;
    }
}