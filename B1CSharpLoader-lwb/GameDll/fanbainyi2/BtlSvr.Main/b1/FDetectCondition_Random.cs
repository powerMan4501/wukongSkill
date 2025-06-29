using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_Random")]
public struct FDetectCondition_Random
{
	[UMeta(MDProp.ClampMin, 0f)]
	[EditAnywhere]
	[DisplayName("成功率")]
	[UProperty]
	[UMeta(MDProp.ClampMax, 1f)]
	[USharpPath("/Script/b1-Managed.DetectCondition_Random:SuccessRate")]
	public float SuccessRate;

	private static int DetectCondition_Random_StructSize;

	public FDetectCondition_Random Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_Random");
		DetectCondition_Random_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_Random));
	}

	static FDetectCondition_Random()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_Random)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_Random));
	}
}
