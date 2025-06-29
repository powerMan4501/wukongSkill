using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.HairGeometrySettings", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FHairGeometrySettings
{
	private static bool HairWidth_IsValid;

	private static int HairWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGeometrySettings:HairWidth")]
	public float HairWidth;

	private static bool HairRootScale_IsValid;

	private static int HairRootScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGeometrySettings:HairRootScale")]
	public float HairRootScale;

	private static bool HairTipScale_IsValid;

	private static int HairTipScale_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/HairStrandsCore.HairGeometrySettings:HairTipScale")]
	public float HairTipScale;

	private static bool FHairGeometrySettings_IsValid;

	private static int FHairGeometrySettings_StructSize;

	public FHairGeometrySettings Copy()
	{
		return this;
	}

	public static FHairGeometrySettings FromNative(IntPtr nativeBuffer)
	{
		return new FHairGeometrySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHairGeometrySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHairGeometrySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHairGeometrySettings(nativeBuffer + arrayIndex * FHairGeometrySettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHairGeometrySettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FHairGeometrySettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FHairGeometrySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGeometrySettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairWidth_Offset), HairWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairRootScale_Offset), HairRootScale);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairTipScale_Offset), HairTipScale);
	}

	public FHairGeometrySettings(IntPtr nativeStruct)
	{
		if (!FHairGeometrySettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.HairGeometrySettings");
			HairWidth = 0f;
			HairRootScale = 0f;
			HairTipScale = 0f;
		}
		else
		{
			HairWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairWidth_Offset));
			HairRootScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairRootScale_Offset));
			HairTipScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairTipScale_Offset));
		}
	}

	static FHairGeometrySettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FHairGeometrySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHairGeometrySettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.HairGeometrySettings");
		FHairGeometrySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		HairWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairWidth");
		HairWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairWidth", Classes.FFloatProperty);
		HairRootScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairRootScale");
		HairRootScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairRootScale", Classes.FFloatProperty);
		HairTipScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairTipScale");
		HairTipScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairTipScale", Classes.FFloatProperty);
		FHairGeometrySettings_IsValid = intPtr != IntPtr.Zero && HairWidth_IsValid && HairRootScale_IsValid && HairTipScale_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.HairGeometrySettings", FHairGeometrySettings_IsValid);
	}
}
