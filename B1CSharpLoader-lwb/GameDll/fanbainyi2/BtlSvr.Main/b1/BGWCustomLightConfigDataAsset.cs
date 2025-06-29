using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWCustomLightConfigDataAsset")]
public class BGWCustomLightConfigDataAsset : UBGWDataAsset
{
	private static bool MapCustsomLightConfigs_IsValid;

	private static int MapCustsomLightConfigs_Offset;

	private static FFieldAddress MapCustsomLightConfigs_PropertyAddress;

	private TArrayReadWriteMarshaler<FSoftObjectPath> MapCustsomLightConfigs_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Map Light Setting")]
	[DisplayName("自定义光照池")]
	[USharpPath("/Script/b1-Managed.BGWCustomLightConfigDataAsset:MapCustsomLightConfigs")]
	public TArrayReadWrite<FSoftObjectPath> MapCustsomLightConfigs
	{
		get
		{
			CheckDestroyed();
			if (!MapCustsomLightConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWCustomLightConfigDataAsset:MapCustsomLightConfigs");
				return null;
			}
			if (MapCustsomLightConfigs_Marshaler == null)
			{
				MapCustsomLightConfigs_Marshaler = new TArrayReadWriteMarshaler<FSoftObjectPath>(1, MapCustsomLightConfigs_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative);
			}
			return MapCustsomLightConfigs_Marshaler.FromNative(IntPtr.Add(base.Address, MapCustsomLightConfigs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWCustomLightConfigDataAsset");
		NativeReflection.GetPropertyRef(ref MapCustsomLightConfigs_PropertyAddress, unrealStruct, "MapCustsomLightConfigs");
		MapCustsomLightConfigs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MapCustsomLightConfigs");
		MapCustsomLightConfigs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MapCustsomLightConfigs", Classes.FArrayProperty);
	}

	static BGWCustomLightConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWCustomLightConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWCustomLightConfigDataAsset));
	}
}
