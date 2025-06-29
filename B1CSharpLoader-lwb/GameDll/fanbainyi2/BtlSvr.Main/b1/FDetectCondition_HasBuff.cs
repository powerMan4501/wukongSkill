using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_HasBuff")]
public struct FDetectCondition_HasBuff
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_HasBuff:BuffId")]
	public int BuffId;

	private static int DetectCondition_HasBuff_StructSize;

	public FDetectCondition_HasBuff Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_HasBuff");
		DetectCondition_HasBuff_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_HasBuff));
	}

	static FDetectCondition_HasBuff()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_HasBuff)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_HasBuff));
	}
}
