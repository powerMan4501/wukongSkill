using System;

namespace UnrealEngine.Runtime;

public struct FUniqueObjectGuid
{
	internal Guid Guid;

	public bool IsValid()
	{
		return Guid != Guid.Empty;
	}

	public bool IsDefault()
	{
		return Guid == Guid.Empty;
	}
}
