using UnrealEngine.Engine;

namespace UnrealEngine.Plugins.OpacityMicroMap;

public static class UOMMBlueprintLibrary_CsExtensions
{
	public static bool IsThisDeviceSupportOMM(this UWorld WorldContextObject)
	{
		return UOMMBlueprintLibrary.IsThisDeviceSupportOMM(WorldContextObject);
	}

	public static float CalculateCurrentWorldOMMTotalDataSize(this UWorld WorldContextObject)
	{
		return UOMMBlueprintLibrary.CalculateCurrentWorldOMMTotalDataSize(WorldContextObject);
	}

	public static void BuildAllStaticMesh(this UWorld WorldContextObject)
	{
		UOMMBlueprintLibrary.BuildAllStaticMesh(WorldContextObject);
	}
}
