using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
	public class CovAreasModel
	{
		public void NewCovArea(string District, string Street, int Num_house)
		{
			PROVIDER_DBDataContext dc = new PROVIDER_DBDataContext();

			var CovArea = new coverage_areas()
			{
				district = District,
				street = Street,
				num_house = Num_house
			};

			dc.coverage_areas.InsertOnSubmit(CovArea);	// добавление в БД
			dc.SubmitChanges();							// выполняет соответствующие команды
														// для внесения изменений базы данных
		}

		public void DelCovArea(int idCovArea)
		{
			PROVIDER_DBDataContext dc = new PROVIDER_DBDataContext();

			coverage_areas ca = (from c in dc.coverage_areas
					where (c.coverage_area_id == idCovArea)
					select c).Single<coverage_areas>();
			
			/*dc.OrderDetails.DeleteAllOnSubmit(
				cust.Orders.SelectMany(o => o.OrderDetails));

			dc.Orders.DeleteAllOnSubmit(cust.Orders);*/

			dc.coverage_areas.DeleteOnSubmit(ca);
			dc.SubmitChanges();	//Добавление в БД
		}
	}
}
