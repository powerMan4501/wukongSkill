using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.AbcStaticMeshSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public struct FAbcStaticMeshSettings
{
	private static bool MergeMeshes_IsValid;

	private static FFieldAddress MergeMeshes_PropertyAddress;

	private static int MergeMeshes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcStaticMeshSettings:bMergeMeshes")]
	public bool MergeMeshes;

	private static bool PropagateMatrixTransformations_IsValid;

	private static FFieldAddress PropagateMatrixTransformations_PropertyAddress;

	private static int PropagateMatrixTransformations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcStaticMeshSettings:bPropagateMatrixTransformations")]
	public bool PropagateMatrixTransformations;

	private static bool GenerateLightmapUVs_IsValid;

	private static FFieldAddress GenerateLightmapUVs_PropertyAddress;

	private static int GenerateLightmapUVs_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcStaticMeshSettings:bGenerateLightmapUVs")]
	public bool GenerateLightmapUVs;

	private static bool FAbcStaticMeshSettings_IsValid;

	private static int FAbcStaticMeshSettings_StructSize;

	public FAbcStaticMeshSettings Copy()
	{
		return this;
	}

	public static FAbcStaticMeshSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAbcStaticMeshSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAbcStaticMeshSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAbcStaticMeshSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAbcStaticMeshSettings(nativeBuffer + arrayIndex * FAbcStaticMeshSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAbcStaticMeshSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAbcStaticMeshSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAbcStaticMeshSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcStaticMeshSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, MergeMeshes_Offset), 0, MergeMeshes_PropertyAddress.Address, MergeMeshes);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PropagateMatrixTransformations_Offset), 0, PropagateMatrixTransformations_PropertyAddress.Address, PropagateMatrixTransformations);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address, GenerateLightmapUVs);
	}

	public FAbcStaticMeshSettings(IntPtr nativeStruct)
	{
		if (!FAbcStaticMeshSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcStaticMeshSettings");
			MergeMeshes = false;
			PropagateMatrixTransformations = false;
			GenerateLightmapUVs = false;
		}
		else
		{
			MergeMeshes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, MergeMeshes_Offset), 0, MergeMeshes_PropertyAddress.Address);
			PropagateMatrixTransformations = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PropagateMatrixTransformations_Offset), 0, PropagateMatrixTransformations_PropertyAddress.Address);
			GenerateLightmapUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, GenerateLightmapUVs_Offset), 0, GenerateLightmapUVs_PropertyAddress.Address);
		}
	}

	static FAbcStaticMeshSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAbcStaticMeshSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbcStaticMeshSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AlembicLibrary.AbcStaticMeshSettings");
		FAbcStaticMeshSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref MergeMeshes_PropertyAddress, intPtr, "bMergeMeshes");
		MergeMeshes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMergeMeshes");
		MergeMeshes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMergeMeshes", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PropagateMatrixTransformations_PropertyAddress, intPtr, "bPropagateMatrixTransformations");
		PropagateMatrixTransformations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPropagateMatrixTransformations");
		PropagateMatrixTransformations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPropagateMatrixTransformations", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GenerateLightmapUVs_PropertyAddress, intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bGenerateLightmapUVs");
		GenerateLightmapUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bGenerateLightmapUVs", Classes.FBoolProperty);
		FAbcStaticMeshSettings_IsValid = intPtr != IntPtr.Zero && MergeMeshes_IsValid && PropagateMatrixTransformations_IsValid && GenerateLightmapUVs_IsValid;
		NativeReflection.LogStructIsValid("/Script/AlembicLibrary.AbcStaticMeshSettings", FAbcStaticMeshSettings_IsValid);
	}
}
