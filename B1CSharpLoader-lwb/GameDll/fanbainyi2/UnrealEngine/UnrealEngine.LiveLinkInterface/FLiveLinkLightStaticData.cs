using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkLightStaticData
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

	private static bool IsTemperatureSupported_IsValid;

	private static FFieldAddress IsTemperatureSupported_PropertyAddress;

	private static int IsTemperatureSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsTemperatureSupported")]
	public bool IsTemperatureSupported;

	private static bool IsIntensitySupported_IsValid;

	private static FFieldAddress IsIntensitySupported_PropertyAddress;

	private static int IsIntensitySupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsIntensitySupported")]
	public bool IsIntensitySupported;

	private static bool IsLightColorSupported_IsValid;

	private static FFieldAddress IsLightColorSupported_PropertyAddress;

	private static int IsLightColorSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsLightColorSupported")]
	public bool IsLightColorSupported;

	private static bool IsInnerConeAngleSupported_IsValid;

	private static FFieldAddress IsInnerConeAngleSupported_PropertyAddress;

	private static int IsInnerConeAngleSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsInnerConeAngleSupported")]
	public bool IsInnerConeAngleSupported;

	private static bool IsOuterConeAngleSupported_IsValid;

	private static FFieldAddress IsOuterConeAngleSupported_PropertyAddress;

	private static int IsOuterConeAngleSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsOuterConeAngleSupported")]
	public bool IsOuterConeAngleSupported;

	private static bool IsAttenuationRadiusSupported_IsValid;

	private static FFieldAddress IsAttenuationRadiusSupported_PropertyAddress;

	private static int IsAttenuationRadiusSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsAttenuationRadiusSupported")]
	public bool IsAttenuationRadiusSupported;

	private static bool IsSourceLenghtSupported_IsValid;

	private static FFieldAddress IsSourceLenghtSupported_PropertyAddress;

	private static int IsSourceLenghtSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsSourceLenghtSupported")]
	public bool IsSourceLenghtSupported;

	private static bool IsSourceRadiusSupported_IsValid;

	private static FFieldAddress IsSourceRadiusSupported_PropertyAddress;

	private static int IsSourceRadiusSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsSourceRadiusSupported")]
	public bool IsSourceRadiusSupported;

	private static bool IsSoftSourceRadiusSupported_IsValid;

	private static FFieldAddress IsSoftSourceRadiusSupported_PropertyAddress;

	private static int IsSoftSourceRadiusSupported_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightStaticData:bIsSoftSourceRadiusSupported")]
	public bool IsSoftSourceRadiusSupported;

	private static bool FLiveLinkLightStaticData_IsValid;

	private static int FLiveLinkLightStaticData_StructSize;

	public FLiveLinkLightStaticData Copy()
	{
		FLiveLinkLightStaticData result = this;
		if (PropertyNames != null)
		{
			result.PropertyNames = new List<FName>(PropertyNames);
		}
		return result;
	}

	public static FLiveLinkLightStaticData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkLightStaticData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkLightStaticData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkLightStaticData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkLightStaticData(nativeBuffer + arrayIndex * FLiveLinkLightStaticData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkLightStaticData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkLightStaticData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkLightStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkLightStaticData");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsTemperatureSupported_Offset), 0, IsTemperatureSupported_PropertyAddress.Address, IsTemperatureSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsIntensitySupported_Offset), 0, IsIntensitySupported_PropertyAddress.Address, IsIntensitySupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLightColorSupported_Offset), 0, IsLightColorSupported_PropertyAddress.Address, IsLightColorSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsInnerConeAngleSupported_Offset), 0, IsInnerConeAngleSupported_PropertyAddress.Address, IsInnerConeAngleSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsOuterConeAngleSupported_Offset), 0, IsOuterConeAngleSupported_PropertyAddress.Address, IsOuterConeAngleSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsAttenuationRadiusSupported_Offset), 0, IsAttenuationRadiusSupported_PropertyAddress.Address, IsAttenuationRadiusSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSourceLenghtSupported_Offset), 0, IsSourceLenghtSupported_PropertyAddress.Address, IsSourceLenghtSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSourceRadiusSupported_Offset), 0, IsSourceRadiusSupported_PropertyAddress.Address, IsSourceRadiusSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSoftSourceRadiusSupported_Offset), 0, IsSoftSourceRadiusSupported_PropertyAddress.Address, IsSoftSourceRadiusSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsLocationSupported_Offset), 0, IsLocationSupported_PropertyAddress.Address, IsLocationSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsRotationSupported_Offset), 0, IsRotationSupported_PropertyAddress.Address, IsRotationSupported);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsScaleSupported_Offset), 0, IsScaleSupported_PropertyAddress.Address, IsScaleSupported);
		new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyNames_Offset), PropertyNames);
	}

	public FLiveLinkLightStaticData(IntPtr nativeStruct)
	{
		if (!FLiveLinkLightStaticData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkLightStaticData");
			IsTemperatureSupported = false;
			IsIntensitySupported = false;
			IsLightColorSupported = false;
			IsInnerConeAngleSupported = false;
			IsOuterConeAngleSupported = false;
			IsAttenuationRadiusSupported = false;
			IsSourceLenghtSupported = false;
			IsSourceRadiusSupported = false;
			IsSoftSourceRadiusSupported = false;
			IsLocationSupported = false;
			IsRotationSupported = false;
			IsScaleSupported = false;
			PropertyNames = null;
		}
		else
		{
			IsTemperatureSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsTemperatureSupported_Offset), 0, IsTemperatureSupported_PropertyAddress.Address);
			IsIntensitySupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsIntensitySupported_Offset), 0, IsIntensitySupported_PropertyAddress.Address);
			IsLightColorSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLightColorSupported_Offset), 0, IsLightColorSupported_PropertyAddress.Address);
			IsInnerConeAngleSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsInnerConeAngleSupported_Offset), 0, IsInnerConeAngleSupported_PropertyAddress.Address);
			IsOuterConeAngleSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsOuterConeAngleSupported_Offset), 0, IsOuterConeAngleSupported_PropertyAddress.Address);
			IsAttenuationRadiusSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsAttenuationRadiusSupported_Offset), 0, IsAttenuationRadiusSupported_PropertyAddress.Address);
			IsSourceLenghtSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSourceLenghtSupported_Offset), 0, IsSourceLenghtSupported_PropertyAddress.Address);
			IsSourceRadiusSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSourceRadiusSupported_Offset), 0, IsSourceRadiusSupported_PropertyAddress.Address);
			IsSoftSourceRadiusSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSoftSourceRadiusSupported_Offset), 0, IsSoftSourceRadiusSupported_PropertyAddress.Address);
			IsLocationSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsLocationSupported_Offset), 0, IsLocationSupported_PropertyAddress.Address);
			IsRotationSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsRotationSupported_Offset), 0, IsRotationSupported_PropertyAddress.Address);
			IsScaleSupported = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsScaleSupported_Offset), 0, IsScaleSupported_PropertyAddress.Address);
			PropertyNames = new TArrayCopyMarshaler<FName>(1, PropertyNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyNames_Offset));
		}
	}

	static FLiveLinkLightStaticData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkLightStaticData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkLightStaticData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkLightStaticData");
		FLiveLinkLightStaticData_StructSize = NativeReflection.GetStructSize(intPtr);
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
		NativeReflectionCached.GetPropertyRef(ref IsTemperatureSupported_PropertyAddress, intPtr, "bIsTemperatureSupported");
		IsTemperatureSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsTemperatureSupported");
		IsTemperatureSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsTemperatureSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsIntensitySupported_PropertyAddress, intPtr, "bIsIntensitySupported");
		IsIntensitySupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsIntensitySupported");
		IsIntensitySupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsIntensitySupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLightColorSupported_PropertyAddress, intPtr, "bIsLightColorSupported");
		IsLightColorSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsLightColorSupported");
		IsLightColorSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsLightColorSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsInnerConeAngleSupported_PropertyAddress, intPtr, "bIsInnerConeAngleSupported");
		IsInnerConeAngleSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsInnerConeAngleSupported");
		IsInnerConeAngleSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsInnerConeAngleSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsOuterConeAngleSupported_PropertyAddress, intPtr, "bIsOuterConeAngleSupported");
		IsOuterConeAngleSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsOuterConeAngleSupported");
		IsOuterConeAngleSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsOuterConeAngleSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsAttenuationRadiusSupported_PropertyAddress, intPtr, "bIsAttenuationRadiusSupported");
		IsAttenuationRadiusSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsAttenuationRadiusSupported");
		IsAttenuationRadiusSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsAttenuationRadiusSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSourceLenghtSupported_PropertyAddress, intPtr, "bIsSourceLenghtSupported");
		IsSourceLenghtSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSourceLenghtSupported");
		IsSourceLenghtSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSourceLenghtSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSourceRadiusSupported_PropertyAddress, intPtr, "bIsSourceRadiusSupported");
		IsSourceRadiusSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSourceRadiusSupported");
		IsSourceRadiusSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSourceRadiusSupported", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSoftSourceRadiusSupported_PropertyAddress, intPtr, "bIsSoftSourceRadiusSupported");
		IsSoftSourceRadiusSupported_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSoftSourceRadiusSupported");
		IsSoftSourceRadiusSupported_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSoftSourceRadiusSupported", Classes.FBoolProperty);
		FLiveLinkLightStaticData_IsValid = intPtr != IntPtr.Zero && IsTemperatureSupported_IsValid && IsIntensitySupported_IsValid && IsLightColorSupported_IsValid && IsInnerConeAngleSupported_IsValid && IsOuterConeAngleSupported_IsValid && IsAttenuationRadiusSupported_IsValid && IsSourceLenghtSupported_IsValid && IsSourceRadiusSupported_IsValid && IsSoftSourceRadiusSupported_IsValid && IsLocationSupported_IsValid && IsRotationSupported_IsValid && IsScaleSupported_IsValid && PropertyNames_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkLightStaticData", FLiveLinkLightStaticData_IsValid);
	}
}
