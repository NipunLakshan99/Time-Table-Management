
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Student_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Academic_Year_Semester = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Programme = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Group_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Group_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(24, 271);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(742, 172);
            this.dataGridView2.TabIndex = 33;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Student_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Student_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Academic_Year_Semester";
            this.dataGridViewTextBoxColumn2.HeaderText = "Academic_Year_Semester";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Programme";
            this.dataGridViewTextBoxColumn3.HeaderText = "Programme";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Group_Number";
            this.dataGridViewTextBoxColumn4.HeaderText = "Group_Number";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Sub_Group_Number";
            this.dataGridViewTextBoxColumn5.HeaderText = "Sub_Group_Number";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Group_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "Group_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Sub_Group_ID";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sub_Group_ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Student_ID,
            this.Academic_Year_Semester,
            this.Programme,
            this.Group_Number,
            this.Sub_Group_Number,
            this.Group_ID,
            this.Sub_Group_ID});
            this.dataGridView1.Location = new System.Drawing.Point(14, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(750, 203);
            this.dataGridView1.TabIndex = 32;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Student_ID
            // 
            this.Student_ID.DataPropertyName = "Student_ID";
            this.Student_ID.HeaderText = "Student_ID";
            this.Student_ID.Name = "Student_ID";
            // 
            // Academic_Year_Semester
            // 
            this.Academic_Year_Semester.DataPropertyName = "Academic_Year_Semester";
            this.Academic_Year_Semester.HeaderText = "Academic_Year_Semester";
            this.Academic_Year_Semester.Name = "Academic_Year_Semester";
            // 
            // Programme
            // 
            this.Programme.DataPropertyName = "Programme";
            this.Programme.HeaderText = "Programme";
            this.Programme.Name = "Programme";
            // 
            // Group_Number
            // 
            this.Group_Number.DataPropertyName = "Group_Number";
            this.Group_Number.HeaderText = "Group_Number";
            this.Group_Number.Name = "Group_Number";
            // 
            // Sub_Group_Number
            // 
            this.Sub_Group_Number.DataPropertyName = "Sub_Group_Number";
            this.Sub_Group_Number.HeaderText = "Sub_Group_Number";
            this.Sub_Group_Number.Name = "Sub_Group_Number";
            // 
            // Group_ID
            // 
            this.Group_ID.DataPropertyName = "Group_ID";
            this.Group_ID.HeaderText = "Group_ID";
            this.Group_ID.Name = "Group_ID";
            // 
            // Sub_Group_ID
            // 
            this.Sub_Group_ID.DataPropertyName = "Sub_Group_ID";
            this.Sub_Group_ID.HeaderText = "Sub_Group_ID";
            this.Sub_Group_ID.Name = "Sub_Group_ID";
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
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 477);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Student_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Academic_Year_Semester;
        private System.Windows.Forms.DataGridViewTextBoxColumn Programme;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Group_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Group_ID;
        private System.Windows.Forms.ComboBox txtAddGroupNo;
        private System.Windows.Forms.ComboBox txtAddSubGroupNo;
        private System.Windows.Forms.ComboBox txtMAYS;
        private System.Windows.Forms.ComboBox txtMGI;
        private System.Windows.Forms.ComboBox txtSGI;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtMSID;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}