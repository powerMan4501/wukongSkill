using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple", "UnrealExtent", UnrealModuleType.Game)]
public struct FAnimNotifyEventSimple
{
	private static bool StartTime_IsValid;

	private static int StartTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple:StartTime")]
	public float StartTime;

	private static bool Duration_IsValid;

	private static int Duration_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple:Duration")]
	public float Duration;

	private static bool NotifyName_IsValid;

	private static int NotifyName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple:NotifyName")]
	public FName NotifyName;

	private static bool Notify_IsValid;

	private static int Notify_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple:Notify")]
	public UAnimNotify Notify;

	private static bool NotifyStateClass_IsValid;

	private static int NotifyStateClass_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple:NotifyStateClass")]
	public UAnimNotifyState NotifyStateClass;

	private static bool GuidString_IsValid;

	private static int GuidString_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple:GuidString")]
	public string GuidString;

	private static bool TrackIndex_IsValid;

	private static int TrackIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AnimNotifyEventSimple:TrackIndex")]
	public int TrackIndex;

	private static bool FAnimNotifyEventSimple_IsValid;

	private static int FAnimNotifyEventSimple_StructSize;

	public FAnimNotifyEventSimple Copy()
	{
		return this;
	}

	public static FAnimNotifyEventSimple FromNative(IntPtr nativeBuffer)
	{
		return new FAnimNotifyEventSimple(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimNotifyEventSimple value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimNotifyEventSimple FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimNotifyEventSimple(nativeBuffer + arrayIndex * FAnimNotifyEventSimple_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimNotifyEventSimple value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimNotifyEventSimple_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimNotifyEventSimple_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AnimNotifyEventSimple");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, StartTime_Offset), StartTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Duration_Offset), Duration);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, NotifyName_Offset), NotifyName);
		UObjectMarshaler<UAnimNotify>.ToNative(IntPtr.Add(nativeStruct, Notify_Offset), Notify);
		UObjectMarshaler<UAnimNotifyState>.ToNative(IntPtr.Add(nativeStruct, NotifyStateClass_Offset), NotifyStateClass);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, GuidString_Offset), GuidString);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TrackIndex_Offset), TrackIndex);
	}

	public FAnimNotifyEventSimple(IntPtr nativeStruct)
	{
		if (!FAnimNotifyEventSimple_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AnimNotifyEventSimple");
			StartTime = 0f;
			Duration = 0f;
			NotifyName = default(FName);
			Notify = null;
			NotifyStateClass = null;
			GuidString = FStringMarshaler.DefaultString;
			TrackIndex = 0;
		}
		else
		{
			StartTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, StartTime_Offset));
			Duration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Duration_Offset));
			NotifyName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, NotifyName_Offset));
			Notify = UObjectMarshaler<UAnimNotify>.FromNative(IntPtr.Add(nativeStruct, Notify_Offset));
			NotifyStateClass = UObjectMarshaler<UAnimNotifyState>.FromNative(IntPtr.Add(nativeStruct, NotifyStateClass_Offset));
			GuidString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, GuidString_Offset));
			TrackIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TrackIndex_Offset));
		}
	}

	static FAnimNotifyEventSimple()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimNotifyEventSimple)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimNotifyEventSimple));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.AnimNotifyEventSimple");
		FAnimNotifyEventSimple_StructSize = NativeReflection.GetStructSize(intPtr);
		StartTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StartTime");
		StartTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StartTime", Classes.FFloatProperty);
		Duration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Duration");
		Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Duration", Classes.FFloatProperty);
		NotifyName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyName");
		NotifyName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyName", Classes.FNameProperty);
		Notify_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Notify");
		Notify_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Notify", Classes.FObjectProperty);
		NotifyStateClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NotifyStateClass");
		NotifyStateClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NotifyStateClass", Classes.FObjectProperty);
		GuidString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GuidString");
		GuidString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GuidString", Classes.FStrProperty);
		TrackIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrackIndex");
		TrackIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrackIndex", Classes.FIntProperty);
		FAnimNotifyEventSimple_IsValid = intPtr != IntPtr.Zero && StartTime_IsValid && Duration_IsValid && NotifyName_IsValid && Notify_IsValid && NotifyStateClass_IsValid && GuidString_IsValid && TrackIndex_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.AnimNotifyEventSimple", FAnimNotifyEventSimple_IsValid);
	}
}
