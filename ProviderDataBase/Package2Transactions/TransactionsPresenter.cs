using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketReservationSystem
{
	public class TransactionsPresenter
	{
		IForm2 view;

		public TransactionsPresenter(IForm2 vw)
		{
			view = vw;
			view.AddTransactionClicked += new EventHandler<EventArgs>(Add);
		}

		public void Add(object sender, EventArgs e)
        {
            //Обращаемся к модели
			TransactionsModel tranMod = new TransactionsModel();
			tranMod.NewTransaction(view.Id_agreement, view.Operation_type,
				view.Transaction_amount, view.Transaction_date);
        }
	}
}
