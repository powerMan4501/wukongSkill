using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialProxySettings", "Engine", UnrealModuleType.Engine)]
public struct FMaterialProxySettings
{
	private static bool TextureSizingType_IsValid;

	private static FFieldAddress TextureSizingType_PropertyAddress;

	private static int TextureSizingType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:TextureSizingType")]
	public ETextureSizingType TextureSizingType;

	private static bool TextureSize_IsValid;

	private static int TextureSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:TextureSize")]
	public FIntPoint TextureSize;

	private static bool TargetTexelDensityPerMeter_IsValid;

	private static int TargetTexelDensityPerMeter_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:TargetTexelDensityPerMeter")]
	public float TargetTexelDensityPerMeter;

	private static bool MeshMaxScreenSizePercent_IsValid;

	private static int MeshMaxScreenSizePercent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:MeshMaxScreenSizePercent")]
	public float MeshMaxScreenSizePercent;

	private static bool MeshMinDrawDistance_IsValid;

	private static int MeshMinDrawDistance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:MeshMinDrawDistance")]
	public float MeshMinDrawDistance;

	private static bool GutterSpace_IsValid;

	private static int GutterSpace_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:GutterSpace")]
	public float GutterSpace;

	private static bool MetallicConstant_IsValid;

	private static int MetallicConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:MetallicConstant")]
	public float MetallicConstant;

	private static bool RoughnessConstant_IsValid;

	private static int RoughnessConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:RoughnessConstant")]
	public float RoughnessConstant;

	private static bool AnisotropyConstant_IsValid;

	private static int AnisotropyConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:AnisotropyConstant")]
	public float AnisotropyConstant;

	private static bool SpecularConstant_IsValid;

	private static int SpecularConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:SpecularConstant")]
	public float SpecularConstant;

	private static bool OpacityConstant_IsValid;

	private static int OpacityConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:OpacityConstant")]
	public float OpacityConstant;

	private static bool OpacityMaskConstant_IsValid;

	private static int OpacityMaskConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:OpacityMaskConstant")]
	public float OpacityMaskConstant;

	private static bool AmbientOcclusionConstant_IsValid;

	private static int AmbientOcclusionConstant_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:AmbientOcclusionConstant")]
	public float AmbientOcclusionConstant;

	private static bool BlendMode_IsValid;

	private static FFieldAddress BlendMode_PropertyAddress;

	private static int BlendMode_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:BlendMode")]
	public EBlendMode BlendMode;

	private static bool AllowTwoSidedMaterial_IsValid;

	private static FFieldAddress AllowTwoSidedMaterial_PropertyAddress;

	private static int AllowTwoSidedMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bAllowTwoSidedMaterial")]
	public bool AllowTwoSidedMaterial;

	private static bool NormalMap_IsValid;

	private static FFieldAddress NormalMap_PropertyAddress;

	private static int NormalMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bNormalMap")]
	public bool NormalMap;

	private static bool TangentMap_IsValid;

	private static FFieldAddress TangentMap_PropertyAddress;

	private static int TangentMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bTangentMap")]
	public bool TangentMap;

	private static bool MetallicMap_IsValid;

	private static FFieldAddress MetallicMap_PropertyAddress;

	private static int MetallicMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bMetallicMap")]
	public bool MetallicMap;

	private static bool RoughnessMap_IsValid;

	private static FFieldAddress RoughnessMap_PropertyAddress;

	private static int RoughnessMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bRoughnessMap")]
	public bool RoughnessMap;

	private static bool AnisotropyMap_IsValid;

	private static FFieldAddress AnisotropyMap_PropertyAddress;

	private static int AnisotropyMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bAnisotropyMap")]
	public bool AnisotropyMap;

	private static bool SpecularMap_IsValid;

	private static FFieldAddress SpecularMap_PropertyAddress;

	private static int SpecularMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bSpecularMap")]
	public bool SpecularMap;

	private static bool EmissiveMap_IsValid;

	private static FFieldAddress EmissiveMap_PropertyAddress;

	private static int EmissiveMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bEmissiveMap")]
	public bool EmissiveMap;

	private static bool OpacityMap_IsValid;

	private static FFieldAddress OpacityMap_PropertyAddress;

	private static int OpacityMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bOpacityMap")]
	public bool OpacityMap;

	private static bool OpacityMaskMap_IsValid;

