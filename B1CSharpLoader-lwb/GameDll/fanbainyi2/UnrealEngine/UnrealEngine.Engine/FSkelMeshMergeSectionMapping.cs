using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.SkelMeshMergeSectionMapping", "Engine", UnrealModuleType.Engine)]
public struct FSkelMeshMergeSectionMapping
{
	private static bool SectionIDs_IsValid;

	private static FFieldAddress SectionIDs_PropertyAddress;

	private static int SectionIDs_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/Engine.SkelMeshMergeSectionMapping:SectionIDs")]
	public List<int> SectionIDs;

	private static bool FSkelMeshMergeSectionMapping_IsValid;

	private static int FSkelMeshMergeSectionMapping_StructSize;

	public FSkelMeshMergeSectionMapping Copy()
	{
		FSkelMeshMergeSectionMapping result = this;
		if (SectionIDs != null)
		{
			result.SectionIDs = new List<int>(SectionIDs);
		}
		return result;
	}

	public static FSkelMeshMergeSectionMapping FromNative(IntPtr nativeBuffer)
	{
		return new FSkelMeshMergeSectionMapping(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSkelMeshMergeSectionMapping value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSkelMeshMergeSectionMapping FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSkelMeshMergeSectionMapping(nativeBuffer + arrayIndex * FSkelMeshMergeSectionMapping_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSkelMeshMergeSectionMapping value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSkelMeshMergeSectionMapping_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSkelMeshMergeSectionMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshMergeSectionMapping");
		}
		else
		{
			new TArrayCopyMarshaler<int>(1, SectionIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, SectionIDs_Offset), SectionIDs);
		}
	}

	public FSkelMeshMergeSectionMapping(IntPtr nativeStruct)
	{
		if (!FSkelMeshMergeSectionMapping_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SkelMeshMergeSectionMapping");
			SectionIDs = null;
		}
		else
		{
			SectionIDs = new TArrayCopyMarshaler<int>(1, SectionIDs_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, SectionIDs_Offset));
		}
	}

	static FSkelMeshMergeSectionMapping()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSkelMeshMergeSectionMapping)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSkelMeshMergeSectionMapping));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SkelMeshMergeSectionMapping");
		FSkelMeshMergeSectionMapping_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref SectionIDs_PropertyAddress, intPtr, "SectionIDs");
		SectionIDs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SectionIDs");
		SectionIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SectionIDs", Classes.FArrayProperty);
		FSkelMeshMergeSectionMapping_IsValid = intPtr != IntPtr.Zero && SectionIDs_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SkelMeshMergeSectionMapping", FSkelMeshMergeSectionMapping_IsValid);
	}
}
