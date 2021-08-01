namespace طب_اسنان
{
    partial class Form9
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
        	this.dataGridView2 = new System.Windows.Forms.DataGridView();
        	this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.button1 = new System.Windows.Forms.Button();
        	this.button3 = new System.Windows.Forms.Button();
        	this.button5 = new System.Windows.Forms.Button();
        	this.dataGridView1 = new System.Windows.Forms.DataGridView();
        	this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
        	this.label6 = new System.Windows.Forms.Label();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.textBox2 = new System.Windows.Forms.TextBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.button4 = new System.Windows.Forms.Button();
        	this.pictureBox1 = new System.Windows.Forms.PictureBox();
        	this.button2 = new System.Windows.Forms.Button();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// dataGridView2
        	// 
        	this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
        	this.dataGridView2.AllowUserToAddRows = false;
        	this.dataGridView2.AllowUserToDeleteRows = false;
        	this.dataGridView2.AllowUserToResizeColumns = false;
        	this.dataGridView2.AllowUserToResizeRows = false;
        	this.dataGridView2.Anchor = System.Windows.Forms.AnchorStyles.None;
        	this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        	this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        	this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4,
			this.Column5,
			this.Column6});
        	this.dataGridView2.Location = new System.Drawing.Point(12, 5);
        	this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
        	this.dataGridView2.MultiSelect = false;
        	this.dataGridView2.Name = "dataGridView2";
        	this.dataGridView2.ReadOnly = true;
        	this.dataGridView2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.dataGridView2.RowHeadersVisible = false;
        	this.dataGridView2.RowTemplate.Height = 25;
        	this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        	this.dataGridView2.ShowCellToolTips = false;
        	this.dataGridView2.ShowEditingIcon = false;
        	this.dataGridView2.Size = new System.Drawing.Size(902, 201);
        	this.dataGridView2.TabIndex = 18;
        	this.dataGridView2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DataGridView2SelectionChanged);
        	// 
        	// Column1
        	// 
        	this.Column1.HeaderText = "الرقم";
        	this.Column1.Name = "Column1";
        	this.Column1.ReadOnly = true;
        	this.Column1.Visible = false;
        	// 
        	// Column2
        	// 
        	this.Column2.FillWeight = 83.7121F;
        	this.Column2.HeaderText = "اسم المريض";
        	this.Column2.Name = "Column2";
        	this.Column2.ReadOnly = true;
        	// 
        	// Column3
        	// 
        	this.Column3.FillWeight = 101.5229F;
        	this.Column3.HeaderText = "اسم الأب";
        	this.Column3.Name = "Column3";
        	this.Column3.ReadOnly = true;
        	// 
        	// Column4
        	// 
        	this.Column4.FillWeight = 94.88133F;
        	this.Column4.HeaderText = "اسم الأم";
        	this.Column4.Name = "Column4";
        	this.Column4.ReadOnly = true;
        	// 
        	// Column5
        	// 
        	this.Column5.FillWeight = 109.9419F;
        	this.Column5.HeaderText = "العمر";
        	this.Column5.Name = "Column5";
        	this.Column5.ReadOnly = true;
        	// 
        	// Column6
        	// 
        	this.Column6.FillWeight = 109.9419F;
        	this.Column6.HeaderText = "متزوج ام لا";
        	this.Column6.Name = "Column6";
        	this.Column6.ReadOnly = true;
        	// 
        	// button1
        	// 
        	this.button1.Location = new System.Drawing.Point(781, 529);
        	this.button1.Margin = new System.Windows.Forms.Padding(4);
        	this.button1.Name = "button1";
        	this.button1.Size = new System.Drawing.Size(127, 34);
        	this.button1.TabIndex = 205;
        	this.button1.Text = "اضافة تشخيص";
        	this.button1.UseVisualStyleBackColor = true;
        	this.button1.Click += new System.EventHandler(this.Button1Click);
        	// 
        	// button3
        	// 
        	this.button3.Location = new System.Drawing.Point(376, 529);
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
        	this.button5.Location = new System.Drawing.Point(511, 529);
        	this.button5.Margin = new System.Windows.Forms.Padding(4);
        	this.button5.Name = "button5";
        	this.button5.Size = new System.Drawing.Size(127, 34);
        	this.button5.TabIndex = 209;
        	this.button5.Text = "حذف تشخيص";
        	this.button5.UseVisualStyleBackColor = true;
        	this.button5.Click += new System.EventHandler(this.Button5Click);
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
			this.Column7});
        	this.dataGridView1.Location = new System.Drawing.Point(199, 218);
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
        	this.dataGridView1.Size = new System.Drawing.Size(715, 209);
        	this.dataGridView1.TabIndex = 211;
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
        	this.dataGridViewTextBoxColumn2.FillWeight = 30.3006F;
        	this.dataGridViewTextBoxColumn2.HeaderText = "السن";
        	this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
        	this.dataGridViewTextBoxColumn2.ReadOnly = true;
        	// 
        	// dataGridViewTextBoxColumn3
        	// 
        	this.dataGridViewTextBoxColumn3.FillWeight = 96.70404F;
        	this.dataGridViewTextBoxColumn3.HeaderText = "تشخيص السن";
        	this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
        	this.dataGridViewTextBoxColumn3.ReadOnly = true;
        	// 
        	// Column7
        	// 
        	this.Column7.HeaderText = "الصورة";
        	this.Column7.Name = "Column7";
        	this.Column7.ReadOnly = true;
        	this.Column7.Visible = false;
        	// 
        	// label6
        	// 
        	this.label6.AutoSize = true;
        	this.label6.Location = new System.Drawing.Point(797, 439);
        	this.label6.Name = "label6";
        	this.label6.Size = new System.Drawing.Size(88, 19);
        	this.label6.TabIndex = 214;
        	this.label6.Text = "ما هو السن";
        	// 
        	// textBox1
        	// 
        	this.textBox1.Location = new System.Drawing.Point(201, 436);
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(590, 27);
        	this.textBox1.TabIndex = 215;
        	this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
        	// 
        	// textBox2
        	// 
        	this.textBox2.Location = new System.Drawing.Point(10, 472);
        	this.textBox2.Multiline = true;
        	this.textBox2.Name = "textBox2";
        	this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
        	this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        	this.textBox2.Size = new System.Drawing.Size(781, 50);
        	this.textBox2.TabIndex = 217;
        	// 
        	// label2
        	// 
        	this.label2.AutoSize = true;
        	this.label2.Location = new System.Drawing.Point(797, 469);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(109, 19);
        	this.label2.TabIndex = 216;
        	this.label2.Text = "تشخيص السن";
        	// 
        	// button4
        	// 
        	this.button4.Location = new System.Drawing.Point(13, 431);
        	this.button4.Margin = new System.Windows.Forms.Padding(4);
        	this.button4.Name = "button4";
        	this.button4.Size = new System.Drawing.Size(182, 34);
        	this.button4.TabIndex = 218;
        	this.button4.Text = "استعراض صورة الاشعة";
        	this.button4.UseVisualStyleBackColor = true;
        	this.button4.Click += new System.EventHandler(this.Button4Click);
        	// 
        	// pictureBox1
        	// 
        	this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
        	this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
        	this.pictureBox1.InitialImage = null;
        	this.pictureBox1.Location = new System.Drawing.Point(13, 218);
        	this.pictureBox1.Name = "pictureBox1";
        	this.pictureBox1.Size = new System.Drawing.Size(182, 209);
        	this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
        	this.pictureBox1.TabIndex = 219;
        	this.pictureBox1.TabStop = false;
        	// 
        	// button2
        	// 
        	this.button2.Location = new System.Drawing.Point(646, 529);
        	this.button2.Margin = new System.Windows.Forms.Padding(4);
        	this.button2.Name = "button2";
        	this.button2.Size = new System.Drawing.Size(127, 34);
        	this.button2.TabIndex = 220;
        	this.button2.Text = "تعديل التشخيص";
        	this.button2.UseVisualStyleBackColor = true;
        	this.button2.Click += new System.EventHandler(this.Button2Click);
        	// 
        	// Form9
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(919, 576);
        	this.Controls.Add(this.button2);
        	this.Controls.Add(this.pictureBox1);
        	this.Controls.Add(this.button4);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.textBox2);
        	this.Controls.Add(this.label6);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.dataGridView1);
        	this.Controls.Add(this.button5);
        	this.Controls.Add(this.button3);
        	this.Controls.Add(this.button1);
        	this.Controls.Add(this.dataGridView2);
        	this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        	this.Margin = new System.Windows.Forms.Padding(4);
        	this.MaximizeBox = false;
        	this.MinimizeBox = false;
        	this.Name = "Form9";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "التشخيص";
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
        	this.ResumeLayout(false);
        	this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button button2;
    }
}