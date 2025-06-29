using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig")]
public struct FSplineFlyMoveConfig
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("飞行单位类型")]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:UnitType")]
	public ESplineFlyUnitType UnitType;

	[DisplayName("控制单位")]
	[UMeta(MDProp.EditCondition, "UnitType == SplineFlyUnitType::Monster")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:Unit")]
	public TSoftObject<BUTamerActor> Unit;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("飞行轨迹")]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:SplineActor")]
	public TSoftObject<AActor> SplineActor;

	[DisplayName("飞行速度曲线")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:FlySpeed")]
	public UCurveFloat FlySpeed;

	[DisplayName("开始延迟时间")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:DelayTime")]
	public float DelayTime;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:JogSpeed")]
	public float JogSpeed;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:RunSpeed")]
	public float RunSpeed;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.SplineFlyMoveConfig:SprintSpeed")]
	public float SprintSpeed;

	private static int SplineFlyMoveConfig_StructSize;

	private static int SplineFlyMoveConfig_IsValid;

	private static bool UnitType_IsValid;

	private static int UnitType_Offset;

	private static FFieldAddress UnitType_PropertyAddress;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool SplineActor_IsValid;

	private static int SplineActor_Offset;

	private static bool FlySpeed_IsValid;

	private static int FlySpeed_Offset;

	private static bool DelayTime_IsValid;

	private static int DelayTime_Offset;

	private static bool JogSpeed_IsValid;

	private static int JogSpeed_Offset;

	private static bool RunSpeed_IsValid;

	private static int RunSpeed_Offset;

	private static bool SprintSpeed_IsValid;

	private static int SprintSpeed_Offset;

	public FSplineFlyMoveConfig Copy()
	{
		return this;
	}

	public static FSplineFlyMoveConfig FromNative(IntPtr nativeBuffer)
	{
		return new FSplineFlyMoveConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSplineFlyMoveConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSplineFlyMoveConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSplineFlyMoveConfig(IntPtr.Add(nativeBuffer, arrayIndex * SplineFlyMoveConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSplineFlyMoveConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * SplineFlyMoveConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (SplineFlyMoveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SplineFlyMoveConfig");
			return;
		}
		EnumMarshaler<ESplineFlyUnitType>.ToNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address, UnitType);
		TSoftObjectMarshaler<BUTamerActor>.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		TSoftObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, SplineActor_Offset), SplineActor);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, FlySpeed_Offset), FlySpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DelayTime_Offset), DelayTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, JogSpeed_Offset), JogSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RunSpeed_Offset), RunSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SprintSpeed_Offset), SprintSpeed);
	}

	public FSplineFlyMoveConfig(IntPtr nativeStruct)
	{
		if (SplineFlyMoveConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.SplineFlyMoveConfig");
			UnitType = ESplineFlyUnitType.Monster;
			Unit = default(TSoftObject<BUTamerActor>);
			SplineActor = default(TSoftObject<AActor>);
			FlySpeed = null;
			DelayTime = 0f;
			JogSpeed = 0f;
			RunSpeed = 0f;
			SprintSpeed = 0f;
		}
		else
		{
			UnitType = EnumMarshaler<ESplineFlyUnitType>.FromNative(IntPtr.Add(nativeStruct, UnitType_Offset), 0, UnitType_PropertyAddress.Address);
			Unit = TSoftObjectMarshaler<BUTamerActor>.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			SplineActor = TSoftObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, SplineActor_Offset));
			FlySpeed = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, FlySpeed_Offset));
			DelayTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DelayTime_Offset));
			JogSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, JogSpeed_Offset));
			RunSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RunSpeed_Offset));
			SprintSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SprintSpeed_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.SplineFlyMoveConfig");
		SplineFlyMoveConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref UnitType_PropertyAddress, intPtr, "UnitType");
		UnitType_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitType");
		UnitType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitType", Classes.FEnumProperty);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FSoftObjectProperty);
		SplineActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "SplineActor");
		SplineActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SplineActor", Classes.FSoftObjectProperty);
		FlySpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlySpeed");
		FlySpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlySpeed", Classes.FObjectProperty);
		DelayTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DelayTime");
		DelayTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DelayTime", Classes.FFloatProperty);
		JogSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "JogSpeed");
		JogSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JogSpeed", Classes.FFloatProperty);
		RunSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "RunSpeed");
		RunSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RunSpeed", Classes.FFloatProperty);
		SprintSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "SprintSpeed");
		SprintSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SprintSpeed", Classes.FFloatProperty);
		SplineFlyMoveConfig_IsValid = ((intPtr != IntPtr.Zero && UnitType_IsValid && Unit_IsValid && SplineActor_IsValid && FlySpeed_IsValid && DelayTime_IsValid && JogSpeed_IsValid && RunSpeed_IsValid && SprintSpeed_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.SplineFlyMoveConfig", (byte)SplineFlyMoveConfig_IsValid != 0);
	}

	static FSplineFlyMoveConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FSplineFlyMoveConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSplineFlyMoveConfig));
	}
}
