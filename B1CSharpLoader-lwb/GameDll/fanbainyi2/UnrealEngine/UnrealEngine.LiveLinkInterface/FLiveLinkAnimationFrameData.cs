using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkAnimationFrameData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkAnimationFrameData
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

	private static bool Transforms_IsValid;

	private static FFieldAddress Transforms_PropertyAddress;

	private static int Transforms_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkAnimationFrameData:Transforms")]
	public List<FTransform> Transforms;

	private static bool FLiveLinkAnimationFrameData_IsValid;

	private static int FLiveLinkAnimationFrameData_StructSize;

	public FLiveLinkAnimationFrameData Copy()
	{
		FLiveLinkAnimationFrameData result = this;
		if (Transforms != null)
		{
			result.Transforms = new List<FTransform>(Transforms);
		}
		if (PropertyValues != null)
		{
			result.PropertyValues = new List<float>(PropertyValues);
		}
		return result;
	}

	public static FLiveLinkAnimationFrameData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkAnimationFrameData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkAnimationFrameData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkAnimationFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkAnimationFrameData(nativeBuffer + arrayIndex * FLiveLinkAnimationFrameData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkAnimationFrameData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkAnimationFrameData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkAnimationFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkAnimationFrameData");
			return;
		}
		new TArrayCopyMarshaler<FTransform>(1, Transforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Transforms_Offset), Transforms);
		FLiveLinkMetaData.ToNative(IntPtr.Add(nativeStruct, MetaData_Offset), MetaData);
		new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyValues_Offset), PropertyValues);
	}

	public FLiveLinkAnimationFrameData(IntPtr nativeStruct)
	{
		if (!FLiveLinkAnimationFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkAnimationFrameData");
			Transforms = null;
			MetaData = default(FLiveLinkMetaData);
			PropertyValues = null;
		}
		else
		{
			Transforms = new TArrayCopyMarshaler<FTransform>(1, Transforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Transforms_Offset));
			MetaData = FLiveLinkMetaData.FromNative(IntPtr.Add(nativeStruct, MetaData_Offset));
			PropertyValues = new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyValues_Offset));
		}
	}

	static FLiveLinkAnimationFrameData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkAnimationFrameData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkAnimationFrameData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkAnimationFrameData");
		FLiveLinkAnimationFrameData_StructSize = NativeReflection.GetStructSize(intPtr);
		MetaData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetaData");
		MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetaData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyValues_PropertyAddress, intPtr, "PropertyValues");
		PropertyValues_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyValues");
		PropertyValues_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyValues", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Transforms_PropertyAddress, intPtr, "Transforms");
		Transforms_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transforms");
		Transforms_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transforms", Classes.FArrayProperty);
		FLiveLinkAnimationFrameData_IsValid = intPtr != IntPtr.Zero && Transforms_IsValid && MetaData_IsValid && PropertyValues_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkAnimationFrameData", FLiveLinkAnimationFrameData_IsValid);
	}
}
