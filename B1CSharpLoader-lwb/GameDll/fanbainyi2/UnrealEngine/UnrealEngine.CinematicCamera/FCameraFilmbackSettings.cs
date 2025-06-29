using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicCamera.CameraFilmbackSettings", "CinematicCamera", UnrealModuleType.Engine)]
public struct FCameraFilmbackSettings
{
	private static bool SensorWidth_IsValid;

	private static int SensorWidth_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFilmbackSettings:SensorWidth")]
	public float SensorWidth;

	private static bool SensorHeight_IsValid;

	private static int SensorHeight_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFilmbackSettings:SensorHeight")]
	public float SensorHeight;

	private static bool SensorAspectRatio_IsValid;

	private static int SensorAspectRatio_Offset;

	[UProperty(Flags = (PropFlags)6755477824340501uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFilmbackSettings:SensorAspectRatio")]
	public float SensorAspectRatio;

	private static bool FCameraFilmbackSettings_IsValid;

	private static int FCameraFilmbackSettings_StructSize;

	public FCameraFilmbackSettings Copy()
	{
		return this;
	}

	public static FCameraFilmbackSettings FromNative(IntPtr nativeBuffer)
	{
		return new FCameraFilmbackSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraFilmbackSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraFilmbackSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraFilmbackSettings(nativeBuffer + arrayIndex * FCameraFilmbackSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraFilmbackSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraFilmbackSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraFilmbackSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraFilmbackSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SensorWidth_Offset), SensorWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SensorHeight_Offset), SensorHeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SensorAspectRatio_Offset), SensorAspectRatio);
	}

	public FCameraFilmbackSettings(IntPtr nativeStruct)
	{
		if (!FCameraFilmbackSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraFilmbackSettings");
			SensorWidth = 0f;
			SensorHeight = 0f;
			SensorAspectRatio = 0f;
		}
		else
		{
			SensorWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SensorWidth_Offset));
			SensorHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SensorHeight_Offset));
			SensorAspectRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SensorAspectRatio_Offset));
		}
	}

	static FCameraFilmbackSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraFilmbackSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraFilmbackSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicCamera.CameraFilmbackSettings");
		FCameraFilmbackSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		SensorWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SensorWidth");
		SensorWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SensorWidth", Classes.FFloatProperty);
		SensorHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SensorHeight");
		SensorHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SensorHeight", Classes.FFloatProperty);
		SensorAspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SensorAspectRatio");
		SensorAspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SensorAspectRatio", Classes.FFloatProperty);
		FCameraFilmbackSettings_IsValid = intPtr != IntPtr.Zero && SensorWidth_IsValid && SensorHeight_IsValid && SensorAspectRatio_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicCamera.CameraFilmbackSettings", FCameraFilmbackSettings_IsValid);
	}
}
