
namespace TimeTable
{
    partial class Location
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
            this.txtLRoomname = new System.Windows.Forms.TextBox();
            this.txtLcapacity = new System.Windows.Forms.TextBox();
            this.txtbuildname = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Capacity = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLocsave = new System.Windows.Forms.Button();
            this.radioLlab = new System.Windows.Forms.RadioButton();
            this.radioLlechall = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txtlocID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLUpdate = new System.Windows.Forms.Button();
            this.btnLDelete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLUCapacity = new System.Windows.Forms.TextBox();
            this.txtLURoomname = new System.Windows.Forms.TextBox();
            this.radioLUlab = new System.Windows.Forms.RadioButton();
            this.radioLulechall = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLUbuildingname = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtAddNWD = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1067, 554);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.txtLRoomname);
            this.tabPage1.Controls.Add(this.txtLcapacity);
            this.tabPage1.Controls.Add(this.txtbuildname);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.Capacity);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.btnLocsave);
            this.tabPage1.Controls.Add(this.radioLlab);
            this.tabPage1.Controls.Add(this.radioLlechall);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1059, 525);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD LOCATION";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtLRoomname
            // 
            this.txtLRoomname.Location = new System.Drawing.Point(719, 42);
            this.txtLRoomname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLRoomname.Name = "txtLRoomname";
            this.txtLRoomname.Size = new System.Drawing.Size(252, 22);
            this.txtLRoomname.TabIndex = 31;
            // 
            // txtLcapacity
            // 
            this.txtLcapacity.Location = new System.Drawing.Point(719, 126);
            this.txtLcapacity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLcapacity.Name = "txtLcapacity";
            this.txtLcapacity.Size = new System.Drawing.Size(252, 22);
            this.txtLcapacity.TabIndex = 30;
            // 
            // txtbuildname
            // 
            this.txtbuildname.Location = new System.Drawing.Point(217, 42);
            this.txtbuildname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtbuildname.Name = "txtbuildname";
            this.txtbuildname.Size = new System.Drawing.Size(263, 22);
            this.txtbuildname.TabIndex = 29;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(11, 250);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1035, 262);
            this.dataGridView2.TabIndex = 28;
            this.dataGridView2.Click += new System.EventHandler(this.dataGridView2_Click);
            // 
            // Capacity
            // 
            this.Capacity.AutoSize = true;
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacity.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.Capacity.Location = new System.Drawing.Point(569, 130);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(97, 25);
            this.Capacity.TabIndex = 27;
            this.Capacity.Text = "Capacity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Location = new System.Drawing.Point(36, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Room Type";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Location = new System.Drawing.Point(491, 194);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 41);
            this.button3.TabIndex = 25;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnLocsave
            // 
            this.btnLocsave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLocsave.Location = new System.Drawing.Point(345, 194);
            this.btnLocsave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLocsave.Name = "btnLocsave";
            this.btnLocsave.Size = new System.Drawing.Size(100, 41);
            this.btnLocsave.TabIndex = 24;
            this.btnLocsave.Text = "SAVE";
            this.btnLocsave.UseVisualStyleBackColor = false;
            this.btnLocsave.Click += new System.EventHandler(this.btnLocsave_Click);
            // 
            // radioLlab
            // 
            this.radioLlab.AutoSize = true;
            this.radioLlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLlab.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioLlab.Location = new System.Drawing.Point(388, 126);
            this.radioLlab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioLlab.Name = "radioLlab";
            this.radioLlab.Size = new System.Drawing.Size(136, 29);
            this.radioLlab.TabIndex = 21;
            this.radioLlab.TabStop = true;
            this.radioLlab.Text = "Laboratory";
            this.radioLlab.UseVisualStyleBackColor = true;
            this.radioLlab.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioLlechall
            // 
            this.radioLlechall.AutoSize = true;
            this.radioLlechall.Checked = true;
            this.radioLlechall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLlechall.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioLlechall.Location = new System.Drawing.Point(217, 126);
            this.radioLlechall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioLlechall.Name = "radioLlechall";
            this.radioLlechall.Size = new System.Drawing.Size(148, 29);
            this.radioLlechall.TabIndex = 20;
            this.radioLlechall.TabStop = true;
            this.radioLlechall.Text = "Lecture Hall";
            this.radioLlechall.UseVisualStyleBackColor = true;
            this.radioLlechall.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(548, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Room Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(36, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Building Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtlocID);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.btnLUpdate);
            this.tabPage2.Controls.Add(this.btnLDelete);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtLUCapacity);
            this.tabPage2.Controls.Add(this.txtLURoomname);
            this.tabPage2.Controls.Add(this.radioLUlab);
            this.tabPage2.Controls.Add(this.radioLulechall);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtLUbuildingname);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1059, 525);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MANAGE LOCATION";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(60, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 25);
            this.label4.TabIndex = 78;
            this.label4.Text = "Location ID";
            // 
            // txtlocID
            // 
            this.txtlocID.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.txtlocID.Location = new System.Drawing.Point(325, 34);
            this.txtlocID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtlocID.Multiline = true;
            this.txtlocID.Name = "txtlocID";
            this.txtlocID.Size = new System.Drawing.Size(297, 35);
            this.txtlocID.TabIndex = 77;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button4.Location = new System.Drawing.Point(636, 214);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 37);
            this.button4.TabIndex = 76;
            this.button4.Text = "REFRESH";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnLUpdate
            // 
            this.btnLUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLUpdate.Location = new System.Drawing.Point(188, 214);
            this.btnLUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLUpdate.Name = "btnLUpdate";
            this.btnLUpdate.Size = new System.Drawing.Size(116, 37);
            this.btnLUpdate.TabIndex = 75;
            this.btnLUpdate.Text = "UPDATE";
            this.btnLUpdate.UseVisualStyleBackColor = false;
            this.btnLUpdate.Click += new System.EventHandler(this.btnLUpdate_Click);
            // 
            // btnLDelete
            // 
            this.btnLDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnLDelete.Location = new System.Drawing.Point(427, 214);
            this.btnLDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLDelete.Name = "btnLDelete";
            this.btnLDelete.Size = new System.Drawing.Size(116, 37);
            this.btnLDelete.TabIndex = 74;
            this.btnLDelete.Text = "DELETE";
            this.btnLDelete.UseVisualStyleBackColor = false;
            this.btnLDelete.Click += new System.EventHandler(this.btnLDelete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(65, 258);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(905, 235);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(673, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Capacity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(660, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Room Type";
            // 
            // txtLUCapacity
            // 
            this.txtLUCapacity.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.txtLUCapacity.Location = new System.Drawing.Point(839, 140);
            this.txtLUCapacity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLUCapacity.Multiline = true;
            this.txtLUCapacity.Name = "txtLUCapacity";
            this.txtLUCapacity.Size = new System.Drawing.Size(176, 35);
            this.txtLUCapacity.TabIndex = 34;
            this.txtLUCapacity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtLURoomname
            // 
            this.txtLURoomname.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.txtLURoomname.Location = new System.Drawing.Point(325, 140);
            this.txtLURoomname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLURoomname.Multiline = true;
            this.txtLURoomname.Name = "txtLURoomname";
            this.txtLURoomname.Size = new System.Drawing.Size(297, 35);
            this.txtLURoomname.TabIndex = 33;
            // 
            // radioLUlab
            // 
            this.radioLUlab.AutoSize = true;
            this.radioLUlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLUlab.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioLUlab.Location = new System.Drawing.Point(839, 71);
            this.radioLUlab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioLUlab.Name = "radioLUlab";
            this.radioLUlab.Size = new System.Drawing.Size(136, 29);
            this.radioLUlab.TabIndex = 32;
            this.radioLUlab.TabStop = true;
            this.radioLUlab.Text = "Laboratory";
            this.radioLUlab.UseVisualStyleBackColor = true;
            this.radioLUlab.CheckedChanged += new System.EventHandler(this.radioLUlab_CheckedChanged);
            // 
            // radioLulechall
            // 
            this.radioLulechall.AutoSize = true;
            this.radioLulechall.Checked = true;
            this.radioLulechall.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioLulechall.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.radioLulechall.Location = new System.Drawing.Point(839, 14);
            this.radioLulechall.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioLulechall.Name = "radioLulechall";
            this.radioLulechall.Size = new System.Drawing.Size(159, 29);
            this.radioLulechall.TabIndex = 31;
            this.radioLulechall.TabStop = true;
            this.radioLulechall.Text = "Lecture Halls";
            this.radioLulechall.UseVisualStyleBackColor = true;
            this.radioLulechall.CheckedChanged += new System.EventHandler(this.radioLulechall_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(60, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 25);
            this.label7.TabIndex = 30;
            this.label7.Text = "Room Name";
            // 
            // txtLUbuildingname
            // 
            this.txtLUbuildingname.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.txtLUbuildingname.Location = new System.Drawing.Point(325, 86);
            this.txtLUbuildingname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLUbuildingname.Multiline = true;
            this.txtLUbuildingname.Name = "txtLUbuildingname";
            this.txtLUbuildingname.Size = new System.Drawing.Size(297, 35);
            this.txtLUbuildingname.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(60, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 25);
            this.label8.TabIndex = 28;
            this.label8.Text = "Building Name";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Controls.Add(this.comboBox2);
            this.tabPage3.Controls.Add(this.comboBox1);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.textBox2);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.txtAddNWD);
            this.tabPage3.Controls.Add(this.textBox1);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1059, 525);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NOT AVAILABLE TIMES";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(40, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 25);
            this.label9.TabIndex = 79;
            this.label9.Text = "Select Room";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label10.Location = new System.Drawing.Point(569, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 25);
            this.label10.TabIndex = 81;
            this.label10.Text = "Select Day";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.textBox1.Location = new System.Drawing.Point(210, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 33);
            this.textBox1.TabIndex = 82;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // txtAddNWD
            // 
            this.txtAddNWD.FormattingEnabled = true;
            this.txtAddNWD.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.txtAddNWD.Location = new System.Drawing.Point(788, 43);
            this.txtAddNWD.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddNWD.Name = "txtAddNWD";
            this.txtAddNWD.Size = new System.Drawing.Size(210, 24);
            this.txtAddNWD.TabIndex = 83;
            this.txtAddNWD.SelectedIndexChanged += new System.EventHandler(this.txtAddNWD_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label11.Location = new System.Drawing.Point(40, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 25);
            this.label11.TabIndex = 84;
            this.label11.Text = "Start Time";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label12.Location = new System.Drawing.Point(569, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 25);
            this.label12.TabIndex = 85;
            this.label12.Text = "End Time";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // textBox2
            // 
            this.textBox2.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.textBox2.Location = new System.Drawing.Point(210, 119);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 33);
            this.textBox2.TabIndex = 86;
            // 
            // textBox3
            // 
            this.textBox3.Cursor = System.Windows.Forms.Cursors.PanWest;
            this.textBox3.Location = new System.Drawing.Point(742, 107);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(167, 33);
            this.textBox3.TabIndex = 87;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox1.Location = new System.Drawing.Point(427, 127);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 24);
            this.comboBox1.TabIndex = 88;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comboBox2.Location = new System.Drawing.Point(945, 115);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(80, 24);
            this.comboBox2.TabIndex = 89;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Location = new System.Drawing.Point(382, 207);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 90;
            this.button1.Text = "Add Session";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button2.Location = new System.Drawing.Point(557, 207);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 37);
            this.button2.TabIndex = 91;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Location";
            this.Text = "Location";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton radioLlab;
        private System.Windows.Forms.RadioButton radioLlechall;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLocsave;
        private System.Windows.Forms.Label Capacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLUCapacity;
        private System.Windows.Forms.TextBox txtLURoomname;
        private System.Windows.Forms.RadioButton radioLUlab;
        private System.Windows.Forms.RadioButton radioLulechall;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLUbuildingname;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLUpdate;
        private System.Windows.Forms.Button btnLDelete;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox txtLRoomname;
        private System.Windows.Forms.TextBox txtLcapacity;
        private System.Windows.Forms.TextBox txtbuildname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtlocID;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox txtAddNWD;
    }
}