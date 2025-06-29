using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 57352)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Timecode", "CoreUObject", UnrealModuleType.Engine)]
public struct FTimecode
{
	private static bool Hours_IsValid;

	private static int Hours_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CoreUObject.Timecode:Hours")]
	public int Hours;

	private static bool Minutes_IsValid;

	private static int Minutes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CoreUObject.Timecode:Minutes")]
	public int Minutes;

	private static bool Seconds_IsValid;

	private static int Seconds_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CoreUObject.Timecode:Seconds")]
	public int Seconds;

	private static bool Frames_IsValid;

	private static int Frames_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CoreUObject.Timecode:Frames")]
	public int Frames;

	private static bool DropFrameFormat_IsValid;

	private static FFieldAddress DropFrameFormat_PropertyAddress;

	private static int DropFrameFormat_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/CoreUObject.Timecode:bDropFrameFormat")]
	public bool DropFrameFormat;

	private static bool FTimecode_IsValid;

	private static int FTimecode_StructSize;

	public FTimecode Copy()
	{
		return this;
	}

	public static FTimecode FromNative(IntPtr nativeBuffer)
	{
		return new FTimecode(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTimecode value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTimecode FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTimecode(nativeBuffer + arrayIndex * FTimecode_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTimecode value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTimecode_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTimecode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Timecode");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Hours_Offset), Hours);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Minutes_Offset), Minutes);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Seconds_Offset), Seconds);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Frames_Offset), Frames);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DropFrameFormat_Offset), 0, DropFrameFormat_PropertyAddress.Address, DropFrameFormat);
	}

	public FTimecode(IntPtr nativeStruct)
	{
		if (!FTimecode_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CoreUObject.Timecode");
			Hours = 0;
			Minutes = 0;
			Seconds = 0;
			Frames = 0;
			DropFrameFormat = false;
		}
		else
		{
			Hours = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Hours_Offset));
			Minutes = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Minutes_Offset));
			Seconds = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Seconds_Offset));
			Frames = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Frames_Offset));
			DropFrameFormat = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DropFrameFormat_Offset), 0, DropFrameFormat_PropertyAddress.Address);
		}
	}

	static FTimecode()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTimecode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTimecode));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CoreUObject.Timecode");
		FTimecode_StructSize = NativeReflection.GetStructSize(intPtr);
		Hours_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Hours");
		Hours_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Hours", Classes.FIntProperty);
		Minutes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Minutes");
		Minutes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Minutes", Classes.FIntProperty);
		Seconds_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Seconds");
		Seconds_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Seconds", Classes.FIntProperty);
		Frames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Frames");
		Frames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Frames", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DropFrameFormat_PropertyAddress, intPtr, "bDropFrameFormat");
		DropFrameFormat_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDropFrameFormat");
		DropFrameFormat_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDropFrameFormat", Classes.FBoolProperty);
		FTimecode_IsValid = intPtr != IntPtr.Zero && Hours_IsValid && Minutes_IsValid && Seconds_IsValid && Frames_IsValid && DropFrameFormat_IsValid;
		NativeReflection.LogStructIsValid("/Script/CoreUObject.Timecode", FTimecode_IsValid);
	}
}
