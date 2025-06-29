using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.FocusEvent", "SlateCore", UnrealModuleType.Engine)]
public class FFocusEvent : StructAsClass
{
	private static bool FFocusEvent_IsValid;

	private static IntPtr FFocusEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FFocusEvent_StructAddress;
	}

	static FFocusEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFocusEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFocusEvent));
	}

	private static void LoadNativeType()
	{
		FFocusEvent_IsValid = (FFocusEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.FocusEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.FocusEvent", FFocusEvent_IsValid);
	}
}
