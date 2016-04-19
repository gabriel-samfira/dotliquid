using System;
using System.Runtime.Serialization;

namespace DotLiquid.Exceptions
{
	[DataContract]
	public class ArgumentException : LiquidException
	{
		public ArgumentException(string message, params string[] args)
			: base(string.Format(message, args))
		{
		}

		public ArgumentException()
		{
		}
	}
}