using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaTimeStampInfo", "MediaAssets", UnrealModuleType.Engine)]
public class UMediaTimeStampInfo : UObject
{
	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool SequenceIndex_IsValid;

	private static int SequenceIndex_Offset;

	[UProperty(Flags = (PropFlags)6755468160533012uL)]
	[UMetaPath("/Script/MediaAssets.MediaTimeStampInfo:Time")]
	public FTimespan Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTimeStampInfo:Time");
				return default(FTimespan);
			}
			return FTimespan.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTimeStampInfo:Time");
			}
			else
			{
				FTimespan.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/MediaAssets.MediaTimeStampInfo:SequenceIndex")]
	public long SequenceIndex
	{
		get
		{
			CheckDestroyed();
			if (!SequenceIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTimeStampInfo:SequenceIndex");
				return 0L;
			}
			return BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(base.Address, SequenceIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SequenceIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaAssets.MediaTimeStampInfo:SequenceIndex");
			}
			else
			{
				BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(base.Address, SequenceIndex_Offset), value);
			}
		}
	}

	static UMediaTimeStampInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaTimeStampInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaTimeStampInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MediaAssets.MediaTimeStampInfo");
		Time_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Time", Classes.FStructProperty);
		SequenceIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SequenceIndex");
		SequenceIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SequenceIndex", Classes.FInt64Property);
	}
}
