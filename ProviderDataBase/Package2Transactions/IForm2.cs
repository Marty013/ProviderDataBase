using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
	public interface IForm2
	{
		int Id_agreement { get; }
		string Operation_type { get; }
		int Transaction_amount { get; }
		DateTime Transaction_date { get; }

		event EventHandler<EventArgs>AddTransactionClicked;
	}
}
