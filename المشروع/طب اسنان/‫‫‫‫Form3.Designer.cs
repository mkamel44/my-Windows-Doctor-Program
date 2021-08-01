namespace طب_اسنان
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
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column2 = new System.Windows.Forms.DataGridViewButtonColumn();
        	this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.label1 = new System.Windows.Forms.Label();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	this.SuspendLayout();
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
			this.dataGridViewTextBoxColumn3,
			this.Column7,
			this.Column8,
			this.Column1,
			this.Column2,
			this.Column3});
        	this.dataGridView1.Location = new System.Drawing.Point(15, 47);
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
        	this.dataGridView1.Size = new System.Drawing.Size(543, 406);
        	this.dataGridView1.TabIndex = 220;
        	this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1CellContentClick);
        	// 
        	// dataGridViewTextBoxColumn1
        	// 
        	this.dataGridViewTextBoxColumn1.HeaderText = "الرقم";
        	this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
        	this.dataGridViewTextBoxColumn1.ReadOnly = true;
        	this.dataGridViewTextBoxColumn1.Visible = false;
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
        	// Column2
        	// 
        	this.Column2.FlatStyle = System.Windows.Forms.FlatStyle.System;
        	this.Column2.HeaderText = "تم";
        	this.Column2.Name = "Column2";
        	this.Column2.ReadOnly = true;
        	this.Column2.Text = "تم";
        	// 
        	// Column3
        	// 
        	this.Column3.HeaderText = "لم يتم";
        	this.Column3.Name = "Column3";
        	this.Column3.ReadOnly = true;
        	this.Column3.Text = "لم يتم";
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
			"الأربعاء",
			"الخميس",
			"الجمعة"});
        	this.comboBox1.Location = new System.Drawing.Point(168, 11);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.comboBox1.Size = new System.Drawing.Size(162, 32);
        	this.comboBox1.TabIndex = 221;
        	this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
        	// 
        	// label1
        	// 
        	this.label1.Location = new System.Drawing.Point(336, 14);
        	this.label1.Name = "label1";
        	this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.label1.Size = new System.Drawing.Size(89, 23);
        	this.label1.TabIndex = 222;
        	this.label1.Text = "اختر اليوم";
        	// 
        	// Form3
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(573, 468);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.dataGridView1);
        	this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "Form3";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "المواعيد";
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewButtonColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}