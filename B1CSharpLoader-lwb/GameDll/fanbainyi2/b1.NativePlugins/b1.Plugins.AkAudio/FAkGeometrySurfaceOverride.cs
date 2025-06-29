using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkGeometrySurfaceOverride", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkGeometrySurfaceOverride
{
	private static bool AcousticTexture_IsValid;

	private static int AcousticTexture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometrySurfaceOverride:AcousticTexture")]
	public UAkAcousticTexture AcousticTexture;

	private static bool EnableOcclusionOverride_IsValid;

	private static FFieldAddress EnableOcclusionOverride_PropertyAddress;

	private static int EnableOcclusionOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometrySurfaceOverride:bEnableOcclusionOverride")]
	public bool EnableOcclusionOverride;

	private static bool OcclusionValue_IsValid;

	private static int OcclusionValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AkAudio.AkGeometrySurfaceOverride:OcclusionValue")]
	public float OcclusionValue;

	private static bool FAkGeometrySurfaceOverride_IsValid;

	private static int FAkGeometrySurfaceOverride_StructSize;

	public FAkGeometrySurfaceOverride Copy()
	{
		return this;
	}

	public static FAkGeometrySurfaceOverride FromNative(IntPtr nativeBuffer)
	{
		return new FAkGeometrySurfaceOverride(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkGeometrySurfaceOverride value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkGeometrySurfaceOverride FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkGeometrySurfaceOverride(nativeBuffer + arrayIndex * FAkGeometrySurfaceOverride_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkGeometrySurfaceOverride value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkGeometrySurfaceOverride_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkGeometrySurfaceOverride_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkGeometrySurfaceOverride");
			return;
		}
		UObjectMarshaler<UAkAcousticTexture>.ToNative(IntPtr.Add(nativeStruct, AcousticTexture_Offset), AcousticTexture);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableOcclusionOverride_Offset), 0, EnableOcclusionOverride_PropertyAddress.Address, EnableOcclusionOverride);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OcclusionValue_Offset), OcclusionValue);
	}

	public FAkGeometrySurfaceOverride(IntPtr nativeStruct)
	{
		if (!FAkGeometrySurfaceOverride_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkGeometrySurfaceOverride");
			AcousticTexture = null;
			EnableOcclusionOverride = false;
			OcclusionValue = 0f;
		}
		else
		{
			AcousticTexture = UObjectMarshaler<UAkAcousticTexture>.FromNative(IntPtr.Add(nativeStruct, AcousticTexture_Offset));
			EnableOcclusionOverride = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableOcclusionOverride_Offset), 0, EnableOcclusionOverride_PropertyAddress.Address);
			OcclusionValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OcclusionValue_Offset));
		}
	}

	static FAkGeometrySurfaceOverride()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkGeometrySurfaceOverride)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkGeometrySurfaceOverride));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkGeometrySurfaceOverride");
		FAkGeometrySurfaceOverride_StructSize = NativeReflection.GetStructSize(intPtr);
		AcousticTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AcousticTexture");
		AcousticTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AcousticTexture", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableOcclusionOverride_PropertyAddress, intPtr, "bEnableOcclusionOverride");
		EnableOcclusionOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableOcclusionOverride");
		EnableOcclusionOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableOcclusionOverride", Classes.FBoolProperty);
		OcclusionValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OcclusionValue");
		OcclusionValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OcclusionValue", Classes.FFloatProperty);
		FAkGeometrySurfaceOverride_IsValid = intPtr != IntPtr.Zero && AcousticTexture_IsValid && EnableOcclusionOverride_IsValid && OcclusionValue_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkGeometrySurfaceOverride", FAkGeometrySurfaceOverride_IsValid);
	}
}
