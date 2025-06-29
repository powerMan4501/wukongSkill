using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MediaAssets;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/MediaAssets.MediaSoundComponentSpectralData", "MediaAssets", UnrealModuleType.Engine)]
public struct FMediaSoundComponentSpectralData
{
	private static bool FrequencyHz_IsValid;

	private static int FrequencyHz_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponentSpectralData:FrequencyHz")]
	public float FrequencyHz;

	private static bool Magnitude_IsValid;

	private static int Magnitude_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/MediaAssets.MediaSoundComponentSpectralData:Magnitude")]
	public float Magnitude;

	private static bool FMediaSoundComponentSpectralData_IsValid;

	private static int FMediaSoundComponentSpectralData_StructSize;

	public FMediaSoundComponentSpectralData Copy()
	{
		return this;
	}

	public static FMediaSoundComponentSpectralData FromNative(IntPtr nativeBuffer)
	{
		return new FMediaSoundComponentSpectralData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMediaSoundComponentSpectralData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMediaSoundComponentSpectralData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMediaSoundComponentSpectralData(nativeBuffer + arrayIndex * FMediaSoundComponentSpectralData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMediaSoundComponentSpectralData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMediaSoundComponentSpectralData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMediaSoundComponentSpectralData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaAssets.MediaSoundComponentSpectralData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FrequencyHz_Offset), FrequencyHz);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Magnitude_Offset), Magnitude);
	}

	public FMediaSoundComponentSpectralData(IntPtr nativeStruct)
	{
		if (!FMediaSoundComponentSpectralData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/MediaAssets.MediaSoundComponentSpectralData");
			FrequencyHz = 0f;
			Magnitude = 0f;
		}
		else
		{
			FrequencyHz = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FrequencyHz_Offset));
			Magnitude = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Magnitude_Offset));
		}
	}

	static FMediaSoundComponentSpectralData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMediaSoundComponentSpectralData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMediaSoundComponentSpectralData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/MediaAssets.MediaSoundComponentSpectralData");
		FMediaSoundComponentSpectralData_StructSize = NativeReflection.GetStructSize(intPtr);
		FrequencyHz_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrequencyHz");
		FrequencyHz_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrequencyHz", Classes.FFloatProperty);
		Magnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Magnitude");
		Magnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Magnitude", Classes.FFloatProperty);
		FMediaSoundComponentSpectralData_IsValid = intPtr != IntPtr.Zero && FrequencyHz_IsValid && Magnitude_IsValid;
		NativeReflection.LogStructIsValid("/Script/MediaAssets.MediaSoundComponentSpectralData", FMediaSoundComponentSpectralData_IsValid);
	}
}
