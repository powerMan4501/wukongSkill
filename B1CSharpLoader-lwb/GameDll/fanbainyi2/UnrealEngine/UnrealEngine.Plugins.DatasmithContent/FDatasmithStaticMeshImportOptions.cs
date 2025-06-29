using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithStaticMeshImportOptions", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public struct FDatasmithStaticMeshImportOptions
{
	private static bool MinLightmapResolution_IsValid;

	private static FFieldAddress MinLightmapResolution_PropertyAddress;

	private static int MinLightmapResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithStaticMeshImportOptions:MinLightmapResolution")]
	public EDatasmithImportLightmapMin MinLightmapResolution;

	private static bool MaxLightmapResolution_IsValid;

	private static FFieldAddress MaxLightmapResolution_PropertyAddress;

	private static int MaxLightmapResolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithStaticMeshImportOptions:MaxLightmapResolution")]
	public EDatasmithImportLightmapMax MaxLightmapResolution;

	private static bool GenerateLightmapUVs_IsValid;

	private static FFieldAddress GenerateLightmapUVs_PropertyAddress;

	private static int GenerateLightmapUVs_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithStaticMeshImportOptions:bGenerateLightmapUVs")]
	public bool GenerateLightmapUVs;

	private static bool RemoveDegenerates_IsValid;

	private static FFieldAddress RemoveDegenerates_PropertyAddress;

	private static int RemoveDegenerates_Offset;

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithStaticMeshImportOptions:bRemoveDegenerates")]
	public bool RemoveDegenerates;

	private static bool FDatasmithStaticMeshImportOptions_IsValid;

	private static int FDatasmithStaticMeshImportOptions_StructSize;

	public FDatasmithStaticMeshImportOptions Copy()
	{
		return this;
	}

	public static FDatasmithStaticMeshImportOptions FromNative(IntPtr nativeBuffer)
	{
		return new FDatasmithStaticMeshImportOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDatasmithStaticMeshImportOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDatasmithStaticMeshImportOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDatasmithStaticMeshImportOptions(nativeBuffer + arrayIndex * FDatasmithStaticMeshImportOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDatasmithStaticMeshImportOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDatasmithStaticMeshImportOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDatasmithStaticMeshImportOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithStaticMeshImportOptions");
			return;
		}
		EnumMarshaler<EDatasmithImportLightmapMin>.ToNative(IntPtr.Add(nativeStruct, MinLightmapResolution_Offset), 0, MinLightmapResolution_PropertyAddress.Address, MinLightmapResolution);
		EnumMarshaler<EDatasmithImportLightmapMax>.ToNative(IntPtr.Add(nativeStruct, MaxLightmapResolution_Offset), 0, MaxLightmapResolution_PropertyAddress.Address, MaxLightmapResolution);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address, GenerateLightmapUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address, RemoveDegenerates);
	}

	public FDatasmithStaticMeshImportOptions(IntPtr nativeStruct)
	{
		if (!FDatasmithStaticMeshImportOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithStaticMeshImportOptions");
			MinLightmapResolution = EDatasmithImportLightmapMin.LIGHTMAP_16;
			MaxLightmapResolution = EDatasmithImportLightmapMax.LIGHTMAP_64;
			GenerateLightmapUVs = false;
			RemoveDegenerates = false;
		}
		else
		{
			MinLightmapResolution = EnumMarshaler<EDatasmithImportLightmapMin>.FromNative(IntPtr.Add(nativeStruct, MinLightmapResolution_Offset), 0, MinLightmapResolution_PropertyAddress.Address);
			MaxLightmapResolution = EnumMarshaler<EDatasmithImportLightmapMax>.FromNative(IntPtr.Add(nativeStruct, MaxLightmapResolution_Offset), 0, MaxLightmapResolution_PropertyAddress.Address);
			GenerateLightmapUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address);
			RemoveDegenerates = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RemoveDegenerates_Offset), 0, RemoveDegenerates_PropertyAddress.Address);
		}
	}

	static FDatasmithStaticMeshImportOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDatasmithStaticMeshImportOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDatasmithStaticMeshImportOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DatasmithContent.DatasmithStaticMeshImportOptions");
		FDatasmithStaticMeshImportOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MinLightmapResolution_PropertyAddress, intPtr, "MinLightmapResolution");
		MinLightmapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinLightmapResolution");
		MinLightmapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinLightmapResolution", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref MaxLightmapResolution_PropertyAddress, intPtr, "MaxLightmapResolution");
		MaxLightmapResolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxLightmapResolution");
		MaxLightmapResolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxLightmapResolution", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateLightmapUVs_PropertyAddress, intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateLightmapUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveDegenerates_PropertyAddress, intPtr, "bRemoveDegenerates");
		RemoveDegenerates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRemoveDegenerates");
		RemoveDegenerates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRemoveDegenerates", Classes.FBoolProperty);
		FDatasmithStaticMeshImportOptions_IsValid = intPtr != IntPtr.Zero && MinLightmapResolution_IsValid && MaxLightmapResolution_IsValid && GenerateLightmapUVs_IsValid && RemoveDegenerates_IsValid;
		NativeReflection.LogStructIsValid("/Script/DatasmithContent.DatasmithStaticMeshImportOptions", FDatasmithStaticMeshImportOptions_IsValid);
	}
}
