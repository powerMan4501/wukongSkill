using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicCamera.CameraLensSettings", "CinematicCamera", UnrealModuleType.Engine)]
public struct FCameraLensSettings
{
	private static bool MinFocalLength_IsValid;

	private static int MinFocalLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLensSettings:MinFocalLength")]
	public float MinFocalLength;

	private static bool MaxFocalLength_IsValid;

	private static int MaxFocalLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLensSettings:MaxFocalLength")]
	public float MaxFocalLength;

	private static bool MinFStop_IsValid;

	private static int MinFStop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLensSettings:MinFStop")]
	public float MinFStop;

	private static bool MaxFStop_IsValid;

	private static int MaxFStop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLensSettings:MaxFStop")]
	public float MaxFStop;

	private static bool MinimumFocusDistance_IsValid;

	private static int MinimumFocusDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLensSettings:MinimumFocusDistance")]
	public float MinimumFocusDistance;

	private static bool DiaphragmBladeCount_IsValid;

	private static int DiaphragmBladeCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraLensSettings:DiaphragmBladeCount")]
	public int DiaphragmBladeCount;

	private static bool FCameraLensSettings_IsValid;

	private static int FCameraLensSettings_StructSize;

	public FCameraLensSettings Copy()
	{
		return this;
	}

	public static FCameraLensSettings FromNative(IntPtr nativeBuffer)
	{
		return new FCameraLensSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraLensSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraLensSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraLensSettings(nativeBuffer + arrayIndex * FCameraLensSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraLensSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraLensSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraLensSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraLensSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinFocalLength_Offset), MinFocalLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxFocalLength_Offset), MaxFocalLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinFStop_Offset), MinFStop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxFStop_Offset), MaxFStop);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinimumFocusDistance_Offset), MinimumFocusDistance);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, DiaphragmBladeCount_Offset), DiaphragmBladeCount);
	}

	public FCameraLensSettings(IntPtr nativeStruct)
	{
		if (!FCameraLensSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraLensSettings");
			MinFocalLength = 0f;
			MaxFocalLength = 0f;
			MinFStop = 0f;
			MaxFStop = 0f;
			MinimumFocusDistance = 0f;
			DiaphragmBladeCount = 0;
		}
		else
		{
			MinFocalLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinFocalLength_Offset));
			MaxFocalLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxFocalLength_Offset));
			MinFStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinFStop_Offset));
			MaxFStop = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxFStop_Offset));
			MinimumFocusDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinimumFocusDistance_Offset));
			DiaphragmBladeCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, DiaphragmBladeCount_Offset));
		}
	}

	static FCameraLensSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraLensSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraLensSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicCamera.CameraLensSettings");
		FCameraLensSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		MinFocalLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinFocalLength");
		MinFocalLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinFocalLength", Classes.FFloatProperty);
		MaxFocalLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxFocalLength");
		MaxFocalLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxFocalLength", Classes.FFloatProperty);
		MinFStop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinFStop");
		MinFStop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinFStop", Classes.FFloatProperty);
		MaxFStop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxFStop");
		MaxFStop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxFStop", Classes.FFloatProperty);
		MinimumFocusDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumFocusDistance");
		MinimumFocusDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumFocusDistance", Classes.FFloatProperty);
		DiaphragmBladeCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DiaphragmBladeCount");
		DiaphragmBladeCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DiaphragmBladeCount", Classes.FIntProperty);
		FCameraLensSettings_IsValid = intPtr != IntPtr.Zero && MinFocalLength_IsValid && MaxFocalLength_IsValid && MinFStop_IsValid && MaxFStop_IsValid && MinimumFocusDistance_IsValid && DiaphragmBladeCount_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicCamera.CameraLensSettings", FCameraLensSettings_IsValid);
	}
}
