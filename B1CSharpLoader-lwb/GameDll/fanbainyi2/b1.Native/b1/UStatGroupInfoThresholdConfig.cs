using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.StatGroupInfoThresholdConfig", "UnrealExtent", UnrealModuleType.Game)]
public class UStatGroupInfoThresholdConfig : UPrimaryDataAsset
{
	private static bool SimulatedGraphicsCardConfig_IsValid;

	private static FFieldAddress SimulatedGraphicsCardConfig_PropertyAddress;

	private static int SimulatedGraphicsCardConfig_Offset;

	private TArrayReadWriteMarshaler<FStatUISimulatedGraphicsCardScaleFactor> SimulatedGraphicsCardConfig_MarshalerCached;

	private static bool ThresholdConfig_IsValid;

	private static FFieldAddress ThresholdConfig_PropertyAddress;

	private static int ThresholdConfig_Offset;

	private TArrayReadWriteMarshaler<FStatInfoThreshold> ThresholdConfig_MarshalerCached;

	private static bool TextColor_Medium_IsValid;

	private static int TextColor_Medium_Offset;

	private static bool TextColor_High_IsValid;

	private static int TextColor_High_Offset;

	private static bool TextColor_Severe_IsValid;

	private static int TextColor_Severe_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.StatGroupInfoThresholdConfig:SimulatedGraphicsCardConfig")]
	public TArrayReadWrite<FStatUISimulatedGraphicsCardScaleFactor> SimulatedGraphicsCardConfig
	{
		get
		{
			CheckDestroyed();
			if (!SimulatedGraphicsCardConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:SimulatedGraphicsCardConfig");
				return null;
			}
			if (SimulatedGraphicsCardConfig_MarshalerCached == null)
			{
				SimulatedGraphicsCardConfig_MarshalerCached = new TArrayReadWriteMarshaler<FStatUISimulatedGraphicsCardScaleFactor>(1, SimulatedGraphicsCardConfig_PropertyAddress, CachedMarshalingDelegates<FStatUISimulatedGraphicsCardScaleFactor, FStatUISimulatedGraphicsCardScaleFactor>.FromNative, CachedMarshalingDelegates<FStatUISimulatedGraphicsCardScaleFactor, FStatUISimulatedGraphicsCardScaleFactor>.ToNative);
			}
			return SimulatedGraphicsCardConfig_MarshalerCached.FromNative(IntPtr.Add(base.Address, SimulatedGraphicsCardConfig_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.StatGroupInfoThresholdConfig:ThresholdConfig")]
	public TArrayReadWrite<FStatInfoThreshold> ThresholdConfig
	{
		get
		{
			CheckDestroyed();
			if (!ThresholdConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:ThresholdConfig");
				return null;
			}
			if (ThresholdConfig_MarshalerCached == null)
			{
				ThresholdConfig_MarshalerCached = new TArrayReadWriteMarshaler<FStatInfoThreshold>(1, ThresholdConfig_PropertyAddress, CachedMarshalingDelegates<FStatInfoThreshold, FStatInfoThreshold>.FromNative, CachedMarshalingDelegates<FStatInfoThreshold, FStatInfoThreshold>.ToNative);
			}
			return ThresholdConfig_MarshalerCached.FromNative(IntPtr.Add(base.Address, ThresholdConfig_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_Medium")]
	public FLinearColor TextColor_Medium
	{
		get
		{
			CheckDestroyed();
			if (!TextColor_Medium_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_Medium");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TextColor_Medium_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextColor_Medium_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_Medium");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, TextColor_Medium_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_High")]
	public FLinearColor TextColor_High
	{
		get
		{
			CheckDestroyed();
			if (!TextColor_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_High");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TextColor_High_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextColor_High_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_High");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, TextColor_High_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_Severe")]
	public FLinearColor TextColor_Severe
	{
		get
		{
			CheckDestroyed();
			if (!TextColor_Severe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_Severe");
				return default(FLinearColor);
			}
			return BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(base.Address, TextColor_Severe_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextColor_Severe_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.StatGroupInfoThresholdConfig:TextColor_Severe");
			}
			else
			{
				BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(base.Address, TextColor_Severe_Offset), value);
			}
		}
	}

	static UStatGroupInfoThresholdConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStatGroupInfoThresholdConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStatGroupInfoThresholdConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.StatGroupInfoThresholdConfig");
		NativeReflectionCached.GetPropertyRef(ref SimulatedGraphicsCardConfig_PropertyAddress, unrealStruct, "SimulatedGraphicsCardConfig");
		SimulatedGraphicsCardConfig_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SimulatedGraphicsCardConfig");
		SimulatedGraphicsCardConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SimulatedGraphicsCardConfig", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ThresholdConfig_PropertyAddress, unrealStruct, "ThresholdConfig");
		ThresholdConfig_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ThresholdConfig");
		ThresholdConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ThresholdConfig", Classes.FArrayProperty);
		TextColor_Medium_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextColor_Medium");
		TextColor_Medium_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextColor_Medium", Classes.FStructProperty);
		TextColor_High_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextColor_High");
		TextColor_High_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextColor_High", Classes.FStructProperty);
		TextColor_Severe_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextColor_Severe");
		TextColor_Severe_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextColor_Severe", Classes.FStructProperty);
	}
}
