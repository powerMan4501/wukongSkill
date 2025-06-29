using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_ObservationModeConfig")]
public class BGWDataAsset_ObservationModeConfig : UBGWDataAsset
{
	private static bool ObModeConfigMap_IsValid;

	private static int ObModeConfigMap_Offset;

	private static FFieldAddress ObModeConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<EObModeSource, FObservationModeConfig> ObModeConfigMap_Marshaler;

	private static bool SpecialItemObModeConfigMap_IsValid;

	private static int SpecialItemObModeConfigMap_Offset;

	private static FFieldAddress SpecialItemObModeConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FSpecialItemObModeConfig> SpecialItemObModeConfigMap_Marshaler;

	[DisplayName("默认配置")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ObservationModeConfig:ObModeConfigMap")]
	public TMapReadWrite<EObModeSource, FObservationModeConfig> ObModeConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!ObModeConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ObservationModeConfig:ObModeConfigMap");
				return null;
			}
			if (ObModeConfigMap_Marshaler == null)
			{
				ObModeConfigMap_Marshaler = new TMapReadWriteMarshaler<EObModeSource, FObservationModeConfig>(1, ObModeConfigMap_PropertyAddress, CachedMarshalingDelegates<EObModeSource, EnumMarshaler<EObModeSource>>.FromNative, CachedMarshalingDelegates<EObModeSource, EnumMarshaler<EObModeSource>>.ToNative, CachedMarshalingDelegates<FObservationModeConfig, FObservationModeConfig>.FromNative, CachedMarshalingDelegates<FObservationModeConfig, FObservationModeConfig>.ToNative);
			}
			return ObModeConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, ObModeConfigMap_Offset));
		}
	}

	[DisplayName("特殊物品配置")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_ObservationModeConfig:SpecialItemObModeConfigMap")]
	public TMapReadWrite<int, FSpecialItemObModeConfig> SpecialItemObModeConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!SpecialItemObModeConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_ObservationModeConfig:SpecialItemObModeConfigMap");
				return null;
			}
			if (SpecialItemObModeConfigMap_Marshaler == null)
			{
				SpecialItemObModeConfigMap_Marshaler = new TMapReadWriteMarshaler<int, FSpecialItemObModeConfig>(1, SpecialItemObModeConfigMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FSpecialItemObModeConfig, FSpecialItemObModeConfig>.FromNative, CachedMarshalingDelegates<FSpecialItemObModeConfig, FSpecialItemObModeConfig>.ToNative);
			}
			return SpecialItemObModeConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, SpecialItemObModeConfigMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_ObservationModeConfig");
		NativeReflection.GetPropertyRef(ref ObModeConfigMap_PropertyAddress, unrealStruct, "ObModeConfigMap");
		ObModeConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ObModeConfigMap");
		ObModeConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ObModeConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref SpecialItemObModeConfigMap_PropertyAddress, unrealStruct, "SpecialItemObModeConfigMap");
		SpecialItemObModeConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialItemObModeConfigMap");
		SpecialItemObModeConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialItemObModeConfigMap", Classes.FMapProperty);
	}

	static BGWDataAsset_ObservationModeConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_ObservationModeConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_ObservationModeConfig));
	}
}
