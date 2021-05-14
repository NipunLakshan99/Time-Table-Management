
namespace TimeTable
{
    partial class Form4
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTagName = new System.Windows.Forms.ComboBox();
            this.txtTagCode = new System.Windows.Forms.ComboBox();
            this.txtRelatedTag = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMTagName = new System.Windows.Forms.ComboBox();
            this.txtMTagCode = new System.Windows.Forms.ComboBox();
            this.txtMRelatedTag = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnMClear = new System.Windows.Forms.Button();
            this.btnMDelete = new System.Windows.Forms.Button();
            this.btnMUpdate = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtMTagID = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnClear);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.txtRelatedTag);
            this.tabPage1.Controls.Add(this.txtTagCode);
            this.tabPage1.Controls.Add(this.txtTagName);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ADD TAGS";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.tabPage2.Controls.Add(this.txtMTagID);
            this.tabPage2.Controls.Add(this.btnMUpdate);
            this.tabPage2.Controls.Add(this.btnMDelete);
            this.tabPage2.Controls.Add(this.btnMClear);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.txtMRelatedTag);
            this.tabPage2.Controls.Add(this.txtMTagCode);
            this.tabPage2.Controls.Add(this.txtMTagName);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MANAGE TAGS";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "SUBJECT NAME";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "SUBJECT CODE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(59, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "RELATED TAG";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(46, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "TAG_ID";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtTagName
            // 
            this.txtTagName.FormattingEnabled = true;
            this.txtTagName.Items.AddRange(new object[] {
            "Introduction to Programmong",
            "",
            "Information & Communication System",
            "",
            "Communication Skills",
            "",
            "IWT",
            "",
            "DBMS",
            "",
            "Network Design Management",
            "",
            "Database System",
            "",
            "ITP",
            "",
            "ITPM"});
            this.txtTagName.Location = new System.Drawing.Point(256, 39);
            this.txtTagName.Name = "txtTagName";
            this.txtTagName.Size = new System.Drawing.Size(221, 21);
            this.txtTagName.TabIndex = 4;
            // 
            // txtTagCode
            // 
            this.txtTagCode.FormattingEnabled = true;
            this.txtTagCode.Items.AddRange(new object[] {
            "IT1010",
            "",
            "IT1020",
            "",
            "IT1030",
            "",
            "IT1040",
            "",
            "IT1050",
            "",
            "IT2010",
            "",
            "IT2020",
            "",
            "IT2030",
            "",
            "IT2040",
            "",
            "IT2050",
            "",
            "IT3010",
            "",
            "IT3020",
            "",
            "IT3030",
            "",
            "IT3040",
            "",
            "IT3050"});
            this.txtTagCode.Location = new System.Drawing.Point(256, 107);
            this.txtTagCode.Name = "txtTagCode";
            this.txtTagCode.Size = new System.Drawing.Size(221, 21);
            this.txtTagCode.TabIndex = 5;
            // 
            // txtRelatedTag
            // 
            this.txtRelatedTag.FormattingEnabled = true;
            this.txtRelatedTag.Items.AddRange(new object[] {
            "Lectuer",
            "",
            "Lab/Practical",
            "",
            "Tute"});
            this.txtRelatedTag.Location = new System.Drawing.Point(256, 175);
            this.txtRelatedTag.Name = "txtRelatedTag";
            this.txtRelatedTag.Size = new System.Drawing.Size(221, 21);
            this.txtRelatedTag.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSave.Location = new System.Drawing.Point(593, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 33);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClear.Location = new System.Drawing.Point(593, 39);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 33);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "CLEAR";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(46, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "SUBJECT NAME";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(46, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "SUBJECT CODE";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(46, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "RELATED TAG";
            // 
            // txtMTagName
            // 
            this.txtMTagName.FormattingEnabled = true;
            this.txtMTagName.Items.AddRange(new object[] {
            "Introduction to Programmong",
            "",
            "Information & Communication System",
            "",
            "Communication Skills",
            "",
            "IWT",
            "",
            "DBMS",
            "",
            "Network Design Management",
            "",
            "Database System",
            "",
            "ITP",
            "",
            "ITPM"});
            this.txtMTagName.Location = new System.Drawing.Point(240, 81);
            this.txtMTagName.Name = "txtMTagName";
            this.txtMTagName.Size = new System.Drawing.Size(221, 21);
            this.txtMTagName.TabIndex = 8;
            // 
            // txtMTagCode
            // 
            this.txtMTagCode.FormattingEnabled = true;
            this.txtMTagCode.Items.AddRange(new object[] {
            "IT1010",
            "",
            "IT1020",
            "",
            "IT1030",
            "",
            "IT1040",
            "",
            "IT1050",
            "",
            "IT2010",
            "",
            "IT2020",
            "",
            "IT2030",
            "",
            "IT2040",
            "",
            "IT2050",
            "",
            "IT3010",
            "",
            "IT3020",
            "",
            "IT3030",
            "",
            "IT3040",
            "",
            "IT3050"});
            this.txtMTagCode.Location = new System.Drawing.Point(240, 138);
            this.txtMTagCode.Name = "txtMTagCode";
            this.txtMTagCode.Size = new System.Drawing.Size(221, 21);
            this.txtMTagCode.TabIndex = 9;
            // 
            // txtMRelatedTag
            // 
            this.txtMRelatedTag.FormattingEnabled = true;
            this.txtMRelatedTag.Items.AddRange(new object[] {
            "Lectuer",
            "",
            "Lab/Practical",
            "",
            "Tute"});
            this.txtMRelatedTag.Location = new System.Drawing.Point(240, 191);
            this.txtMRelatedTag.Name = "txtMRelatedTag";
            this.txtMRelatedTag.Size = new System.Drawing.Size(221, 21);
            this.txtMRelatedTag.TabIndex = 10;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(162, 229);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(441, 150);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // btnMClear
            // 
            this.btnMClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMClear.Location = new System.Drawing.Point(610, 34);
            this.btnMClear.Name = "btnMClear";
            this.btnMClear.Size = new System.Drawing.Size(101, 30);
            this.btnMClear.TabIndex = 32;
            this.btnMClear.Text = "CLEAR";
            this.btnMClear.UseVisualStyleBackColor = false;
            this.btnMClear.Click += new System.EventHandler(this.btnMClear_Click);
            // 
            // btnMDelete
            // 
            this.btnMDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMDelete.Location = new System.Drawing.Point(610, 97);
            this.btnMDelete.Name = "btnMDelete";
            this.btnMDelete.Size = new System.Drawing.Size(101, 30);
            this.btnMDelete.TabIndex = 33;
            this.btnMDelete.Text = "DELETE";
            this.btnMDelete.UseVisualStyleBackColor = false;
            this.btnMDelete.Click += new System.EventHandler(this.btnMDelete_Click);
            // 
            // btnMUpdate
            // 
            this.btnMUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMUpdate.Location = new System.Drawing.Point(610, 164);
            this.btnMUpdate.Name = "btnMUpdate";
            this.btnMUpdate.Size = new System.Drawing.Size(101, 30);
            this.btnMUpdate.TabIndex = 34;
            this.btnMUpdate.Text = "UPDATE";
            this.btnMUpdate.UseVisualStyleBackColor = false;
            this.btnMUpdate.Click += new System.EventHandler(this.btnMUpdate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(157, 236);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 150);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtMTagID
            // 
            this.txtMTagID.Location = new System.Drawing.Point(240, 34);
            this.txtMTagID.Name = "txtMTagID";
            this.txtMTagID.Size = new System.Drawing.Size(221, 20);
            this.txtMTagID.TabIndex = 35;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txtRelatedTag;
        private System.Windows.Forms.ComboBox txtTagCode;
        private System.Windows.Forms.ComboBox txtTagName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox txtMRelatedTag;
        private System.Windows.Forms.ComboBox txtMTagCode;
        private System.Windows.Forms.ComboBox txtMTagName;
        private System.Windows.Forms.Button btnMClear;
        private System.Windows.Forms.Button btnMDelete;
        private System.Windows.Forms.Button btnMUpdate;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtMTagID;
    }
}