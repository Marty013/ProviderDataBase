namespace TicketReservationSystem
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
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.user_contact_phone_num = new System.Windows.Forms.TextBox();
			this.user_address = new System.Windows.Forms.TextBox();
			this.user_passport_data = new System.Windows.Forms.TextBox();
			this.user_patronymic = new System.Windows.Forms.TextBox();
			this.user_name = new System.Windows.Forms.TextBox();
			this.user_surname = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.btn_user_del = new System.Windows.Forms.Button();
			this.btn_user_add = new System.Windows.Forms.Button();
			this.btn_user_change = new System.Windows.Forms.Button();
			this.users_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.users_list)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.user_contact_phone_num);
			this.groupBox2.Controls.Add(this.user_address);
			this.groupBox2.Controls.Add(this.user_passport_data);
			this.groupBox2.Controls.Add(this.user_patronymic);
			this.groupBox2.Controls.Add(this.user_name);
			this.groupBox2.Controls.Add(this.user_surname);
			this.groupBox2.Controls.Add(this.label15);
			this.groupBox2.Controls.Add(this.label14);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.btn_user_del);
			this.groupBox2.Controls.Add(this.btn_user_add);
			this.groupBox2.Controls.Add(this.btn_user_change);
			this.groupBox2.Location = new System.Drawing.Point(468, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(304, 328);
			this.groupBox2.TabIndex = 21;
			this.groupBox2.TabStop = false;
			// 
			// user_contact_phone_num
			// 
			this.user_contact_phone_num.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.user_contact_phone_num.Location = new System.Drawing.Point(158, 149);
			this.user_contact_phone_num.MaxLength = 8;
			this.user_contact_phone_num.Name = "user_contact_phone_num";
			this.user_contact_phone_num.Size = new System.Drawing.Size(140, 20);
			this.user_contact_phone_num.TabIndex = 8;
			// 
			// user_address
			// 
			this.user_address.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.user_address.ForeColor = System.Drawing.Color.Gray;
			this.user_address.Location = new System.Drawing.Point(78, 123);
			this.user_address.MaxLength = 50;
			this.user_address.Name = "user_address";
			this.user_address.Size = new System.Drawing.Size(220, 20);
			this.user_address.TabIndex = 7;
			this.user_address.Text = "[Район][Улица][№дома] << формат";
			this.user_address.Enter += new System.EventHandler(this.user_address_Enter);
			this.user_address.Leave += new System.EventHandler(this.user_address_Leave);
			// 
			// user_passport_data
			// 
			this.user_passport_data.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.user_passport_data.Location = new System.Drawing.Point(158, 97);
			this.user_passport_data.MaxLength = 10;
			this.user_passport_data.Name = "user_passport_data";
			this.user_passport_data.Size = new System.Drawing.Size(140, 20);
			this.user_passport_data.TabIndex = 6;
			// 
			// user_patronymic
			// 
			this.user_patronymic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.user_patronymic.Location = new System.Drawing.Point(78, 71);
			this.user_patronymic.MaxLength = 30;
			this.user_patronymic.Name = "user_patronymic";
			this.user_patronymic.Size = new System.Drawing.Size(220, 20);
			this.user_patronymic.TabIndex = 5;
			// 
			// user_name
			// 
			this.user_name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.user_name.Location = new System.Drawing.Point(78, 45);
			this.user_name.MaxLength = 15;
			this.user_name.Name = "user_name";
			this.user_name.Size = new System.Drawing.Size(220, 20);
			this.user_name.TabIndex = 4;
			// 
			// user_surname
			// 
			this.user_surname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.user_surname.Location = new System.Drawing.Point(78, 19);
			this.user_surname.MaxLength = 30;
			this.user_surname.Name = "user_surname";
			this.user_surname.Size = new System.Drawing.Size(220, 20);
			this.user_surname.TabIndex = 3;
			// 
			// label15
			// 
			this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(32, 149);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(120, 13);
			this.label15.TabIndex = 30;
			this.label15.Text = "Контактный телефон :";
			// 
			// label14
			// 
			this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(28, 123);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(44, 13);
			this.label14.TabIndex = 29;
			this.label14.Text = "Адрес :";
			// 
			// label13
			// 
			this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(35, 97);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(117, 13);
			this.label13.TabIndex = 28;
			this.label13.Text = "Паспортные данные :";
			// 
			// label12
			// 
			this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(12, 71);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(60, 13);
			this.label12.TabIndex = 27;
			this.label12.Text = "Отчество :";
			// 
			// label11
			// 
			this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(37, 45);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(35, 13);
			this.label11.TabIndex = 26;
			this.label11.Text = "Имя :";
			// 
			// label10
			// 
			this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(10, 19);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 13);
			this.label10.TabIndex = 25;
			this.label10.Text = "Фамилия :";
			// 
			// btn_user_del
			// 
			this.btn_user_del.AllowDrop = true;
			this.btn_user_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_user_del.Location = new System.Drawing.Point(153, 297);
			this.btn_user_del.Name = "btn_user_del";
			this.btn_user_del.Size = new System.Drawing.Size(145, 25);
			this.btn_user_del.TabIndex = 11;
			this.btn_user_del.Text = "удалить пользователя";
			this.btn_user_del.UseVisualStyleBackColor = true;
			// 
			// btn_user_add
			// 
			this.btn_user_add.AllowDrop = true;
			this.btn_user_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_user_add.Location = new System.Drawing.Point(153, 235);
			this.btn_user_add.Name = "btn_user_add";
			this.btn_user_add.Size = new System.Drawing.Size(145, 25);
			this.btn_user_add.TabIndex = 10;
			this.btn_user_add.Text = "добавить пользователя";
			this.btn_user_add.UseVisualStyleBackColor = true;
			// 
			// btn_user_change
			// 
			this.btn_user_change.AllowDrop = true;
			this.btn_user_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_user_change.Location = new System.Drawing.Point(153, 266);
			this.btn_user_change.Name = "btn_user_change";
			this.btn_user_change.Size = new System.Drawing.Size(145, 25);
			this.btn_user_change.TabIndex = 9;
			this.btn_user_change.Text = "изменить запись";
			this.btn_user_change.UseVisualStyleBackColor = true;
			// 
			// users_list
			// 
			this.users_list.AllowUserToAddRows = false;
			this.users_list.AllowUserToDeleteRows = false;
			this.users_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.users_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.users_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
			this.users_list.Location = new System.Drawing.Point(12, 12);
			this.users_list.Name = "users_list";
			this.users_list.ReadOnly = true;
			this.users_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.users_list.Size = new System.Drawing.Size(450, 328);
			this.users_list.TabIndex = 22;
			this.users_list.SelectionChanged += new System.EventHandler(this.users_list_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Код польз.";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Visible = false;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Фамилия";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.HeaderText = "Отчество";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.HeaderText = "Пасп. данные";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Width = 120;
			// 
			// dataGridViewTextBoxColumn6
			// 
			this.dataGridViewTextBoxColumn6.HeaderText = "Адрес";
			this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
			this.dataGridViewTextBoxColumn6.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn7
			// 
			this.dataGridViewTextBoxColumn7.HeaderText = "Контактный тел.";
			this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
			this.dataGridViewTextBoxColumn7.ReadOnly = true;
			this.dataGridViewTextBoxColumn7.Width = 130;
			// 
			// Form3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 352);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.users_list);
			this.MinimumSize = new System.Drawing.Size(800, 390);
			this.Name = "Form3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Пользователи";
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.users_list)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox user_contact_phone_num;
		private System.Windows.Forms.TextBox user_address;
		private System.Windows.Forms.TextBox user_passport_data;
		private System.Windows.Forms.TextBox user_patronymic;
		private System.Windows.Forms.TextBox user_name;
		private System.Windows.Forms.TextBox user_surname;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_user_del;
		private System.Windows.Forms.Button btn_user_add;
		private System.Windows.Forms.Button btn_user_change;
		private System.Windows.Forms.DataGridView users_list;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
	}
}