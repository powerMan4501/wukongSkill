using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.AttackIKBonePairs")]
public struct FAttackIKBonePairs
{
	[Tooltip("通常为 胳膊 腿 尾巴的根骨骼")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击IK起始骨骼")]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKRootBoneName")]
	public FName AttackIKRootBoneName;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("攻击IK终止骨骼")]
	[Tooltip("通常为 胳膊 腿 尾巴的终点骨骼，比如foot_l hand_r之类")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKLimbBoneName")]
	public FName AttackIKLimbBoneName;

	[BlueprintReadWrite]
	[DisplayName("攻击Roll")]
	[Tooltip("调整扫掠面roll值，确保动画初始状态可以命中目标")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKRoll")]
	public float AttackIKRoll;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("攻击Pitch")]
	[Tooltip("调整扫掠面pitch值，确保动画初始状态可以命中目标")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKPitch")]
	public float AttackIKPitch;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("目标骨骼")]
	[Tooltip("IK目标具体骨骼名，默认和容错为 head")]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKTargetActorBoneName")]
	public FName AttackIKTargetActorBoneName;

	[Tooltip("融合距离范围内，计算攻击IK作用alpha，小于融合最近距离的范围 alpha 为 0 关闭功能")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("融合最近距离")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKBlendMinDistance")]
	public float AttackIKBlendMinDistance;

	[DisplayName("融合最远距离")]
	[Tooltip("融合距离范围内，计算攻击IK作用alpha，大于融合最远距离的范围 alpha 为 1")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKBlendMaxDistance")]
	public float AttackIKBlendMaxDistance;

	[Tooltip("是否开启IK角度限制")]
	[DisplayName("开启IK约束")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKLimitEnable")]
	public bool AttackIKLimitEnable;

	[UMeta(MDProp.ClampMax, 90f)]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.ClampMin, -90f)]
	[DisplayName("Pitch范围约束")]
	[Tooltip("Pitch范围约束，最小和最大值")]
	[USharpPath("/Script/b1-Managed.AttackIKBonePairs:AttackIKPitchLimit")]
	public FVector2D AttackIKPitchLimit;

	private static int AttackIKBonePairs_StructSize;

	private static int AttackIKBonePairs_IsValid;

	private static bool AttackIKRootBoneName_IsValid;

	private static int AttackIKRootBoneName_Offset;

	private static bool AttackIKLimbBoneName_IsValid;

	private static int AttackIKLimbBoneName_Offset;

	private static bool AttackIKRoll_IsValid;

	private static int AttackIKRoll_Offset;

	private static bool AttackIKPitch_IsValid;

	private static int AttackIKPitch_Offset;

	private static bool AttackIKTargetActorBoneName_IsValid;

	private static int AttackIKTargetActorBoneName_Offset;

	private static bool AttackIKBlendMinDistance_IsValid;

	private static int AttackIKBlendMinDistance_Offset;

	private static bool AttackIKBlendMaxDistance_IsValid;

	private static int AttackIKBlendMaxDistance_Offset;

	private static bool AttackIKLimitEnable_IsValid;

	private static int AttackIKLimitEnable_Offset;

	private static FFieldAddress AttackIKLimitEnable_PropertyAddress;

	private static bool AttackIKPitchLimit_IsValid;

	private static int AttackIKPitchLimit_Offset;

	public FAttackIKBonePairs Copy()
	{
		return this;
	}

	public static FAttackIKBonePairs FromNative(IntPtr nativeBuffer)
	{
		return new FAttackIKBonePairs(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAttackIKBonePairs value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAttackIKBonePairs FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAttackIKBonePairs(IntPtr.Add(nativeBuffer, arrayIndex * AttackIKBonePairs_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAttackIKBonePairs value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * AttackIKBonePairs_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (AttackIKBonePairs_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AttackIKBonePairs");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttackIKRootBoneName_Offset), AttackIKRootBoneName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttackIKLimbBoneName_Offset), AttackIKLimbBoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackIKRoll_Offset), AttackIKRoll);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackIKPitch_Offset), AttackIKPitch);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AttackIKTargetActorBoneName_Offset), AttackIKTargetActorBoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackIKBlendMinDistance_Offset), AttackIKBlendMinDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttackIKBlendMaxDistance_Offset), AttackIKBlendMaxDistance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AttackIKLimitEnable_Offset), 0, AttackIKLimitEnable_PropertyAddress.Address, AttackIKLimitEnable);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, AttackIKPitchLimit_Offset), AttackIKPitchLimit);
	}

	public FAttackIKBonePairs(IntPtr nativeStruct)
	{
		if (AttackIKBonePairs_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.AttackIKBonePairs");
			AttackIKRootBoneName = default(FName);
			AttackIKLimbBoneName = default(FName);
			AttackIKRoll = 0f;
			AttackIKPitch = 0f;
			AttackIKTargetActorBoneName = default(FName);
			AttackIKBlendMinDistance = 0f;
			AttackIKBlendMaxDistance = 0f;
			AttackIKLimitEnable = false;
			AttackIKPitchLimit = default(FVector2D);
		}
		else
		{
			AttackIKRootBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttackIKRootBoneName_Offset));
			AttackIKLimbBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttackIKLimbBoneName_Offset));
			AttackIKRoll = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackIKRoll_Offset));
			AttackIKPitch = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackIKPitch_Offset));
			AttackIKTargetActorBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AttackIKTargetActorBoneName_Offset));
			AttackIKBlendMinDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackIKBlendMinDistance_Offset));
			AttackIKBlendMaxDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttackIKBlendMaxDistance_Offset));
			AttackIKLimitEnable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AttackIKLimitEnable_Offset), 0, AttackIKLimitEnable_PropertyAddress.Address);
			AttackIKPitchLimit = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, AttackIKPitchLimit_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.AttackIKBonePairs");
		AttackIKBonePairs_StructSize = NativeReflection.GetStructSize(intPtr);
		AttackIKRootBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKRootBoneName");
		AttackIKRootBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKRootBoneName", Classes.FNameProperty);
		AttackIKLimbBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKLimbBoneName");
		AttackIKLimbBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKLimbBoneName", Classes.FNameProperty);
		AttackIKRoll_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKRoll");
		AttackIKRoll_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKRoll", Classes.FFloatProperty);
		AttackIKPitch_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKPitch");
		AttackIKPitch_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKPitch", Classes.FFloatProperty);
		AttackIKTargetActorBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKTargetActorBoneName");
		AttackIKTargetActorBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKTargetActorBoneName", Classes.FNameProperty);
		AttackIKBlendMinDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKBlendMinDistance");
		AttackIKBlendMinDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKBlendMinDistance", Classes.FFloatProperty);
		AttackIKBlendMaxDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKBlendMaxDistance");
		AttackIKBlendMaxDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKBlendMaxDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref AttackIKLimitEnable_PropertyAddress, intPtr, "AttackIKLimitEnable");
		AttackIKLimitEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKLimitEnable");
		AttackIKLimitEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKLimitEnable", Classes.FBoolProperty);
		AttackIKPitchLimit_Offset = NativeReflection.GetPropertyOffset(intPtr, "AttackIKPitchLimit");
		AttackIKPitchLimit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AttackIKPitchLimit", Classes.FStructProperty);
		AttackIKBonePairs_IsValid = ((intPtr != IntPtr.Zero && AttackIKRootBoneName_IsValid && AttackIKLimbBoneName_IsValid && AttackIKRoll_IsValid && AttackIKPitch_IsValid && AttackIKTargetActorBoneName_IsValid && AttackIKBlendMinDistance_IsValid && AttackIKBlendMaxDistance_IsValid && AttackIKLimitEnable_IsValid && AttackIKPitchLimit_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.AttackIKBonePairs", (byte)AttackIKBonePairs_IsValid != 0);
	}

	static FAttackIKBonePairs()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FAttackIKBonePairs)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAttackIKBonePairs));
	}
}
