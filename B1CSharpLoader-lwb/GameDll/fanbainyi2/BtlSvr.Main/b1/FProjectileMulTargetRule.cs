using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ProjectileMulTargetRule")]
public struct FProjectileMulTargetRule
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("扇形区域半角")]
	[USharpPath("/Script/b1-Managed.ProjectileMulTargetRule:HalfAngle")]
	public float HalfAngle;

	[UProperty]
	[EditAnywhere]
	[DisplayName("筛选距离")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectileMulTargetRule:MaxDistance")]
	public float MaxDistance;

	[EditAnywhere]
	[UProperty]
	[DisplayName("最大目标数量")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.ProjectileMulTargetRule:MaxTargetNum")]
	public int MaxTargetNum;

	private static int ProjectileMulTargetRule_StructSize;

	public bool RuleValidate()
	{
		if (HalfAngle <= 0f || MaxDistance <= 0f || MaxTargetNum <= 0)
		{
			return false;
		}
		return true;
	}

	public FProjectileMulTargetRule Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.ProjectileMulTargetRule");
		ProjectileMulTargetRule_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FProjectileMulTargetRule));
	}

	static FProjectileMulTargetRule()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FProjectileMulTargetRule)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FProjectileMulTargetRule));
	}
}
