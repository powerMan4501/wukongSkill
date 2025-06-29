using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomConversionSettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FGroomConversionSettings
{
	private static bool Rotation_IsValid;

	private static int Rotation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomConversionSettings:Rotation")]
	public FVector Rotation;

	private static bool Scale_IsValid;

	private static int Scale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomConversionSettings:Scale")]
	public FVector Scale;

	private static bool FGroomConversionSettings_IsValid;

	private static int FGroomConversionSettings_StructSize;

	public FGroomConversionSettings Copy()
	{
		return this;
	}

	public static FGroomConversionSettings FromNative(IntPtr nativeBuffer)
	{
		return new FGroomConversionSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGroomConversionSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGroomConversionSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGroomConversionSettings(nativeBuffer + arrayIndex * FGroomConversionSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGroomConversionSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGroomConversionSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGroomConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomConversionSettings");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Rotation_Offset), Rotation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Scale_Offset), Scale);
	}

	public FGroomConversionSettings(IntPtr nativeStruct)
	{
		if (!FGroomConversionSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomConversionSettings");
			Rotation = default(FVector);
			Scale = default(FVector);
		}
		else
		{
			Rotation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Rotation_Offset));
			Scale = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Scale_Offset));
		}
	}

	static FGroomConversionSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGroomConversionSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGroomConversionSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.GroomConversionSettings");
		FGroomConversionSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		Rotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Rotation");
		Rotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Rotation", Classes.FStructProperty);
		Scale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Scale");
		Scale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Scale", Classes.FStructProperty);
		FGroomConversionSettings_IsValid = intPtr != IntPtr.Zero && Rotation_IsValid && Scale_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.GroomConversionSettings", FGroomConversionSettings_IsValid);
	}
}
