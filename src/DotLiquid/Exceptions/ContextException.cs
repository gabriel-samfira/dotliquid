using System;
using System.Runtime.Serialization;

namespace DotLiquid.Exceptions
{
	[DataContract]
	public class ContextException : LiquidException
	{
		public ContextException(string message, params string[] args)
			: base(string.Format(message, args))
		{
		}

		public ContextException()
		{
		}
	}
}