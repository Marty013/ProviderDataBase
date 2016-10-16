using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationSystem
{
	public partial class Form2 : Form, IForm2
	{
		PROVIDER_DBDataContext dc;
		int idAgreement;

		public event EventHandler<EventArgs> AddTransactionClicked; //событие для наблюдателя

		public Form2(int idAgr)
		{
			InitializeComponent();
			dc = new PROVIDER_DBDataContext();
			idAgreement = idAgr;
			fillTransactions();
			transaction_date.Enabled = false;
		}

		//Получаем данные транзакции
		public int Id_agreement { get { return Convert.ToInt32(id_agreement.Text); } }
		public string Operation_type { get { return operation_type.Text; } }
		public int Transaction_amount { get { return (int) transaction_amount.Value; } }
		public DateTime Transaction_date { get { return transaction_date.Value; } }

		//ОТОБРАЖЕНИЕ ДАННЫХ ВЫБРАННОЙ ТРАНЗАКЦИИ
		public void transactions_list_SelectionChanged(object sender, EventArgs e)
		{
			//Если строка не пустая
			try
			{
				if (transactions_list.CurrentRow.Index >= 0)
				{
					//При выделении строчки в таблице
					int idt = Convert.ToInt32(transactions_list.Rows[transactions_list.CurrentRow.Index].Cells[0].Value.ToString());
					var t = dc.transactions.SingleOrDefault(c => c.transaction_id == idt);
					if (t != null)
					{
						operation_type.Text = t.operation_type;
						transaction_amount.Value = t.transaction_amount;
						transaction_date.Value = t.transaction_date;
					}
				}
			}
			catch { }
		}

		// ЗАПОЛНЕНИЕ ТАБЛИЦЫ
		private void fillTransactions()
		{
			// Отметим код договора
			id_agreement.Text = idAgreement.ToString();

			// Перезаполним таблицу
			int countRow = transactions_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				transactions_list.Rows.RemoveAt(0);
			}
			var query2 = dc.transactions;
			int numRow = 0;
			foreach (var item in query2)
			{
				transactions_list.Rows.Add();
				transactions_list.Rows[numRow].Cells[0].Value = item.transaction_id.ToString();
				transactions_list.Rows[numRow].Cells[1].Value = item.id_agreement.ToString();
				transactions_list.Rows[numRow].Cells[2].Value = item.operation_type.ToString();
				transactions_list.Rows[numRow].Cells[3].Value = item.transaction_amount.ToString();
				transactions_list.Rows[numRow].Cells[4].Value = item.transaction_date.ToString();
				numRow++;
			}
		}

		// ДОБАВЛЕНИЕ НОВОЙ ТРАНЗАКЦИИ
		public void btn_transaction_add_Click(object sender, EventArgs e)
		{
			if (operation_type.Text != "" && transaction_amount.Value != 0 /*&& transaction_date.Value >= System.DateTime.Now*/)
			{
				// НАБЛЮДАТЕЛЬ
				AddTransactionClicked(this, e);

				// обновим таблицу
				fillTransactions();
			}
			else
			{
				MessageBox.Show("Не все поля заполнены верно!");
			}
		}
	}
}
