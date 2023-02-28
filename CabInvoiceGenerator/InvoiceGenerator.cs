using System;
namespace CabInvoiceGenerator
{
	public class InvoiceGenerator
	{
		public double CaluculateTotalFare(Ride ride)
		{
			double totalFare = 0;
			if (ride.distance <= 0)
			{
				throw new CabInvoiceCustomException("Invalid distance", CabInvoiceCustomException.ExceptionTypes.INVALID_DISTANCE);
			}
			else if (ride.time <= 0)
			{
                throw new CabInvoiceCustomException("Invalid time", CabInvoiceCustomException.ExceptionTypes.INVALID_TIME);
            }
			else
			{
				totalFare = ride.distance * ride.COST_PER_KM + ride.time * ride.COST_PER_MIN;
				return Math.Max(totalFare, ride.MINIMUM_FARE);
			}
		}

		public double CalculateTotalfareForMultipleRides(Ride[] rides)
		{
			double totalfare = 0;
			foreach(Ride ride in rides)
			{
				totalfare += CaluculateTotalFare(ride);
			}
			return totalfare;
		}
	}
}

