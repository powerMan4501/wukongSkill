using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AlembicLibrary.AbcImportSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public class UAbcImportSettings : UObject
{
	private static bool ImportType_IsValid;

	private static FFieldAddress ImportType_PropertyAddress;

	private static int ImportType_Offset;

	private static bool SamplingSettings_IsValid;

	private static int SamplingSettings_Offset;

	private static bool NormalGenerationSettings_IsValid;

	private static int NormalGenerationSettings_Offset;

	private static bool MaterialSettings_IsValid;

	private static int MaterialSettings_Offset;

	private static bool CompressionSettings_IsValid;

	private static int CompressionSettings_Offset;

	private static bool StaticMeshSettings_IsValid;

	private static int StaticMeshSettings_Offset;

	private static bool GeometryCacheSettings_IsValid;

	private static int GeometryCacheSettings_Offset;

	private static bool ConversionSettings_IsValid;

	private static int ConversionSettings_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:ImportType")]
	public EAlembicImportType ImportType
	{
		get
		{
			CheckDestroyed();
			if (!ImportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:ImportType");
				return EAlembicImportType.StaticMesh;
			}
			return EnumMarshaler<EAlembicImportType>.FromNative(IntPtr.Add(base.Address, ImportType_Offset), 0, ImportType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ImportType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:ImportType");
			}
			else
			{
				EnumMarshaler<EAlembicImportType>.ToNative(IntPtr.Add(base.Address, ImportType_Offset), 0, ImportType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:SamplingSettings")]
	public FAbcSamplingSettings SamplingSettings
	{
		get
		{
			CheckDestroyed();
			if (!SamplingSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:SamplingSettings");
				return default(FAbcSamplingSettings);
			}
			return FAbcSamplingSettings.FromNative(IntPtr.Add(base.Address, SamplingSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SamplingSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:SamplingSettings");
			}
			else
			{
				FAbcSamplingSettings.ToNative(IntPtr.Add(base.Address, SamplingSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:NormalGenerationSettings")]
	public FAbcNormalGenerationSettings NormalGenerationSettings
	{
		get
		{
			CheckDestroyed();
			if (!NormalGenerationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:NormalGenerationSettings");
				return default(FAbcNormalGenerationSettings);
			}
			return FAbcNormalGenerationSettings.FromNative(IntPtr.Add(base.Address, NormalGenerationSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NormalGenerationSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:NormalGenerationSettings");
			}
			else
			{
				FAbcNormalGenerationSettings.ToNative(IntPtr.Add(base.Address, NormalGenerationSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:MaterialSettings")]
	public FAbcMaterialSettings MaterialSettings
	{
		get
		{
			CheckDestroyed();
			if (!MaterialSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:MaterialSettings");
				return default(FAbcMaterialSettings);
			}
			return FAbcMaterialSettings.FromNative(IntPtr.Add(base.Address, MaterialSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaterialSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:MaterialSettings");
			}
			else
			{
				FAbcMaterialSettings.ToNative(IntPtr.Add(base.Address, MaterialSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:CompressionSettings")]
	public FAbcCompressionSettings CompressionSettings
	{
		get
		{
			CheckDestroyed();
			if (!CompressionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:CompressionSettings");
				return default(FAbcCompressionSettings);
			}
			return FAbcCompressionSettings.FromNative(IntPtr.Add(base.Address, CompressionSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CompressionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:CompressionSettings");
			}
			else
			{
				FAbcCompressionSettings.ToNative(IntPtr.Add(base.Address, CompressionSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:StaticMeshSettings")]
	public FAbcStaticMeshSettings StaticMeshSettings
	{
		get
		{
			CheckDestroyed();
			if (!StaticMeshSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:StaticMeshSettings");
				return default(FAbcStaticMeshSettings);
			}
			return FAbcStaticMeshSettings.FromNative(IntPtr.Add(base.Address, StaticMeshSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StaticMeshSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:StaticMeshSettings");
			}
			else
			{
				FAbcStaticMeshSettings.ToNative(IntPtr.Add(base.Address, StaticMeshSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:GeometryCacheSettings")]
	public FAbcGeometryCacheSettings GeometryCacheSettings
	{
		get
		{
			CheckDestroyed();
			if (!GeometryCacheSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:GeometryCacheSettings");
				return default(FAbcGeometryCacheSettings);
			}
			return FAbcGeometryCacheSettings.FromNative(IntPtr.Add(base.Address, GeometryCacheSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GeometryCacheSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:GeometryCacheSettings");
			}
			else
			{
				FAbcGeometryCacheSettings.ToNative(IntPtr.Add(base.Address, GeometryCacheSettings_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcImportSettings:ConversionSettings")]
	public FAbcConversionSettings ConversionSettings
	{
		get
		{
			CheckDestroyed();
			if (!ConversionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:ConversionSettings");
				return default(FAbcConversionSettings);
			}
			return FAbcConversionSettings.FromNative(IntPtr.Add(base.Address, ConversionSettings_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ConversionSettings_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AlembicLibrary.AbcImportSettings:ConversionSettings");
			}
			else
			{
				FAbcConversionSettings.ToNative(IntPtr.Add(base.Address, ConversionSettings_Offset), value);
			}
		}
	}

	static UAbcImportSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAbcImportSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAbcImportSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AlembicLibrary.AbcImportSettings");
		NativeReflectionCached.GetPropertyRef(ref ImportType_PropertyAddress, unrealStruct, "ImportType");
		ImportType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ImportType");
		ImportType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ImportType", Classes.FEnumProperty);
		SamplingSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SamplingSettings");
		SamplingSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SamplingSettings", Classes.FStructProperty);
		NormalGenerationSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NormalGenerationSettings");
		NormalGenerationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NormalGenerationSettings", Classes.FStructProperty);
		MaterialSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "MaterialSettings");
		MaterialSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "MaterialSettings", Classes.FStructProperty);
		CompressionSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "CompressionSettings");
		CompressionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "CompressionSettings", Classes.FStructProperty);
		StaticMeshSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StaticMeshSettings");
		StaticMeshSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StaticMeshSettings", Classes.FStructProperty);
		GeometryCacheSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "GeometryCacheSettings");
		GeometryCacheSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "GeometryCacheSettings", Classes.FStructProperty);
		ConversionSettings_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ConversionSettings");
		ConversionSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ConversionSettings", Classes.FStructProperty);
	}
}
