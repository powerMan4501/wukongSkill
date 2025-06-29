using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshWriteLOD", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeshWriteLOD
{
	private static bool WriteHiResSource_IsValid;

	private static FFieldAddress WriteHiResSource_PropertyAddress;

	private static int WriteHiResSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshWriteLOD:bWriteHiResSource")]
	public bool WriteHiResSource;

	private static bool LODIndex_IsValid;

	private static int LODIndex_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeshWriteLOD:LODIndex")]
	public int LODIndex;

	private static bool FGeometryScriptMeshWriteLOD_IsValid;

	private static int FGeometryScriptMeshWriteLOD_StructSize;

	public FGeometryScriptMeshWriteLOD Copy()
	{
		return this;
	}

	public static FGeometryScriptMeshWriteLOD FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeshWriteLOD(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeshWriteLOD value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeshWriteLOD FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeshWriteLOD(nativeBuffer + arrayIndex * FGeometryScriptMeshWriteLOD_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeshWriteLOD value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeshWriteLOD_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshWriteLOD_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshWriteLOD");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WriteHiResSource_Offset), 0, WriteHiResSource_PropertyAddress.Address, WriteHiResSource);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, LODIndex_Offset), LODIndex);
	}

	public FGeometryScriptMeshWriteLOD(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeshWriteLOD_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeshWriteLOD");
			WriteHiResSource = false;
			LODIndex = 0;
		}
		else
		{
			WriteHiResSource = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WriteHiResSource_Offset), 0, WriteHiResSource_PropertyAddress.Address);
			LODIndex = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, LODIndex_Offset));
		}
	}

	static FGeometryScriptMeshWriteLOD()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeshWriteLOD)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeshWriteLOD));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeshWriteLOD");
		FGeometryScriptMeshWriteLOD_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref WriteHiResSource_PropertyAddress, intPtr, "bWriteHiResSource");
		WriteHiResSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWriteHiResSource");
		WriteHiResSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWriteHiResSource", Classes.FBoolProperty);
		LODIndex_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LODIndex");
		LODIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LODIndex", Classes.FIntProperty);
		FGeometryScriptMeshWriteLOD_IsValid = intPtr != IntPtr.Zero && WriteHiResSource_IsValid && LODIndex_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeshWriteLOD", FGeometryScriptMeshWriteLOD_IsValid);
	}
}
