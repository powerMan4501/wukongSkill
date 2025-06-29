using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig")]
public class BGWDataAsset_EnvironmentAbnormalEffectConfig : UBGWDataAsset
{
	private static bool EnvironmentAbnormalEffectList_IsValid;

	private static int EnvironmentAbnormalEffectList_Offset;

	private static FFieldAddress EnvironmentAbnormalEffectList_PropertyAddress;

	private TArrayReadWriteMarshaler<EnvironmentAbnormalEffectConfig> EnvironmentAbnormalEffectList_Marshaler;

	private static bool Interval_IsValid;

	private static int Interval_Offset;

	private static bool EnvironmentAbnormalAutoRecoverRateList_IsValid;

	private static int EnvironmentAbnormalAutoRecoverRateList_Offset;

	private static FFieldAddress EnvironmentAbnormalAutoRecoverRateList_PropertyAddress;

	private TArrayReadWriteMarshaler<EnvironmentAbnormalRecoverRate> EnvironmentAbnormalAutoRecoverRateList_Marshaler;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig:EnvironmentAbnormalEffectList")]
	public TArrayReadWrite<EnvironmentAbnormalEffectConfig> EnvironmentAbnormalEffectList
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentAbnormalEffectList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig:EnvironmentAbnormalEffectList");
				return null;
			}
			if (EnvironmentAbnormalEffectList_Marshaler == null)
			{
				EnvironmentAbnormalEffectList_Marshaler = new TArrayReadWriteMarshaler<EnvironmentAbnormalEffectConfig>(1, EnvironmentAbnormalEffectList_PropertyAddress, CachedMarshalingDelegates<EnvironmentAbnormalEffectConfig, EnvironmentAbnormalEffectConfig>.FromNative, CachedMarshalingDelegates<EnvironmentAbnormalEffectConfig, EnvironmentAbnormalEffectConfig>.ToNative);
			}
			return EnvironmentAbnormalEffectList_Marshaler.FromNative(IntPtr.Add(base.Address, EnvironmentAbnormalEffectList_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig:Interval")]
	public float Interval
	{
		get
		{
			CheckDestroyed();
			if (!Interval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig:Interval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Interval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Interval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig:Interval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Interval_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig:EnvironmentAbnormalAutoRecoverRateList")]
	public TArrayReadWrite<EnvironmentAbnormalRecoverRate> EnvironmentAbnormalAutoRecoverRateList
	{
		get
		{
			CheckDestroyed();
			if (!EnvironmentAbnormalAutoRecoverRateList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig:EnvironmentAbnormalAutoRecoverRateList");
				return null;
			}
			if (EnvironmentAbnormalAutoRecoverRateList_Marshaler == null)
			{
				EnvironmentAbnormalAutoRecoverRateList_Marshaler = new TArrayReadWriteMarshaler<EnvironmentAbnormalRecoverRate>(1, EnvironmentAbnormalAutoRecoverRateList_PropertyAddress, CachedMarshalingDelegates<EnvironmentAbnormalRecoverRate, EnvironmentAbnormalRecoverRate>.FromNative, CachedMarshalingDelegates<EnvironmentAbnormalRecoverRate, EnvironmentAbnormalRecoverRate>.ToNative);
			}
			return EnvironmentAbnormalAutoRecoverRateList_Marshaler.FromNative(IntPtr.Add(base.Address, EnvironmentAbnormalAutoRecoverRateList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_EnvironmentAbnormalEffectConfig");
		NativeReflection.GetPropertyRef(ref EnvironmentAbnormalEffectList_PropertyAddress, unrealStruct, "EnvironmentAbnormalEffectList");
		EnvironmentAbnormalEffectList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnvironmentAbnormalEffectList");
		EnvironmentAbnormalEffectList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnvironmentAbnormalEffectList", Classes.FArrayProperty);
		Interval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Interval");
		Interval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Interval", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnvironmentAbnormalAutoRecoverRateList_PropertyAddress, unrealStruct, "EnvironmentAbnormalAutoRecoverRateList");
		EnvironmentAbnormalAutoRecoverRateList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "EnvironmentAbnormalAutoRecoverRateList");
		EnvironmentAbnormalAutoRecoverRateList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "EnvironmentAbnormalAutoRecoverRateList", Classes.FArrayProperty);
	}

	static BGWDataAsset_EnvironmentAbnormalEffectConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_EnvironmentAbnormalEffectConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_EnvironmentAbnormalEffectConfig));
	}
}
