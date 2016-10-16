namespace TicketReservationSystem
{
	partial class Form1
	{
		/// <summary>
		/// Требуется переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Обязательный метод для поддержки конструктора - не изменяйте
		/// содержимое данного метода при помощи редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.id_rate = new System.Windows.Forms.ComboBox();
			this.btn_search_id_cov_area = new System.Windows.Forms.Button();
			this.id_co_worker = new System.Windows.Forms.ComboBox();
			this.date_connection = new System.Windows.Forms.DateTimePicker();
			this.num_apartments = new System.Windows.Forms.NumericUpDown();
			this.id_coverage_area = new System.Windows.Forms.ComboBox();
			this.password = new System.Windows.Forms.TextBox();
			this.balance = new System.Windows.Forms.NumericUpDown();
			this.login = new System.Windows.Forms.TextBox();
			this.id_user = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btn_agreement_del = new System.Windows.Forms.Button();
			this.btn_agreement_add = new System.Windows.Forms.Button();
			this.btn_agreement_change = new System.Windows.Forms.Button();
			this.agreements_list = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btn_transaction_agreement = new System.Windows.Forms.Button();
			this.agreementOk = new System.Windows.Forms.Button();
			this.agreementCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_apartments)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.balance)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.agreements_list)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox1.Controls.Add(this.id_rate);
			this.groupBox1.Controls.Add(this.btn_search_id_cov_area);
			this.groupBox1.Controls.Add(this.id_co_worker);
			this.groupBox1.Controls.Add(this.date_connection);
			this.groupBox1.Controls.Add(this.num_apartments);
			this.groupBox1.Controls.Add(this.id_coverage_area);
			this.groupBox1.Controls.Add(this.password);
			this.groupBox1.Controls.Add(this.balance);
			this.groupBox1.Controls.Add(this.login);
			this.groupBox1.Controls.Add(this.id_user);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(538, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(424, 290);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// id_rate
			// 
			this.id_rate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_rate.FormattingEnabled = true;
			this.id_rate.Location = new System.Drawing.Point(105, 247);
			this.id_rate.Name = "id_rate";
			this.id_rate.Size = new System.Drawing.Size(307, 21);
			this.id_rate.TabIndex = 11;
			// 
			// btn_search_id_cov_area
			// 
			this.btn_search_id_cov_area.Location = new System.Drawing.Point(267, 136);
			this.btn_search_id_cov_area.Name = "btn_search_id_cov_area";
			this.btn_search_id_cov_area.Size = new System.Drawing.Size(145, 22);
			this.btn_search_id_cov_area.TabIndex = 14;
			this.btn_search_id_cov_area.Text = "поиск по адресу";
			this.btn_search_id_cov_area.UseVisualStyleBackColor = true;
			this.btn_search_id_cov_area.Click += new System.EventHandler(this.btn_search_id_cov_area_Click);
			// 
			// id_co_worker
			// 
			this.id_co_worker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_co_worker.FormattingEnabled = true;
			this.id_co_worker.Location = new System.Drawing.Point(105, 218);
			this.id_co_worker.Name = "id_co_worker";
			this.id_co_worker.Size = new System.Drawing.Size(307, 21);
			this.id_co_worker.TabIndex = 10;
			// 
			// date_connection
			// 
			this.date_connection.Location = new System.Drawing.Point(267, 191);
			this.date_connection.Name = "date_connection";
			this.date_connection.RightToLeftLayout = true;
			this.date_connection.Size = new System.Drawing.Size(145, 20);
			this.date_connection.TabIndex = 9;
			// 
			// num_apartments
			// 
			this.num_apartments.Location = new System.Drawing.Point(300, 164);
			this.num_apartments.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
			this.num_apartments.Name = "num_apartments";
			this.num_apartments.Size = new System.Drawing.Size(112, 20);
			this.num_apartments.TabIndex = 8;
			// 
			// id_coverage_area
			// 
			this.id_coverage_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_coverage_area.FormattingEnabled = true;
			this.id_coverage_area.Location = new System.Drawing.Point(105, 136);
			this.id_coverage_area.Name = "id_coverage_area";
			this.id_coverage_area.Size = new System.Drawing.Size(156, 21);
			this.id_coverage_area.TabIndex = 7;
			// 
			// password
			// 
			this.password.Location = new System.Drawing.Point(105, 108);
			this.password.MaxLength = 15;
			this.password.Name = "password";
			this.password.Size = new System.Drawing.Size(307, 20);
			this.password.TabIndex = 6;
			// 
			// balance
			// 
			this.balance.Location = new System.Drawing.Point(300, 49);
			this.balance.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.balance.Name = "balance";
			this.balance.Size = new System.Drawing.Size(112, 20);
			this.balance.TabIndex = 4;
			// 
			// login
			// 
			this.login.Location = new System.Drawing.Point(105, 76);
			this.login.MaxLength = 15;
			this.login.Name = "login";
			this.login.Size = new System.Drawing.Size(307, 20);
			this.login.TabIndex = 5;
			// 
			// id_user
			// 
			this.id_user.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.id_user.FormattingEnabled = true;
			this.id_user.Location = new System.Drawing.Point(105, 20);
			this.id_user.Name = "id_user";
			this.id_user.Size = new System.Drawing.Size(307, 21);
			this.id_user.TabIndex = 3;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 247);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(93, 13);
			this.label9.TabIndex = 8;
			this.label9.Text = "Тарифный план :";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(33, 218);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 13);
			this.label8.TabIndex = 7;
			this.label8.Text = "Сотрудник :";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(152, 191);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(109, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Дата подключения :";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(195, 164);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(99, 13);
			this.label6.TabIndex = 5;
			this.label6.Text = "Номер квартиры :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(38, 136);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Код дома :";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(48, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(51, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Пароль :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(55, 76);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(44, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Логин :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(244, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Баланс :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Пользователь :";
			// 
			// btn_agreement_del
			// 
			this.btn_agreement_del.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_agreement_del.Location = new System.Drawing.Point(238, 29);
			this.btn_agreement_del.Name = "btn_agreement_del";
			this.btn_agreement_del.Size = new System.Drawing.Size(110, 30);
			this.btn_agreement_del.TabIndex = 14;
			this.btn_agreement_del.Text = "Расторгнуть";
			this.btn_agreement_del.UseVisualStyleBackColor = true;
			// 
			// btn_agreement_add
			// 
			this.btn_agreement_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_agreement_add.Location = new System.Drawing.Point(6, 29);
			this.btn_agreement_add.Name = "btn_agreement_add";
			this.btn_agreement_add.Size = new System.Drawing.Size(110, 30);
			this.btn_agreement_add.TabIndex = 13;
			this.btn_agreement_add.Text = "Заключить";
			this.btn_agreement_add.UseVisualStyleBackColor = true;
			// 
			// btn_agreement_change
			// 
			this.btn_agreement_change.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_agreement_change.Location = new System.Drawing.Point(122, 29);
			this.btn_agreement_change.Name = "btn_agreement_change";
			this.btn_agreement_change.Size = new System.Drawing.Size(110, 30);
			this.btn_agreement_change.TabIndex = 12;
			this.btn_agreement_change.Text = "Внести изменения";
			this.btn_agreement_change.UseVisualStyleBackColor = true;
			// 
			// agreements_list
			// 
			this.agreements_list.AllowUserToAddRows = false;
			this.agreements_list.AllowUserToDeleteRows = false;
			this.agreements_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.agreements_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.agreements_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
			this.agreements_list.Location = new System.Drawing.Point(12, 12);
			this.agreements_list.Name = "agreements_list";
			this.agreements_list.ReadOnly = true;
			this.agreements_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.agreements_list.Size = new System.Drawing.Size(520, 290);
			this.agreements_list.TabIndex = 19;
			this.agreements_list.SelectionChanged += new System.EventHandler(this.agreements_list_SelectionChanged);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "Код договора";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Width = 115;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "Пользователь";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 120;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Баланс";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// Column4
			// 
			this.Column4.HeaderText = "Логин";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			// 
			// Column5
			// 
			this.Column5.HeaderText = "Пароль";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "Код дома";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			// 
			// Column7
			// 
			this.Column7.HeaderText = "№ квартиры";
			this.Column7.Name = "Column7";
			this.Column7.ReadOnly = true;
			this.Column7.Width = 105;
			// 
			// Column8
			// 
			this.Column8.HeaderText = "Дата подкл.";
			this.Column8.Name = "Column8";
			this.Column8.ReadOnly = true;
			this.Column8.Width = 105;
			// 
			// Column9
			// 
			this.Column9.HeaderText = "Сотрудник";
			this.Column9.Name = "Column9";
			this.Column9.ReadOnly = true;
			// 
			// Column10
			// 
			this.Column10.HeaderText = "Тарифный план";
			this.Column10.Name = "Column10";
			this.Column10.ReadOnly = true;
			this.Column10.Width = 130;
			// 
			// groupBox2
			// 
			this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox2.Controls.Add(this.btn_agreement_change);
			this.groupBox2.Controls.Add(this.btn_transaction_agreement);
			this.groupBox2.Controls.Add(this.btn_agreement_del);
			this.groupBox2.Controls.Add(this.btn_agreement_add);
			this.groupBox2.Location = new System.Drawing.Point(12, 308);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(520, 82);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Выберите действие :";
			// 
			// btn_transaction_agreement
			// 
			this.btn_transaction_agreement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_transaction_agreement.Location = new System.Drawing.Point(394, 29);
			this.btn_transaction_agreement.Name = "btn_transaction_agreement";
			this.btn_transaction_agreement.Size = new System.Drawing.Size(110, 30);
			this.btn_transaction_agreement.TabIndex = 14;
			this.btn_transaction_agreement.Text = "Работа со счётом";
			this.btn_transaction_agreement.UseVisualStyleBackColor = true;
			this.btn_transaction_agreement.Click += new System.EventHandler(this.btn_transaction_agreement_Click);
			// 
			// agreementOk
			// 
			this.agreementOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.agreementOk.Font = new System.Drawing.Font("Snap ITC", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
			this.agreementOk.Location = new System.Drawing.Point(674, 318);
			this.agreementOk.Name = "agreementOk";
			this.agreementOk.Size = new System.Drawing.Size(135, 40);
			this.agreementOk.TabIndex = 21;
			this.agreementOk.Text = "Подтвердить";
			this.agreementOk.UseVisualStyleBackColor = true;
			// 
			// agreementCancel
			// 
			this.agreementCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.agreementCancel.Font = new System.Drawing.Font("Snap ITC", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)), true);
			this.agreementCancel.Location = new System.Drawing.Point(815, 318);
			this.agreementCancel.Name = "agreementCancel";
			this.agreementCancel.Size = new System.Drawing.Size(135, 40);
			this.agreementCancel.TabIndex = 21;
			this.agreementCancel.Text = "Отмена";
			this.agreementCancel.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(974, 402);
			this.Controls.Add(this.agreementCancel);
			this.Controls.Add(this.agreementOk);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.agreements_list);
			this.Controls.Add(this.groupBox1);
			this.MinimumSize = new System.Drawing.Size(990, 440);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Работа с договарами";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.num_apartments)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.balance)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.agreements_list)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button btn_agreement_del;
		private System.Windows.Forms.Button btn_agreement_add;
		private System.Windows.Forms.Button btn_agreement_change;
		private System.Windows.Forms.ComboBox id_rate;
		private System.Windows.Forms.ComboBox id_co_worker;
		private System.Windows.Forms.DateTimePicker date_connection;
		private System.Windows.Forms.NumericUpDown num_apartments;
		private System.Windows.Forms.ComboBox id_coverage_area;
		private System.Windows.Forms.TextBox password;
		private System.Windows.Forms.NumericUpDown balance;
		private System.Windows.Forms.TextBox login;
		private System.Windows.Forms.ComboBox id_user;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView agreements_list;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button agreementOk;
		private System.Windows.Forms.Button agreementCancel;
		private System.Windows.Forms.Button btn_search_id_cov_area;
		private System.Windows.Forms.Button btn_transaction_agreement;
	}
}

