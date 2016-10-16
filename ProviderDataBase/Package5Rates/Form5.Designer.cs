namespace TicketReservationSystem
{
	partial class Form5
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
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rate_validity = new System.Windows.Forms.DateTimePicker();
			this.rate_cost = new System.Windows.Forms.NumericUpDown();
			this.rate_notes = new System.Windows.Forms.TextBox();
			this.rate_description = new System.Windows.Forms.TextBox();
			this.rate_name = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.btn_rate_del = new System.Windows.Forms.Button();
			this.btn_rate_add = new System.Windows.Forms.Button();
			this.btn_rate_change = new System.Windows.Forms.Button();
			this.rates_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn32 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn33 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn34 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn35 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn36 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.rate_cost)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rates_list)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox5
			// 
			this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox5.Controls.Add(this.rate_validity);
			this.groupBox5.Controls.Add(this.rate_cost);
			this.groupBox5.Controls.Add(this.rate_notes);
			this.groupBox5.Controls.Add(this.rate_description);
			this.groupBox5.Controls.Add(this.rate_name);
			this.groupBox5.Controls.Add(this.label32);
			this.groupBox5.Controls.Add(this.label31);
			this.groupBox5.Controls.Add(this.label30);
			this.groupBox5.Controls.Add(this.label29);
			this.groupBox5.Controls.Add(this.label28);
			this.groupBox5.Controls.Add(this.btn_rate_del);
			this.groupBox5.Controls.Add(this.btn_rate_add);
			this.groupBox5.Controls.Add(this.btn_rate_change);
			this.groupBox5.Location = new System.Drawing.Point(451, 12);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(321, 208);
			this.groupBox5.TabIndex = 21;
			this.groupBox5.TabStop = false;
			// 
			// rate_validity
			// 
			this.rate_validity.Location = new System.Drawing.Point(175, 71);
			this.rate_validity.Name = "rate_validity";
			this.rate_validity.Size = new System.Drawing.Size(140, 20);
			this.rate_validity.TabIndex = 5;
			// 
			// rate_cost
			// 
			this.rate_cost.Location = new System.Drawing.Point(175, 97);
			this.rate_cost.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
			this.rate_cost.Name = "rate_cost";
			this.rate_cost.Size = new System.Drawing.Size(140, 20);
			this.rate_cost.TabIndex = 6;
			// 
			// rate_notes
			// 
			this.rate_notes.Location = new System.Drawing.Point(101, 125);
			this.rate_notes.MaxLength = 30;
			this.rate_notes.Name = "rate_notes";
			this.rate_notes.Size = new System.Drawing.Size(214, 20);
			this.rate_notes.TabIndex = 7;
			// 
			// rate_description
			// 
			this.rate_description.Location = new System.Drawing.Point(101, 45);
			this.rate_description.MaxLength = 50;
			this.rate_description.Name = "rate_description";
			this.rate_description.Size = new System.Drawing.Size(214, 20);
			this.rate_description.TabIndex = 4;
			// 
			// rate_name
			// 
			this.rate_name.Location = new System.Drawing.Point(101, 19);
			this.rate_name.MaxLength = 15;
			this.rate_name.Name = "rate_name";
			this.rate_name.Size = new System.Drawing.Size(214, 20);
			this.rate_name.TabIndex = 3;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(19, 125);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(76, 13);
			this.label32.TabIndex = 25;
			this.label32.Text = "Примечания :";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(37, 97);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(132, 13);
			this.label31.TabIndex = 25;
			this.label31.Text = "Стоимость абон. платы :";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(32, 71);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(137, 13);
			this.label30.TabIndex = 25;
			this.label30.Text = "Дата окон. действия ТП :";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(32, 45);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(63, 13);
			this.label29.TabIndex = 25;
			this.label29.Text = "Описание :";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(6, 19);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(89, 13);
			this.label28.TabIndex = 25;
			this.label28.Text = "Наименование :";
			// 
			// btn_rate_del
			// 
			this.btn_rate_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_rate_del.Location = new System.Drawing.Point(240, 177);
			this.btn_rate_del.Name = "btn_rate_del";
			this.btn_rate_del.Size = new System.Drawing.Size(75, 25);
			this.btn_rate_del.TabIndex = 10;
			this.btn_rate_del.Text = "удалить";
			this.btn_rate_del.UseVisualStyleBackColor = true;
			// 
			// btn_rate_add
			// 
			this.btn_rate_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_rate_add.Location = new System.Drawing.Point(78, 177);
			this.btn_rate_add.Name = "btn_rate_add";
			this.btn_rate_add.Size = new System.Drawing.Size(75, 25);
			this.btn_rate_add.TabIndex = 9;
			this.btn_rate_add.Text = "добавить";
			this.btn_rate_add.UseVisualStyleBackColor = true;
			// 
			// btn_rate_change
			// 
			this.btn_rate_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_rate_change.Location = new System.Drawing.Point(159, 177);
			this.btn_rate_change.Name = "btn_rate_change";
			this.btn_rate_change.Size = new System.Drawing.Size(75, 25);
			this.btn_rate_change.TabIndex = 8;
			this.btn_rate_change.Text = "изменить";
			this.btn_rate_change.UseVisualStyleBackColor = true;
			// 
			// rates_list
			// 
			this.rates_list.AllowUserToAddRows = false;
			this.rates_list.AllowUserToDeleteRows = false;
			this.rates_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rates_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.rates_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn31,
            this.dataGridViewTextBoxColumn32,
            this.dataGridViewTextBoxColumn33,
            this.dataGridViewTextBoxColumn34,
            this.dataGridViewTextBoxColumn35,
            this.dataGridViewTextBoxColumn36});
			this.rates_list.Location = new System.Drawing.Point(12, 12);
			this.rates_list.Name = "rates_list";
			this.rates_list.ReadOnly = true;
			this.rates_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.rates_list.Size = new System.Drawing.Size(433, 208);
			this.rates_list.TabIndex = 22;
			this.rates_list.SelectionChanged += new System.EventHandler(this.rates_list_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn31
			// 
			this.dataGridViewTextBoxColumn31.HeaderText = "Код тарифа";
			this.dataGridViewTextBoxColumn31.Name = "dataGridViewTextBoxColumn31";
			this.dataGridViewTextBoxColumn31.ReadOnly = true;
			this.dataGridViewTextBoxColumn31.Visible = false;
			this.dataGridViewTextBoxColumn31.Width = 110;
			// 
			// dataGridViewTextBoxColumn32
			// 
			this.dataGridViewTextBoxColumn32.HeaderText = "Наименование";
			this.dataGridViewTextBoxColumn32.Name = "dataGridViewTextBoxColumn32";
			this.dataGridViewTextBoxColumn32.ReadOnly = true;
			this.dataGridViewTextBoxColumn32.Width = 110;
			// 
			// dataGridViewTextBoxColumn33
			// 
			this.dataGridViewTextBoxColumn33.HeaderText = "Описание";
			this.dataGridViewTextBoxColumn33.Name = "dataGridViewTextBoxColumn33";
			this.dataGridViewTextBoxColumn33.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn34
			// 
			this.dataGridViewTextBoxColumn34.HeaderText = "Дата оконч.";
			this.dataGridViewTextBoxColumn34.Name = "dataGridViewTextBoxColumn34";
			this.dataGridViewTextBoxColumn34.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn35
			// 
			this.dataGridViewTextBoxColumn35.HeaderText = "Стоимость";
			this.dataGridViewTextBoxColumn35.Name = "dataGridViewTextBoxColumn35";
			this.dataGridViewTextBoxColumn35.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn36
			// 
			this.dataGridViewTextBoxColumn36.HeaderText = "Примечания";
			this.dataGridViewTextBoxColumn36.Name = "dataGridViewTextBoxColumn36";
			this.dataGridViewTextBoxColumn36.ReadOnly = true;
			this.dataGridViewTextBoxColumn36.Width = 105;
			// 
			// Form5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 232);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.rates_list);
			this.MinimumSize = new System.Drawing.Size(800, 270);
			this.Name = "Form5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Тарифные планы";
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.rate_cost)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rates_list)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.DateTimePicker rate_validity;
		private System.Windows.Forms.NumericUpDown rate_cost;
		private System.Windows.Forms.TextBox rate_notes;
		private System.Windows.Forms.TextBox rate_description;
		private System.Windows.Forms.TextBox rate_name;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Button btn_rate_del;
		private System.Windows.Forms.Button btn_rate_add;
		private System.Windows.Forms.Button btn_rate_change;
		private System.Windows.Forms.DataGridView rates_list;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn31;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn32;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn33;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn34;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn35;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn36;
	}
}