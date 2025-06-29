using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.DatasmithContent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions", "DatasmithContent", UnrealModuleType.EnginePlugin)]
public struct FDatasmithImportBaseOptions
{
	private static bool SceneHandling_IsValid;

	private static FFieldAddress SceneHandling_PropertyAddress;

	private static int SceneHandling_Offset;

	[UProperty(Flags = (PropFlags)6755469234283012uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:SceneHandling")]
	public EDatasmithImportScene SceneHandling;

	private static bool IncludeGeometry_IsValid;

	private static FFieldAddress IncludeGeometry_PropertyAddress;

	private static int IncludeGeometry_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeGeometry")]
	public bool IncludeGeometry;

	private static bool IncludeMaterial_IsValid;

	private static FFieldAddress IncludeMaterial_PropertyAddress;

	private static int IncludeMaterial_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeMaterial")]
	public bool IncludeMaterial;

	private static bool IncludeLight_IsValid;

	private static FFieldAddress IncludeLight_PropertyAddress;

	private static int IncludeLight_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeLight")]
	public bool IncludeLight;

	private static bool IncludeCamera_IsValid;

	private static FFieldAddress IncludeCamera_PropertyAddress;

	private static int IncludeCamera_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeCamera")]
	public bool IncludeCamera;

	private static bool IncludeAnimation_IsValid;

	private static FFieldAddress IncludeAnimation_PropertyAddress;

	private static int IncludeAnimation_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:bIncludeAnimation")]
	public bool IncludeAnimation;

	private static bool AssetOptions_IsValid;

	private static int AssetOptions_Offset;

	[UProperty(Flags = (PropFlags)4508066393358340uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:AssetOptions")]
	public FDatasmithAssetImportOptions AssetOptions;

	private static bool StaticMeshOptions_IsValid;

	private static int StaticMeshOptions_Offset;

	[UProperty(Flags = (PropFlags)4508066393374725uL)]
	[UMetaPath("/Script/DatasmithContent.DatasmithImportBaseOptions:StaticMeshOptions")]
	public FDatasmithStaticMeshImportOptions StaticMeshOptions;

	private static bool FDatasmithImportBaseOptions_IsValid;

	private static int FDatasmithImportBaseOptions_StructSize;

	public FDatasmithImportBaseOptions Copy()
	{
		return this;
	}

	public static FDatasmithImportBaseOptions FromNative(IntPtr nativeBuffer)
	{
		return new FDatasmithImportBaseOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDatasmithImportBaseOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDatasmithImportBaseOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDatasmithImportBaseOptions(nativeBuffer + arrayIndex * FDatasmithImportBaseOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDatasmithImportBaseOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDatasmithImportBaseOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDatasmithImportBaseOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithImportBaseOptions");
			return;
		}
		EnumMarshaler<EDatasmithImportScene>.ToNative(IntPtr.Add(nativeStruct, SceneHandling_Offset), 0, SceneHandling_PropertyAddress.Address, SceneHandling);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeGeometry_Offset), 0, IncludeGeometry_PropertyAddress.Address, IncludeGeometry);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeMaterial_Offset), 0, IncludeMaterial_PropertyAddress.Address, IncludeMaterial);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeLight_Offset), 0, IncludeLight_PropertyAddress.Address, IncludeLight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeCamera_Offset), 0, IncludeCamera_PropertyAddress.Address, IncludeCamera);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IncludeAnimation_Offset), 0, IncludeAnimation_PropertyAddress.Address, IncludeAnimation);
		FDatasmithAssetImportOptions.ToNative(IntPtr.Add(nativeStruct, AssetOptions_Offset), AssetOptions);
		FDatasmithStaticMeshImportOptions.ToNative(IntPtr.Add(nativeStruct, StaticMeshOptions_Offset), StaticMeshOptions);
	}

	public FDatasmithImportBaseOptions(IntPtr nativeStruct)
	{
		if (!FDatasmithImportBaseOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DatasmithContent.DatasmithImportBaseOptions");
			SceneHandling = EDatasmithImportScene.NewLevel;
			IncludeGeometry = false;
			IncludeMaterial = false;
			IncludeLight = false;
			IncludeCamera = false;
			IncludeAnimation = false;
			AssetOptions = default(FDatasmithAssetImportOptions);
			StaticMeshOptions = default(FDatasmithStaticMeshImportOptions);
		}
		else
		{
			SceneHandling = EnumMarshaler<EDatasmithImportScene>.FromNative(IntPtr.Add(nativeStruct, SceneHandling_Offset), 0, SceneHandling_PropertyAddress.Address);
			IncludeGeometry = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeGeometry_Offset), 0, IncludeGeometry_PropertyAddress.Address);
			IncludeMaterial = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeMaterial_Offset), 0, IncludeMaterial_PropertyAddress.Address);
			IncludeLight = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeLight_Offset), 0, IncludeLight_PropertyAddress.Address);
			IncludeCamera = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeCamera_Offset), 0, IncludeCamera_PropertyAddress.Address);
			IncludeAnimation = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IncludeAnimation_Offset), 0, IncludeAnimation_PropertyAddress.Address);
			AssetOptions = FDatasmithAssetImportOptions.FromNative(IntPtr.Add(nativeStruct, AssetOptions_Offset));
			StaticMeshOptions = FDatasmithStaticMeshImportOptions.FromNative(IntPtr.Add(nativeStruct, StaticMeshOptions_Offset));
		}
	}

	static FDatasmithImportBaseOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDatasmithImportBaseOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDatasmithImportBaseOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DatasmithContent.DatasmithImportBaseOptions");
		FDatasmithImportBaseOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SceneHandling_PropertyAddress, intPtr, "SceneHandling");
		SceneHandling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneHandling");
		SceneHandling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneHandling", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeGeometry_PropertyAddress, intPtr, "bIncludeGeometry");
		IncludeGeometry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeGeometry");
		IncludeGeometry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeGeometry", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeMaterial_PropertyAddress, intPtr, "bIncludeMaterial");
		IncludeMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeMaterial");
		IncludeMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeMaterial", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeLight_PropertyAddress, intPtr, "bIncludeLight");
		IncludeLight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeLight");
		IncludeLight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeLight", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeCamera_PropertyAddress, intPtr, "bIncludeCamera");
		IncludeCamera_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeCamera");
		IncludeCamera_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeCamera", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IncludeAnimation_PropertyAddress, intPtr, "bIncludeAnimation");
		IncludeAnimation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIncludeAnimation");
		IncludeAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIncludeAnimation", Classes.FBoolProperty);
		AssetOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AssetOptions");
		AssetOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AssetOptions", Classes.FStructProperty);
		StaticMeshOptions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StaticMeshOptions");
		StaticMeshOptions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StaticMeshOptions", Classes.FStructProperty);
		FDatasmithImportBaseOptions_IsValid = intPtr != IntPtr.Zero && SceneHandling_IsValid && IncludeGeometry_IsValid && IncludeMaterial_IsValid && IncludeLight_IsValid && IncludeCamera_IsValid && IncludeAnimation_IsValid && AssetOptions_IsValid && StaticMeshOptions_IsValid;
		NativeReflection.LogStructIsValid("/Script/DatasmithContent.DatasmithImportBaseOptions", FDatasmithImportBaseOptions_IsValid);
	}
}
