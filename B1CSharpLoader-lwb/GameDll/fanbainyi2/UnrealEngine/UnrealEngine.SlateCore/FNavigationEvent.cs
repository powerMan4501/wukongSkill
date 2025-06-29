using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.NavigationEvent", "SlateCore", UnrealModuleType.Engine)]
public class FNavigationEvent : StructAsClass
{
	private static bool FNavigationEvent_IsValid;

	private static IntPtr FNavigationEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FNavigationEvent_StructAddress;
	}

	static FNavigationEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FNavigationEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNavigationEvent));
	}

	private static void LoadNativeType()
	{
		FNavigationEvent_IsValid = (FNavigationEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.NavigationEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.NavigationEvent", FNavigationEvent_IsValid);
	}
}
