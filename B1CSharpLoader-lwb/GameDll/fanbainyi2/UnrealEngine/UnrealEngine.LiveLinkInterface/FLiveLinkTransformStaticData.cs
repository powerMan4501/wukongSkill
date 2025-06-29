using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformStaticData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkTransformStaticData
{
	private static bool PropertyNames_IsValid;

	private static FFieldAddress PropertyNames_PropertyAddress;

	private static int PropertyNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseStaticData:PropertyNames")]
	public List<FName> PropertyNames;

	private static bool IsLocationSupported_IsValid;

	private static FFieldAddress IsLocationSupported_PropertyAddress;

	private static int IsLocationSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformStaticData:bIsLocationSupported")]
	public bool IsLocationSupported;

	private static bool IsRotationSupported_IsValid;

	private static FFieldAddress IsRotationSupported_PropertyAddress;

	private static int IsRotationSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformStaticData:bIsRotationSupported")]
	public bool IsRotationSupported;

	private static bool IsScaleSupported_IsValid;

	private static FFieldAddress IsScaleSupported_PropertyAddress;

	private static int IsScaleSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformStaticData:bIsScaleSupported")]
	public bool IsScaleSupported;

	private static bool FLiveLinkTransformStaticData_IsValid;

	private static int FLiveLinkTransformStaticData_StructSize;

	public FLiveLinkTransformStaticData Copy()
	{
		FLiveLinkTransformStaticData result = this;
		if (PropertyNames != null)
		{
			result.PropertyNames = new List<FName>(PropertyNames);
		}
		return result;
	}

	public static FLiveLinkTransformStaticData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkTransformStaticData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkTransformStaticData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkTransformStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkTransformStaticData(nativeBuffer + arrayIndex * FLiveLinkTransformStaticData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkTransformStaticData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkTransformStaticData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransformStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransformStaticData");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLocationSupported_Offset), 0, IsLocationSupported_PropertyAddress.Address, IsLocationSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRotationSupported_Offset), 0, IsRotationSupported_PropertyAddress.Address, IsRotationSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsScaleSupported_Offset), 0, IsScaleSupported_PropertyAddress.Address, IsScaleSupported);
		new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyNames_Offset), PropertyNames);
	}

	public FLiveLinkTransformStaticData(IntPtr nativeStruct)
	{
		if (!FLiveLinkTransformStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkTransformStaticData");
			IsLocationSupported = false;
			IsRotationSupported = false;
			IsScaleSupported = false;
			PropertyNames = null;
		}
		else
		{
			IsLocationSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLocationSupported_Offset), 0, IsLocationSupported_PropertyAddress.Address);
			IsRotationSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRotationSupported_Offset), 0, IsRotationSupported_PropertyAddress.Address);
			IsScaleSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsScaleSupported_Offset), 0, IsScaleSupported_PropertyAddress.Address);
			PropertyNames = new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyNames_Offset));
		}
	}

	static FLiveLinkTransformStaticData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkTransformStaticData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkTransformStaticData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkTransformStaticData");
		FLiveLinkTransformStaticData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PropertyNames_PropertyAddress, intPtr, "PropertyNames");
		PropertyNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyNames");
		PropertyNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLocationSupported_PropertyAddress, intPtr, "bIsLocationSupported");
		IsLocationSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLocationSupported");
		IsLocationSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLocationSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRotationSupported_PropertyAddress, intPtr, "bIsRotationSupported");
		IsRotationSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsRotationSupported");
		IsRotationSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsRotationSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsScaleSupported_PropertyAddress, intPtr, "bIsScaleSupported");
		IsScaleSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsScaleSupported");
		IsScaleSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsScaleSupported", Classes.FBoolProperty);
		FLiveLinkTransformStaticData_IsValid = intPtr != IntPtr.Zero && IsLocationSupported_IsValid && IsRotationSupported_IsValid && IsScaleSupported_IsValid && PropertyNames_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkTransformStaticData", FLiveLinkTransformStaticData_IsValid);
	}
}
