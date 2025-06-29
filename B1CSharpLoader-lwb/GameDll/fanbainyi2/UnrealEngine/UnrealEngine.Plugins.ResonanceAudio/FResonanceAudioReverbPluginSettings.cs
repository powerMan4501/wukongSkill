using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ResonanceAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings", "ResonanceAudio", UnrealModuleType.EnginePlugin)]
public struct FResonanceAudioReverbPluginSettings
{
	private static bool EnableRoomEffects_IsValid;

	private static FFieldAddress EnableRoomEffects_PropertyAddress;

	private static int EnableRoomEffects_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:bEnableRoomEffects")]
	public bool EnableRoomEffects;

	private static bool RoomPosition_IsValid;

	private static int RoomPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RoomPosition")]
	public FVector RoomPosition;

	private static bool RoomRotation_IsValid;

	private static int RoomRotation_Offset;

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RoomRotation")]
	public FQuat RoomRotation;

	private static bool RoomDimensions_IsValid;

	private static int RoomDimensions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RoomDimensions")]
	public FVector RoomDimensions;

	private static bool LeftWallMaterial_IsValid;

	private static FFieldAddress LeftWallMaterial_PropertyAddress;

	private static int LeftWallMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:LeftWallMaterial")]
	public ERaMaterialName LeftWallMaterial;

	private static bool RightWallMaterial_IsValid;

	private static FFieldAddress RightWallMaterial_PropertyAddress;

	private static int RightWallMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:RightWallMaterial")]
	public ERaMaterialName RightWallMaterial;

	private static bool FloorMaterial_IsValid;

	private static FFieldAddress FloorMaterial_PropertyAddress;

	private static int FloorMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:FloorMaterial")]
	public ERaMaterialName FloorMaterial;

	private static bool CeilingMaterial_IsValid;

	private static FFieldAddress CeilingMaterial_PropertyAddress;

	private static int CeilingMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:CeilingMaterial")]
	public ERaMaterialName CeilingMaterial;

	private static bool FrontWallMaterial_IsValid;

	private static FFieldAddress FrontWallMaterial_PropertyAddress;

	private static int FrontWallMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:FrontWallMaterial")]
	public ERaMaterialName FrontWallMaterial;

	private static bool BackWallMaterial_IsValid;

	private static FFieldAddress BackWallMaterial_PropertyAddress;

	private static int BackWallMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:BackWallMaterial")]
	public ERaMaterialName BackWallMaterial;

	private static bool ReflectionScalar_IsValid;

	private static int ReflectionScalar_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReflectionScalar")]
	public float ReflectionScalar;

	private static bool ReverbGain_IsValid;

	private static int ReverbGain_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReverbGain")]
	public float ReverbGain;

	private static bool ReverbTimeModifier_IsValid;

	private static int ReverbTimeModifier_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReverbTimeModifier")]
	public float ReverbTimeModifier;

	private static bool ReverbBrightness_IsValid;

	private static int ReverbBrightness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings:ReverbBrightness")]
	public float ReverbBrightness;

	private static bool FResonanceAudioReverbPluginSettings_IsValid;

	private static int FResonanceAudioReverbPluginSettings_StructSize;

	public FResonanceAudioReverbPluginSettings Copy()
	{
		return this;
	}

