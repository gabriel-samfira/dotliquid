using System;
using System.Runtime.Serialization;

namespace DotLiquid.Exceptions
{
	[DataContract]
	public class SyntaxException : LiquidException
	{
		public SyntaxException(string message, params string[] args)
			: base(string.Format(message, args))
		{
		}
	}
}