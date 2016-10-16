using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketReservationSystem
{
	public class TransactionsModel
	{
		public void NewTransaction(int Id_agreement, string Operation_type,
				int Transaction_amount, DateTime Transaction_date)
		{
			PROVIDER_DBDataContext dc = new PROVIDER_DBDataContext();

			var Trans = new transactions()
			{
				id_agreement = Id_agreement,
				operation_type = Operation_type,
				transaction_amount = Transaction_amount,
				transaction_date = Transaction_date
			};

			dc.transactions.InsertOnSubmit(Trans);	// добавление в БД
			dc.SubmitChanges();						// выполняет соответствующие команды
													// для внесения изменений базы данных
		}
	}
}
