using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_TargetInAngleRange")]
public struct FDetectCondition_TargetInAngleRange
{
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, -180f)]
	[UMeta(MDProp.ClampMax, 180f)]
	[DisplayName("最小Yaw值")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_TargetInAngleRange:MinYawAngle")]
	public float MinYawAngle;

	[UMeta(MDProp.ClampMax, 180f)]
	[UMeta(MDProp.ClampMin, -180f)]
	[EditAnywhere]
	[UProperty]
	[DisplayName("最大Yaw值")]
	[USharpPath("/Script/b1-Managed.DetectCondition_TargetInAngleRange:MaxYawAngle")]
	public float MaxYawAngle;

	private static int DetectCondition_TargetInAngleRange_StructSize;

	public FDetectCondition_TargetInAngleRange Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_TargetInAngleRange");
		DetectCondition_TargetInAngleRange_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FDetectCondition_TargetInAngleRange));
	}

	static FDetectCondition_TargetInAngleRange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_TargetInAngleRange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_TargetInAngleRange));
	}
}
