using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[UClass(Flags = (ClassFlags)810553508uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxTextureImportData", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxTextureImportData : UFbxAssetImportData
{
	private static bool InvertNormalMaps_IsValid;

	private static FFieldAddress InvertNormalMaps_PropertyAddress;

	private static int InvertNormalMaps_Offset;

	private static bool MaterialSearchLocation_IsValid;

	private static FFieldAddress MaterialSearchLocation_PropertyAddress;

	private static int MaterialSearchLocation_Offset;

	private static bool BaseMaterialName_IsValid;

	private static int BaseMaterialName_Offset;

	private static bool BaseColorName_IsValid;

	private static int BaseColorName_Offset;

	private static bool BaseDiffuseTextureName_IsValid;

	private static int BaseDiffuseTextureName_Offset;

	private static bool BaseNormalTextureName_IsValid;

	private static int BaseNormalTextureName_Offset;

	private static bool BaseEmissiveColorName_IsValid;

	private static int BaseEmissiveColorName_Offset;

	private static bool BaseEmmisiveTextureName_IsValid;

	private static int BaseEmmisiveTextureName_Offset;

	private static bool BaseSpecularTextureName_IsValid;

	private static int BaseSpecularTextureName_Offset;

	private static bool BaseOpacityTextureName_IsValid;

	private static int BaseOpacityTextureName_Offset;

	[UProperty(Flags = (PropFlags)6759866207059973uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:bInvertNormalMaps")]
	public bool InvertNormalMaps
	{
		get
		{
			CheckDestroyed();
			if (!InvertNormalMaps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:bInvertNormalMaps");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InvertNormalMaps_Offset), 0, InvertNormalMaps_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InvertNormalMaps_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:bInvertNormalMaps");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InvertNormalMaps_Offset), 0, InvertNormalMaps_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:MaterialSearchLocation")]
	public EMaterialSearchLocation MaterialSearchLocation
	{
		get
		{
			CheckDestroyed();
			if (!MaterialSearchLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:MaterialSearchLocation");
				return EMaterialSearchLocation.Local;
			}
			return EnumMarshaler<EMaterialSearchLocation>.FromNative(IntPtr.Add(base.Address, MaterialSearchLocation_Offset), 0, MaterialSearchLocation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MaterialSearchLocation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:MaterialSearchLocation");
			}
			else
			{
				EnumMarshaler<EMaterialSearchLocation>.ToNative(IntPtr.Add(base.Address, MaterialSearchLocation_Offset), 0, MaterialSearchLocation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072645uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseMaterialName")]
	public FSoftObjectPath BaseMaterialName
	{
		get
		{
			CheckDestroyed();
			if (!BaseMaterialName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseMaterialName");
				return default(FSoftObjectPath);
			}
			return FSoftObjectPath.FromNative(IntPtr.Add(base.Address, BaseMaterialName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseMaterialName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseMaterialName");
			}
			else
			{
				FSoftObjectPath.ToNative(IntPtr.Add(base.Address, BaseMaterialName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseColorName")]
	public string BaseColorName
	{
		get
		{
			CheckDestroyed();
			if (!BaseColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseColorName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, BaseColorName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseColorName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, BaseColorName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseDiffuseTextureName")]
	public string BaseDiffuseTextureName
	{
		get
		{
			CheckDestroyed();
			if (!BaseDiffuseTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseDiffuseTextureName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, BaseDiffuseTextureName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseDiffuseTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseDiffuseTextureName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, BaseDiffuseTextureName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseNormalTextureName")]
	public string BaseNormalTextureName
	{
		get
		{
			CheckDestroyed();
			if (!BaseNormalTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseNormalTextureName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, BaseNormalTextureName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseNormalTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseNormalTextureName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, BaseNormalTextureName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseEmissiveColorName")]
	public string BaseEmissiveColorName
	{
		get
		{
			CheckDestroyed();
			if (!BaseEmissiveColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseEmissiveColorName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, BaseEmissiveColorName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseEmissiveColorName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseEmissiveColorName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, BaseEmissiveColorName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseEmmisiveTextureName")]
	public string BaseEmmisiveTextureName
	{
		get
		{
			CheckDestroyed();
			if (!BaseEmmisiveTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseEmmisiveTextureName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, BaseEmmisiveTextureName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseEmmisiveTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseEmmisiveTextureName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, BaseEmmisiveTextureName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseSpecularTextureName")]
	public string BaseSpecularTextureName
	{
		get
		{
			CheckDestroyed();
			if (!BaseSpecularTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseSpecularTextureName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, BaseSpecularTextureName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseSpecularTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseSpecularTextureName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, BaseSpecularTextureName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755399441072644uL)]
	[UMetaPath("/Script/UnrealEd.FbxTextureImportData:BaseOpacityTextureName")]
	public string BaseOpacityTextureName
	{
		get
		{
			CheckDestroyed();
			if (!BaseOpacityTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseOpacityTextureName");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, BaseOpacityTextureName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseOpacityTextureName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxTextureImportData:BaseOpacityTextureName");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, BaseOpacityTextureName_Offset), value);
			}
		}
	}

	static UFbxTextureImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxTextureImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxTextureImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.FbxTextureImportData");
		NativeReflectionCached.GetPropertyRef(ref InvertNormalMaps_PropertyAddress, unrealStruct, "bInvertNormalMaps");
		InvertNormalMaps_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bInvertNormalMaps");
		InvertNormalMaps_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bInvertNormalMaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MaterialSearchLocation_PropertyAddress, unrealStruct, "MaterialSearchLocation");
		MaterialSearchLocation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialSearchLocation");
		MaterialSearchLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialSearchLocation", Classes.FEnumProperty);
		BaseMaterialName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseMaterialName");
		BaseMaterialName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseMaterialName", Classes.FStructProperty);
		BaseColorName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseColorName");
		BaseColorName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseColorName", Classes.FStrProperty);
		BaseDiffuseTextureName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseDiffuseTextureName");
		BaseDiffuseTextureName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseDiffuseTextureName", Classes.FStrProperty);
		BaseNormalTextureName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseNormalTextureName");
		BaseNormalTextureName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseNormalTextureName", Classes.FStrProperty);
		BaseEmissiveColorName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseEmissiveColorName");
		BaseEmissiveColorName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseEmissiveColorName", Classes.FStrProperty);
		BaseEmmisiveTextureName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseEmmisiveTextureName");
		BaseEmmisiveTextureName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseEmmisiveTextureName", Classes.FStrProperty);
		BaseSpecularTextureName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseSpecularTextureName");
		BaseSpecularTextureName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseSpecularTextureName", Classes.FStrProperty);
		BaseOpacityTextureName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseOpacityTextureName");
		BaseOpacityTextureName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseOpacityTextureName", Classes.FStrProperty);
	}
}
