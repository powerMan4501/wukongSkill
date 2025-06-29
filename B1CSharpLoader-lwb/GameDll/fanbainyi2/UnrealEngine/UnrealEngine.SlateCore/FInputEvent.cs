using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.InputEvent", "SlateCore", UnrealModuleType.Engine)]
public class FInputEvent : StructAsClass
{
	private static bool FInputEvent_IsValid;

	private static IntPtr FInputEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FInputEvent_StructAddress;
	}

	static FInputEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputEvent));
	}

	private static void LoadNativeType()
	{
		FInputEvent_IsValid = (FInputEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.InputEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.InputEvent", FInputEvent_IsValid);
	}
}
