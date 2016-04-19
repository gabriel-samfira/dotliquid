using System;
using System.Runtime.Serialization;

namespace DotLiquid.Exceptions
{
	[DataContract]
	public class FileSystemException : LiquidException
	{
		public FileSystemException(string message, params string[] args)
			: base(string.Format(message, args))
		{
		}
	}
}