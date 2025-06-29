using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/UnrealExtent.VATAnimClipsInfoConfig", "UnrealExtent", UnrealModuleType.Game)]
public class UVATAnimClipsInfoConfig : UPrimaryDataAsset
{
	private static bool ClipConfigs_IsValid;

	private static FFieldAddress ClipConfigs_PropertyAddress;

	private static int ClipConfigs_Offset;

	private TArrayReadWriteMarshaler<FVATAnimClipInfo> ClipConfigs_MarshalerCached;

	private static bool TotalFrames_IsValid;

	private static int TotalFrames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimClipsInfoConfig:ClipConfigs")]
	public TArrayReadWrite<FVATAnimClipInfo> ClipConfigs
	{
		get
		{
			CheckDestroyed();
			if (!ClipConfigs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimClipsInfoConfig:ClipConfigs");
				return null;
			}
			if (ClipConfigs_MarshalerCached == null)
			{
				ClipConfigs_MarshalerCached = new TArrayReadWriteMarshaler<FVATAnimClipInfo>(1, ClipConfigs_PropertyAddress, CachedMarshalingDelegates<FVATAnimClipInfo, FVATAnimClipInfo>.FromNative, CachedMarshalingDelegates<FVATAnimClipInfo, FVATAnimClipInfo>.ToNative);
			}
			return ClipConfigs_MarshalerCached.FromNative(IntPtr.Add(base.Address, ClipConfigs_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.VATAnimClipsInfoConfig:TotalFrames")]
	public int TotalFrames
	{
		get
		{
			CheckDestroyed();
			if (!TotalFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimClipsInfoConfig:TotalFrames");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TotalFrames_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TotalFrames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealExtent.VATAnimClipsInfoConfig:TotalFrames");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TotalFrames_Offset), value);
			}
		}
	}

	static UVATAnimClipsInfoConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UVATAnimClipsInfoConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UVATAnimClipsInfoConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealExtent.VATAnimClipsInfoConfig");
		NativeReflectionCached.GetPropertyRef(ref ClipConfigs_PropertyAddress, unrealStruct, "ClipConfigs");
		ClipConfigs_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ClipConfigs");
		ClipConfigs_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ClipConfigs", Classes.FArrayProperty);
		TotalFrames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TotalFrames");
		TotalFrames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TotalFrames", Classes.FIntProperty);
	}
}
