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
}
