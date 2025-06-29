using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.BaseMediaSource", "MediaAssets", UnrealModuleType.Engine)]
public class UBaseMediaSource : UMediaSource
{
	private static bool PlatformPlayerNames_IsValid;

	private static FFieldAddress PlatformPlayerNames_PropertyAddress;

	private static int PlatformPlayerNames_Offset;

	private TMapReadWriteMarshaler<string, FName> PlatformPlayerNames_MarshalerCached;

	[UProperty(Flags = (PropFlags)4503633987117061uL)]
	[UMetaPath("/Script/MediaAssets.BaseMediaSource:PlatformPlayerNames")]
	public TMapReadWrite<string, FName> PlatformPlayerNames
	{
		get
		{
			CheckDestroyed();
			if (!PlatformPlayerNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.BaseMediaSource:PlatformPlayerNames");
				return null;
			}
			if (PlatformPlayerNames_MarshalerCached == null)
			{
				PlatformPlayerNames_MarshalerCached = new TMapReadWriteMarshaler<string, FName>(1, PlatformPlayerNames_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return PlatformPlayerNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, PlatformPlayerNames_Offset));
		}
	}

	static UBaseMediaSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBaseMediaSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBaseMediaSource));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MediaAssets.BaseMediaSource");
		NativeReflectionCached.GetPropertyRef(ref PlatformPlayerNames_PropertyAddress, unrealStruct, "PlatformPlayerNames");
		PlatformPlayerNames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PlatformPlayerNames");
		PlatformPlayerNames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PlatformPlayerNames", Classes.FMapProperty);
	}
}
