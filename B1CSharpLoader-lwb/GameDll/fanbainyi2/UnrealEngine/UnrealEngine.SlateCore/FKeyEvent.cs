using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.KeyEvent", "SlateCore", UnrealModuleType.Engine)]
public class FKeyEvent : StructAsClass
{
	private static bool FKeyEvent_IsValid;

	private static IntPtr FKeyEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FKeyEvent_StructAddress;
	}

	static FKeyEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FKeyEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FKeyEvent));
	}

	private static void LoadNativeType()
	{
		FKeyEvent_IsValid = (FKeyEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.KeyEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.KeyEvent", FKeyEvent_IsValid);
	}
}
