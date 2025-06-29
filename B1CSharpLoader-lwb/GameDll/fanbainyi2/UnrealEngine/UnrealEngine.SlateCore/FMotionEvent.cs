using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.MotionEvent", "SlateCore", UnrealModuleType.Engine)]
public class FMotionEvent : StructAsClass
{
	private static bool FMotionEvent_IsValid;

	private static IntPtr FMotionEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FMotionEvent_StructAddress;
	}

	static FMotionEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMotionEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMotionEvent));
	}

	private static void LoadNativeType()
	{
		FMotionEvent_IsValid = (FMotionEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.MotionEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.MotionEvent", FMotionEvent_IsValid);
	}
}
