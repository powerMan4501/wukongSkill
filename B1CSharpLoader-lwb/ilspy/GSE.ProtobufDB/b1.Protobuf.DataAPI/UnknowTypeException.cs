using System;

namespace b1.Protobuf.DataAPI;

internal class UnknowTypeException : Exception
{
	public readonly string UnknowType;

	public UnknowTypeException(in string unknowType)
	{
		UnknowType = unknowType;
	}
}
