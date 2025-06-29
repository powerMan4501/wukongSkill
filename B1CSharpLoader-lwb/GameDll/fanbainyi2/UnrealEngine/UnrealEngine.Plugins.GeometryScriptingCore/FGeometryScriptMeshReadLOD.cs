using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshReadLOD", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshReadLOD
{
	private static bool LODType_IsValid;

	private static FFieldAddress LODType_PropertyAddress;

	private static int LODType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshReadLOD:LODType")]
	public EGeometryScriptLODType LODType;

	private static bool LODIndex_IsValid;

	private static int LODIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshReadLOD:LODIndex")]
	public int LODIndex;

	private static bool FGeometryScriptMeshReadLOD_IsValid;

	private static int FGeometryScriptMeshReadLOD_StructSize;

	public FGeometryScriptMeshReadLOD Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshReadLOD FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshReadLOD(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshReadLOD value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshReadLOD FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshReadLOD(nativeBuffer + arrayIndex * FGeometryScriptMeshReadLOD_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshReadLOD value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshReadLOD_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshReadLOD_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshReadLOD");
			return;
		}
		EnumMarshaler<EGeometryScriptLODType>.ToNative(IntPtr.Add(nativeStruct, LODType_Offset), 0, LODType_PropertyAddress.Address, LODType);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODIndex_Offset), LODIndex);
	}

	public FGeometryScriptMeshReadLOD(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshReadLOD_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshReadLOD");
			LODType = EGeometryScriptLODType.MaxAvailable;
			LODIndex = 0;
		}
		else
		{
			LODType = EnumMarshaler<EGeometryScriptLODType>.FromNative(IntPtr.Add(nativeStruct, LODType_Offset), 0, LODType_PropertyAddress.Address);
			LODIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODIndex_Offset));
		}
	}

	static FGeometryScriptMeshReadLOD()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshReadLOD)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshReadLOD));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshReadLOD");
		FGeometryScriptMeshReadLOD_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref LODType_PropertyAddress, intPtr, "LODType");
		LODType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODType");
		LODType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODType", Classes.FEnumProperty);
		LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODIndex");
		LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODIndex", Classes.FIntProperty);
		FGeometryScriptMeshReadLOD_IsValid = intPtr != IntPtr.Zero && LODType_IsValid && LODIndex_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshReadLOD", FGeometryScriptMeshReadLOD_IsValid);
	}
}
