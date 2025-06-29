using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)810553504uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.StreamMediaSource", "MediaAssets", UnrealModuleType.Engine)]
public class UStreamMediaSource : UBaseMediaSource
{
	private static bool StreamUrl_IsValid;

	private static int StreamUrl_Offset;

	[UProperty(Flags = (PropFlags)6756498952684037uL)]
	[UMetaPath("/Script/MediaAssets.StreamMediaSource:StreamUrl")]
	public string StreamUrl
	{
		get
		{
			CheckDestroyed();
			if (!StreamUrl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.StreamMediaSource:StreamUrl");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, StreamUrl_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StreamUrl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.StreamMediaSource:StreamUrl");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, StreamUrl_Offset), value);
			}
		}
	}

	static UStreamMediaSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UStreamMediaSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UStreamMediaSource));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MediaAssets.StreamMediaSource");
		StreamUrl_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StreamUrl");
		StreamUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StreamUrl", Classes.FStrProperty);
	}
}
