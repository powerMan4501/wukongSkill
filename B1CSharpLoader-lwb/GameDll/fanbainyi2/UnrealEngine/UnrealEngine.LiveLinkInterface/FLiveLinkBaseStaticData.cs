using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseStaticData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkBaseStaticData
{
	private static bool PropertyNames_IsValid;

	private static FFieldAddress PropertyNames_PropertyAddress;

	private static int PropertyNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseStaticData:PropertyNames")]
	public List<FName> PropertyNames;

	private static bool FLiveLinkBaseStaticData_IsValid;

	private static int FLiveLinkBaseStaticData_StructSize;

	public FLiveLinkBaseStaticData Copy()
	{
		FLiveLinkBaseStaticData result = this;
		if (PropertyNames != null)
		{
			result.PropertyNames = new List<FName>(PropertyNames);
		}
		return result;
	}

	public static FLiveLinkBaseStaticData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkBaseStaticData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkBaseStaticData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkBaseStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkBaseStaticData(nativeBuffer + arrayIndex * FLiveLinkBaseStaticData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkBaseStaticData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkBaseStaticData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkBaseStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBaseStaticData");
		}
		else
		{
			new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyNames_Offset), PropertyNames);
		}
	}

	public FLiveLinkBaseStaticData(IntPtr nativeStruct)
	{
		if (!FLiveLinkBaseStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBaseStaticData");
			PropertyNames = null;
		}
		else
		{
			PropertyNames = new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyNames_Offset));
		}
	}

	static FLiveLinkBaseStaticData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkBaseStaticData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkBaseStaticData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkBaseStaticData");
		FLiveLinkBaseStaticData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PropertyNames_PropertyAddress, intPtr, "PropertyNames");
		PropertyNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyNames");
		PropertyNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyNames", Classes.FArrayProperty);
		FLiveLinkBaseStaticData_IsValid = intPtr != IntPtr.Zero && PropertyNames_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkBaseStaticData", FLiveLinkBaseStaticData_IsValid);
	}
}
