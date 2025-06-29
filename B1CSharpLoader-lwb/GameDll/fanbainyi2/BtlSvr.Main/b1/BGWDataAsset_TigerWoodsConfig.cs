using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig")]
public class BGWDataAsset_TigerWoodsConfig : UBGWDataAsset
{
	private static bool TWImpulseDataList_IsValid;

	private static int TWImpulseDataList_Offset;

	private static FFieldAddress TWImpulseDataList_PropertyAddress;

	private TArrayReadWriteMarshaler<FTWImpulseData> TWImpulseDataList_Marshaler;

	private static bool TWImpulseBlendCurve_IsValid;

	private static int TWImpulseBlendCurve_Offset;

	private static bool TWForceDataList_IsValid;

	private static int TWForceDataList_Offset;

	private static FFieldAddress TWForceDataList_PropertyAddress;

	private TArrayReadWriteMarshaler<FTWForceData> TWForceDataList_Marshaler;

	private static bool TWForceBlendCurve_IsValid;

	private static int TWForceBlendCurve_Offset;

	private static bool PhysicsDistanceThreshold_IsValid;

	private static int PhysicsDistanceThreshold_Offset;

	private static bool InterpolationDistanceThreshold_IsValid;

	private static int InterpolationDistanceThreshold_Offset;

	private static bool LocationInterpolationSpeedCurve_IsValid;

	private static int LocationInterpolationSpeedCurve_Offset;

	private static bool RotationInterpolationSpeedCurve_IsValid;

	private static int RotationInterpolationSpeedCurve_Offset;

	[DisplayName("冲量混合数据列表")]
	[Category("Physics Simulation")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWImpulseDataList")]
	public TArrayReadWrite<FTWImpulseData> TWImpulseDataList
	{
		get
		{
			CheckDestroyed();
			if (!TWImpulseDataList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWImpulseDataList");
				return null;
			}
			if (TWImpulseDataList_Marshaler == null)
			{
				TWImpulseDataList_Marshaler = new TArrayReadWriteMarshaler<FTWImpulseData>(1, TWImpulseDataList_PropertyAddress, CachedMarshalingDelegates<FTWImpulseData, FTWImpulseData>.FromNative, CachedMarshalingDelegates<FTWImpulseData, FTWImpulseData>.ToNative);
			}
			return TWImpulseDataList_Marshaler.FromNative(IntPtr.Add(base.Address, TWImpulseDataList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("冲量混合曲线（距离-冲量缩放倍率）")]
	[Category("Physics Simulation")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWImpulseBlendCurve")]
	public UCurveFloat TWImpulseBlendCurve
	{
		get
		{
			CheckDestroyed();
			if (!TWImpulseBlendCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWImpulseBlendCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, TWImpulseBlendCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TWImpulseBlendCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWImpulseBlendCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, TWImpulseBlendCurve_Offset), value);
			}
		}
	}

	[Category("Physics Simulation")]
	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[DisplayName("力混合数据列表")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWForceDataList")]
	public TArrayReadWrite<FTWForceData> TWForceDataList
	{
		get
		{
			CheckDestroyed();
			if (!TWForceDataList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWForceDataList");
				return null;
			}
			if (TWForceDataList_Marshaler == null)
			{
				TWForceDataList_Marshaler = new TArrayReadWriteMarshaler<FTWForceData>(1, TWForceDataList_PropertyAddress, CachedMarshalingDelegates<FTWForceData, FTWForceData>.FromNative, CachedMarshalingDelegates<FTWForceData, FTWForceData>.ToNative);
			}
			return TWForceDataList_Marshaler.FromNative(IntPtr.Add(base.Address, TWForceDataList_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("力混合曲线（距离-力缩放倍率）")]
	[Category("Physics Simulation")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWForceBlendCurve")]
	public UCurveFloat TWForceBlendCurve
	{
		get
		{
			CheckDestroyed();
			if (!TWForceBlendCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWForceBlendCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, TWForceBlendCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TWForceBlendCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:TWForceBlendCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, TWForceBlendCurve_Offset), value);
			}
		}
	}

	[Category("Physics Simulation")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("物理模拟距离阈值")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:PhysicsDistanceThreshold")]
	public float PhysicsDistanceThreshold
	{
		get
		{
			CheckDestroyed();
			if (!PhysicsDistanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:PhysicsDistanceThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PhysicsDistanceThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PhysicsDistanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:PhysicsDistanceThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PhysicsDistanceThreshold_Offset), value);
			}
		}
	}

	[Category("Interpolation")]
	[DisplayName("插值距离阈值")]
	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:InterpolationDistanceThreshold")]
	public float InterpolationDistanceThreshold
	{
		get
		{
			CheckDestroyed();
			if (!InterpolationDistanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:InterpolationDistanceThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpolationDistanceThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpolationDistanceThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:InterpolationDistanceThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpolationDistanceThreshold_Offset), value);
			}
		}
	}

	[Category("Interpolation")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("位移插值速度曲线（距离-位移插值速度）")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:LocationInterpolationSpeedCurve")]
	public UCurveFloat LocationInterpolationSpeedCurve
	{
		get
		{
			CheckDestroyed();
			if (!LocationInterpolationSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:LocationInterpolationSpeedCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, LocationInterpolationSpeedCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LocationInterpolationSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:LocationInterpolationSpeedCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, LocationInterpolationSpeedCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Interpolation")]
	[UProperty]
	[BlueprintReadOnly]
	[DisplayName("旋转插值速度曲线（距离-旋转插值速度）")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:RotationInterpolationSpeedCurve")]
	public UCurveFloat RotationInterpolationSpeedCurve
	{
		get
		{
			CheckDestroyed();
			if (!RotationInterpolationSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:RotationInterpolationSpeedCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, RotationInterpolationSpeedCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RotationInterpolationSpeedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig:RotationInterpolationSpeedCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, RotationInterpolationSpeedCurve_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TigerWoodsConfig");
		NativeReflection.GetPropertyRef(ref TWImpulseDataList_PropertyAddress, unrealStruct, "TWImpulseDataList");
		TWImpulseDataList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TWImpulseDataList");
		TWImpulseDataList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TWImpulseDataList", Classes.FArrayProperty);
		TWImpulseBlendCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TWImpulseBlendCurve");
		TWImpulseBlendCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TWImpulseBlendCurve", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TWForceDataList_PropertyAddress, unrealStruct, "TWForceDataList");
		TWForceDataList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TWForceDataList");
		TWForceDataList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TWForceDataList", Classes.FArrayProperty);
		TWForceBlendCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TWForceBlendCurve");
		TWForceBlendCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TWForceBlendCurve", Classes.FObjectProperty);
		PhysicsDistanceThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PhysicsDistanceThreshold");
		PhysicsDistanceThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PhysicsDistanceThreshold", Classes.FFloatProperty);
		InterpolationDistanceThreshold_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InterpolationDistanceThreshold");
		InterpolationDistanceThreshold_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InterpolationDistanceThreshold", Classes.FFloatProperty);
		LocationInterpolationSpeedCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LocationInterpolationSpeedCurve");
		LocationInterpolationSpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LocationInterpolationSpeedCurve", Classes.FObjectProperty);
		RotationInterpolationSpeedCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RotationInterpolationSpeedCurve");
		RotationInterpolationSpeedCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RotationInterpolationSpeedCurve", Classes.FObjectProperty);
	}

	static BGWDataAsset_TigerWoodsConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TigerWoodsConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TigerWoodsConfig));
	}
}
