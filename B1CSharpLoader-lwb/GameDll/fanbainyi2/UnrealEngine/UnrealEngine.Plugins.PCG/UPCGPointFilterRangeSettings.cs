using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGPointFilterRangeSettings", "PCG", UnrealModuleType.EnginePlugin)]
public class UPCGPointFilterRangeSettings : UPCGSettings
{
	private static bool TargetAttribute_IsValid;

	private static int TargetAttribute_Offset;

	private static bool MinThreshold_IsValid;

	private static int MinThreshold_Offset;

	private static bool MaxThreshold_IsValid;

	private static int MaxThreshold_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterRangeSettings:TargetAttribute")]
	public FPCGAttributePropertyInputSelector TargetAttribute
	{
		get
		{
			CheckDestroyed();
			if (!TargetAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterRangeSettings:TargetAttribute");
				return default(FPCGAttributePropertyInputSelector);
			}
			return FPCGAttributePropertyInputSelector.FromNative(IntPtr.Add(base.Address, TargetAttribute_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetAttribute_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterRangeSettings:TargetAttribute");
			}
			else
			{
				FPCGAttributePropertyInputSelector.ToNative(IntPtr.Add(base.Address, TargetAttribute_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterRangeSettings:MinThreshold")]
	public FPCGPointFilterThresholdSettings MinThreshold
	{
		get
		{
			CheckDestroyed();
			if (!MinThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterRangeSettings:MinThreshold");
				return default(FPCGPointFilterThresholdSettings);
			}
			return FPCGPointFilterThresholdSettings.FromNative(IntPtr.Add(base.Address, MinThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterRangeSettings:MinThreshold");
			}
			else
			{
				FPCGPointFilterThresholdSettings.ToNative(IntPtr.Add(base.Address, MinThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/PCG.PCGPointFilterRangeSettings:MaxThreshold")]
	public FPCGPointFilterThresholdSettings MaxThreshold
	{
		get
		{
			CheckDestroyed();
			if (!MaxThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterRangeSettings:MaxThreshold");
				return default(FPCGPointFilterThresholdSettings);
			}
			return FPCGPointFilterThresholdSettings.FromNative(IntPtr.Add(base.Address, MaxThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/PCG.PCGPointFilterRangeSettings:MaxThreshold");
			}
			else
			{
				FPCGPointFilterThresholdSettings.ToNative(IntPtr.Add(base.Address, MaxThreshold_Offset), value);
			}
		}
	}

	static UPCGPointFilterRangeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UPCGPointFilterRangeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPCGPointFilterRangeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/PCG.PCGPointFilterRangeSettings");
		TargetAttribute_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TargetAttribute");
		TargetAttribute_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TargetAttribute", Classes.FStructProperty);
		MinThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MinThreshold");
		MinThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MinThreshold", Classes.FStructProperty);
		MaxThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaxThreshold");
		MaxThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaxThreshold", Classes.FStructProperty);
	}
}
