using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.MaterialBaking;

[UClass(Flags = (ClassFlags)810549412uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MaterialBaking.MaterialOptions", "MaterialBaking", UnrealModuleType.Engine)]
public class UMaterialOptions : UObject
{
	private static bool Properties_IsValid;

	private static FFieldAddress Properties_PropertyAddress;

	private static int Properties_Offset;

	private TArrayReadWriteMarshaler<FPropertyEntry> Properties_MarshalerCached;

	private static bool TextureSize_IsValid;

	private static int TextureSize_Offset;

	private static bool LODIndices_IsValid;

	private static FFieldAddress LODIndices_PropertyAddress;

	private static int LODIndices_Offset;

	private TArrayReadWriteMarshaler<int> LODIndices_MarshalerCached;

	private static bool UseMeshData_IsValid;

	private static FFieldAddress UseMeshData_PropertyAddress;

	private static int UseMeshData_Offset;

	private static bool UseSpecificUVIndex_IsValid;

	private static FFieldAddress UseSpecificUVIndex_PropertyAddress;

	private static int UseSpecificUVIndex_Offset;

	private static bool TextureCoordinateIndex_IsValid;

	private static int TextureCoordinateIndex_Offset;

	[UProperty(Flags = (PropFlags)4785074604098053uL)]
	[UMetaPath("/Script/MaterialBaking.MaterialOptions:Properties")]
	public TArrayReadWrite<FPropertyEntry> Properties
	{
		get
		{
			CheckDestroyed();
			if (!Properties_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:Properties");
				return null;
			}
			if (Properties_MarshalerCached == null)
			{
				Properties_MarshalerCached = new TArrayReadWriteMarshaler<FPropertyEntry>(1, Properties_PropertyAddress, CachedMarshalingDelegates<FPropertyEntry, FPropertyEntry>.FromNative, CachedMarshalingDelegates<FPropertyEntry, FPropertyEntry>.ToNative);
			}
			return Properties_MarshalerCached.FromNative(IntPtr.Add(base.Address, Properties_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7036944211001861uL)]
	[UMetaPath("/Script/MaterialBaking.MaterialOptions:TextureSize")]
	public FIntPoint TextureSize
	{
		get
		{
			CheckDestroyed();
			if (!TextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:TextureSize");
				return default(FIntPoint);
			}
			return BlittableTypeMarshaler<FIntPoint>.FromNative(IntPtr.Add(base.Address, TextureSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:TextureSize");
			}
			else
			{
				BlittableTypeMarshaler<FIntPoint>.ToNative(IntPtr.Add(base.Address, TextureSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4785074604081668uL)]
	[UMetaPath("/Script/MaterialBaking.MaterialOptions:LODIndices")]
	public TArrayReadWrite<int> LODIndices
	{
		get
		{
			CheckDestroyed();
			if (!LODIndices_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:LODIndices");
				return null;
			}
			if (LODIndices_MarshalerCached == null)
			{
				LODIndices_MarshalerCached = new TArrayReadWriteMarshaler<int>(1, LODIndices_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return LODIndices_MarshalerCached.FromNative(IntPtr.Add(base.Address, LODIndices_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)7036944211001861uL)]
	[UMetaPath("/Script/MaterialBaking.MaterialOptions:bUseMeshData")]
	public bool UseMeshData
	{
		get
		{
			CheckDestroyed();
			if (!UseMeshData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:bUseMeshData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseMeshData_Offset), 0, UseMeshData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseMeshData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:bUseMeshData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseMeshData_Offset), 0, UseMeshData_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/MaterialBaking.MaterialOptions:bUseSpecificUVIndex")]
	public bool UseSpecificUVIndex
	{
		get
		{
			CheckDestroyed();
			if (!UseSpecificUVIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:bUseSpecificUVIndex");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSpecificUVIndex_Offset), 0, UseSpecificUVIndex_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSpecificUVIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:bUseSpecificUVIndex");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSpecificUVIndex_Offset), 0, UseSpecificUVIndex_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7036944210985477uL)]
	[UMetaPath("/Script/MaterialBaking.MaterialOptions:TextureCoordinateIndex")]
	public int TextureCoordinateIndex
	{
		get
		{
			CheckDestroyed();
			if (!TextureCoordinateIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:TextureCoordinateIndex");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TextureCoordinateIndex_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TextureCoordinateIndex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MaterialBaking.MaterialOptions:TextureCoordinateIndex");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TextureCoordinateIndex_Offset), value);
			}
		}
	}

	static UMaterialOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MaterialBaking.MaterialOptions");
		NativeReflectionCached.GetPropertyRef(ref Properties_PropertyAddress, unrealStruct, "Properties");
		Properties_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Properties");
		Properties_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Properties", Classes.FArrayProperty);
		TextureSize_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextureSize");
		TextureSize_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextureSize", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LODIndices_PropertyAddress, unrealStruct, "LODIndices");
		LODIndices_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "LODIndices");
		LODIndices_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "LODIndices", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref UseMeshData_PropertyAddress, unrealStruct, "bUseMeshData");
		UseMeshData_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseMeshData");
		UseMeshData_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseMeshData", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UseSpecificUVIndex_PropertyAddress, unrealStruct, "bUseSpecificUVIndex");
		UseSpecificUVIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUseSpecificUVIndex");
		UseSpecificUVIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUseSpecificUVIndex", Classes.FBoolProperty);
		TextureCoordinateIndex_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TextureCoordinateIndex");
		TextureCoordinateIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TextureCoordinateIndex", Classes.FIntProperty);
	}
}
