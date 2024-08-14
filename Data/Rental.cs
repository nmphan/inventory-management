using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement.Data
{
    public class Rental
    {
        int rentalId;
        DateTime date, rentalDate, returnDate;
        int customerId;
        int equipmentId;
        float cost;

		public int RentalId { get => rentalId; set => rentalId = value; }
		public DateTime Date { get => date; set => date = value; }
		public DateTime RentalDate { get => rentalDate; set => rentalDate = value; }
		public DateTime ReturnDate { get => returnDate; set => returnDate = value; }
		public int CustomerId { get => customerId; set => customerId = value; }
		public int EquipmentId { get => equipmentId; set => equipmentId = value; }
		public float Cost { get => cost; set => cost = value; }

        public Rental()
        {
            
        }

		public Rental(int rentalId, DateTime date, DateTime rentalDate, DateTime returnDate, int customerId, int equipmentId, float cost)
		{
			this.rentalId = rentalId;
			this.date = date;
			this.rentalDate = rentalDate;
			this.returnDate = returnDate;
			this.customerId = customerId;
			this.equipmentId = equipmentId;
			this.cost = cost;
		}
	}
}
