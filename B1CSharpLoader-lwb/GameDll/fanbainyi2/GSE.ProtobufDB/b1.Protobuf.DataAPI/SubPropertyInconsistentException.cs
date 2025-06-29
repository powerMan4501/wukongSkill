using System;

namespace b1.Protobuf.DataAPI;

internal class SubPropertyInconsistentException : Exception
{
	public readonly string PropertyName;

	public SubPropertyInconsistentException(in string propertyName)
	{
		PropertyName = propertyName;
	}
}
