using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.TimeSynchronizableMediaSource", "MediaAssets", UnrealModuleType.Engine)]
public class UTimeSynchronizableMediaSource : UBaseMediaSource
{
	private static bool UseTimeSynchronization_IsValid;

	private static FFieldAddress UseTimeSynchronization_PropertyAddress;

	private static int UseTimeSynchronization_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.TimeSynchronizableMediaSource:bUseTimeSynchronization")]
	public bool UseTimeSynchronization
	{
		get
		{
			CheckDestroyed();
			if (!UseTimeSynchronization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.TimeSynchronizableMediaSource:bUseTimeSynchronization");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseTimeSynchronization_Offset), 0, UseTimeSynchronization_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseTimeSynchronization_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.TimeSynchronizableMediaSource:bUseTimeSynchronization");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseTimeSynchronization_Offset), 0, UseTimeSynchronization_PropertyAddress.Address, value);
			}
		}
	}

	static UTimeSynchronizableMediaSource()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UTimeSynchronizableMediaSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UTimeSynchronizableMediaSource));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MediaAssets.TimeSynchronizableMediaSource");
		NativeReflectionCached.GetPropertyRef(ref UseTimeSynchronization_PropertyAddress, unrealStruct, "bUseTimeSynchronization");
		UseTimeSynchronization_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseTimeSynchronization");
		UseTimeSynchronization_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseTimeSynchronization", Classes.FBoolProperty);
	}
}
