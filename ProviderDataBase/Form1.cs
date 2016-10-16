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
	public partial class Form1 : Form
	{
		PROVIDER_DBDataContext dc;

		Form3 f3;
		Form4 f4;
		Form5 f5;

		Form2 f2;
		Form6 f6;

		public Form1()
		{
			InitializeComponent();
			f3 = new Form3();
			f4 = new Form4();
			f5 = new Form5();
			f3.Show();
			f4.Show();
			f5.Show();

			dc = new PROVIDER_DBDataContext();
			fillAgreements();

			agreementOk.Visible = false;
			agreementCancel.Visible = false;
		}

		// Открытие окна со списком зон покрытия, для уточнения кода дома, прописанного в договоре, по адресу
		private void btn_search_id_cov_area_Click(object sender, EventArgs e)
		{
			f6 = new Form6();
			f6.Show();
			CovAreasPresenter ca = new CovAreasPresenter(f6);
		}

		// Выполнение операции со счётом для выбранного договора
		private void btn_transaction_agreement_Click(object sender, EventArgs e)
		{
			int IdAgr = 0;
			if (agreements_list.Rows.Count > 0)
			{
				IdAgr = Convert.ToInt32(agreements_list.Rows[agreements_list.CurrentRow.Index].Cells[0].Value.ToString());
			}
			if (dc.agreements.Count() > 0 && IdAgr >= 0 /*&& IdAgr <= dc.agreements.Count()*/)
			{
				f2 = new Form2(IdAgr);
				f2.Show();
				TransactionsPresenter t = new TransactionsPresenter(f2);
			}
		}

		// Отображение данных выбранной транзакции
		public void agreements_list_SelectionChanged(object sender, EventArgs e)
		{
			//Если строка не пустая
			try
			{
				if (agreements_list.CurrentRow.Index >= 0)
				{
					//При выделении строчки в таблице
					int ida = Convert.ToInt32(agreements_list.Rows[agreements_list.CurrentRow.Index].Cells[0].Value.ToString());
					var a = dc.agreements.SingleOrDefault(c => c.agreement_id == ida);
					if (a != null)
					{
						for (int i=0; i<id_user.Items.Count; i++) if (id_user.Items[i].ToString() == a.users.user_name.ToString()) id_user.SelectedIndex = i;
						balance.Value = a.balance;
						login.Text = a.login;
						password.Text = a.password;
						for (int i = 0; i < id_coverage_area.Items.Count; i++) if (id_coverage_area.Items[i].ToString() == a.id_coverage_area.ToString()) id_coverage_area.SelectedIndex = i;
						num_apartments.Value = a.num_apartment;
						date_connection.Value = a.date_connection;
						for (int i = 0; i < id_co_worker.Items.Count; i++) if (id_co_worker.Items[i].ToString() == a.co_workers.co_worker_name.ToString()) id_co_worker.SelectedIndex = i;
						for (int i = 0; i < id_rate.Items.Count; i++) if (id_rate.Items[i].ToString() == a.rates.name_rate.ToString()) id_rate.SelectedIndex = i;
					}
				}
			}
			catch { }
		}

		// Заполнение таблицы договоров
		private void fillAgreements()
		{
			// Перезаполним ComboBox-ы
			id_user.Items.Clear();
			id_coverage_area.Items.Clear();
			id_co_worker.Items.Clear();
			id_rate.Items.Clear();

			var query1 = dc.users;
			foreach (var item in query1) id_user.Items.Add(item.user_name.ToString());
			var query2 = dc.coverage_areas;
			foreach (var item in query2) id_coverage_area.Items.Add(item.coverage_area_id.ToString());
			var query3 = dc.co_workers;
			foreach (var item in query3) id_co_worker.Items.Add(item.co_worker_name.ToString());
			var query4 = dc.rates;
			foreach (var item in query4) id_rate.Items.Add(item.name_rate.ToString());

			if (id_user.Items.Count > 0) id_user.SelectedIndex = 0;
			if (id_coverage_area.Items.Count > 0) id_coverage_area.SelectedIndex = 0;
			if (id_co_worker.Items.Count > 0) id_co_worker.SelectedIndex = 0;
			if (id_rate.Items.Count > 0) id_rate.SelectedIndex = 0;

			// Перезаполним таблицу
			int countRow = agreements_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				agreements_list.Rows.RemoveAt(0);
			}
			var query5 = dc.agreements;
			int numRow = 0;
			foreach (var item in query5)
			{
				agreements_list.Rows.Add();
				agreements_list.Rows[numRow].Cells[0].Value = item.agreement_id.ToString();
				agreements_list.Rows[numRow].Cells[1].Value = item.users.user_name.ToString();
				agreements_list.Rows[numRow].Cells[2].Value = item.balance.ToString();
				agreements_list.Rows[numRow].Cells[3].Value = item.login.ToString();
				agreements_list.Rows[numRow].Cells[4].Value = item.password.ToString();
				agreements_list.Rows[numRow].Cells[5].Value = item.id_coverage_area.ToString();
				agreements_list.Rows[numRow].Cells[6].Value = item.num_apartment.ToString();
				agreements_list.Rows[numRow].Cells[7].Value = item.date_connection.ToString();
				agreements_list.Rows[numRow].Cells[8].Value = item.co_workers.co_worker_name.ToString() + " " +
																item.co_workers.co_worker_surname.ToString();
				agreements_list.Rows[numRow].Cells[9].Value = item.rates.name_rate.ToString();
				numRow++;
			}
		}
	}
}
