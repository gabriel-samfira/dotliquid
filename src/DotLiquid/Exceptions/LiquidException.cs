using System;
using System.Runtime.Serialization;

namespace DotLiquid.Exceptions
{
	[DataContract]
	public abstract class LiquidException : ApplicationException
	{
		protected LiquidException(string message, Exception innerException)
			: base(message, innerException)
		{
		}

		protected LiquidException(string message)
			: base(message)
		{
		}

		protected LiquidException()
		{
		}
	}
}