using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.HoudiniEngineRuntime;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniAssetActor", "HoudiniEngineRuntime", UnrealModuleType.GamePlugin)]
public class AHoudiniAssetActor : AActor
{
	private static bool HoudiniAssetComponent_IsValid;

	private static int HoudiniAssetComponent_Offset;

	[UProperty(Flags = (PropFlags)6755469234930205uL)]
	[UMetaPath("/Script/HoudiniEngineRuntime.HoudiniAssetActor:HoudiniAssetComponent")]
	public UHoudiniAssetComponent HoudiniAssetComponent
	{
		get
		{
			CheckDestroyed();
			if (!HoudiniAssetComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniAssetActor:HoudiniAssetComponent");
				return null;
			}
			return UObjectMarshaler<UHoudiniAssetComponent>.FromNative(IntPtr.Add(base.Address, HoudiniAssetComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoudiniAssetComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/HoudiniEngineRuntime.HoudiniAssetActor:HoudiniAssetComponent");
			}
			else
			{
				UObjectMarshaler<UHoudiniAssetComponent>.ToNative(IntPtr.Add(base.Address, HoudiniAssetComponent_Offset), value);
			}
		}
	}

	static AHoudiniAssetActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AHoudiniAssetActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AHoudiniAssetActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/HoudiniEngineRuntime.HoudiniAssetActor");
		HoudiniAssetComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HoudiniAssetComponent");
		HoudiniAssetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HoudiniAssetComponent", Classes.FObjectProperty);
	}
}
