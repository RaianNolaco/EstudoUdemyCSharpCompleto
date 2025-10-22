using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using TratamentoDeErro.Exceptions;

namespace TratamentoDeErro.Entities
{
     class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }



        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            validadeDates(checkIn,checkOut);
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public Reservation()
        {
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            validadeDates(checkin, checkout);

            CheckIn = checkin;
            CheckOut = checkout;
        }

        private void validadeDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin <= now || checkout < now)
                throw new DomainException("Reservation dates for updates must be future dates");
            if (checkout <= checkin)
                throw new DomainException("Check-out date must be after check-in date");
        }

        public override string ToString()
        {
            return $"Reservation: Room {RoomNumber}, check-in: {CheckIn.ToString("dd/MM/yyyy")}, check-out: {CheckOut.ToString("dd/MM/yyyy")}, {Duration()} nights";
        }
    }
}
