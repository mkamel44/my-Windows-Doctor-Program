namespace طب_اسنان
{
    partial class Form2
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
        	this.button1 = new System.Windows.Forms.Button();
        	this.button2 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button5 = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.label6 = new System.Windows.Forms.Label();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label3 = new System.Windows.Forms.Label();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.comboBox2 = new System.Windows.Forms.ComboBox();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(796, 466);
        	this.button1.Margin = new System.Windows.Forms.Padding(4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(127, 34);
        	this.button1.TabIndex = 205;
        	this.button1.Text = "اضافة الموعد";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(661, 466);
        	this.button2.Margin = new System.Windows.Forms.Padding(4);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(127, 34);
        	this.button2.TabIndex = 206;
        	this.button2.Text = "تعديل الموعد";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(391, 466);
        	this.button3.Margin = new System.Windows.Forms.Padding(4);
        	this.button3.Name = "button3";
        	this.button3.Size = new System.Drawing.Size(127, 34);
        	this.button3.TabIndex = 207;
        	this.button3.Text = "افراغ الحقول";
        	this.button3.UseVisualStyleBackColor = true;
        	this.button3.Click += new System.EventHandler(this.Button3Click);
        	// 
        	// button5
        	// 
        	this.button5.Location = new System.Drawing.Point(526, 466);
        	this.button5.Margin = new System.Windows.Forms.Padding(4);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(127, 34);
        	this.button5.TabIndex = 209;
        	this.button5.Text = "حذف الموعد";
        	this.button5.UseVisualStyleBackColor = true;
        	this.button5.Click += new System.EventHandler(this.Button5Click);
        	// 
        	// label1
        	// 
        	this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(865, 435);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(40, 19);
        	this.label1.TabIndex = 212;
        	this.label1.Text = "اليوم";
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(653, 435);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(83, 19);
        	this.label6.TabIndex = 214;
        	this.label6.Text = "من الساعة";
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(561, 432);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(86, 27);
        	this.textBox1.TabIndex = 215;
        	this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	this.textBox1.TextChanged += new System.EventHandler(this.TextBox1TextChanged);
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(466, 435);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(88, 19);
        	this.label2.TabIndex = 216;
        	this.label2.Text = "الى الساعة";
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(374, 432);
        	this.textBox2.Name = "textBox2";
        	this.textBox2.Size = new System.Drawing.Size(86, 27);
        	this.textBox2.TabIndex = 217;
        	this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        	this.textBox2.TextChanged += new System.EventHandler(this.TextBox2TextChanged);
        	// 
        	// label3
        	// 
        	this.label3.AutoSize = true;
        	this.label3.Location = new System.Drawing.Point(305, 435);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(58, 19);
        	this.label3.TabIndex = 218;
        	this.label3.Text = "المريض";
        	// 
        	// dataGridView1
        	// 
        	this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        	this.dataGridView1.AllowUserToAddRows = false;
        	this.dataGridView1.AllowUserToDeleteRows = false;
        	this.dataGridView1.AllowUserToResizeColumns = false;
        	this.dataGridView1.AllowUserToResizeRows = false;
        	this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
        	this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.dataGridViewTextBoxColumn1,
			this.dataGridViewTextBoxColumn2,
			this.dataGridViewTextBoxColumn3,
			this.Column7,
			this.Column8,
			this.Column1});
        	this.dataGridView1.Location = new System.Drawing.Point(12, 9);
        	this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
        	this.dataGridView1.MultiSelect = false;
        	this.dataGridView1.Name = "dataGridView1";
        	this.dataGridView1.ReadOnly = true;
        	this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.dataGridView1.RowHeadersVisible = false;
        	this.dataGridView1.RowTemplate.Height = 25;
        	this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dataGridView1.ShowCellToolTips = false;
        	this.dataGridView1.ShowEditingIcon = false;
        	this.dataGridView1.Size = new System.Drawing.Size(911, 414);
        	this.dataGridView1.TabIndex = 220;
        	this.dataGridView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView1MouseClick);
        	// 
        	// dataGridViewTextBoxColumn1
        	// 
        	this.dataGridViewTextBoxColumn1.HeaderText = "الرقم";
        	this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        	this.dataGridViewTextBoxColumn1.ReadOnly = true;
        	this.dataGridViewTextBoxColumn1.Visible = false;
        	// 
        	// dataGridViewTextBoxColumn2
        	// 
        	this.dataGridViewTextBoxColumn2.FillWeight = 83.92642F;
        	this.dataGridViewTextBoxColumn2.HeaderText = "اليوم";
        	this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        	this.dataGridViewTextBoxColumn2.ReadOnly = true;
        	// 
        	// dataGridViewTextBoxColumn3
        	// 
        	this.dataGridViewTextBoxColumn3.FillWeight = 60.25528F;
        	this.dataGridViewTextBoxColumn3.HeaderText = "من";
        	this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        	this.dataGridViewTextBoxColumn3.ReadOnly = true;
        	// 
        	// Column7
        	// 
        	this.Column7.FillWeight = 63.52464F;
        	this.Column7.HeaderText = "الى";
        	this.Column7.Name = "Column7";
        	this.Column7.ReadOnly = true;
        	// 
        	// Column8
        	// 
        	this.Column8.FillWeight = 205.6313F;
        	this.Column8.HeaderText = "المريض";
        	this.Column8.Name = "Column8";
        	this.Column8.ReadOnly = true;
        	// 
        	// Column1
        	// 
        	this.Column1.FillWeight = 13.66693F;
        	this.Column1.HeaderText = "رقم المريض";
        	this.Column1.Name = "Column1";
        	this.Column1.ReadOnly = true;
        	this.Column1.Visible = false;
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Items.AddRange(new object[] {
			"السبت",
			"الاحد",
			"الاثنين",
			"الثلاثاء",
			"الاربعاء",
			"الخميس",
			"الجمعة"});
        	this.comboBox1.Location = new System.Drawing.Point(742, 432);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.comboBox1.Size = new System.Drawing.Size(121, 27);
        	this.comboBox1.TabIndex = 222;
        	// 
        	// comboBox2
        	// 
        	this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        	this.comboBox2.FormattingEnabled = true;
        	this.comboBox2.Location = new System.Drawing.Point(12, 432);
        	this.comboBox2.Name = "comboBox2";
        	this.comboBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.comboBox2.Size = new System.Drawing.Size(287, 27);
        	this.comboBox2.TabIndex = 223;
        	// 
        	// Form2
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(934, 506);
        	this.Controls.Add(this.comboBox2);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.button5);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.button1);
        	this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "Form2";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "المواعيد";
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}