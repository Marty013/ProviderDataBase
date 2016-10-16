namespace TicketReservationSystem
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
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.id_agreement = new System.Windows.Forms.Label();
			this.transaction_date = new System.Windows.Forms.DateTimePicker();
			this.transaction_amount = new System.Windows.Forms.NumericUpDown();
			this.operation_type = new System.Windows.Forms.TextBox();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.btn_transaction_add = new System.Windows.Forms.Button();
			this.transactions_list = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.transaction_amount)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.transactions_list)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.Controls.Add(this.id_agreement);
			this.groupBox3.Controls.Add(this.transaction_date);
			this.groupBox3.Controls.Add(this.transaction_amount);
			this.groupBox3.Controls.Add(this.operation_type);
			this.groupBox3.Controls.Add(this.label19);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label16);
			this.groupBox3.Controls.Add(this.btn_transaction_add);
			this.groupBox3.Location = new System.Drawing.Point(519, 12);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(253, 208);
			this.groupBox3.TabIndex = 21;
			this.groupBox3.TabStop = false;
			// 
			// id_agreement
			// 
			this.id_agreement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.id_agreement.AutoSize = true;
			this.id_agreement.BackColor = System.Drawing.SystemColors.Control;
			this.id_agreement.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.id_agreement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.id_agreement.Location = new System.Drawing.Point(112, 19);
			this.id_agreement.Name = "id_agreement";
			this.id_agreement.Size = new System.Drawing.Size(93, 18);
			this.id_agreement.TabIndex = 29;
			this.id_agreement.Text = "id_agreement";
			// 
			// transaction_date
			// 
			this.transaction_date.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.transaction_date.Location = new System.Drawing.Point(112, 97);
			this.transaction_date.Name = "transaction_date";
			this.transaction_date.Size = new System.Drawing.Size(135, 20);
			this.transaction_date.TabIndex = 6;
			// 
			// transaction_amount
			// 
			this.transaction_amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.transaction_amount.Location = new System.Drawing.Point(112, 71);
			this.transaction_amount.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
			this.transaction_amount.Minimum = new decimal(new int[] {
            99999,
            0,
            0,
            -2147483648});
			this.transaction_amount.Name = "transaction_amount";
			this.transaction_amount.Size = new System.Drawing.Size(135, 20);
			this.transaction_amount.TabIndex = 5;
			// 
			// operation_type
			// 
			this.operation_type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.operation_type.Location = new System.Drawing.Point(112, 45);
			this.operation_type.MaxLength = 30;
			this.operation_type.Name = "operation_type";
			this.operation_type.Size = new System.Drawing.Size(135, 20);
			this.operation_type.TabIndex = 4;
			// 
			// label19
			// 
			this.label19.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(5, 97);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(101, 13);
			this.label19.TabIndex = 28;
			this.label19.Text = "Дата транзакции :";
			// 
			// label18
			// 
			this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(8, 71);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(98, 13);
			this.label18.TabIndex = 27;
			this.label18.Text = "Сумма операции :";
			// 
			// label17
			// 
			this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(23, 45);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(83, 13);
			this.label17.TabIndex = 26;
			this.label17.Text = "Вид операции :";
			// 
			// label16
			// 
			this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(9, 19);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(97, 13);
			this.label16.TabIndex = 25;
			this.label16.Text = "Номер договора :";
			// 
			// btn_transaction_add
			// 
			this.btn_transaction_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_transaction_add.Location = new System.Drawing.Point(112, 177);
			this.btn_transaction_add.Name = "btn_transaction_add";
			this.btn_transaction_add.Size = new System.Drawing.Size(135, 25);
			this.btn_transaction_add.TabIndex = 8;
			this.btn_transaction_add.Text = "выполнить операцию";
			this.btn_transaction_add.UseVisualStyleBackColor = true;
			this.btn_transaction_add.Click += new System.EventHandler(this.btn_transaction_add_Click);
			// 
			// transactions_list
			// 
			this.transactions_list.AllowUserToAddRows = false;
			this.transactions_list.AllowUserToDeleteRows = false;
			this.transactions_list.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.transactions_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.transactions_list.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15});
			this.transactions_list.Location = new System.Drawing.Point(12, 12);
			this.transactions_list.Name = "transactions_list";
			this.transactions_list.ReadOnly = true;
			this.transactions_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.transactions_list.Size = new System.Drawing.Size(489, 208);
			this.transactions_list.TabIndex = 22;
			this.transactions_list.SelectionChanged += new System.EventHandler(this.transactions_list_SelectionChanged);
			// 
			// dataGridViewTextBoxColumn11
			// 
			this.dataGridViewTextBoxColumn11.HeaderText = "Код операции";
			this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
			this.dataGridViewTextBoxColumn11.ReadOnly = true;
			this.dataGridViewTextBoxColumn11.Width = 115;
			// 
			// dataGridViewTextBoxColumn12
			// 
			this.dataGridViewTextBoxColumn12.HeaderText = "Код договора";
			this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
			this.dataGridViewTextBoxColumn12.ReadOnly = true;
			this.dataGridViewTextBoxColumn12.Width = 115;
			// 
			// dataGridViewTextBoxColumn13
			// 
			this.dataGridViewTextBoxColumn13.HeaderText = "Вид операции";
			this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
			this.dataGridViewTextBoxColumn13.ReadOnly = true;
			this.dataGridViewTextBoxColumn13.Width = 115;
			// 
			// dataGridViewTextBoxColumn14
			// 
			this.dataGridViewTextBoxColumn14.HeaderText = "Сумма операции";
			this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
			this.dataGridViewTextBoxColumn14.ReadOnly = true;
			this.dataGridViewTextBoxColumn14.Width = 130;
			// 
			// dataGridViewTextBoxColumn15
			// 
			this.dataGridViewTextBoxColumn15.HeaderText = "Дата транзакции";
			this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
			this.dataGridViewTextBoxColumn15.ReadOnly = true;
			this.dataGridViewTextBoxColumn15.Width = 135;
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 232);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.transactions_list);
			this.MinimumSize = new System.Drawing.Size(800, 270);
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Денежные операции";
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.transaction_amount)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.transactions_list)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DateTimePicker transaction_date;
		private System.Windows.Forms.NumericUpDown transaction_amount;
		private System.Windows.Forms.TextBox operation_type;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Button btn_transaction_add;
		private System.Windows.Forms.DataGridView transactions_list;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
		private System.Windows.Forms.Label id_agreement;

	}
}