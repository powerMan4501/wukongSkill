using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkCameraStaticData
{
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

	private static bool PropertyNames_IsValid;

	private static FFieldAddress PropertyNames_PropertyAddress;

	private static int PropertyNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkBaseStaticData:PropertyNames")]
	public List<FName> PropertyNames;

	private static bool IsFieldOfViewSupported_IsValid;

	private static FFieldAddress IsFieldOfViewSupported_PropertyAddress;

	private static int IsFieldOfViewSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsFieldOfViewSupported")]
	public bool IsFieldOfViewSupported;

	private static bool IsAspectRatioSupported_IsValid;

	private static FFieldAddress IsAspectRatioSupported_PropertyAddress;

	private static int IsAspectRatioSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsAspectRatioSupported")]
	public bool IsAspectRatioSupported;

	private static bool IsFocalLengthSupported_IsValid;

	private static FFieldAddress IsFocalLengthSupported_PropertyAddress;

	private static int IsFocalLengthSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsFocalLengthSupported")]
	public bool IsFocalLengthSupported;

	private static bool IsProjectionModeSupported_IsValid;

	private static FFieldAddress IsProjectionModeSupported_PropertyAddress;

	private static int IsProjectionModeSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsProjectionModeSupported")]
	public bool IsProjectionModeSupported;

	private static bool FilmBackWidth_IsValid;

	private static int FilmBackWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:FilmBackWidth")]
	public float FilmBackWidth;

	private static bool FilmBackHeight_IsValid;

	private static int FilmBackHeight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:FilmBackHeight")]
	public float FilmBackHeight;

	private static bool IsApertureSupported_IsValid;

	private static FFieldAddress IsApertureSupported_PropertyAddress;

	private static int IsApertureSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsApertureSupported")]
	public bool IsApertureSupported;

	private static bool IsFocusDistanceSupported_IsValid;

	private static FFieldAddress IsFocusDistanceSupported_PropertyAddress;

	private static int IsFocusDistanceSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraStaticData:bIsFocusDistanceSupported")]
	public bool IsFocusDistanceSupported;

	private static bool FLiveLinkCameraStaticData_IsValid;

	private static int FLiveLinkCameraStaticData_StructSize;

	public FLiveLinkCameraStaticData Copy()
	{
		FLiveLinkCameraStaticData result = this;
		if (PropertyNames != null)
		{
			result.PropertyNames = new List<FName>(PropertyNames);
		}
		return result;
	}

	public static FLiveLinkCameraStaticData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkCameraStaticData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkCameraStaticData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkCameraStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkCameraStaticData(nativeBuffer + arrayIndex * FLiveLinkCameraStaticData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkCameraStaticData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkCameraStaticData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkCameraStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCameraStaticData");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsFieldOfViewSupported_Offset), 0, IsFieldOfViewSupported_PropertyAddress.Address, IsFieldOfViewSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsAspectRatioSupported_Offset), 0, IsAspectRatioSupported_PropertyAddress.Address, IsAspectRatioSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsFocalLengthSupported_Offset), 0, IsFocalLengthSupported_PropertyAddress.Address, IsFocalLengthSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsProjectionModeSupported_Offset), 0, IsProjectionModeSupported_PropertyAddress.Address, IsProjectionModeSupported);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilmBackWidth_Offset), FilmBackWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FilmBackHeight_Offset), FilmBackHeight);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsApertureSupported_Offset), 0, IsApertureSupported_PropertyAddress.Address, IsApertureSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsFocusDistanceSupported_Offset), 0, IsFocusDistanceSupported_PropertyAddress.Address, IsFocusDistanceSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLocationSupported_Offset), 0, IsLocationSupported_PropertyAddress.Address, IsLocationSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRotationSupported_Offset), 0, IsRotationSupported_PropertyAddress.Address, IsRotationSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsScaleSupported_Offset), 0, IsScaleSupported_PropertyAddress.Address, IsScaleSupported);
		new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyNames_Offset), PropertyNames);
	}

	public FLiveLinkCameraStaticData(IntPtr nativeStruct)
	{
		if (!FLiveLinkCameraStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCameraStaticData");
			IsFieldOfViewSupported = false;
			IsAspectRatioSupported = false;
			IsFocalLengthSupported = false;
			IsProjectionModeSupported = false;
			FilmBackWidth = 0f;
			FilmBackHeight = 0f;
			IsApertureSupported = false;
			IsFocusDistanceSupported = false;
			IsLocationSupported = false;
			IsRotationSupported = false;
			IsScaleSupported = false;
			PropertyNames = null;
		}
		else
		{
			IsFieldOfViewSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsFieldOfViewSupported_Offset), 0, IsFieldOfViewSupported_PropertyAddress.Address);
			IsAspectRatioSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsAspectRatioSupported_Offset), 0, IsAspectRatioSupported_PropertyAddress.Address);
			IsFocalLengthSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsFocalLengthSupported_Offset), 0, IsFocalLengthSupported_PropertyAddress.Address);
			IsProjectionModeSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsProjectionModeSupported_Offset), 0, IsProjectionModeSupported_PropertyAddress.Address);
			FilmBackWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilmBackWidth_Offset));
			FilmBackHeight = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FilmBackHeight_Offset));
			IsApertureSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsApertureSupported_Offset), 0, IsApertureSupported_PropertyAddress.Address);
			IsFocusDistanceSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsFocusDistanceSupported_Offset), 0, IsFocusDistanceSupported_PropertyAddress.Address);
			IsLocationSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLocationSupported_Offset), 0, IsLocationSupported_PropertyAddress.Address);
			IsRotationSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRotationSupported_Offset), 0, IsRotationSupported_PropertyAddress.Address);
			IsScaleSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsScaleSupported_Offset), 0, IsScaleSupported_PropertyAddress.Address);
			PropertyNames = new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyNames_Offset));
		}
	}

	static FLiveLinkCameraStaticData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkCameraStaticData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkCameraStaticData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkCameraStaticData");
		FLiveLinkCameraStaticData_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref IsLocationSupported_PropertyAddress, intPtr, "bIsLocationSupported");
		IsLocationSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLocationSupported");
		IsLocationSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLocationSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsRotationSupported_PropertyAddress, intPtr, "bIsRotationSupported");
		IsRotationSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsRotationSupported");
		IsRotationSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsRotationSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsScaleSupported_PropertyAddress, intPtr, "bIsScaleSupported");
		IsScaleSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsScaleSupported");
		IsScaleSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsScaleSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyNames_PropertyAddress, intPtr, "PropertyNames");
		PropertyNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyNames");
		PropertyNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFieldOfViewSupported_PropertyAddress, intPtr, "bIsFieldOfViewSupported");
		IsFieldOfViewSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsFieldOfViewSupported");
		IsFieldOfViewSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsFieldOfViewSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAspectRatioSupported_PropertyAddress, intPtr, "bIsAspectRatioSupported");
		IsAspectRatioSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsAspectRatioSupported");
		IsAspectRatioSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsAspectRatioSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocalLengthSupported_PropertyAddress, intPtr, "bIsFocalLengthSupported");
		IsFocalLengthSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsFocalLengthSupported");
		IsFocalLengthSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsFocalLengthSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsProjectionModeSupported_PropertyAddress, intPtr, "bIsProjectionModeSupported");
		IsProjectionModeSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsProjectionModeSupported");
		IsProjectionModeSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsProjectionModeSupported", Classes.FBoolProperty);
		FilmBackWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilmBackWidth");
		FilmBackWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilmBackWidth", Classes.FFloatProperty);
		FilmBackHeight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FilmBackHeight");
		FilmBackHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FilmBackHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsApertureSupported_PropertyAddress, intPtr, "bIsApertureSupported");
		IsApertureSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsApertureSupported");
		IsApertureSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsApertureSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsFocusDistanceSupported_PropertyAddress, intPtr, "bIsFocusDistanceSupported");
		IsFocusDistanceSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsFocusDistanceSupported");
		IsFocusDistanceSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsFocusDistanceSupported", Classes.FBoolProperty);
		FLiveLinkCameraStaticData_IsValid = intPtr != IntPtr.Zero && IsFieldOfViewSupported_IsValid && IsAspectRatioSupported_IsValid && IsFocalLengthSupported_IsValid && IsProjectionModeSupported_IsValid && FilmBackWidth_IsValid && FilmBackHeight_IsValid && IsApertureSupported_IsValid && IsFocusDistanceSupported_IsValid && IsLocationSupported_IsValid && IsRotationSupported_IsValid && IsScaleSupported_IsValid && PropertyNames_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkCameraStaticData", FLiveLinkCameraStaticData_IsValid);
	}
}
