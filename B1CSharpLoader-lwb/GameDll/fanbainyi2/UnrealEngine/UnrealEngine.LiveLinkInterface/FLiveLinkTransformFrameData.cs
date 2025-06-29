using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformFrameData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkTransformFrameData
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

	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)4503678010523653uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformFrameData:Transform")]
	public FTransform Transform;

	private static bool FLiveLinkTransformFrameData_IsValid;

	private static int FLiveLinkTransformFrameData_StructSize;

	public FLiveLinkTransformFrameData Copy()
	{
		FLiveLinkTransformFrameData result = this;
		if (PropertyValues != null)
		{
			result.PropertyValues = new List<float>(PropertyValues);
		}
		return result;
	}

	public static FLiveLinkTransformFrameData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkTransformFrameData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkTransformFrameData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkTransformFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkTransformFrameData(nativeBuffer + arrayIndex * FLiveLinkTransformFrameData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkTransformFrameData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkTransformFrameData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransformFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransformFrameData");
			return;
		}
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Transform_Offset), Transform);
		FLiveLinkMetaData.ToNative(IntPtr.Add(nativeStruct, MetaData_Offset), MetaData);
		new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyValues_Offset), PropertyValues);
	}

	public FLiveLinkTransformFrameData(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransformFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransformFrameData");
			Transform = default(FTransform);
			MetaData = default(FLiveLinkMetaData);
			PropertyValues = null;
		}
		else
		{
			Transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Transform_Offset));
			MetaData = FLiveLinkMetaData.FromNative(IntPtr.Add(nativeStruct, MetaData_Offset));
			PropertyValues = new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyValues_Offset));
		}
	}

	static FLiveLinkTransformFrameData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkTransformFrameData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkTransformFrameData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkTransformFrameData");
		FLiveLinkTransformFrameData_StructSize = NativeReflection.GetStructSize(intPtr);
		MetaData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetaData");
		MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetaData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyValues_PropertyAddress, intPtr, "PropertyValues");
		PropertyValues_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyValues");
		PropertyValues_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyValues", Classes.FArrayProperty);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		FLiveLinkTransformFrameData_IsValid = intPtr != IntPtr.Zero && Transform_IsValid && MetaData_IsValid && PropertyValues_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkTransformFrameData", FLiveLinkTransformFrameData_IsValid);
	}
}
