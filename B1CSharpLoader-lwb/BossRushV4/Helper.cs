using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace BossRushV4;

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

	public static APlayerController GetController()
	{
		return UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)GetWorld());
	}

	public static APawn GetControlledPawn()
	{
		return UGSE_EngineFuncLib.GetFirstLocalPlayerController((UObject)GetWorld())?.GetControlledPawn();
	}
}
