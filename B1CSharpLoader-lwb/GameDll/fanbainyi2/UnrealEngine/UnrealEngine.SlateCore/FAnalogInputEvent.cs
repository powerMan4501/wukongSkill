using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.AnalogInputEvent", "SlateCore", UnrealModuleType.Engine)]
public class FAnalogInputEvent : StructAsClass
{
	private static bool FAnalogInputEvent_IsValid;

	private static IntPtr FAnalogInputEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FAnalogInputEvent_StructAddress;
	}

	static FAnalogInputEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnalogInputEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnalogInputEvent));
	}

	private static void LoadNativeType()
	{
		FAnalogInputEvent_IsValid = (FAnalogInputEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.AnalogInputEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.AnalogInputEvent", FAnalogInputEvent_IsValid);
	}
}
