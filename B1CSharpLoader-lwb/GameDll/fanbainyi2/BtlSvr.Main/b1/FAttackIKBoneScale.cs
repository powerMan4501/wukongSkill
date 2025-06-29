using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.AttackIKBoneScale")]
public struct FAttackIKBoneScale
{
	[Tooltip("通常为攻击IK骨链后相对稳定的骨骼")]
	[DisplayName("缩放骨骼")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AttackIKBoneScale:TargetBoneScaleName")]
	public FName TargetBoneScaleName;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("锁定目标骨骼")]
	[Tooltip("IK的终点角色骨骼")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AttackIKBoneScale:TargetBoneName")]
	public FName TargetBoneName;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("缩放长度偏移")]
	[Tooltip("需要补全的长度偏移\ud83d\ude02")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AttackIKBoneScale:BoneScaleOffset")]
	public float BoneScaleOffset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("追踪距离限制")]
	[Tooltip("追踪距离约束")]
	[USharpPath("/Script/b1-Managed.AttackIKBoneScale:BoneScaleDistanceLimit")]
	public FVector2D BoneScaleDistanceLimit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("追踪角度限制")]
	[Tooltip("追踪角度约束")]
	[USharpPath("/Script/b1-Managed.AttackIKBoneScale:BoneScaleYawLimit")]
	public float BoneScaleYawLimit;

	private static int AttackIKBoneScale_StructSize;

	public FAttackIKBoneScale Copy()
	{
		return this;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/b1-Managed.AttackIKBoneScale");
		AttackIKBoneScale_StructSize = NativeReflection.GetStructSize(unrealStruct);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FAttackIKBoneScale));
	}

	static FAttackIKBoneScale()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAttackIKBoneScale)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAttackIKBoneScale));
	}
}
