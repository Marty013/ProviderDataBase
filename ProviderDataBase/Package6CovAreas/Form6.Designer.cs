namespace TicketReservationSystem
{
	partial class Form6
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
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.agreementOk = new System.Windows.Forms.Button();
			this.num_house = new System.Windows.Forms.NumericUpDown();
			this.street = new System.Windows.Forms.TextBox();
			this.district = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.btn_coverage_area_del = new System.Windows.Forms.Button();
			this.btn_coverage_area_add = new System.Windows.Forms.Button();
			this.coverage_areas_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn41 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn42 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn43 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn44 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox6.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_house)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.coverage_areas_list)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox6
			// 
			this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox6.Controls.Add(this.agreementOk);
			this.groupBox6.Controls.Add(this.num_house);
			this.groupBox6.Controls.Add(this.street);
			this.groupBox6.Controls.Add(this.district);
			this.groupBox6.Controls.Add(this.label35);
			this.groupBox6.Controls.Add(this.label34);
			this.groupBox6.Controls.Add(this.label33);
			this.groupBox6.Controls.Add(this.btn_coverage_area_del);
			this.groupBox6.Controls.Add(this.btn_coverage_area_add);
			this.groupBox6.Location = new System.Drawing.Point(523, 12);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(249, 208);
			this.groupBox6.TabIndex = 21;
			this.groupBox6.TabStop = false;
			// 
			// agreementOk
			// 
			this.agreementOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.agreementOk.Font = new System.Drawing.Font("Snap ITC", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
			this.agreementOk.Location = new System.Drawing.Point(9, 146);
			this.agreementOk.Name = "agreementOk";
			this.agreementOk.Size = new System.Drawing.Size(108, 56);
			this.agreementOk.TabIndex = 24;
			this.agreementOk.Text = "выбрать";
			this.agreementOk.UseVisualStyleBackColor = true;
			// 
			// num_house
			// 
			this.num_house.Location = new System.Drawing.Point(88, 71);
			this.num_house.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.num_house.Name = "num_house";
			this.num_house.Size = new System.Drawing.Size(155, 20);
			this.num_house.TabIndex = 5;
			// 
			// street
			// 
			this.street.Location = new System.Drawing.Point(56, 45);
			this.street.MaxLength = 30;
			this.street.Name = "street";
			this.street.Size = new System.Drawing.Size(187, 20);
			this.street.TabIndex = 4;
			// 
			// district
			// 
			this.district.Location = new System.Drawing.Point(56, 19);
			this.district.MaxLength = 30;
			this.district.Name = "district";
			this.district.Size = new System.Drawing.Size(187, 20);
			this.district.TabIndex = 3;
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(6, 76);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(76, 13);
			this.label35.TabIndex = 25;
			this.label35.Text = "Номер дома :";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(5, 48);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(45, 13);
			this.label34.TabIndex = 25;
			this.label34.Text = "Улица :";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(6, 19);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(44, 13);
			this.label33.TabIndex = 25;
			this.label33.Text = "Район :";
			// 
			// btn_coverage_area_del
			// 
			this.btn_coverage_area_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_coverage_area_del.Location = new System.Drawing.Point(123, 177);
			this.btn_coverage_area_del.Name = "btn_coverage_area_del";
			this.btn_coverage_area_del.Size = new System.Drawing.Size(120, 25);
			this.btn_coverage_area_del.TabIndex = 8;
			this.btn_coverage_area_del.Text = "удалить зону";
			this.btn_coverage_area_del.UseVisualStyleBackColor = true;
			this.btn_coverage_area_del.Click += new System.EventHandler(this.btn_coverage_area_del_Click);
			// 
			// btn_coverage_area_add
			// 
			this.btn_coverage_area_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_coverage_area_add.Location = new System.Drawing.Point(123, 146);
			this.btn_coverage_area_add.Name = "btn_coverage_area_add";
			this.btn_coverage_area_add.Size = new System.Drawing.Size(120, 25);
			this.btn_coverage_area_add.TabIndex = 7;
			this.btn_coverage_area_add.Text = "добавить зону";
			this.btn_coverage_area_add.UseVisualStyleBackColor = true;
			this.btn_coverage_area_add.Click += new System.EventHandler(this.btn_coverage_area_add_Click);
			// 
			// coverage_areas_list
			// 
			this.coverage_areas_list.AllowUserToAddRows = false;
			this.coverage_areas_list.AllowUserToDeleteRows = false;
			this.coverage_areas_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.coverage_areas_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.coverage_areas_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn41,
            this.dataGridViewTextBoxColumn42,
            this.dataGridViewTextBoxColumn43,
            this.dataGridViewTextBoxColumn44});
			this.coverage_areas_list.Location = new System.Drawing.Point(12, 12);
			this.coverage_areas_list.Name = "coverage_areas_list";
			this.coverage_areas_list.ReadOnly = true;
			this.coverage_areas_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.coverage_areas_list.Size = new System.Drawing.Size(496, 208);
			this.coverage_areas_list.TabIndex = 22;
			this.coverage_areas_list.SelectionChanged += new System.EventHandler(this.coverage_areas_list_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn41
			// 
			this.dataGridViewTextBoxColumn41.HeaderText = "Код дома";
			this.dataGridViewTextBoxColumn41.Name = "dataGridViewTextBoxColumn41";
			this.dataGridViewTextBoxColumn41.ReadOnly = true;
			this.dataGridViewTextBoxColumn41.Width = 80;
			// 
			// dataGridViewTextBoxColumn42
			// 
			this.dataGridViewTextBoxColumn42.HeaderText = "Район";
			this.dataGridViewTextBoxColumn42.Name = "dataGridViewTextBoxColumn42";
			this.dataGridViewTextBoxColumn42.ReadOnly = true;
			this.dataGridViewTextBoxColumn42.Width = 130;
			// 
			// dataGridViewTextBoxColumn43
			// 
			this.dataGridViewTextBoxColumn43.HeaderText = "Улица";
			this.dataGridViewTextBoxColumn43.Name = "dataGridViewTextBoxColumn43";
			this.dataGridViewTextBoxColumn43.ReadOnly = true;
			this.dataGridViewTextBoxColumn43.Width = 130;
			// 
			// dataGridViewTextBoxColumn44
			// 
			this.dataGridViewTextBoxColumn44.HeaderText = "Номер дома";
			this.dataGridViewTextBoxColumn44.Name = "dataGridViewTextBoxColumn44";
			this.dataGridViewTextBoxColumn44.ReadOnly = true;
			this.dataGridViewTextBoxColumn44.Width = 110;
			// 
			// Form6
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 232);
			this.Controls.Add(this.groupBox6);
			this.Controls.Add(this.coverage_areas_list);
			this.MinimumSize = new System.Drawing.Size(800, 270);
			this.Name = "Form6";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Покрытие";
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_house)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.coverage_areas_list)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.NumericUpDown num_house;
		private System.Windows.Forms.TextBox street;
		private System.Windows.Forms.TextBox district;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Button btn_coverage_area_del;
		private System.Windows.Forms.Button btn_coverage_area_add;
		private System.Windows.Forms.DataGridView coverage_areas_list;
		private System.Windows.Forms.Button agreementOk;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn41;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn42;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn43;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn44;
	}
}