	public static FResonanceAudioReverbPluginSettings FromNative(IntPtr nativeBuffer)
	{
		return new FResonanceAudioReverbPluginSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FResonanceAudioReverbPluginSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FResonanceAudioReverbPluginSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FResonanceAudioReverbPluginSettings(nativeBuffer + arrayIndex * FResonanceAudioReverbPluginSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FResonanceAudioReverbPluginSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FResonanceAudioReverbPluginSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FResonanceAudioReverbPluginSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRoomEffects_Offset), 0, EnableRoomEffects_PropertyAddress.Address, EnableRoomEffects);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RoomPosition_Offset), RoomPosition);
		BlittableTypeMarshaler<FQuat>.ToNative(IntPtr.Add(nativeStruct, RoomRotation_Offset), RoomRotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, RoomDimensions_Offset), RoomDimensions);
		EnumMarshaler<ERaMaterialName>.ToNative(IntPtr.Add(nativeStruct, LeftWallMaterial_Offset), 0, LeftWallMaterial_PropertyAddress.Address, LeftWallMaterial);
		EnumMarshaler<ERaMaterialName>.ToNative(IntPtr.Add(nativeStruct, RightWallMaterial_Offset), 0, RightWallMaterial_PropertyAddress.Address, RightWallMaterial);
		EnumMarshaler<ERaMaterialName>.ToNative(IntPtr.Add(nativeStruct, FloorMaterial_Offset), 0, FloorMaterial_PropertyAddress.Address, FloorMaterial);
		EnumMarshaler<ERaMaterialName>.ToNative(IntPtr.Add(nativeStruct, CeilingMaterial_Offset), 0, CeilingMaterial_PropertyAddress.Address, CeilingMaterial);
		EnumMarshaler<ERaMaterialName>.ToNative(IntPtr.Add(nativeStruct, FrontWallMaterial_Offset), 0, FrontWallMaterial_PropertyAddress.Address, FrontWallMaterial);
		EnumMarshaler<ERaMaterialName>.ToNative(IntPtr.Add(nativeStruct, BackWallMaterial_Offset), 0, BackWallMaterial_PropertyAddress.Address, BackWallMaterial);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReflectionScalar_Offset), ReflectionScalar);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReverbGain_Offset), ReverbGain);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReverbTimeModifier_Offset), ReverbTimeModifier);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReverbBrightness_Offset), ReverbBrightness);
	}

	public FResonanceAudioReverbPluginSettings(IntPtr nativeStruct)
	{
		if (!FResonanceAudioReverbPluginSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings");
			EnableRoomEffects = false;
			RoomPosition = default(FVector);
			RoomRotation = default(FQuat);
			RoomDimensions = default(FVector);
			LeftWallMaterial = ERaMaterialName.TRANSPARENT;
			RightWallMaterial = ERaMaterialName.TRANSPARENT;
			FloorMaterial = ERaMaterialName.TRANSPARENT;
			CeilingMaterial = ERaMaterialName.TRANSPARENT;
			FrontWallMaterial = ERaMaterialName.TRANSPARENT;
			BackWallMaterial = ERaMaterialName.TRANSPARENT;
			ReflectionScalar = 0f;
			ReverbGain = 0f;
			ReverbTimeModifier = 0f;
			ReverbBrightness = 0f;
		}
		else
		{
			EnableRoomEffects = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRoomEffects_Offset), 0, EnableRoomEffects_PropertyAddress.Address);
			RoomPosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RoomPosition_Offset));
			RoomRotation = BlittableTypeMarshaler<FQuat>.FromNative(IntPtr.Add(nativeStruct, RoomRotation_Offset));
			RoomDimensions = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, RoomDimensions_Offset));
			LeftWallMaterial = EnumMarshaler<ERaMaterialName>.FromNative(IntPtr.Add(nativeStruct, LeftWallMaterial_Offset), 0, LeftWallMaterial_PropertyAddress.Address);
			RightWallMaterial = EnumMarshaler<ERaMaterialName>.FromNative(IntPtr.Add(nativeStruct, RightWallMaterial_Offset), 0, RightWallMaterial_PropertyAddress.Address);
			FloorMaterial = EnumMarshaler<ERaMaterialName>.FromNative(IntPtr.Add(nativeStruct, FloorMaterial_Offset), 0, FloorMaterial_PropertyAddress.Address);
			CeilingMaterial = EnumMarshaler<ERaMaterialName>.FromNative(IntPtr.Add(nativeStruct, CeilingMaterial_Offset), 0, CeilingMaterial_PropertyAddress.Address);
			FrontWallMaterial = EnumMarshaler<ERaMaterialName>.FromNative(IntPtr.Add(nativeStruct, FrontWallMaterial_Offset), 0, FrontWallMaterial_PropertyAddress.Address);
			BackWallMaterial = EnumMarshaler<ERaMaterialName>.FromNative(IntPtr.Add(nativeStruct, BackWallMaterial_Offset), 0, BackWallMaterial_PropertyAddress.Address);
			ReflectionScalar = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReflectionScalar_Offset));
			ReverbGain = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReverbGain_Offset));
			ReverbTimeModifier = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReverbTimeModifier_Offset));
			ReverbBrightness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReverbBrightness_Offset));
		}
	}

	static FResonanceAudioReverbPluginSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FResonanceAudioReverbPluginSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FResonanceAudioReverbPluginSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings");
		FResonanceAudioReverbPluginSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EnableRoomEffects_PropertyAddress, intPtr, "bEnableRoomEffects");
		EnableRoomEffects_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRoomEffects");
		EnableRoomEffects_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRoomEffects", Classes.FBoolProperty);
		RoomPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoomPosition");
		RoomPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoomPosition", Classes.FStructProperty);
		RoomRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoomRotation");
		RoomRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoomRotation", Classes.FStructProperty);
		RoomDimensions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoomDimensions");
		RoomDimensions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoomDimensions", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LeftWallMaterial_PropertyAddress, intPtr, "LeftWallMaterial");
		LeftWallMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LeftWallMaterial");
		LeftWallMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LeftWallMaterial", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref RightWallMaterial_PropertyAddress, intPtr, "RightWallMaterial");
		RightWallMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RightWallMaterial");
		RightWallMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RightWallMaterial", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FloorMaterial_PropertyAddress, intPtr, "FloorMaterial");
		FloorMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FloorMaterial");
		FloorMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FloorMaterial", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref CeilingMaterial_PropertyAddress, intPtr, "CeilingMaterial");
		CeilingMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CeilingMaterial");
		CeilingMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CeilingMaterial", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FrontWallMaterial_PropertyAddress, intPtr, "FrontWallMaterial");
		FrontWallMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FrontWallMaterial");
		FrontWallMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FrontWallMaterial", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref BackWallMaterial_PropertyAddress, intPtr, "BackWallMaterial");
		BackWallMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BackWallMaterial");
		BackWallMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BackWallMaterial", Classes.FEnumProperty);
		ReflectionScalar_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReflectionScalar");
		ReflectionScalar_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReflectionScalar", Classes.FFloatProperty);
		ReverbGain_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbGain");
		ReverbGain_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbGain", Classes.FFloatProperty);
		ReverbTimeModifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbTimeModifier");
		ReverbTimeModifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbTimeModifier", Classes.FFloatProperty);
		ReverbBrightness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReverbBrightness");
		ReverbBrightness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReverbBrightness", Classes.FFloatProperty);
		FResonanceAudioReverbPluginSettings_IsValid = intPtr != IntPtr.Zero && EnableRoomEffects_IsValid && RoomPosition_IsValid && RoomRotation_IsValid && RoomDimensions_IsValid && LeftWallMaterial_IsValid && RightWallMaterial_IsValid && FloorMaterial_IsValid && CeilingMaterial_IsValid && FrontWallMaterial_IsValid && BackWallMaterial_IsValid && ReflectionScalar_IsValid && ReverbGain_IsValid && ReverbTimeModifier_IsValid && ReverbBrightness_IsValid;
		NativeReflection.LogStructIsValid("/Script/ResonanceAudio.ResonanceAudioReverbPluginSettings", FResonanceAudioReverbPluginSettings_IsValid);
	}
}
