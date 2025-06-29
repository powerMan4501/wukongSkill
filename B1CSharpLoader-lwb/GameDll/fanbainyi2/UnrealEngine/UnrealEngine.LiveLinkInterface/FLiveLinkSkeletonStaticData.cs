using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkSkeletonStaticData
{
	private static bool PropertyNames_IsValid;

	private static FFieldAddress PropertyNames_PropertyAddress;

	private static int PropertyNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseStaticData:PropertyNames")]
	public List<FName> PropertyNames;

	private static bool BoneNames_IsValid;

	private static FFieldAddress BoneNames_PropertyAddress;

	private static int BoneNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData:BoneNames")]
	public List<FName> BoneNames;

	private static bool BoneParents_IsValid;

	private static FFieldAddress BoneParents_PropertyAddress;

	private static int BoneParents_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData:BoneParents")]
	public List<int> BoneParents;

	private static bool FLiveLinkSkeletonStaticData_IsValid;

	private static int FLiveLinkSkeletonStaticData_StructSize;

	public FLiveLinkSkeletonStaticData Copy()
	{
		FLiveLinkSkeletonStaticData result = this;
		if (BoneNames != null)
		{
			result.BoneNames = new List<FName>(BoneNames);
		}
		if (BoneParents != null)
		{
			result.BoneParents = new List<int>(BoneParents);
		}
		if (PropertyNames != null)
		{
			result.PropertyNames = new List<FName>(PropertyNames);
		}
		return result;
	}

	public static FLiveLinkSkeletonStaticData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkSkeletonStaticData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkSkeletonStaticData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkSkeletonStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkSkeletonStaticData(nativeBuffer + arrayIndex * FLiveLinkSkeletonStaticData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkSkeletonStaticData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkSkeletonStaticData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkSkeletonStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData");
			return;
		}
		new TArrayCopyMarshaler<FName>(1, BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BoneNames_Offset), BoneNames);
		new TArrayCopyMarshaler<int>(1, BoneParents_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).ToNative(IntPtr.Add(nativeStruct, BoneParents_Offset), BoneParents);
		new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyNames_Offset), PropertyNames);
	}

	public FLiveLinkSkeletonStaticData(IntPtr nativeStruct)
	{
		if (!FLiveLinkSkeletonStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData");
			BoneNames = null;
			BoneParents = null;
			PropertyNames = null;
		}
		else
		{
			BoneNames = new TArrayCopyMarshaler<FName>(1, BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BoneNames_Offset));
			BoneParents = new TArrayCopyMarshaler<int>(1, BoneParents_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(nativeStruct, BoneParents_Offset));
			PropertyNames = new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyNames_Offset));
		}
	}

	static FLiveLinkSkeletonStaticData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkSkeletonStaticData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkSkeletonStaticData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData");
		FLiveLinkSkeletonStaticData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PropertyNames_PropertyAddress, intPtr, "PropertyNames");
		PropertyNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyNames");
		PropertyNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoneNames_PropertyAddress, intPtr, "BoneNames");
		BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneNames");
		BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BoneParents_PropertyAddress, intPtr, "BoneParents");
		BoneParents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneParents");
		BoneParents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneParents", Classes.FArrayProperty);
		FLiveLinkSkeletonStaticData_IsValid = intPtr != IntPtr.Zero && BoneNames_IsValid && BoneParents_IsValid && PropertyNames_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkSkeletonStaticData", FLiveLinkSkeletonStaticData_IsValid);
	}
}
