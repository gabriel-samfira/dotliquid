using System;
using System.Runtime.Serialization;

namespace DotLiquid.Exceptions
{
	[DataContract]
	public class StackLevelException : LiquidException
	{
		public StackLevelException(string message)
			: base(string.Format(message))
		{
		}
	}
}