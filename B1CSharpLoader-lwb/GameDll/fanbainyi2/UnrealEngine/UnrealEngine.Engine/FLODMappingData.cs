using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.LODMappingData", "Engine", UnrealModuleType.Engine)]
public struct FLODMappingData
{
	private static bool Mapping_IsValid;

	private static FFieldAddress Mapping_PropertyAddress;

	private static int Mapping_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.LODMappingData:Mapping")]
	public List<int> Mapping;

	private static bool FLODMappingData_IsValid;

	private static int FLODMappingData_StructSize;

	public FLODMappingData Copy()
	{
		FLODMappingData result = this;
		if (Mapping != null)
		{
			result.Mapping = new List<int>(Mapping);
		}
		return result;
	}

	public static FLODMappingData FromNative(IntPtr nativeBuffer)
	{
		return new FLODMappingData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLODMappingData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLODMappingData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLODMappingData(nativeBuffer + arrayIndex * FLODMappingData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLODMappingData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLODMappingData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLODMappingData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LODMappingData");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, Mapping_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Mapping_Offset), Mapping);
		}
	}

	public FLODMappingData(IntPtr nativeStruct)
	{
		if (!FLODMappingData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.LODMappingData");
			Mapping = null;
		}
		else
		{
			Mapping = new TArrayCopyMarshaler<int>(1, Mapping_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Mapping_Offset));
		}
	}

	static FLODMappingData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLODMappingData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLODMappingData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.LODMappingData");
		FLODMappingData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Mapping_PropertyAddress, intPtr, "Mapping");
		Mapping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Mapping");
		Mapping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Mapping", Classes.FArrayProperty);
		FLODMappingData_IsValid = intPtr != IntPtr.Zero && Mapping_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.LODMappingData", FLODMappingData_IsValid);
	}
}
