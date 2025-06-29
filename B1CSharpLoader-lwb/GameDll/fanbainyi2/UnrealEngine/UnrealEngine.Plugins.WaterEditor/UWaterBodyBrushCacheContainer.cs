using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.WaterEditor;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/WaterEditor.WaterBodyBrushCacheContainer", "WaterEditor", UnrealModuleType.EnginePlugin)]
public class UWaterBodyBrushCacheContainer : UObject
{
	private static bool Cache_IsValid;

	private static int Cache_Offset;

	[UProperty(Flags = (PropFlags)4503668346912773uL)]
	[UMetaPath("/Script/WaterEditor.WaterBodyBrushCacheContainer:Cache")]
	protected FWaterBodyBrushCache Cache
	{
		get
		{
			CheckDestroyed();
			if (!Cache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBodyBrushCacheContainer:Cache");
				return default(FWaterBodyBrushCache);
			}
			return FWaterBodyBrushCache.FromNative(IntPtr.Add(base.Address, Cache_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Cache_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/WaterEditor.WaterBodyBrushCacheContainer:Cache");
			}
			else
			{
				FWaterBodyBrushCache.ToNative(IntPtr.Add(base.Address, Cache_Offset), value);
			}
		}
	}

	static UWaterBodyBrushCacheContainer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWaterBodyBrushCacheContainer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWaterBodyBrushCacheContainer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/WaterEditor.WaterBodyBrushCacheContainer");
		Cache_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Cache");
		Cache_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Cache", Classes.FStructProperty);
	}
}
