using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig")]
public struct FNpcGuideSplineMoveConfig
{
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("SplineActor")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig:SplineActor")]
	public FGsActorGuidReference SplineActor;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("是否需要根据玩家距离改变速度")]
	[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig:NeedSwitchSpeedByDistanceToPlayer")]
	public bool NeedSwitchSpeedByDistanceToPlayer;

	[EditAnywhere]
	[DisplayName("固定移动速度")]
	[UMeta(MDProp.EditCondition, "!NeedSwitchSpeedByDistanceToPlayer")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig:SplineMoveSpeed")]
	public EAIMoveSpeedType SplineMoveSpeed;

	[DisplayName("Sprint距离")]
	[Tooltip("与玩家距离低于该值时，使用Sprint速度")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "NeedSwitchSpeedByDistanceToPlayer")]
	[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig:MaxDistance_Sprint")]
	public float MaxDistance_Sprint;

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("Run距离")]
	[Tooltip("与玩家距离低于该值时，使用Run速度")]
	[UMeta(MDProp.EditCondition, "NeedSwitchSpeedByDistanceToPlayer")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig:MaxDistance_Run")]
	public float MaxDistance_Run;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("与玩家距离低于该值时，使用Jog速度")]
	[UMeta(MDProp.EditCondition, "NeedSwitchSpeedByDistanceToPlayer")]
	[DisplayName("Jog距离")]
	[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig:MaxDistance_Jog")]
	public float MaxDistance_Jog;

	[UMeta(MDProp.EditCondition, "NeedSwitchSpeedByDistanceToPlayer")]
	[Tooltip("设置缓冲距离，切换速度后需要超过一定缓冲距离才能再次切换回之前的速度。防止频繁切换速度。")]
	[DisplayName("切换缓冲距离")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.NpcGuideSplineMoveConfig:DistanceBuffer")]
	public float DistanceBuffer;

	private static int NpcGuideSplineMoveConfig_StructSize;

	private static int NpcGuideSplineMoveConfig_IsValid;

	private static bool SplineActor_IsValid;

	private static int SplineActor_Offset;

	private static bool NeedSwitchSpeedByDistanceToPlayer_IsValid;

	private static int NeedSwitchSpeedByDistanceToPlayer_Offset;

	private static FFieldAddress NeedSwitchSpeedByDistanceToPlayer_PropertyAddress;

	private static bool SplineMoveSpeed_IsValid;

	private static int SplineMoveSpeed_Offset;

	private static FFieldAddress SplineMoveSpeed_PropertyAddress;

	private static bool MaxDistance_Sprint_IsValid;

	private static int MaxDistance_Sprint_Offset;

	private static bool MaxDistance_Run_IsValid;

	private static int MaxDistance_Run_Offset;

	private static bool MaxDistance_Jog_IsValid;

	private static int MaxDistance_Jog_Offset;

	private static bool DistanceBuffer_IsValid;

	private static int DistanceBuffer_Offset;

	public FNpcGuideSplineMoveConfig Copy()
	{
		return this;
	}

	public static FNpcGuideSplineMoveConfig FromNative(IntPtr nativeBuffer)
	{
		return new FNpcGuideSplineMoveConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FNpcGuideSplineMoveConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FNpcGuideSplineMoveConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FNpcGuideSplineMoveConfig(IntPtr.Add(nativeBuffer, arrayIndex * NpcGuideSplineMoveConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FNpcGuideSplineMoveConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * NpcGuideSplineMoveConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (NpcGuideSplineMoveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NpcGuideSplineMoveConfig");
			return;
		}
		FGsActorGuidReference.ToNative(IntPtr.Add(nativeStruct, SplineActor_Offset), SplineActor);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NeedSwitchSpeedByDistanceToPlayer_Offset), 0, NeedSwitchSpeedByDistanceToPlayer_PropertyAddress.Address, NeedSwitchSpeedByDistanceToPlayer);
		EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(nativeStruct, SplineMoveSpeed_Offset), 0, SplineMoveSpeed_PropertyAddress.Address, SplineMoveSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Sprint_Offset), MaxDistance_Sprint);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Run_Offset), MaxDistance_Run);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxDistance_Jog_Offset), MaxDistance_Jog);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DistanceBuffer_Offset), DistanceBuffer);
	}

	public FNpcGuideSplineMoveConfig(IntPtr nativeStruct)
	{
		if (NpcGuideSplineMoveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.NpcGuideSplineMoveConfig");
			SplineActor = default(FGsActorGuidReference);
			NeedSwitchSpeedByDistanceToPlayer = false;
			SplineMoveSpeed = EAIMoveSpeedType.JOG;
			MaxDistance_Sprint = 0f;
			MaxDistance_Run = 0f;
			MaxDistance_Jog = 0f;
			DistanceBuffer = 0f;
		}
		else
		{
			SplineActor = FGsActorGuidReference.FromNative(IntPtr.Add(nativeStruct, SplineActor_Offset));
			NeedSwitchSpeedByDistanceToPlayer = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NeedSwitchSpeedByDistanceToPlayer_Offset), 0, NeedSwitchSpeedByDistanceToPlayer_PropertyAddress.Address);
			SplineMoveSpeed = EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(nativeStruct, SplineMoveSpeed_Offset), 0, SplineMoveSpeed_PropertyAddress.Address);
			MaxDistance_Sprint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Sprint_Offset));
			MaxDistance_Run = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Run_Offset));
			MaxDistance_Jog = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxDistance_Jog_Offset));
			DistanceBuffer = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DistanceBuffer_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.NpcGuideSplineMoveConfig");
		NpcGuideSplineMoveConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		SplineActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineActor");
		SplineActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineActor", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref NeedSwitchSpeedByDistanceToPlayer_PropertyAddress, intPtr, "NeedSwitchSpeedByDistanceToPlayer");
		NeedSwitchSpeedByDistanceToPlayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "NeedSwitchSpeedByDistanceToPlayer");
		NeedSwitchSpeedByDistanceToPlayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NeedSwitchSpeedByDistanceToPlayer", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref SplineMoveSpeed_PropertyAddress, intPtr, "SplineMoveSpeed");
		SplineMoveSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineMoveSpeed");
		SplineMoveSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineMoveSpeed", Classes.FEnumProperty);
		MaxDistance_Sprint_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance_Sprint");
		MaxDistance_Sprint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance_Sprint", Classes.FFloatProperty);
		MaxDistance_Run_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance_Run");
		MaxDistance_Run_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance_Run", Classes.FFloatProperty);
		MaxDistance_Jog_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxDistance_Jog");
		MaxDistance_Jog_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxDistance_Jog", Classes.FFloatProperty);
		DistanceBuffer_Offset = NativeReflection.GetPropertyOffset(intPtr, "DistanceBuffer");
		DistanceBuffer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DistanceBuffer", Classes.FFloatProperty);
		NpcGuideSplineMoveConfig_IsValid = ((intPtr != IntPtr.Zero && SplineActor_IsValid && NeedSwitchSpeedByDistanceToPlayer_IsValid && SplineMoveSpeed_IsValid && MaxDistance_Sprint_IsValid && MaxDistance_Run_IsValid && MaxDistance_Jog_IsValid && DistanceBuffer_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.NpcGuideSplineMoveConfig", (byte)NpcGuideSplineMoveConfig_IsValid != 0);
	}

	static FNpcGuideSplineMoveConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FNpcGuideSplineMoveConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FNpcGuideSplineMoveConfig));
	}
}
