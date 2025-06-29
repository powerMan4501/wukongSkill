using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_CustomFsmState")]
public struct FDetectCondition_CustomFsmState
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DetectCondition_CustomFsmState:CustomFsmState")]
	public FGameplayTag CustomFsmState;

	private static int DetectCondition_CustomFsmState_StructSize;

	public FDetectCondition_CustomFsmState Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_CustomFsmState");
		DetectCondition_CustomFsmState_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_CustomFsmState));
	}

	static FDetectCondition_CustomFsmState()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_CustomFsmState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_CustomFsmState));
	}
}
