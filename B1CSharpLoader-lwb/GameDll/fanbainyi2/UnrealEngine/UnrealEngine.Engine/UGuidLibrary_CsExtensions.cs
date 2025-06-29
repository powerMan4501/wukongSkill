using System;

namespace UnrealEngine.Engine;

public static class UGuidLibrary_CsExtensions
{
	public static string Conv_GuidToString(this Guid InGuid)
	{
		return UGuidLibrary.Conv_GuidToString(InGuid);
	}
}
