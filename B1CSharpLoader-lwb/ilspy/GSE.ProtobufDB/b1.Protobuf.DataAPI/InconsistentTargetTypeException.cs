using System;

namespace b1.Protobuf.DataAPI;

internal class InconsistentTargetTypeException : Exception
{
	public readonly string SourceType;

	public readonly string TargetType;

	public InconsistentTargetTypeException(in string sourceType, in string targetType)
	{
		SourceType = sourceType;
		TargetType = targetType;
	}
}
