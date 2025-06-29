using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.PointerEvent", "SlateCore", UnrealModuleType.Engine)]
public class FPointerEvent : StructAsClass
{
	private static bool FPointerEvent_IsValid;

	private static IntPtr FPointerEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FPointerEvent_StructAddress;
	}

	static FPointerEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPointerEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPointerEvent));
	}

	private static void LoadNativeType()
	{
		FPointerEvent_IsValid = (FPointerEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.PointerEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.PointerEvent", FPointerEvent_IsValid);
	}
}
