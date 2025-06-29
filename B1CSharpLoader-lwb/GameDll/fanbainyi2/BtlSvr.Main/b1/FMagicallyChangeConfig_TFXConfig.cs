using System;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig")]
public struct FMagicallyChangeConfig_TFXConfig
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig:TFXAsset")]
	public UTressFXAsset TFXAsset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig:HairMaterial")]
	public UMaterialInterface HairMaterial;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig:ShadeSettings")]
	public FTressFXShadeSettings ShadeSettings;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig:LodScreenSize")]
	public float LodScreenSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig:bEnableSimulation")]
	public bool bEnableSimulation;

	private static int MagicallyChangeConfig_TFXConfig_StructSize;

	private static int MagicallyChangeConfig_TFXConfig_IsValid;

	private static bool TFXAsset_IsValid;

	private static int TFXAsset_Offset;

	private static bool HairMaterial_IsValid;

	private static int HairMaterial_Offset;

	private static bool ShadeSettings_IsValid;

	private static int ShadeSettings_Offset;

	private static bool LodScreenSize_IsValid;

	private static int LodScreenSize_Offset;

	private static bool bEnableSimulation_IsValid;

	private static int bEnableSimulation_Offset;

	private static FFieldAddress bEnableSimulation_PropertyAddress;

	public FMagicallyChangeConfig_TFXConfig Copy()
	{
		return this;
	}

	public static FMagicallyChangeConfig_TFXConfig FromNative(IntPtr nativeBuffer)
	{
		return new FMagicallyChangeConfig_TFXConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMagicallyChangeConfig_TFXConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMagicallyChangeConfig_TFXConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMagicallyChangeConfig_TFXConfig(IntPtr.Add(nativeBuffer, arrayIndex * MagicallyChangeConfig_TFXConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMagicallyChangeConfig_TFXConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * MagicallyChangeConfig_TFXConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (MagicallyChangeConfig_TFXConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig");
			return;
		}
		UObjectMarshaler<UTressFXAsset>.ToNative(IntPtr.Add(nativeStruct, TFXAsset_Offset), TFXAsset);
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, HairMaterial_Offset), HairMaterial);
		FTressFXShadeSettings.ToNative(IntPtr.Add(nativeStruct, ShadeSettings_Offset), ShadeSettings);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LodScreenSize_Offset), LodScreenSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bEnableSimulation_Offset), 0, bEnableSimulation_PropertyAddress.Address, bEnableSimulation);
	}

	public FMagicallyChangeConfig_TFXConfig(IntPtr nativeStruct)
	{
		if (MagicallyChangeConfig_TFXConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig");
			TFXAsset = null;
			HairMaterial = null;
			ShadeSettings = default(FTressFXShadeSettings);
			LodScreenSize = 0f;
			bEnableSimulation = false;
		}
		else
		{
			TFXAsset = UObjectMarshaler<UTressFXAsset>.FromNative(IntPtr.Add(nativeStruct, TFXAsset_Offset));
			HairMaterial = UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, HairMaterial_Offset));
			ShadeSettings = FTressFXShadeSettings.FromNative(IntPtr.Add(nativeStruct, ShadeSettings_Offset));
			LodScreenSize = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LodScreenSize_Offset));
			bEnableSimulation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bEnableSimulation_Offset), 0, bEnableSimulation_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig");
		MagicallyChangeConfig_TFXConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		TFXAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "TFXAsset");
		TFXAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TFXAsset", Classes.FObjectProperty);
		HairMaterial_Offset = NativeReflection.GetPropertyOffset(intPtr, "HairMaterial");
		HairMaterial_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HairMaterial", Classes.FObjectProperty);
		ShadeSettings_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShadeSettings");
		ShadeSettings_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShadeSettings", Classes.FStructProperty);
		LodScreenSize_Offset = NativeReflection.GetPropertyOffset(intPtr, "LodScreenSize");
		LodScreenSize_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LodScreenSize", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bEnableSimulation_PropertyAddress, intPtr, "bEnableSimulation");
		bEnableSimulation_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableSimulation");
		bEnableSimulation_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableSimulation", Classes.FBoolProperty);
		MagicallyChangeConfig_TFXConfig_IsValid = ((intPtr != IntPtr.Zero && TFXAsset_IsValid && HairMaterial_IsValid && ShadeSettings_IsValid && LodScreenSize_IsValid && bEnableSimulation_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.MagicallyChangeConfig_TFXConfig", (byte)MagicallyChangeConfig_TFXConfig_IsValid != 0);
	}

	static FMagicallyChangeConfig_TFXConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FMagicallyChangeConfig_TFXConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMagicallyChangeConfig_TFXConfig));
	}
}
