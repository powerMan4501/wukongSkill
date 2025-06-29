using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWPreloadDataAsset", "b1", UnrealModuleType.Game)]
public class UBGWPreloadDataAsset : UBGWDataAsset
{
	private static bool PreloadAssets_IsValid;

	private static FFieldAddress PreloadAssets_PropertyAddress;

	private static int PreloadAssets_Offset;

	private TArrayReadWriteMarshaler<TSoftObject<UObject>> PreloadAssets_MarshalerCached;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/b1.BGWPreloadDataAsset:PreloadAssets")]
	public TArrayReadWrite<TSoftObject<UObject>> PreloadAssets
	{
		get
		{
			CheckDestroyed();
			if (!PreloadAssets_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWPreloadDataAsset:PreloadAssets");
				return null;
			}
			if (PreloadAssets_MarshalerCached == null)
			{
				PreloadAssets_MarshalerCached = new TArrayReadWriteMarshaler<TSoftObject<UObject>>(1, PreloadAssets_PropertyAddress, CachedMarshalingDelegates<TSoftObject<UObject>, TSoftObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<TSoftObject<UObject>, TSoftObjectMarshaler<UObject>>.ToNative);
			}
			return PreloadAssets_MarshalerCached.FromNative(IntPtr.Add(base.Address, PreloadAssets_Offset));
		}
	}

	static UBGWPreloadDataAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWPreloadDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWPreloadDataAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGWPreloadDataAsset");
		NativeReflectionCached.GetPropertyRef(ref PreloadAssets_PropertyAddress, unrealStruct, "PreloadAssets");
		PreloadAssets_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreloadAssets");
		PreloadAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreloadAssets", Classes.FArrayProperty);
	}
}
