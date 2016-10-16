using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
	public interface IForm6
	{
		string District { get; }
		string Street { get; }
		int Num_house { get; }

		int idCovArea { get; }

		event EventHandler<EventArgs> AddCovAreaClicked;
		event EventHandler<EventArgs> DelCovAreaClicked;
	}
}
