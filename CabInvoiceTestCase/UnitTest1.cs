using CabInvoiceGenerator;

namespace CabInvoiceTestCase;

[TestClass]
public class CabInvoiceTestClass
{
    [TestMethod]
    public void TotalFare()
    {
        //4*10+2*1
        Ride ride = new Ride(4, 2);
        InvoiceGenerator invoice = new InvoiceGenerator();
        double actual = invoice.CaluculateTotalFare(ride);
        Assert.AreEqual(42, actual);
    }

    [TestMethod]
    public void MutipleRides()
    {
        //4*10+2*1

        Ride[] rides = new Ride[]
        {
            new Ride(1, 2),//1*10+2*1=12
            new Ride(2, 1) //2*10+1*1=21
        };

        InvoiceGenerator invoice = new InvoiceGenerator();
        double actual = invoice.CalculateTotalfareForMultipleRides(rides);
        Assert.AreEqual(33, actual);
    }
}
