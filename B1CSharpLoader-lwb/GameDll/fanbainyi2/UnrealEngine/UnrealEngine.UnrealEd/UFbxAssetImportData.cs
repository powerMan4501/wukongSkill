using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.UnrealEd;

[Abstract]
[UClass(Flags = (ClassFlags)810553509uL, Config = "EditorPerProjectUserSettings")]
[BlueprintType]
[UMetaPath("/Script/UnrealEd.FbxAssetImportData", "UnrealEd", UnrealModuleType.Engine)]
public class UFbxAssetImportData : UAssetImportData
{
	private static bool ImportTranslation_IsValid;

	private static int ImportTranslation_Offset;

	private static bool ImportRotation_IsValid;

	private static int ImportRotation_Offset;

	private static bool ImportUniformScale_IsValid;

	private static int ImportUniformScale_Offset;

	private static bool ConvertScene_IsValid;

	private static FFieldAddress ConvertScene_PropertyAddress;

	private static int ConvertScene_Offset;

	private static bool ForceFrontXAxis_IsValid;

	private static FFieldAddress ForceFrontXAxis_PropertyAddress;

	private static int ForceFrontXAxis_Offset;

	private static bool ConvertSceneUnit_IsValid;

	private static FFieldAddress ConvertSceneUnit_PropertyAddress;

	private static int ConvertSceneUnit_Offset;

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxAssetImportData:ImportTranslation")]
	public FVector ImportTranslation
	{
		get
		{
			CheckDestroyed();
			if (!ImportTranslation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:ImportTranslation");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ImportTranslation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImportTranslation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:ImportTranslation");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ImportTranslation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420605957uL)]
	[UMetaPath("/Script/UnrealEd.FbxAssetImportData:ImportRotation")]
	public FRotator ImportRotation
	{
		get
		{
			CheckDestroyed();
			if (!ImportRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:ImportRotation");
				return default(FRotator);
			}
			return BlittableTypeMarshaler<FRotator>.FromNative(IntPtr.Add(base.Address, ImportRotation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImportRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:ImportRotation");
			}
			else
			{
				BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(base.Address, ImportRotation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxAssetImportData:ImportUniformScale")]
	public float ImportUniformScale
	{
		get
		{
			CheckDestroyed();
			if (!ImportUniformScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:ImportUniformScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ImportUniformScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ImportUniformScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:ImportUniformScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ImportUniformScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxAssetImportData:bConvertScene")]
	public bool ConvertScene
	{
		get
		{
			CheckDestroyed();
			if (!ConvertScene_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:bConvertScene");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConvertScene_Offset), 0, ConvertScene_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConvertScene_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:bConvertScene");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConvertScene_Offset), 0, ConvertScene_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxAssetImportData:bForceFrontXAxis")]
	public bool ForceFrontXAxis
	{
		get
		{
			CheckDestroyed();
			if (!ForceFrontXAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:bForceFrontXAxis");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceFrontXAxis_Offset), 0, ForceFrontXAxis_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceFrontXAxis_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:bForceFrontXAxis");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceFrontXAxis_Offset), 0, ForceFrontXAxis_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/UnrealEd.FbxAssetImportData:bConvertSceneUnit")]
	public bool ConvertSceneUnit
	{
		get
		{
			CheckDestroyed();
			if (!ConvertSceneUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:bConvertSceneUnit");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConvertSceneUnit_Offset), 0, ConvertSceneUnit_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConvertSceneUnit_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/UnrealEd.FbxAssetImportData:bConvertSceneUnit");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConvertSceneUnit_Offset), 0, ConvertSceneUnit_PropertyAddress.Address, value);
			}
		}
	}

	static UFbxAssetImportData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UFbxAssetImportData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UFbxAssetImportData));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/UnrealEd.FbxAssetImportData");
		ImportTranslation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImportTranslation");
		ImportTranslation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImportTranslation", Classes.FStructProperty);
		ImportRotation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImportRotation");
		ImportRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImportRotation", Classes.FStructProperty);
		ImportUniformScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImportUniformScale");
		ImportUniformScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImportUniformScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertScene_PropertyAddress, unrealStruct, "bConvertScene");
		ConvertScene_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bConvertScene");
		ConvertScene_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bConvertScene", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceFrontXAxis_PropertyAddress, unrealStruct, "bForceFrontXAxis");
		ForceFrontXAxis_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bForceFrontXAxis");
		ForceFrontXAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bForceFrontXAxis", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertSceneUnit_PropertyAddress, unrealStruct, "bConvertSceneUnit");
		ConvertSceneUnit_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bConvertSceneUnit");
		ConvertSceneUnit_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bConvertSceneUnit", Classes.FBoolProperty);
	}
}
