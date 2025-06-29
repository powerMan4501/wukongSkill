using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniAssetComponent", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public class UHoudiniAssetComponent : UPrimitiveComponent, IHoudiniAssetStateEvents, IInterface
{
	private static bool HoudiniAsset_IsValid;

	private static int HoudiniAsset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniAssetComponent:HoudiniAsset")]
	public UHoudiniAsset HoudiniAsset
	{
		get
		{
			CheckDestroyed();
			if (!HoudiniAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniAssetComponent:HoudiniAsset");
				return null;
			}
			return UObjectMarshaler<UHoudiniAsset>.FromNative(IntPtr.Add(base.Address, HoudiniAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoudiniAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniAssetComponent:HoudiniAsset");
			}
			else
			{
				UObjectMarshaler<UHoudiniAsset>.ToNative(IntPtr.Add(base.Address, HoudiniAsset_Offset), value);
			}
		}
	}

	static UHoudiniAssetComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UHoudiniAssetComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UHoudiniAssetComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HoudiniEngineRuntime.HoudiniAssetComponent");
		HoudiniAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HoudiniAsset");
		HoudiniAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HoudiniAsset", Classes.FObjectProperty);
	}
}
