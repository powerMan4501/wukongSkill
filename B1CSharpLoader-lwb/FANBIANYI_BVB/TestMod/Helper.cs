using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace TestMod;

public static class Helper
{
	private static UWorld World;

	public static UWorld GetWorld()
	{
		if (World == null)
		{
			World = GCHelper.FindRef(FGlobals.GWorld)?.Managed as UWorld;
		}
		return World;
	}

	public static APawn GetControlledPawn()
	{
		return UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)GetWorld()).GetControlledPawn();
	}
}
