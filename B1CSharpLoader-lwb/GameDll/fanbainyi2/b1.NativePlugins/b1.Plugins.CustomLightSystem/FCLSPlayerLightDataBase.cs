using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.CustomLightSystem;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase", "CustomLightSystem", UnrealModuleType.GamePlugin)]
public struct FCLSPlayerLightDataBase
{
	private static bool Intensity_IsValid;

	private static int Intensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:Intensity")]
	public float Intensity;

	private static bool Color_IsValid;

	private static int Color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:Color")]
	public FColor Color;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:Radius")]
	public float Radius;

	private static bool AttenuationRadius_IsValid;

	private static int AttenuationRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:AttenuationRadius")]
	public float AttenuationRadius;

	private static bool CastShadows_IsValid;

	private static FFieldAddress CastShadows_PropertyAddress;

	private static int CastShadows_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:bCastShadows")]
	public bool CastShadows;

	private static bool CastShadowMapShadow_IsValid;

	private static FFieldAddress CastShadowMapShadow_PropertyAddress;

	private static int CastShadowMapShadow_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:CastShadowMapShadow")]
	public bool CastShadowMapShadow;

	private static bool ContactShadowLength_IsValid;

	private static int ContactShadowLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:ContactShadowLength")]
	public float ContactShadowLength;

	private static bool UseTemperature_IsValid;

	private static FFieldAddress UseTemperature_PropertyAddress;

	private static int UseTemperature_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:bUseTemperature")]
	public bool UseTemperature;

	private static bool Temperature_IsValid;

	private static int Temperature_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:Temperature")]
	public float Temperature;

	private static bool VolumetricScatteringIntensity_IsValid;

	private static int VolumetricScatteringIntensity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:VolumetricScatteringIntensity")]
	public float VolumetricScatteringIntensity;

	private static bool SpecularScale_IsValid;

	private static int SpecularScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/CustomLightSystem.CLSPlayerLightDataBase:SpecularScale")]
	public float SpecularScale;

	private static bool FCLSPlayerLightDataBase_IsValid;

	private static int FCLSPlayerLightDataBase_StructSize;

	public FCLSPlayerLightDataBase Copy()
	{
		return this;
	}

	public static FCLSPlayerLightDataBase FromNative(IntPtr nativeBuffer)
	{
		return new FCLSPlayerLightDataBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCLSPlayerLightDataBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCLSPlayerLightDataBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCLSPlayerLightDataBase(nativeBuffer + arrayIndex * FCLSPlayerLightDataBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCLSPlayerLightDataBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCLSPlayerLightDataBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightDataBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightDataBase");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Intensity_Offset), Intensity);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, Color_Offset), Color);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, AttenuationRadius_Offset), AttenuationRadius);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CastShadows_Offset), 0, CastShadows_PropertyAddress.Address, CastShadows);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CastShadowMapShadow_Offset), 0, CastShadowMapShadow_PropertyAddress.Address, CastShadowMapShadow);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ContactShadowLength_Offset), ContactShadowLength);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseTemperature_Offset), 0, UseTemperature_PropertyAddress.Address, UseTemperature);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Temperature_Offset), Temperature);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, VolumetricScatteringIntensity_Offset), VolumetricScatteringIntensity);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpecularScale_Offset), SpecularScale);
	}

	public FCLSPlayerLightDataBase(IntPtr nativeStruct)
	{
		if (!FCLSPlayerLightDataBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/CustomLightSystem.CLSPlayerLightDataBase");
			Intensity = 0f;
			Color = default(FColor);
			Radius = 0f;
			AttenuationRadius = 0f;
			CastShadows = false;
			CastShadowMapShadow = false;
			ContactShadowLength = 0f;
			UseTemperature = false;
			Temperature = 0f;
			VolumetricScatteringIntensity = 0f;
			SpecularScale = 0f;
		}
		else
		{
			Intensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Intensity_Offset));
			Color = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, Color_Offset));
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			AttenuationRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, AttenuationRadius_Offset));
			CastShadows = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CastShadows_Offset), 0, CastShadows_PropertyAddress.Address);
			CastShadowMapShadow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CastShadowMapShadow_Offset), 0, CastShadowMapShadow_PropertyAddress.Address);
			ContactShadowLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ContactShadowLength_Offset));
			UseTemperature = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseTemperature_Offset), 0, UseTemperature_PropertyAddress.Address);
			Temperature = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Temperature_Offset));
			VolumetricScatteringIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, VolumetricScatteringIntensity_Offset));
			SpecularScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpecularScale_Offset));
		}
	}

	static FCLSPlayerLightDataBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCLSPlayerLightDataBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCLSPlayerLightDataBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/CustomLightSystem.CLSPlayerLightDataBase");
		FCLSPlayerLightDataBase_StructSize = NativeReflection.GetStructSize(intPtr);
		Intensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Intensity");
		Intensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Intensity", Classes.FFloatProperty);
		Color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Color");
		Color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Color", Classes.FStructProperty);
		Radius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		AttenuationRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AttenuationRadius");
		AttenuationRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AttenuationRadius", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadows_PropertyAddress, intPtr, "bCastShadows");
		CastShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCastShadows");
		CastShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCastShadows", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CastShadowMapShadow_PropertyAddress, intPtr, "CastShadowMapShadow");
		CastShadowMapShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CastShadowMapShadow");
		CastShadowMapShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CastShadowMapShadow", Classes.FBoolProperty);
		ContactShadowLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ContactShadowLength");
		ContactShadowLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ContactShadowLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref UseTemperature_PropertyAddress, intPtr, "bUseTemperature");
		UseTemperature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseTemperature");
		UseTemperature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseTemperature", Classes.FBoolProperty);
		Temperature_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Temperature");
		Temperature_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Temperature", Classes.FFloatProperty);
		VolumetricScatteringIntensity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VolumetricScatteringIntensity");
		VolumetricScatteringIntensity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VolumetricScatteringIntensity", Classes.FFloatProperty);
		SpecularScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpecularScale");
		SpecularScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpecularScale", Classes.FFloatProperty);
		FCLSPlayerLightDataBase_IsValid = intPtr != IntPtr.Zero && Intensity_IsValid && Color_IsValid && Radius_IsValid && AttenuationRadius_IsValid && CastShadows_IsValid && CastShadowMapShadow_IsValid && ContactShadowLength_IsValid && UseTemperature_IsValid && Temperature_IsValid && VolumetricScatteringIntensity_IsValid && SpecularScale_IsValid;
		NativeReflection.LogStructIsValid("/Script/CustomLightSystem.CLSPlayerLightDataBase", FCLSPlayerLightDataBase_IsValid);
	}
}
