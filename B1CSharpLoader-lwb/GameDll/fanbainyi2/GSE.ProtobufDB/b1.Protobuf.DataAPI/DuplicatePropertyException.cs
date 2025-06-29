using System;

namespace b1.Protobuf.DataAPI;

internal class DuplicatePropertyException : Exception
{
	public readonly string DuplicatedProperty;

	public DuplicatePropertyException(in string duplicatedProperty)
	{
		DuplicatedProperty = duplicatedProperty;
	}
}
