using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.LiveLinkInterface;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData", "LiveLinkInterface", UnrealModuleType.Engine)]
public struct FLiveLinkLightFrameData
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

	private static bool Temperature_IsValid;

	private static int Temperature_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:Temperature")]
	public float Temperature;

	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:Intensity")]
	public float Intensity;

	private static bool LightColor_IsValid;

	private static int LightColor_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:LightColor")]
	public FColor LightColor;

	private static bool InnerConeAngle_IsValid;

	private static int InnerConeAngle_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:InnerConeAngle")]
	public float InnerConeAngle;

	private static bool OuterConeAngle_IsValid;

	private static int OuterConeAngle_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:OuterConeAngle")]
	public float OuterConeAngle;

	private static bool AttenuationRadius_IsValid;

	private static int AttenuationRadius_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:AttenuationRadius")]
	public float AttenuationRadius;

	private static bool SourceRadius_IsValid;

	private static int SourceRadius_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:SourceRadius")]
	public float SourceRadius;

	private static bool SoftSourceRadius_IsValid;

	private static int SoftSourceRadius_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:SoftSourceRadius")]
	public float SoftSourceRadius;

	private static bool SourceLength_IsValid;

	private static int SourceLength_Offset;

	[UProperty(Flags = (PropFlags)6755477824209413uL)]
	[UMetaPath("/Script/LiveLinkInterface.LiveLinkLightFrameData:SourceLength")]
	public float SourceLength;

	private static bool FLiveLinkLightFrameData_IsValid;

	private static int FLiveLinkLightFrameData_StructSize;

	public FLiveLinkLightFrameData Copy()
	{
		FLiveLinkLightFrameData result = this;
		if (PropertyValues != null)
		{
			result.PropertyValues = new List<float>(PropertyValues);
		}
		return result;
	}

	public static FLiveLinkLightFrameData FromNative(IntPtr nativeBuffer)
	{
		return new FLiveLinkLightFrameData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLiveLinkLightFrameData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLiveLinkLightFrameData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLiveLinkLightFrameData(nativeBuffer + arrayIndex * FLiveLinkLightFrameData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLiveLinkLightFrameData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLiveLinkLightFrameData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLiveLinkLightFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkLightFrameData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Temperature_Offset), Temperature);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Intensity_Offset), Intensity);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, LightColor_Offset), LightColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InnerConeAngle_Offset), InnerConeAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OuterConeAngle_Offset), OuterConeAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttenuationRadius_Offset), AttenuationRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SourceRadius_Offset), SourceRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SoftSourceRadius_Offset), SoftSourceRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SourceLength_Offset), SourceLength);
		BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(nativeStruct, Transform_Offset), Transform);
		FLiveLinkMetaData.ToNative(IntPtr.Add(nativeStruct, MetaData_Offset), MetaData);
		new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PropertyValues_Offset), PropertyValues);
	}

	public FLiveLinkLightFrameData(IntPtr nativeStruct)
	{
		if (!FLiveLinkLightFrameData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LiveLinkInterface.LiveLinkLightFrameData");
			Temperature = 0f;
			Intensity = 0f;
			LightColor = default(FColor);
			InnerConeAngle = 0f;
			OuterConeAngle = 0f;
			AttenuationRadius = 0f;
			SourceRadius = 0f;
			SoftSourceRadius = 0f;
			SourceLength = 0f;
			Transform = default(FTransform);
			MetaData = default(FLiveLinkMetaData);
			PropertyValues = null;
		}
		else
		{
			Temperature = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Temperature_Offset));
			Intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Intensity_Offset));
			LightColor = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, LightColor_Offset));
			InnerConeAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InnerConeAngle_Offset));
			OuterConeAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OuterConeAngle_Offset));
			AttenuationRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttenuationRadius_Offset));
			SourceRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SourceRadius_Offset));
			SoftSourceRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SoftSourceRadius_Offset));
			SourceLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SourceLength_Offset));
			Transform = BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(nativeStruct, Transform_Offset));
			MetaData = FLiveLinkMetaData.FromNative(IntPtr.Add(nativeStruct, MetaData_Offset));
			PropertyValues = new TArrayCopyMarshaler<float>(1, PropertyValues_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PropertyValues_Offset));
		}
	}

	static FLiveLinkLightFrameData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLiveLinkLightFrameData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLiveLinkLightFrameData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LiveLinkInterface.LiveLinkLightFrameData");
		FLiveLinkLightFrameData_StructSize = NativeReflection.GetStructSize(intPtr);
		Transform_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Transform");
		Transform_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Transform", Classes.FStructProperty);
		MetaData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MetaData");
		MetaData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MetaData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PropertyValues_PropertyAddress, intPtr, "PropertyValues");
		PropertyValues_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PropertyValues");
		PropertyValues_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PropertyValues", Classes.FArrayProperty);
		Temperature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Temperature");
		Temperature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Temperature", Classes.FFloatProperty);
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		LightColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LightColor");
		LightColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LightColor", Classes.FStructProperty);
		InnerConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerConeAngle");
		InnerConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerConeAngle", Classes.FFloatProperty);
		OuterConeAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OuterConeAngle");
		OuterConeAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OuterConeAngle", Classes.FFloatProperty);
		AttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationRadius");
		AttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationRadius", Classes.FFloatProperty);
		SourceRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceRadius");
		SourceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceRadius", Classes.FFloatProperty);
		SoftSourceRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoftSourceRadius");
		SoftSourceRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoftSourceRadius", Classes.FFloatProperty);
		SourceLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceLength");
		SourceLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceLength", Classes.FFloatProperty);
		FLiveLinkLightFrameData_IsValid = intPtr != IntPtr.Zero && Temperature_IsValid && Intensity_IsValid && LightColor_IsValid && InnerConeAngle_IsValid && OuterConeAngle_IsValid && AttenuationRadius_IsValid && SourceRadius_IsValid && SoftSourceRadius_IsValid && SourceLength_IsValid && Transform_IsValid && MetaData_IsValid && PropertyValues_IsValid;
		NativeReflection.LogStructIsValid("/Script/LiveLinkInterface.LiveLinkLightFrameData", FLiveLinkLightFrameData_IsValid);
	}
}
