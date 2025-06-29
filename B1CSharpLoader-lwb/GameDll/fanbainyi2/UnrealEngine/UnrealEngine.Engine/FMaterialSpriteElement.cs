using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialSpriteElement", "Engine", UnrealModuleType.Engine)]
public struct FMaterialSpriteElement
{
	private static bool Material_IsValid;

	private static int Material_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MaterialSpriteElement:Material")]
	public UMaterialInterface Material;

	private static bool DistanceToOpacityCurve_IsValid;

	private static int DistanceToOpacityCurve_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MaterialSpriteElement:DistanceToOpacityCurve")]
	public UCurveFloat DistanceToOpacityCurve;

	private static bool SizeIsInScreenSpace_IsValid;

	private static FFieldAddress SizeIsInScreenSpace_PropertyAddress;

	private static int SizeIsInScreenSpace_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialSpriteElement:bSizeIsInScreenSpace")]
	public bool SizeIsInScreenSpace;

	private static bool BaseSizeX_IsValid;

	private static int BaseSizeX_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialSpriteElement:BaseSizeX")]
	public float BaseSizeX;

	private static bool BaseSizeY_IsValid;

	private static int BaseSizeY_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialSpriteElement:BaseSizeY")]
	public float BaseSizeY;

	private static bool DistanceToSizeCurve_IsValid;

	private static int DistanceToSizeCurve_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.MaterialSpriteElement:DistanceToSizeCurve")]
	public UCurveFloat DistanceToSizeCurve;

	private static bool FMaterialSpriteElement_IsValid;

	private static int FMaterialSpriteElement_StructSize;

	public FMaterialSpriteElement Copy()
	{
		return this;
	}

	public static FMaterialSpriteElement FromNative(IntPtr nativeBuffer)
	{
		return new FMaterialSpriteElement(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMaterialSpriteElement value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMaterialSpriteElement FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMaterialSpriteElement(nativeBuffer + arrayIndex * FMaterialSpriteElement_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMaterialSpriteElement value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMaterialSpriteElement_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMaterialSpriteElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MaterialSpriteElement");
			return;
		}
		UObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, Material_Offset), Material);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, DistanceToOpacityCurve_Offset), DistanceToOpacityCurve);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SizeIsInScreenSpace_Offset), 0, SizeIsInScreenSpace_PropertyAddress.Address, SizeIsInScreenSpace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BaseSizeX_Offset), BaseSizeX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BaseSizeY_Offset), BaseSizeY);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, DistanceToSizeCurve_Offset), DistanceToSizeCurve);
	}

	public FMaterialSpriteElement(IntPtr nativeStruct)
	{
		if (!FMaterialSpriteElement_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MaterialSpriteElement");
			Material = null;
			DistanceToOpacityCurve = null;
			SizeIsInScreenSpace = false;
			BaseSizeX = 0f;
			BaseSizeY = 0f;
			DistanceToSizeCurve = null;
		}
		else
		{
			Material = UObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, Material_Offset));
			DistanceToOpacityCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, DistanceToOpacityCurve_Offset));
			SizeIsInScreenSpace = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SizeIsInScreenSpace_Offset), 0, SizeIsInScreenSpace_PropertyAddress.Address);
			BaseSizeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BaseSizeX_Offset));
			BaseSizeY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BaseSizeY_Offset));
			DistanceToSizeCurve = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, DistanceToSizeCurve_Offset));
		}
	}

	static FMaterialSpriteElement()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMaterialSpriteElement)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMaterialSpriteElement));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MaterialSpriteElement");
		FMaterialSpriteElement_StructSize = NativeReflection.GetStructSize(intPtr);
		Material_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Material");
		Material_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Material", Classes.FObjectProperty);
		DistanceToOpacityCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceToOpacityCurve");
		DistanceToOpacityCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceToOpacityCurve", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SizeIsInScreenSpace_PropertyAddress, intPtr, "bSizeIsInScreenSpace");
		SizeIsInScreenSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSizeIsInScreenSpace");
		SizeIsInScreenSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSizeIsInScreenSpace", Classes.FBoolProperty);
		BaseSizeX_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseSizeX");
		BaseSizeX_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseSizeX", Classes.FFloatProperty);
		BaseSizeY_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseSizeY");
		BaseSizeY_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseSizeY", Classes.FFloatProperty);
		DistanceToSizeCurve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DistanceToSizeCurve");
		DistanceToSizeCurve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DistanceToSizeCurve", Classes.FObjectProperty);
		FMaterialSpriteElement_IsValid = intPtr != IntPtr.Zero && Material_IsValid && DistanceToOpacityCurve_IsValid && SizeIsInScreenSpace_IsValid && BaseSizeX_IsValid && BaseSizeY_IsValid && DistanceToSizeCurve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MaterialSpriteElement", FMaterialSpriteElement_IsValid);
	}
}
