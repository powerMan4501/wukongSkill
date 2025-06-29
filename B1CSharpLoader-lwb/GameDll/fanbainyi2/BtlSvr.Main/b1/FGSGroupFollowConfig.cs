using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig")]
public struct FGSGroupFollowConfig
{
	[BlueprintReadWrite]
	[DisplayName("开启速率调整")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig:bEnableAdjustTimeRate")]
	public bool bEnableAdjustTimeRate;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("最小跟随速率")]
	[UMeta(MDProp.EditCondition, "bEnableAdjustTimeRate")]
	[UMeta(MDProp.ClampMin, "0")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig:MinTimeRate")]
	public float MinTimeRate;

	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "bEnableAdjustTimeRate")]
	[DisplayName("最大跟随速率")]
	[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig:MaxTimeRate")]
	public float MaxTimeRate;

	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("最小跟随速率距离")]
	[Tooltip("距离跟随目标距离小于此距离时，将使用最小跟随速率进行移动")]
	[UMeta(MDProp.EditCondition, "bEnableAdjustTimeRate")]
	[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig:MinRateDistance")]
	public float MinRateDistance;

	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "bEnableAdjustTimeRate")]
	[Tooltip("距离跟随目标距离在此距离和“最小跟随速率距离”之间时，移动速率将在 最小跟随速率～1 之间按比例计算; 在此距离和“增加跟随速率距离”之间时，移动速率为1。")]
	[DisplayName("减少跟随速率距离")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig:DecreaseRateDistance")]
	public float DecreaseRateDistance;

	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.EditCondition, "bEnableAdjustTimeRate")]
	[Tooltip("距离跟随目标距离在此距离和“最大跟随速率距离”之间时，移动速率将在 1～最大跟随速率 之间按比例计算; 在此距离和“减少跟随速率距离”之间时，移动速率为1。")]
	[DisplayName("增加跟随速率距离")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig:IncreaseRateDistance")]
	public float IncreaseRateDistance;

	[UMeta(MDProp.EditCondition, "bEnableAdjustTimeRate")]
	[DisplayName("最大跟随速率距离")]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("距离跟随目标距离大于此距离时，将使用最大跟随速率进行移动")]
	[USharpPath("/Script/b1-Managed.FGSGroupFollowConfig:MaxRateDistance")]
	public float MaxRateDistance;

	private static int FGSGroupFollowConfig_StructSize;

	private static int FGSGroupFollowConfig_IsValid;

	private static bool bEnableAdjustTimeRate_IsValid;

	private static int bEnableAdjustTimeRate_Offset;

	private static FFieldAddress bEnableAdjustTimeRate_PropertyAddress;

	private static bool MinTimeRate_IsValid;

	private static int MinTimeRate_Offset;

	private static bool MaxTimeRate_IsValid;

	private static int MaxTimeRate_Offset;

	private static bool MinRateDistance_IsValid;

	private static int MinRateDistance_Offset;

	private static bool DecreaseRateDistance_IsValid;

	private static int DecreaseRateDistance_Offset;

	private static bool IncreaseRateDistance_IsValid;

	private static int IncreaseRateDistance_Offset;

	private static bool MaxRateDistance_IsValid;

	private static int MaxRateDistance_Offset;

	public FGSGroupFollowConfig Copy()
	{
		return this;
	}

	public static FGSGroupFollowConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSGroupFollowConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSGroupFollowConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSGroupFollowConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSGroupFollowConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSGroupFollowConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSGroupFollowConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSGroupFollowConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSGroupFollowConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSGroupFollowConfig");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableAdjustTimeRate_Offset), 0, bEnableAdjustTimeRate_PropertyAddress.Address, bEnableAdjustTimeRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinTimeRate_Offset), MinTimeRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxTimeRate_Offset), MaxTimeRate);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinRateDistance_Offset), MinRateDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DecreaseRateDistance_Offset), DecreaseRateDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, IncreaseRateDistance_Offset), IncreaseRateDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxRateDistance_Offset), MaxRateDistance);
	}

	public FGSGroupFollowConfig(IntPtr nativeStruct)
	{
		if (FGSGroupFollowConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSGroupFollowConfig");
			bEnableAdjustTimeRate = false;
			MinTimeRate = 0f;
			MaxTimeRate = 0f;
			MinRateDistance = 0f;
			DecreaseRateDistance = 0f;
			IncreaseRateDistance = 0f;
			MaxRateDistance = 0f;
		}
		else
		{
			bEnableAdjustTimeRate = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableAdjustTimeRate_Offset), 0, bEnableAdjustTimeRate_PropertyAddress.Address);
			MinTimeRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinTimeRate_Offset));
			MaxTimeRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxTimeRate_Offset));
			MinRateDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinRateDistance_Offset));
			DecreaseRateDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DecreaseRateDistance_Offset));
			IncreaseRateDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, IncreaseRateDistance_Offset));
			MaxRateDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxRateDistance_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSGroupFollowConfig");
		FGSGroupFollowConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref bEnableAdjustTimeRate_PropertyAddress, intPtr, "bEnableAdjustTimeRate");
		bEnableAdjustTimeRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableAdjustTimeRate");
		bEnableAdjustTimeRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableAdjustTimeRate", Classes.FBoolProperty);
		MinTimeRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinTimeRate");
		MinTimeRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinTimeRate", Classes.FFloatProperty);
		MaxTimeRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxTimeRate");
		MaxTimeRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxTimeRate", Classes.FFloatProperty);
		MinRateDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinRateDistance");
		MinRateDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinRateDistance", Classes.FFloatProperty);
		DecreaseRateDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "DecreaseRateDistance");
		DecreaseRateDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DecreaseRateDistance", Classes.FFloatProperty);
		IncreaseRateDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncreaseRateDistance");
		IncreaseRateDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncreaseRateDistance", Classes.FFloatProperty);
		MaxRateDistance_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxRateDistance");
		MaxRateDistance_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxRateDistance", Classes.FFloatProperty);
		FGSGroupFollowConfig_IsValid = ((intPtr != IntPtr.Zero && bEnableAdjustTimeRate_IsValid && MinTimeRate_IsValid && MaxTimeRate_IsValid && MinRateDistance_IsValid && DecreaseRateDistance_IsValid && IncreaseRateDistance_IsValid && MaxRateDistance_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSGroupFollowConfig", (byte)FGSGroupFollowConfig_IsValid != 0);
	}

	static FGSGroupFollowConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSGroupFollowConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSGroupFollowConfig));
	}
}