	private static FFieldAddress OpacityMaskMap_PropertyAddress;

	private static int OpacityMaskMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bOpacityMaskMap")]
	public bool OpacityMaskMap;

	private static bool AmbientOcclusionMap_IsValid;

	private static FFieldAddress AmbientOcclusionMap_PropertyAddress;

	private static int AmbientOcclusionMap_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:bAmbientOcclusionMap")]
	public bool AmbientOcclusionMap;

	private static bool DiffuseTextureSize_IsValid;

	private static int DiffuseTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:DiffuseTextureSize")]
	public FIntPoint DiffuseTextureSize;

	private static bool NormalTextureSize_IsValid;

	private static int NormalTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:NormalTextureSize")]
	public FIntPoint NormalTextureSize;

	private static bool TangentTextureSize_IsValid;

	private static int TangentTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:TangentTextureSize")]
	public FIntPoint TangentTextureSize;

	private static bool MetallicTextureSize_IsValid;

	private static int MetallicTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:MetallicTextureSize")]
	public FIntPoint MetallicTextureSize;

	private static bool RoughnessTextureSize_IsValid;

	private static int RoughnessTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:RoughnessTextureSize")]
	public FIntPoint RoughnessTextureSize;

	private static bool AnisotropyTextureSize_IsValid;

	private static int AnisotropyTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:AnisotropyTextureSize")]
	public FIntPoint AnisotropyTextureSize;

	private static bool SpecularTextureSize_IsValid;

	private static int SpecularTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:SpecularTextureSize")]
	public FIntPoint SpecularTextureSize;

	private static bool EmissiveTextureSize_IsValid;

	private static int EmissiveTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:EmissiveTextureSize")]
	public FIntPoint EmissiveTextureSize;

	private static bool OpacityTextureSize_IsValid;

	private static int OpacityTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:OpacityTextureSize")]
	public FIntPoint OpacityTextureSize;

	private static bool OpacityMaskTextureSize_IsValid;

	private static int OpacityMaskTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:OpacityMaskTextureSize")]
	public FIntPoint OpacityMaskTextureSize;

	private static bool AmbientOcclusionTextureSize_IsValid;

	private static int AmbientOcclusionTextureSize_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.MaterialProxySettings:AmbientOcclusionTextureSize")]
	public FIntPoint AmbientOcclusionTextureSize;

	private static bool FMaterialProxySettings_IsValid;

	private static int FMaterialProxySettings_StructSize;

	public FMaterialProxySettings Copy()
	{
		return this;
	}

