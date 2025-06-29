using UnrealEngine.Engine;

namespace UnrealEngine.Plugins.GameplayCameras;

public static class UCameraAnimationCameraModifier_CsExtensions
{
	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifierFromID(this UWorld WorldContextObject, int ControllerID)
	{
		return UCameraAnimationCameraModifier.GetCameraAnimationCameraModifierFromID(WorldContextObject, ControllerID);
	}

	public static UCameraAnimationCameraModifier GetCameraAnimationCameraModifier(this UWorld WorldContextObject, int PlayerIndex)
	{
		return UCameraAnimationCameraModifier.GetCameraAnimationCameraModifier(WorldContextObject, PlayerIndex);
	}
}
