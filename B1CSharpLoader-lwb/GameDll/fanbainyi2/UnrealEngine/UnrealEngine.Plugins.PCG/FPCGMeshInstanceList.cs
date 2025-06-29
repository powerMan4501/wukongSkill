using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGMeshInstanceList", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGMeshInstanceList
{
	private static bool Instances_IsValid;

	private static FFieldAddress Instances_PropertyAddress;

	private static int Instances_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMeshInstanceList:Instances")]
	public List<FTransform> Instances;

	private static bool InstancesMetadataEntry_IsValid;

	private static FFieldAddress InstancesMetadataEntry_PropertyAddress;

	private static int InstancesMetadataEntry_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/PCG.PCGMeshInstanceList:InstancesMetadataEntry")]
	public List<long> InstancesMetadataEntry;

	private static bool FPCGMeshInstanceList_IsValid;

	private static int FPCGMeshInstanceList_StructSize;

	public FPCGMeshInstanceList Copy()
	{
		FPCGMeshInstanceList result = this;
		if (Instances != null)
		{
			result.Instances = new List<FTransform>(Instances);
		}
		if (InstancesMetadataEntry != null)
		{
			result.InstancesMetadataEntry = new List<long>(InstancesMetadataEntry);
		}
		return result;
	}

	public static FPCGMeshInstanceList FromNative(IntPtr nativeBuffer)
	{
		return new FPCGMeshInstanceList(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGMeshInstanceList value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGMeshInstanceList FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGMeshInstanceList(nativeBuffer + arrayIndex * FPCGMeshInstanceList_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGMeshInstanceList value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGMeshInstanceList_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGMeshInstanceList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMeshInstanceList");
			return;
		}
		new TArrayCopyMarshaler<FTransform>(1, Instances_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Instances_Offset), Instances);
		new TArrayCopyMarshaler<long>(1, InstancesMetadataEntry_PropertyAddress, CachedMarshalingDelegates<long, BlittableTypeMarshaler<long>>.FromNative, CachedMarshalingDelegates<long, BlittableTypeMarshaler<long>>.ToNative).ToNative(IntPtr.Add(nativeStruct, InstancesMetadataEntry_Offset), InstancesMetadataEntry);
	}

	public FPCGMeshInstanceList(IntPtr nativeStruct)
	{
		if (!FPCGMeshInstanceList_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGMeshInstanceList");
			Instances = null;
			InstancesMetadataEntry = null;
		}
		else
		{
			Instances = new TArrayCopyMarshaler<FTransform>(1, Instances_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Instances_Offset));
			InstancesMetadataEntry = new TArrayCopyMarshaler<long>(1, InstancesMetadataEntry_PropertyAddress, CachedMarshalingDelegates<long, BlittableTypeMarshaler<long>>.FromNative, CachedMarshalingDelegates<long, BlittableTypeMarshaler<long>>.ToNative).FromNative(IntPtr.Add(nativeStruct, InstancesMetadataEntry_Offset));
		}
	}

	static FPCGMeshInstanceList()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGMeshInstanceList)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGMeshInstanceList));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGMeshInstanceList");
		FPCGMeshInstanceList_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Instances_PropertyAddress, intPtr, "Instances");
		Instances_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Instances");
		Instances_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Instances", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref InstancesMetadataEntry_PropertyAddress, intPtr, "InstancesMetadataEntry");
		InstancesMetadataEntry_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InstancesMetadataEntry");
		InstancesMetadataEntry_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InstancesMetadataEntry", Classes.FArrayProperty);
		FPCGMeshInstanceList_IsValid = intPtr != IntPtr.Zero && Instances_IsValid && InstancesMetadataEntry_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGMeshInstanceList", FPCGMeshInstanceList_IsValid);
	}
}
