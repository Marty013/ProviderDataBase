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
	public partial class Form5 : Form
	{
		PROVIDER_DBDataContext dc;

		public Form5()
		{
			InitializeComponent();
			dc = new PROVIDER_DBDataContext();
			fillRates();
		}

		//ОТОБРАЖЕНИЕ ДАННЫХ ВЫБРАННОЙ ТРАНЗАКЦИИ
		public void rates_list_SelectionChanged(object sender, EventArgs e)
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
		private void fillRates()
		{
			// Перезаполним таблицу
			int countRow = rates_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				rates_list.Rows.RemoveAt(0);
			}
			var query = dc.rates;
			int numRow = 0;
			foreach (var item in query)
			{
				rates_list.Rows.Add();
				rates_list.Rows[numRow].Cells[0].Value = item.rate_id.ToString();
				rates_list.Rows[numRow].Cells[1].Value = item.name_rate.ToString();
				rates_list.Rows[numRow].Cells[2].Value = item.description.ToString();
				rates_list.Rows[numRow].Cells[3].Value = item.validity.ToString();
				rates_list.Rows[numRow].Cells[4].Value = item.cost.ToString();
				rates_list.Rows[numRow].Cells[5].Value = item.note.ToString();
				numRow++;
			}
		}
	}
}
