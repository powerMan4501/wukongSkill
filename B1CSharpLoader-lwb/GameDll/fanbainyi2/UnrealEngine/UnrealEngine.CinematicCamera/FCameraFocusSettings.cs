using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.CinematicCamera;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CinematicCamera.CameraFocusSettings", "CinematicCamera", UnrealModuleType.Engine)]
public struct FCameraFocusSettings
{
	private static bool FocusMethod_IsValid;

	private static FFieldAddress FocusMethod_PropertyAddress;

	private static int FocusMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFocusSettings:FocusMethod")]
	public ECameraFocusMethod FocusMethod;

	private static bool ManualFocusDistance_IsValid;

	private static int ManualFocusDistance_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFocusSettings:ManualFocusDistance")]
	public float ManualFocusDistance;

	private static bool TrackingFocusSettings_IsValid;

	private static int TrackingFocusSettings_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFocusSettings:TrackingFocusSettings")]
	public FCameraTrackingFocusSettings TrackingFocusSettings;

	private static bool SmoothFocusChanges_IsValid;

	private static FFieldAddress SmoothFocusChanges_PropertyAddress;

	private static int SmoothFocusChanges_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFocusSettings:bSmoothFocusChanges")]
	public bool SmoothFocusChanges;

	private static bool FocusSmoothingInterpSpeed_IsValid;

	private static int FocusSmoothingInterpSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFocusSettings:FocusSmoothingInterpSpeed")]
	public float FocusSmoothingInterpSpeed;

	private static bool FocusOffset_IsValid;

	private static int FocusOffset_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/CinematicCamera.CameraFocusSettings:FocusOffset")]
	public float FocusOffset;

	private static bool FCameraFocusSettings_IsValid;

	private static int FCameraFocusSettings_StructSize;

	public FCameraFocusSettings Copy()
	{
		return this;
	}

	public static FCameraFocusSettings FromNative(IntPtr nativeBuffer)
	{
		return new FCameraFocusSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCameraFocusSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCameraFocusSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCameraFocusSettings(nativeBuffer + arrayIndex * FCameraFocusSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCameraFocusSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCameraFocusSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCameraFocusSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraFocusSettings");
			return;
		}
		EnumMarshaler<ECameraFocusMethod>.ToNative(IntPtr.Add(nativeStruct, FocusMethod_Offset), 0, FocusMethod_PropertyAddress.Address, FocusMethod);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ManualFocusDistance_Offset), ManualFocusDistance);
		FCameraTrackingFocusSettings.ToNative(IntPtr.Add(nativeStruct, TrackingFocusSettings_Offset), TrackingFocusSettings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SmoothFocusChanges_Offset), 0, SmoothFocusChanges_PropertyAddress.Address, SmoothFocusChanges);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusSmoothingInterpSpeed_Offset), FocusSmoothingInterpSpeed);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusOffset_Offset), FocusOffset);
	}

	public FCameraFocusSettings(IntPtr nativeStruct)
	{
		if (!FCameraFocusSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CinematicCamera.CameraFocusSettings");
			FocusMethod = ECameraFocusMethod.DoNotOverride;
			ManualFocusDistance = 0f;
			TrackingFocusSettings = default(FCameraTrackingFocusSettings);
			SmoothFocusChanges = false;
			FocusSmoothingInterpSpeed = 0f;
			FocusOffset = 0f;
		}
		else
		{
			FocusMethod = EnumMarshaler<ECameraFocusMethod>.FromNative(IntPtr.Add(nativeStruct, FocusMethod_Offset), 0, FocusMethod_PropertyAddress.Address);
			ManualFocusDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ManualFocusDistance_Offset));
			TrackingFocusSettings = FCameraTrackingFocusSettings.FromNative(IntPtr.Add(nativeStruct, TrackingFocusSettings_Offset));
			SmoothFocusChanges = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SmoothFocusChanges_Offset), 0, SmoothFocusChanges_PropertyAddress.Address);
			FocusSmoothingInterpSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusSmoothingInterpSpeed_Offset));
			FocusOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusOffset_Offset));
		}
	}

	static FCameraFocusSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCameraFocusSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCameraFocusSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CinematicCamera.CameraFocusSettings");
		FCameraFocusSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FocusMethod_PropertyAddress, intPtr, "FocusMethod");
		FocusMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusMethod");
		FocusMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusMethod", Classes.FEnumProperty);
		ManualFocusDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManualFocusDistance");
		ManualFocusDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManualFocusDistance", Classes.FFloatProperty);
		TrackingFocusSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrackingFocusSettings");
		TrackingFocusSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrackingFocusSettings", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SmoothFocusChanges_PropertyAddress, intPtr, "bSmoothFocusChanges");
		SmoothFocusChanges_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSmoothFocusChanges");
		SmoothFocusChanges_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSmoothFocusChanges", Classes.FBoolProperty);
		FocusSmoothingInterpSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusSmoothingInterpSpeed");
		FocusSmoothingInterpSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusSmoothingInterpSpeed", Classes.FFloatProperty);
		FocusOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusOffset");
		FocusOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusOffset", Classes.FFloatProperty);
		FCameraFocusSettings_IsValid = intPtr != IntPtr.Zero && FocusMethod_IsValid && ManualFocusDistance_IsValid && TrackingFocusSettings_IsValid && SmoothFocusChanges_IsValid && FocusSmoothingInterpSpeed_IsValid && FocusOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/CinematicCamera.CameraFocusSettings", FCameraFocusSettings_IsValid);
	}
}
