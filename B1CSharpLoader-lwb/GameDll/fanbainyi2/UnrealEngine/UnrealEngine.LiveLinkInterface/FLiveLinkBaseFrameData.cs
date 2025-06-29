using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseFrameData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkBaseFrameData
{
	private static bool MetaData_IsValid;

	private static int MetaData_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseFrameData:MetaData")]
	public FLiveLinkMetaData MetaData;

	private static bool PropertyValues_IsValid;

	private static FFieldAddress PropertyValues_PropertyAddress;

	private static int PropertyValues_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseFrameData:PropertyValues")]
	public List<float> PropertyValues;

	private static bool FLiveLinkBaseFrameData_IsValid;

	private static int FLiveLinkBaseFrameData_StructSize;

	public FLiveLinkBaseFrameData Copy()
	{
		FLiveLinkBaseFrameData result = this;
		if (PropertyValues != null)
		{
			result.PropertyValues = new List<float>(PropertyValues);
		}
		return result;
	}

	public static FLiveLinkBaseFrameData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkBaseFrameData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkBaseFrameData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkBaseFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkBaseFrameData(nativeBuffer + arrayIndex * FLiveLinkBaseFrameData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkBaseFrameData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkBaseFrameData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkBaseFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBaseFrameData");
			return;
		}
		FLiveLinkMetaData.ToNative(IntPtr.Add(nativeStruct, MetaData_Offset), MetaData);
		new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyValues_Offset), PropertyValues);
	}

	public FLiveLinkBaseFrameData(IntPtr nativeStruct)
	{
		if (!FLiveLinkBaseFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkBaseFrameData");
			MetaData = default(FLiveLinkMetaData);
			PropertyValues = null;
		}
		else
		{
			MetaData = FLiveLinkMetaData.FromNative(IntPtr.Add(nativeStruct, MetaData_Offset));
			PropertyValues = new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyValues_Offset));
		}
	}

	static FLiveLinkBaseFrameData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkBaseFrameData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkBaseFrameData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkBaseFrameData");
		FLiveLinkBaseFrameData_StructSize = NativeReflection.GetStructSize(intPtr);
		MetaData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetaData");
		MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetaData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyValues_PropertyAddress, intPtr, "PropertyValues");
		PropertyValues_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyValues");
		PropertyValues_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyValues", Classes.FArrayProperty);
		FLiveLinkBaseFrameData_IsValid = intPtr != IntPtr.Zero && MetaData_IsValid && PropertyValues_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkBaseFrameData", FLiveLinkBaseFrameData_IsValid);
	}
}