	public static FMaterialProxySettings FromNative(IntPtr nativeBuffer)
	{
		return new FMaterialProxySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMaterialProxySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMaterialProxySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMaterialProxySettings(nativeBuffer + arrayIndex * FMaterialProxySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMaterialProxySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMaterialProxySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMaterialProxySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MaterialProxySettings");
			return;
		}
		EnumMarshaler<ETextureSizingType>.ToNative(IntPtr.Add(nativeStruct, TextureSizingType_Offset), 0, TextureSizingType_PropertyAddress.Address, TextureSizingType);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, TextureSize_Offset), TextureSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TargetTexelDensityPerMeter_Offset), TargetTexelDensityPerMeter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MeshMaxScreenSizePercent_Offset), MeshMaxScreenSizePercent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MeshMinDrawDistance_Offset), MeshMinDrawDistance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, GutterSpace_Offset), GutterSpace);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MetallicConstant_Offset), MetallicConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RoughnessConstant_Offset), RoughnessConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AnisotropyConstant_Offset), AnisotropyConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpecularConstant_Offset), SpecularConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OpacityConstant_Offset), OpacityConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OpacityMaskConstant_Offset), OpacityMaskConstant);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AmbientOcclusionConstant_Offset), AmbientOcclusionConstant);
		EnumMarshaler<EBlendMode>.ToNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address, BlendMode);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowTwoSidedMaterial_Offset), 0, AllowTwoSidedMaterial_PropertyAddress.Address, AllowTwoSidedMaterial);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, NormalMap_Offset), 0, NormalMap_PropertyAddress.Address, NormalMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, TangentMap_Offset), 0, TangentMap_PropertyAddress.Address, TangentMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MetallicMap_Offset), 0, MetallicMap_PropertyAddress.Address, MetallicMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RoughnessMap_Offset), 0, RoughnessMap_PropertyAddress.Address, RoughnessMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AnisotropyMap_Offset), 0, AnisotropyMap_PropertyAddress.Address, AnisotropyMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpecularMap_Offset), 0, SpecularMap_PropertyAddress.Address, SpecularMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EmissiveMap_Offset), 0, EmissiveMap_PropertyAddress.Address, EmissiveMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OpacityMap_Offset), 0, OpacityMap_PropertyAddress.Address, OpacityMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OpacityMaskMap_Offset), 0, OpacityMaskMap_PropertyAddress.Address, OpacityMaskMap);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AmbientOcclusionMap_Offset), 0, AmbientOcclusionMap_PropertyAddress.Address, AmbientOcclusionMap);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, DiffuseTextureSize_Offset), DiffuseTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, NormalTextureSize_Offset), NormalTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, TangentTextureSize_Offset), TangentTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, MetallicTextureSize_Offset), MetallicTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, RoughnessTextureSize_Offset), RoughnessTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, AnisotropyTextureSize_Offset), AnisotropyTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, SpecularTextureSize_Offset), SpecularTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, EmissiveTextureSize_Offset), EmissiveTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, OpacityTextureSize_Offset), OpacityTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, OpacityMaskTextureSize_Offset), OpacityMaskTextureSize);
		BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(nativeStruct, AmbientOcclusionTextureSize_Offset), AmbientOcclusionTextureSize);
	}

	public FMaterialProxySettings(IntPtr nativeStruct)
	{
		if (!FMaterialProxySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MaterialProxySettings");
			TextureSizingType = ETextureSizingType.TextureSizingType_UseSingleTextureSize;
			TextureSize = default(FIntPoint);
			TargetTexelDensityPerMeter = 0f;
			MeshMaxScreenSizePercent = 0f;
			MeshMinDrawDistance = 0f;
			GutterSpace = 0f;
			MetallicConstant = 0f;
			RoughnessConstant = 0f;
			AnisotropyConstant = 0f;
			SpecularConstant = 0f;
			OpacityConstant = 0f;
			OpacityMaskConstant = 0f;
			AmbientOcclusionConstant = 0f;
			BlendMode = EBlendMode.BLEND_Opaque;
			AllowTwoSidedMaterial = false;
			NormalMap = false;
			TangentMap = false;
			MetallicMap = false;
			RoughnessMap = false;
			AnisotropyMap = false;
			SpecularMap = false;
			EmissiveMap = false;
			OpacityMap = false;
			OpacityMaskMap = false;
			AmbientOcclusionMap = false;
			DiffuseTextureSize = default(FIntPoint);
			NormalTextureSize = default(FIntPoint);
			TangentTextureSize = default(FIntPoint);
			MetallicTextureSize = default(FIntPoint);
			RoughnessTextureSize = default(FIntPoint);
			AnisotropyTextureSize = default(FIntPoint);
			SpecularTextureSize = default(FIntPoint);
			EmissiveTextureSize = default(FIntPoint);
			OpacityTextureSize = default(FIntPoint);
			OpacityMaskTextureSize = default(FIntPoint);
			AmbientOcclusionTextureSize = default(FIntPoint);
		}
		else
		{
			TextureSizingType = EnumMarshaler<ETextureSizingType>.FromNative(IntPtr.Add(nativeStruct, TextureSizingType_Offset), 0, TextureSizingType_PropertyAddress.Address);
			TextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, TextureSize_Offset));
			TargetTexelDensityPerMeter = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TargetTexelDensityPerMeter_Offset));
			MeshMaxScreenSizePercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MeshMaxScreenSizePercent_Offset));
			MeshMinDrawDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MeshMinDrawDistance_Offset));
			GutterSpace = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, GutterSpace_Offset));
			MetallicConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MetallicConstant_Offset));
			RoughnessConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RoughnessConstant_Offset));
			AnisotropyConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AnisotropyConstant_Offset));
			SpecularConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpecularConstant_Offset));
			OpacityConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OpacityConstant_Offset));
			OpacityMaskConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OpacityMaskConstant_Offset));
			AmbientOcclusionConstant = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AmbientOcclusionConstant_Offset));
			BlendMode = EnumMarshaler<EBlendMode>.FromNative(IntPtr.Add(nativeStruct, BlendMode_Offset), 0, BlendMode_PropertyAddress.Address);
			AllowTwoSidedMaterial = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowTwoSidedMaterial_Offset), 0, AllowTwoSidedMaterial_PropertyAddress.Address);
			NormalMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, NormalMap_Offset), 0, NormalMap_PropertyAddress.Address);
			TangentMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, TangentMap_Offset), 0, TangentMap_PropertyAddress.Address);
			MetallicMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MetallicMap_Offset), 0, MetallicMap_PropertyAddress.Address);
			RoughnessMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RoughnessMap_Offset), 0, RoughnessMap_PropertyAddress.Address);
			AnisotropyMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AnisotropyMap_Offset), 0, AnisotropyMap_PropertyAddress.Address);
			SpecularMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SpecularMap_Offset), 0, SpecularMap_PropertyAddress.Address);
			EmissiveMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EmissiveMap_Offset), 0, EmissiveMap_PropertyAddress.Address);
			OpacityMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OpacityMap_Offset), 0, OpacityMap_PropertyAddress.Address);
			OpacityMaskMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OpacityMaskMap_Offset), 0, OpacityMaskMap_PropertyAddress.Address);
			AmbientOcclusionMap = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AmbientOcclusionMap_Offset), 0, AmbientOcclusionMap_PropertyAddress.Address);
			DiffuseTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, DiffuseTextureSize_Offset));
			NormalTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, NormalTextureSize_Offset));
			TangentTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, TangentTextureSize_Offset));
			MetallicTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, MetallicTextureSize_Offset));
			RoughnessTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, RoughnessTextureSize_Offset));
			AnisotropyTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, AnisotropyTextureSize_Offset));
			SpecularTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, SpecularTextureSize_Offset));
			EmissiveTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, EmissiveTextureSize_Offset));
			OpacityTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, OpacityTextureSize_Offset));
			OpacityMaskTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, OpacityMaskTextureSize_Offset));
			AmbientOcclusionTextureSize = BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(nativeStruct, AmbientOcclusionTextureSize_Offset));
		}
	}

	static FMaterialProxySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMaterialProxySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMaterialProxySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MaterialProxySettings");
		FMaterialProxySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref TextureSizingType_PropertyAddress, intPtr, "TextureSizingType");
		TextureSizingType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureSizingType");
		TextureSizingType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureSizingType", Classes.FByteProperty);
		TextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureSize");
		TextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureSize", Classes.FStructProperty);
		TargetTexelDensityPerMeter_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TargetTexelDensityPerMeter");
		TargetTexelDensityPerMeter_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TargetTexelDensityPerMeter", Classes.FFloatProperty);
		MeshMaxScreenSizePercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshMaxScreenSizePercent");
		MeshMaxScreenSizePercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshMaxScreenSizePercent", Classes.FFloatProperty);
		MeshMinDrawDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshMinDrawDistance");
		MeshMinDrawDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshMinDrawDistance", Classes.FFloatProperty);
		GutterSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GutterSpace");
		GutterSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GutterSpace", Classes.FFloatProperty);
		MetallicConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetallicConstant");
		MetallicConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetallicConstant", Classes.FFloatProperty);
		RoughnessConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoughnessConstant");
		RoughnessConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoughnessConstant", Classes.FFloatProperty);
		AnisotropyConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnisotropyConstant");
		AnisotropyConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnisotropyConstant", Classes.FFloatProperty);
		SpecularConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpecularConstant");
		SpecularConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpecularConstant", Classes.FFloatProperty);
		OpacityConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OpacityConstant");
		OpacityConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OpacityConstant", Classes.FFloatProperty);
		OpacityMaskConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OpacityMaskConstant");
		OpacityMaskConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OpacityMaskConstant", Classes.FFloatProperty);
		AmbientOcclusionConstant_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AmbientOcclusionConstant");
		AmbientOcclusionConstant_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AmbientOcclusionConstant", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendMode_PropertyAddress, intPtr, "BlendMode");
		BlendMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendMode");
		BlendMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendMode", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowTwoSidedMaterial_PropertyAddress, intPtr, "bAllowTwoSidedMaterial");
		AllowTwoSidedMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowTwoSidedMaterial");
		AllowTwoSidedMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowTwoSidedMaterial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref NormalMap_PropertyAddress, intPtr, "bNormalMap");
		NormalMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bNormalMap");
		NormalMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bNormalMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TangentMap_PropertyAddress, intPtr, "bTangentMap");
		TangentMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTangentMap");
		TangentMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTangentMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MetallicMap_PropertyAddress, intPtr, "bMetallicMap");
		MetallicMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMetallicMap");
		MetallicMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMetallicMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RoughnessMap_PropertyAddress, intPtr, "bRoughnessMap");
		RoughnessMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRoughnessMap");
		RoughnessMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRoughnessMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AnisotropyMap_PropertyAddress, intPtr, "bAnisotropyMap");
		AnisotropyMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAnisotropyMap");
		AnisotropyMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAnisotropyMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpecularMap_PropertyAddress, intPtr, "bSpecularMap");
		SpecularMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSpecularMap");
		SpecularMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSpecularMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EmissiveMap_PropertyAddress, intPtr, "bEmissiveMap");
		EmissiveMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEmissiveMap");
		EmissiveMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEmissiveMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OpacityMap_PropertyAddress, intPtr, "bOpacityMap");
		OpacityMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOpacityMap");
		OpacityMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOpacityMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OpacityMaskMap_PropertyAddress, intPtr, "bOpacityMaskMap");
		OpacityMaskMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOpacityMaskMap");
		OpacityMaskMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOpacityMaskMap", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AmbientOcclusionMap_PropertyAddress, intPtr, "bAmbientOcclusionMap");
		AmbientOcclusionMap_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAmbientOcclusionMap");
		AmbientOcclusionMap_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAmbientOcclusionMap", Classes.FBoolProperty);
		DiffuseTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DiffuseTextureSize");
		DiffuseTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DiffuseTextureSize", Classes.FStructProperty);
		NormalTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalTextureSize");
		NormalTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalTextureSize", Classes.FStructProperty);
		TangentTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TangentTextureSize");
		TangentTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TangentTextureSize", Classes.FStructProperty);
		MetallicTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetallicTextureSize");
		MetallicTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetallicTextureSize", Classes.FStructProperty);
		RoughnessTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RoughnessTextureSize");
		RoughnessTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RoughnessTextureSize", Classes.FStructProperty);
		AnisotropyTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnisotropyTextureSize");
		AnisotropyTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnisotropyTextureSize", Classes.FStructProperty);
		SpecularTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpecularTextureSize");
		SpecularTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpecularTextureSize", Classes.FStructProperty);
		EmissiveTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EmissiveTextureSize");
		EmissiveTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EmissiveTextureSize", Classes.FStructProperty);
		OpacityTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OpacityTextureSize");
		OpacityTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OpacityTextureSize", Classes.FStructProperty);
		OpacityMaskTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OpacityMaskTextureSize");
		OpacityMaskTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OpacityMaskTextureSize", Classes.FStructProperty);
		AmbientOcclusionTextureSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AmbientOcclusionTextureSize");
		AmbientOcclusionTextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AmbientOcclusionTextureSize", Classes.FStructProperty);
		FMaterialProxySettings_IsValid = intPtr != IntPtr.Zero && TextureSizingType_IsValid && TextureSize_IsValid && TargetTexelDensityPerMeter_IsValid && MeshMaxScreenSizePercent_IsValid && MeshMinDrawDistance_IsValid && GutterSpace_IsValid && MetallicConstant_IsValid && RoughnessConstant_IsValid && AnisotropyConstant_IsValid && SpecularConstant_IsValid && OpacityConstant_IsValid && OpacityMaskConstant_IsValid && AmbientOcclusionConstant_IsValid && BlendMode_IsValid && AllowTwoSidedMaterial_IsValid && NormalMap_IsValid && TangentMap_IsValid && MetallicMap_IsValid && RoughnessMap_IsValid && AnisotropyMap_IsValid && SpecularMap_IsValid && EmissiveMap_IsValid && OpacityMap_IsValid && OpacityMaskMap_IsValid && AmbientOcclusionMap_IsValid && DiffuseTextureSize_IsValid && NormalTextureSize_IsValid && TangentTextureSize_IsValid && MetallicTextureSize_IsValid && RoughnessTextureSize_IsValid && AnisotropyTextureSize_IsValid && SpecularTextureSize_IsValid && EmissiveTextureSize_IsValid && OpacityTextureSize_IsValid && OpacityMaskTextureSize_IsValid && AmbientOcclusionTextureSize_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MaterialProxySettings", FMaterialProxySettings_IsValid);
	}
}
