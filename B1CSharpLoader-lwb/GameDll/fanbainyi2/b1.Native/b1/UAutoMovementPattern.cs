using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.AutoMovementPattern", "UnrealExtent", UnrealModuleType.Game)]
public class UAutoMovementPattern : UPrimaryDataAsset
{
	private static bool TickInterval_IsValid;

	private static int TickInterval_Offset;

	private static bool ViewingPattern_IsValid;

	private static int ViewingPattern_Offset;

	private static bool HeatmapConfig_IsValid;

	private static int HeatmapConfig_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementPattern:TickInterval")]
	public float TickInterval
	{
		get
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementPattern:TickInterval");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TickInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TickInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementPattern:TickInterval");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TickInterval_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementPattern:ViewingPattern")]
	public FAutoMovementViewingPattern ViewingPattern
	{
		get
		{
			CheckDestroyed();
			if (!ViewingPattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementPattern:ViewingPattern");
				return default(FAutoMovementViewingPattern);
			}
			return FAutoMovementViewingPattern.FromNative(IntPtr.Add(base.Address, ViewingPattern_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ViewingPattern_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementPattern:ViewingPattern");
			}
			else
			{
				FAutoMovementViewingPattern.ToNative(IntPtr.Add(base.Address, ViewingPattern_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementPattern:HeatmapConfig")]
	public FAutoMovementHeatmapConfig HeatmapConfig
	{
		get
		{
			CheckDestroyed();
			if (!HeatmapConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementPattern:HeatmapConfig");
				return default(FAutoMovementHeatmapConfig);
			}
			return FAutoMovementHeatmapConfig.FromNative(IntPtr.Add(base.Address, HeatmapConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeatmapConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.AutoMovementPattern:HeatmapConfig");
			}
			else
			{
				FAutoMovementHeatmapConfig.ToNative(IntPtr.Add(base.Address, HeatmapConfig_Offset), value);
			}
		}
	}

	static UAutoMovementPattern()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAutoMovementPattern)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAutoMovementPattern));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.AutoMovementPattern");
		TickInterval_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TickInterval");
		TickInterval_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TickInterval", Classes.FFloatProperty);
		ViewingPattern_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ViewingPattern");
		ViewingPattern_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ViewingPattern", Classes.FStructProperty);
		HeatmapConfig_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HeatmapConfig");
		HeatmapConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HeatmapConfig", Classes.FStructProperty);
	}
}
