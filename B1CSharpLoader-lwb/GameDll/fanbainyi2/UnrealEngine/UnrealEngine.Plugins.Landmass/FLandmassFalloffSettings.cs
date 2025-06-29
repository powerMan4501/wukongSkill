using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.LandmassFalloffSettings", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FLandmassFalloffSettings
{
	private static bool FalloffMode_IsValid;

	private static FFieldAddress FalloffMode_PropertyAddress;

	private static int FalloffMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassFalloffSettings:FalloffMode")]
	public EBrushFalloffMode FalloffMode;

	private static bool FalloffAngle_IsValid;

	private static int FalloffAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassFalloffSettings:FalloffAngle")]
	public float FalloffAngle;

	private static bool FalloffWidth_IsValid;

	private static int FalloffWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassFalloffSettings:FalloffWidth")]
	public float FalloffWidth;

	private static bool EdgeOffset_IsValid;

	private static int EdgeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassFalloffSettings:EdgeOffset")]
	public float EdgeOffset;

	private static bool ZOffset_IsValid;

	private static int ZOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.LandmassFalloffSettings:ZOffset")]
	public float ZOffset;

	private static bool FLandmassFalloffSettings_IsValid;

	private static int FLandmassFalloffSettings_StructSize;

	public FLandmassFalloffSettings Copy()
	{
		return this;
	}

	public static FLandmassFalloffSettings FromNative(IntPtr nativeBuffer)
	{
		return new FLandmassFalloffSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLandmassFalloffSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLandmassFalloffSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLandmassFalloffSettings(nativeBuffer + arrayIndex * FLandmassFalloffSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLandmassFalloffSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLandmassFalloffSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLandmassFalloffSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.LandmassFalloffSettings");
			return;
		}
		EnumMarshaler<EBrushFalloffMode>.ToNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address, FalloffMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FalloffAngle_Offset), FalloffAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FalloffWidth_Offset), FalloffWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EdgeOffset_Offset), EdgeOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZOffset_Offset), ZOffset);
	}

	public FLandmassFalloffSettings(IntPtr nativeStruct)
	{
		if (!FLandmassFalloffSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.LandmassFalloffSettings");
			FalloffMode = EBrushFalloffMode.Angle;
			FalloffAngle = 0f;
			FalloffWidth = 0f;
			EdgeOffset = 0f;
			ZOffset = 0f;
		}
		else
		{
			FalloffMode = EnumMarshaler<EBrushFalloffMode>.FromNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address);
			FalloffAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FalloffAngle_Offset));
			FalloffWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FalloffWidth_Offset));
			EdgeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EdgeOffset_Offset));
			ZOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZOffset_Offset));
		}
	}

	static FLandmassFalloffSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLandmassFalloffSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLandmassFalloffSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.LandmassFalloffSettings");
		FLandmassFalloffSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref FalloffMode_PropertyAddress, intPtr, "FalloffMode");
		FalloffMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffMode");
		FalloffMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffMode", Classes.FEnumProperty);
		FalloffAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffAngle");
		FalloffAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffAngle", Classes.FFloatProperty);
		FalloffWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffWidth");
		FalloffWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffWidth", Classes.FFloatProperty);
		EdgeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EdgeOffset");
		EdgeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EdgeOffset", Classes.FFloatProperty);
		ZOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ZOffset");
		ZOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ZOffset", Classes.FFloatProperty);
		FLandmassFalloffSettings_IsValid = intPtr != IntPtr.Zero && FalloffMode_IsValid && FalloffAngle_IsValid && FalloffWidth_IsValid && EdgeOffset_IsValid && ZOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.LandmassFalloffSettings", FLandmassFalloffSettings_IsValid);
	}
}
