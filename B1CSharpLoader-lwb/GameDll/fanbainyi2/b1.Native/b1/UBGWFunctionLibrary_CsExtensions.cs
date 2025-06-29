using UnrealEngine.Engine;

namespace b1;

public static class UBGWFunctionLibrary_CsExtensions
{
	public static UBGW_EventCollection GetBGWEvents(this UWorld WorldContextObject)
	{
		return UBGWFunctionLibrary.GetBGWEvents(WorldContextObject);
	}
}
