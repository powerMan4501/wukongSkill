using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkSegmentInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkSegmentInfo
{
	private static bool CurrentPosition_IsValid;

	private static int CurrentPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:CurrentPosition")]
	public int CurrentPosition;

	private static bool PreEntryDuration_IsValid;

	private static int PreEntryDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:PreEntryDuration")]
	public int PreEntryDuration;

	private static bool ActiveDuration_IsValid;

	private static int ActiveDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:ActiveDuration")]
	public int ActiveDuration;

	private static bool PostExitDuration_IsValid;

	private static int PostExitDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:PostExitDuration")]
	public int PostExitDuration;

	private static bool RemainingLookAheadTime_IsValid;

	private static int RemainingLookAheadTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:RemainingLookAheadTime")]
	public int RemainingLookAheadTime;

	private static bool BeatDuration_IsValid;

	private static int BeatDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:BeatDuration")]
	public float BeatDuration;

	private static bool BarDuration_IsValid;

	private static int BarDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:BarDuration")]
	public float BarDuration;

	private static bool GridDuration_IsValid;

	private static int GridDuration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:GridDuration")]
	public float GridDuration;

	private static bool GridOffset_IsValid;

	private static int GridOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/AkAudio.AkSegmentInfo:GridOffset")]
	public float GridOffset;

	private static bool FAkSegmentInfo_IsValid;

	private static int FAkSegmentInfo_StructSize;

	public FAkSegmentInfo Copy()
	{
		return this;
	}

	public static FAkSegmentInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAkSegmentInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkSegmentInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkSegmentInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkSegmentInfo(nativeBuffer + arrayIndex * FAkSegmentInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkSegmentInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkSegmentInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkSegmentInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkSegmentInfo");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CurrentPosition_Offset), CurrentPosition);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PreEntryDuration_Offset), PreEntryDuration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ActiveDuration_Offset), ActiveDuration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PostExitDuration_Offset), PostExitDuration);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RemainingLookAheadTime_Offset), RemainingLookAheadTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeatDuration_Offset), BeatDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BarDuration_Offset), BarDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GridDuration_Offset), GridDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GridOffset_Offset), GridOffset);
	}

	public FAkSegmentInfo(IntPtr nativeStruct)
	{
		if (!FAkSegmentInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkSegmentInfo");
			CurrentPosition = 0;
			PreEntryDuration = 0;
			ActiveDuration = 0;
			PostExitDuration = 0;
			RemainingLookAheadTime = 0;
			BeatDuration = 0f;
			BarDuration = 0f;
			GridDuration = 0f;
			GridOffset = 0f;
		}
		else
		{
			CurrentPosition = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CurrentPosition_Offset));
			PreEntryDuration = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PreEntryDuration_Offset));
			ActiveDuration = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ActiveDuration_Offset));
			PostExitDuration = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PostExitDuration_Offset));
			RemainingLookAheadTime = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RemainingLookAheadTime_Offset));
			BeatDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeatDuration_Offset));
			BarDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BarDuration_Offset));
			GridDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GridDuration_Offset));
			GridOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GridOffset_Offset));
		}
	}

	static FAkSegmentInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkSegmentInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkSegmentInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkSegmentInfo");
		FAkSegmentInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		CurrentPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentPosition");
		CurrentPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentPosition", Classes.FIntProperty);
		PreEntryDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreEntryDuration");
		PreEntryDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreEntryDuration", Classes.FIntProperty);
		ActiveDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveDuration");
		ActiveDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveDuration", Classes.FIntProperty);
		PostExitDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PostExitDuration");
		PostExitDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PostExitDuration", Classes.FIntProperty);
		RemainingLookAheadTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RemainingLookAheadTime");
		RemainingLookAheadTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RemainingLookAheadTime", Classes.FIntProperty);
		BeatDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BeatDuration");
		BeatDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BeatDuration", Classes.FFloatProperty);
		BarDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BarDuration");
		BarDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BarDuration", Classes.FFloatProperty);
		GridDuration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GridDuration");
		GridDuration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GridDuration", Classes.FFloatProperty);
		GridOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GridOffset");
		GridOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GridOffset", Classes.FFloatProperty);
		FAkSegmentInfo_IsValid = intPtr != IntPtr.Zero && CurrentPosition_IsValid && PreEntryDuration_IsValid && ActiveDuration_IsValid && PostExitDuration_IsValid && RemainingLookAheadTime_IsValid && BeatDuration_IsValid && BarDuration_IsValid && GridDuration_IsValid && GridOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkSegmentInfo", FAkSegmentInfo_IsValid);
	}
}
