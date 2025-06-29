using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public struct FAbcGeometryCacheSettings
{
	private static bool FlattenTracks_IsValid;

	private static FFieldAddress FlattenTracks_PropertyAddress;

	private static int FlattenTracks_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings:bFlattenTracks")]
	public bool FlattenTracks;

	private static bool StoreImportedVertexNumbers_IsValid;

	private static FFieldAddress StoreImportedVertexNumbers_PropertyAddress;

	private static int StoreImportedVertexNumbers_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings:bStoreImportedVertexNumbers")]
	public bool StoreImportedVertexNumbers;

	private static bool ApplyConstantTopologyOptimizations_IsValid;

	private static FFieldAddress ApplyConstantTopologyOptimizations_PropertyAddress;

	private static int ApplyConstantTopologyOptimizations_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings:bApplyConstantTopologyOptimizations")]
	public bool ApplyConstantTopologyOptimizations;

	private static bool MotionVectors_IsValid;

	private static FFieldAddress MotionVectors_PropertyAddress;

	private static int MotionVectors_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings:MotionVectors")]
	public EAbcGeometryCacheMotionVectorsImport MotionVectors;

	private static bool OptimizeIndexBuffers_IsValid;

	private static FFieldAddress OptimizeIndexBuffers_PropertyAddress;

	private static int OptimizeIndexBuffers_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings:bOptimizeIndexBuffers")]
	public bool OptimizeIndexBuffers;

	private static bool CompressedPositionPrecision_IsValid;

	private static int CompressedPositionPrecision_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings:CompressedPositionPrecision")]
	public float CompressedPositionPrecision;

	private static bool CompressedTextureCoordinatesNumberOfBits_IsValid;

	private static int CompressedTextureCoordinatesNumberOfBits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcGeometryCacheSettings:CompressedTextureCoordinatesNumberOfBits")]
	public int CompressedTextureCoordinatesNumberOfBits;

	private static bool FAbcGeometryCacheSettings_IsValid;

	private static int FAbcGeometryCacheSettings_StructSize;

	public FAbcGeometryCacheSettings Copy()
	{
		return this;
	}

	public static FAbcGeometryCacheSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAbcGeometryCacheSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAbcGeometryCacheSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAbcGeometryCacheSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAbcGeometryCacheSettings(nativeBuffer + arrayIndex * FAbcGeometryCacheSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAbcGeometryCacheSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAbcGeometryCacheSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAbcGeometryCacheSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcGeometryCacheSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FlattenTracks_Offset), 0, FlattenTracks_PropertyAddress.Address, FlattenTracks);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, StoreImportedVertexNumbers_Offset), 0, StoreImportedVertexNumbers_PropertyAddress.Address, StoreImportedVertexNumbers);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyConstantTopologyOptimizations_Offset), 0, ApplyConstantTopologyOptimizations_PropertyAddress.Address, ApplyConstantTopologyOptimizations);
		EnumMarshaler<EAbcGeometryCacheMotionVectorsImport>.ToNative(IntPtr.Add(nativeStruct, MotionVectors_Offset), 0, MotionVectors_PropertyAddress.Address, MotionVectors);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OptimizeIndexBuffers_Offset), 0, OptimizeIndexBuffers_PropertyAddress.Address, OptimizeIndexBuffers);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CompressedPositionPrecision_Offset), CompressedPositionPrecision);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CompressedTextureCoordinatesNumberOfBits_Offset), CompressedTextureCoordinatesNumberOfBits);
	}

	public FAbcGeometryCacheSettings(IntPtr nativeStruct)
	{
		if (!FAbcGeometryCacheSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcGeometryCacheSettings");
			FlattenTracks = false;
			StoreImportedVertexNumbers = false;
			ApplyConstantTopologyOptimizations = false;
			MotionVectors = EAbcGeometryCacheMotionVectorsImport.NoMotionVectors;
			OptimizeIndexBuffers = false;
			CompressedPositionPrecision = 0f;
			CompressedTextureCoordinatesNumberOfBits = 0;
		}
		else
		{
			FlattenTracks = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FlattenTracks_Offset), 0, FlattenTracks_PropertyAddress.Address);
			StoreImportedVertexNumbers = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, StoreImportedVertexNumbers_Offset), 0, StoreImportedVertexNumbers_PropertyAddress.Address);
			ApplyConstantTopologyOptimizations = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyConstantTopologyOptimizations_Offset), 0, ApplyConstantTopologyOptimizations_PropertyAddress.Address);
			MotionVectors = EnumMarshaler<EAbcGeometryCacheMotionVectorsImport>.FromNative(IntPtr.Add(nativeStruct, MotionVectors_Offset), 0, MotionVectors_PropertyAddress.Address);
			OptimizeIndexBuffers = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OptimizeIndexBuffers_Offset), 0, OptimizeIndexBuffers_PropertyAddress.Address);
			CompressedPositionPrecision = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CompressedPositionPrecision_Offset));
			CompressedTextureCoordinatesNumberOfBits = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CompressedTextureCoordinatesNumberOfBits_Offset));
		}
	}

	static FAbcGeometryCacheSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAbcGeometryCacheSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbcGeometryCacheSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AlembicLibrary.AbcGeometryCacheSettings");
		FAbcGeometryCacheSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FlattenTracks_PropertyAddress, intPtr, "bFlattenTracks");
		FlattenTracks_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFlattenTracks");
		FlattenTracks_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFlattenTracks", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StoreImportedVertexNumbers_PropertyAddress, intPtr, "bStoreImportedVertexNumbers");
		StoreImportedVertexNumbers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bStoreImportedVertexNumbers");
		StoreImportedVertexNumbers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bStoreImportedVertexNumbers", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyConstantTopologyOptimizations_PropertyAddress, intPtr, "bApplyConstantTopologyOptimizations");
		ApplyConstantTopologyOptimizations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyConstantTopologyOptimizations");
		ApplyConstantTopologyOptimizations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyConstantTopologyOptimizations", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MotionVectors_PropertyAddress, intPtr, "MotionVectors");
		MotionVectors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MotionVectors");
		MotionVectors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MotionVectors", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OptimizeIndexBuffers_PropertyAddress, intPtr, "bOptimizeIndexBuffers");
		OptimizeIndexBuffers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOptimizeIndexBuffers");
		OptimizeIndexBuffers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOptimizeIndexBuffers", Classes.FBoolProperty);
		CompressedPositionPrecision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompressedPositionPrecision");
		CompressedPositionPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompressedPositionPrecision", Classes.FFloatProperty);
		CompressedTextureCoordinatesNumberOfBits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CompressedTextureCoordinatesNumberOfBits");
		CompressedTextureCoordinatesNumberOfBits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CompressedTextureCoordinatesNumberOfBits", Classes.FIntProperty);
		FAbcGeometryCacheSettings_IsValid = intPtr != IntPtr.Zero && FlattenTracks_IsValid && StoreImportedVertexNumbers_IsValid && ApplyConstantTopologyOptimizations_IsValid && MotionVectors_IsValid && OptimizeIndexBuffers_IsValid && CompressedPositionPrecision_IsValid && CompressedTextureCoordinatesNumberOfBits_IsValid;
		NativeReflection.LogStructIsValid("/Script/AlembicLibrary.AbcGeometryCacheSettings", FAbcGeometryCacheSettings_IsValid);
	}
}
