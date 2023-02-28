using System;
namespace CabInvoiceGenerator
{
	public class CabInvoiceCustomException:Exception
	{
		public ExceptionTypes exceptionTypes;
		public enum ExceptionTypes
		{
			INVALID_DISTANCE,
			INVALID_TIME
		}

		public CabInvoiceCustomException(string message, ExceptionTypes exceptionTypes):base(message)
		{
			this.exceptionTypes = exceptionTypes;
		}

    }
}

