using System;
namespace Assignment1
{
    public class CabDetails : Cab
    {
        public bool ValidateBookingID()
        {
            if (BookingID.Length == 6 && BookingID.StartsWith("AC") && BookingID[2] == '@')
            {
                string digits = BookingID.Substring(3, 3);
                foreach (char c in digits)
                    if (!char.IsDigit(c)) return false;
                return true;
            }
            return false;
        }

        public double CalculateFareAmount()
        {
            double price = 0;
            if (CabType == "Hatchback") price = 10;
            else if (CabType == "Sedan") price = 20;
            else if (CabType == "SUV") price = 30;

            double wait = Math.Sqrt(WaitingTime);
            double fare = Distance * price + wait;
            return Math.Floor(fare * 100) / 100;
        }
    }
}