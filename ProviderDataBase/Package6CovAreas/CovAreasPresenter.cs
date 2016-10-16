using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
	public class CovAreasPresenter
	{
		IForm6 view;

		public CovAreasPresenter(IForm6 vw)
		{
			view = vw;
			view.AddCovAreaClicked += new EventHandler<EventArgs>(Add);
			view.DelCovAreaClicked += new EventHandler<EventArgs>(Del);
		}

		public void Add(object sender, EventArgs e)
        {
            //Обращаемся к модели
			CovAreasModel covAreaMod = new CovAreasModel();
			covAreaMod.NewCovArea(view.District, view.Street, view.Num_house);
        }

		public void Del(object sender, EventArgs e)
		{
			//Обращаемся к модели
			CovAreasModel covAreaMod = new CovAreasModel();
			covAreaMod.DelCovArea(view.idCovArea);
		}
	}
}
