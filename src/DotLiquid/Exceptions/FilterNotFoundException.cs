using System;
using System.Runtime.Serialization;

namespace DotLiquid.Exceptions
{
	[DataContract]
	public class FilterNotFoundException : LiquidException
	{
		public FilterNotFoundException(string message, FilterNotFoundException innerException)
			: base(message, innerException)
		{
		}

		public FilterNotFoundException(string message, params string[] args)
			: base(string.Format(message, args))
		{
		}

		public FilterNotFoundException(string message)
			: base(message)
		{
		}
	}
}