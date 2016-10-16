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
	public partial class Form6 : Form, IForm6
	{
		PROVIDER_DBDataContext dc;
		int idSelectCovArea;	// Код выбранной зоны покрытия

		public event EventHandler<EventArgs> AddCovAreaClicked;	//событие для наблюдателя
		public event EventHandler<EventArgs> DelCovAreaClicked;

		public Form6()
		{
			InitializeComponent();
			dc = new PROVIDER_DBDataContext();
			fillCoverageAreas();
			idSelectCovArea = -1;
		}

		//Получаем данные зоны покрытия
		public string District { get { return district.Text; } }
		public string Street { get { return street.Text; } }
		public int Num_house { get { return (int)num_house.Value; } }

		// код выбранной зоны покрытия
		public int idCovArea { get { return Convert.ToInt32(coverage_areas_list.Rows[coverage_areas_list.CurrentRow.Index].Cells[0].Value.ToString()); } }
		
		//ОТОБРАЖЕНИЕ ДАННЫХ ВЫБРАННОЙ ЗОНЫ ПОКРЫТИЯ
		public void coverage_areas_list_SelectionChanged(object sender, EventArgs e)
		{
			//Если строка не пустая
			try
			{
				if (coverage_areas_list.CurrentRow.Index >= 0)
				{
					//При выделении строчки в таблице
					int idca = Convert.ToInt32(coverage_areas_list.Rows[coverage_areas_list.CurrentRow.Index].Cells[0].Value.ToString());
					var ca = dc.coverage_areas.SingleOrDefault(c => c.coverage_area_id == idca);
					if (ca != null)
					{
						district.Text = ca.district;
						street.Text = ca.street;
						num_house.Value = ca.num_house;
					}
				}
			}
			catch { }
		}

		// ЗАПОЛНЕНИЕ ТАБЛИЦЫ
		private void fillCoverageAreas()
		{
			// Перезаполним таблицу
			int countRow = coverage_areas_list.Rows.Count;
			for (int i = 0; i < countRow; i++)
			{
				coverage_areas_list.Rows.RemoveAt(0);
			}
			var query = dc.coverage_areas;
			int numRow = 0;
			foreach (var item in query)
			{
				coverage_areas_list.Rows.Add();
				coverage_areas_list.Rows[numRow].Cells[0].Value = item.coverage_area_id.ToString();
				coverage_areas_list.Rows[numRow].Cells[1].Value = item.district.ToString();
				coverage_areas_list.Rows[numRow].Cells[2].Value = item.street.ToString();
				coverage_areas_list.Rows[numRow].Cells[3].Value = item.num_house.ToString();
				numRow++;
			}
		}

		// ДОБАВЛЕНИЕ НОВОЙ ЗОНЫ ПОКРЫТИЯ
		private void btn_coverage_area_add_Click(object sender, EventArgs e)
		{
			if (district.Text != "" && street.Text != "" && num_house.Value > 0)
			{
				// НАБЛЮДАТЕЛЬ
				AddCovAreaClicked(this, e);

				// обновим таблицу
				fillCoverageAreas();
			}
			else
			{
				MessageBox.Show("Не все поля заполнены верно!");
			}
		}

		// УДАЛЕНИЕ ЗОНЫ ПОКРЫТИЯ
		private void btn_coverage_area_del_Click(object sender, EventArgs e)
		{
			if (coverage_areas_list.Rows.Count > 0)
			{
				// НАБЛЮДАТЕЛЬ
				DelCovAreaClicked(this, e);

				// обновим таблицу
				fillCoverageAreas();
			}
		}
	}
}
