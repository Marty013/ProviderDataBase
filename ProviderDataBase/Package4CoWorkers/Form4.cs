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
	public partial class Form4 : Form
	{
		PROVIDER_DBDataContext dc;

		public Form4()
		{
			InitializeComponent();
			dc = new PROVIDER_DBDataContext();
			fillCoWorkers();
		}

		//ОТОБРАЖЕНИЕ ДАННЫХ ВЫБРАННОЙ ТРАНЗАКЦИИ
		public void co_workers_list_SelectionChanged(object sender, EventArgs e)
		{
			//Если строка не пустая
			try
			{
				/*if (transactions_list.CurrentRow.Index >= 0)
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
				}*/
			}
			catch { }
		}

		// ЗАПОЛНЕНИЕ ТАБЛИЦЫ
		private void fillCoWorkers()
		{
			// Перезаполним таблицу
			int countRow = co_workers_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				co_workers_list.Rows.RemoveAt(0);
			}
			var query = dc.co_workers;
			int numRow = 0;
			foreach (var item in query)
			{
				co_workers_list.Rows.Add();
				co_workers_list.Rows[numRow].Cells[0].Value = item.co_worker_id.ToString();
				co_workers_list.Rows[numRow].Cells[1].Value = item.co_worker_surname.ToString();
				co_workers_list.Rows[numRow].Cells[2].Value = item.co_worker_name.ToString();
				co_workers_list.Rows[numRow].Cells[3].Value = item.co_worker_patronymic.ToString();
				co_workers_list.Rows[numRow].Cells[4].Value = item.co_worker_passport_data.ToString();
				co_workers_list.Rows[numRow].Cells[5].Value = item.co_worker_address.ToString();
				co_workers_list.Rows[numRow].Cells[6].Value = item.co_worker_contact_phone_num.ToString();
				co_workers_list.Rows[numRow].Cells[7].Value = item.post.ToString();
				co_workers_list.Rows[numRow].Cells[8].Value = item.salary.ToString();
				numRow++;
			}
		}
	}
}
