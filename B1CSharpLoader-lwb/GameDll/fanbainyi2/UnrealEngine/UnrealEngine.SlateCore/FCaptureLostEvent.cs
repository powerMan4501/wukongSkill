using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.CaptureLostEvent", "SlateCore", UnrealModuleType.Engine)]
public class FCaptureLostEvent : StructAsClass
{
	private static bool FCaptureLostEvent_IsValid;

	private static IntPtr FCaptureLostEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FCaptureLostEvent_StructAddress;
	}

	static FCaptureLostEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCaptureLostEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCaptureLostEvent));
	}

	private static void LoadNativeType()
	{
		FCaptureLostEvent_IsValid = (FCaptureLostEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.CaptureLostEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.CaptureLostEvent", FCaptureLostEvent_IsValid);
	}
}
