using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.AbcConversionSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public struct FAbcConversionSettings
{
	private static bool Preset_IsValid;

	private static FFieldAddress Preset_PropertyAddress;

	private static int Preset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcConversionSettings:Preset")]
	public EAbcConversionPreset Preset;

	private static bool FlipU_IsValid;

	private static FFieldAddress FlipU_PropertyAddress;

	private static int FlipU_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcConversionSettings:bFlipU")]
	public bool FlipU;

	private static bool FlipV_IsValid;

	private static FFieldAddress FlipV_PropertyAddress;

	private static int FlipV_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcConversionSettings:bFlipV")]
	public bool FlipV;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcConversionSettings:Scale")]
	public FVector Scale;

	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcConversionSettings:Rotation")]
	public FVector Rotation;

	private static bool FAbcConversionSettings_IsValid;

	private static int FAbcConversionSettings_StructSize;

	public FAbcConversionSettings Copy()
	{
		return this;
	}

	public static FAbcConversionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAbcConversionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAbcConversionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAbcConversionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAbcConversionSettings(nativeBuffer + arrayIndex * FAbcConversionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAbcConversionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAbcConversionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAbcConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcConversionSettings");
			return;
		}
		EnumMarshaler<EAbcConversionPreset>.ToNative(IntPtr.Add(nativeStruct, Preset_Offset), 0, Preset_PropertyAddress.Address, Preset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlipU_Offset), 0, FlipU_PropertyAddress.Address, FlipU);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlipV_Offset), 0, FlipV_PropertyAddress.Address, FlipV);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
	}

	public FAbcConversionSettings(IntPtr nativeStruct)
	{
		if (!FAbcConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcConversionSettings");
			Preset = EAbcConversionPreset.Maya;
			FlipU = false;
			FlipV = false;
			Scale = default(FVector);
			Rotation = default(FVector);
		}
		else
		{
			Preset = EnumMarshaler<EAbcConversionPreset>.FromNative(IntPtr.Add(nativeStruct, Preset_Offset), 0, Preset_PropertyAddress.Address);
			FlipU = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlipU_Offset), 0, FlipU_PropertyAddress.Address);
			FlipV = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlipV_Offset), 0, FlipV_PropertyAddress.Address);
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
			Rotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
		}
	}

	static FAbcConversionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAbcConversionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbcConversionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AlembicLibrary.AbcConversionSettings");
		FAbcConversionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Preset_PropertyAddress, intPtr, "Preset");
		Preset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Preset");
		Preset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Preset", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipU_PropertyAddress, intPtr, "bFlipU");
		FlipU_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlipU");
		FlipU_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlipU", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FlipV_PropertyAddress, intPtr, "bFlipV");
		FlipV_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlipV");
		FlipV_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlipV", Classes.FBoolProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		FAbcConversionSettings_IsValid = intPtr != IntPtr.Zero && Preset_IsValid && FlipU_IsValid && FlipV_IsValid && Scale_IsValid && Rotation_IsValid;
		NativeReflection.LogStructIsValid("/Script/AlembicLibrary.AbcConversionSettings", FAbcConversionSettings_IsValid);
	}
}
