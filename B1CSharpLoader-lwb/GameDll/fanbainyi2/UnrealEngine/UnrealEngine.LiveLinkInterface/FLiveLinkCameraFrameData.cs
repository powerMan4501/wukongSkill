using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkCameraFrameData
{
	private static bool Transform_IsValid;

	private static int Transform_Offset;

	[UProperty(Flags = (PropFlags)4503678010523653uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkTransformFrameData:Transform")]
	public FTransform Transform;

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

	private static bool FieldOfView_IsValid;

	private static int FieldOfView_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData:FieldOfView")]
	public float FieldOfView;

	private static bool AspectRatio_IsValid;

	private static int AspectRatio_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData:AspectRatio")]
	public float AspectRatio;

	private static bool FocalLength_IsValid;

	private static int FocalLength_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData:FocalLength")]
	public float FocalLength;

	private static bool Aperture_IsValid;

	private static int Aperture_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData:Aperture")]
	public float Aperture;

	private static bool FocusDistance_IsValid;

	private static int FocusDistance_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData:FocusDistance")]
	public float FocusDistance;

	private static bool ProjectionMode_IsValid;

	private static FFieldAddress ProjectionMode_PropertyAddress;

	private static int ProjectionMode_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkCameraFrameData:ProjectionMode")]
	public ELiveLinkCameraProjectionMode ProjectionMode;

	private static bool FLiveLinkCameraFrameData_IsValid;

	private static int FLiveLinkCameraFrameData_StructSize;

	public FLiveLinkCameraFrameData Copy()
	{
		FLiveLinkCameraFrameData result = this;
		if (PropertyValues != null)
		{
			result.PropertyValues = new List<float>(PropertyValues);
		}
		return result;
	}

	public static FLiveLinkCameraFrameData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkCameraFrameData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkCameraFrameData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkCameraFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkCameraFrameData(nativeBuffer + arrayIndex * FLiveLinkCameraFrameData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkCameraFrameData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkCameraFrameData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkCameraFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCameraFrameData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FieldOfView_Offset), FieldOfView);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AspectRatio_Offset), AspectRatio);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocalLength_Offset), FocalLength);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Aperture_Offset), Aperture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FocusDistance_Offset), FocusDistance);
		EnumMarshaler<ELiveLinkCameraProjectionMode>.ToNative(IntPtr.Add(nativeStruct, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address, ProjectionMode);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Transform_Offset), Transform);
		FLiveLinkMetaData.ToNative(IntPtr.Add(nativeStruct, MetaData_Offset), MetaData);
		new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyValues_Offset), PropertyValues);
	}

	public FLiveLinkCameraFrameData(IntPtr nativeStruct)
	{
		if (!FLiveLinkCameraFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkCameraFrameData");
			FieldOfView = 0f;
			AspectRatio = 0f;
			FocalLength = 0f;
			Aperture = 0f;
			FocusDistance = 0f;
			ProjectionMode = ELiveLinkCameraProjectionMode.Perspective;
			Transform = default(FTransform);
			MetaData = default(FLiveLinkMetaData);
			PropertyValues = null;
		}
		else
		{
			FieldOfView = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FieldOfView_Offset));
			AspectRatio = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AspectRatio_Offset));
			FocalLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocalLength_Offset));
			Aperture = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Aperture_Offset));
			FocusDistance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FocusDistance_Offset));
			ProjectionMode = EnumMarshaler<ELiveLinkCameraProjectionMode>.FromNative(IntPtr.Add(nativeStruct, ProjectionMode_Offset), 0, ProjectionMode_PropertyAddress.Address);
			Transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Transform_Offset));
			MetaData = FLiveLinkMetaData.FromNative(IntPtr.Add(nativeStruct, MetaData_Offset));
			PropertyValues = new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyValues_Offset));
		}
	}

	static FLiveLinkCameraFrameData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkCameraFrameData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkCameraFrameData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkCameraFrameData");
		FLiveLinkCameraFrameData_StructSize = NativeReflection.GetStructSize(intPtr);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		MetaData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetaData");
		MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetaData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyValues_PropertyAddress, intPtr, "PropertyValues");
		PropertyValues_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyValues");
		PropertyValues_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyValues", Classes.FArrayProperty);
		FieldOfView_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FieldOfView");
		FieldOfView_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FieldOfView", Classes.FFloatProperty);
		AspectRatio_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AspectRatio");
		AspectRatio_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AspectRatio", Classes.FFloatProperty);
		FocalLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocalLength");
		FocalLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocalLength", Classes.FFloatProperty);
		Aperture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Aperture");
		Aperture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Aperture", Classes.FFloatProperty);
		FocusDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FocusDistance");
		FocusDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FocusDistance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ProjectionMode_PropertyAddress, intPtr, "ProjectionMode");
		ProjectionMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectionMode");
		ProjectionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectionMode", Classes.FEnumProperty);
		FLiveLinkCameraFrameData_IsValid = intPtr != IntPtr.Zero && FieldOfView_IsValid && AspectRatio_IsValid && FocalLength_IsValid && Aperture_IsValid && FocusDistance_IsValid && ProjectionMode_IsValid && Transform_IsValid && MetaData_IsValid && PropertyValues_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkCameraFrameData", FLiveLinkCameraFrameData_IsValid);
	}
}
