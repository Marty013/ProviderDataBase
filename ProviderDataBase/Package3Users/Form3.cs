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
	public partial class Form3 : Form
	{
		PROVIDER_DBDataContext dc;

		public Form3()
		{
			InitializeComponent();
			dc = new PROVIDER_DBDataContext();
			fillUsers();
		}

		//ОТОБРАЖЕНИЕ ДАННЫХ ВЫБРАННОЙ ТРАНЗАКЦИИ
		public void users_list_SelectionChanged(object sender, EventArgs e)
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
		private void fillUsers()
		{
			user_address.Text = "РайонУлица№дома << формат";
			user_address.ForeColor = Color.Gray;

			// Перезаполним таблицу
			int countRow = users_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				users_list.Rows.RemoveAt(0);
			}
			var query = dc.users;
			int numRow = 0;
			foreach (var item in query)
			{
				users_list.Rows.Add();
				users_list.Rows[numRow].Cells[0].Value = item.user_id.ToString();
				users_list.Rows[numRow].Cells[1].Value = item.user_surname.ToString();
				users_list.Rows[numRow].Cells[2].Value = item.user_name.ToString();
				users_list.Rows[numRow].Cells[3].Value = item.user_patronymic.ToString();
				users_list.Rows[numRow].Cells[4].Value = item.user_passport_data.ToString();
				users_list.Rows[numRow].Cells[5].Value = item.user_address.ToString();
				users_list.Rows[numRow].Cells[6].Value = item.user_contact_phone_num.ToString();
				numRow++;
			}
		}

		// происходит когда элемент стает активным
		private void user_address_Enter(object sender, EventArgs e)
		{
			if (user_address.Text == "[Район][Улица][№дома] << формат")
			{
				user_address.Text = null;
				user_address.ForeColor = Color.Black;
			}
		}

		// происходит когда элемент стает НЕактивным
		private void user_address_Leave(object sender, EventArgs e)
		{
			if (user_address.Text == "")
			{
				user_address.Text = "[Район][Улица][№дома] << формат";
				user_address.ForeColor = Color.Gray;
			}
		}
	}
}

