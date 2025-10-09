

using TratamentoDeErro.Entities;
using TratamentoDeErro.Exceptions;

try
{
    Console.Write("Room number: ");
    int room = int.Parse(Console.ReadLine());

    Console.Write("Check-in date (dd/MM/yyyy): ");
    DateTime checkin = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/yyyy): ");
    DateTime checkout = DateTime.Parse(Console.ReadLine());

    Reservation reservation = new Reservation(room, checkin, checkout);

    Console.WriteLine(reservation.ToString());

    Console.WriteLine("Atualizando reserva:");

    Console.Write("Check-in date (dd/MM/yyyy): ");
    checkin = DateTime.Parse(Console.ReadLine());

    Console.Write("Check-out date (dd/MM/yyyy): ");
    checkout = DateTime.Parse(Console.ReadLine());
    Console.WriteLine(reservation.ToString());


    reservation.UpdateDates(checkin, checkout);
}
catch (DomainException ex)
{
    Console.WriteLine("Error in reservation: " + ex.Message);
}
catch(FormatException ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Unspected error: " + ex.Message);
}
