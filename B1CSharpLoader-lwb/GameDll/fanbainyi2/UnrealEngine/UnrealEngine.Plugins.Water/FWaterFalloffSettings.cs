using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterFalloffSettings", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterFalloffSettings
{
	private static bool FalloffMode_IsValid;

	private static FFieldAddress FalloffMode_PropertyAddress;

	private static int FalloffMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterFalloffSettings:FalloffMode")]
	public EWaterBrushFalloffMode FalloffMode;

	private static bool FalloffAngle_IsValid;

	private static int FalloffAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterFalloffSettings:FalloffAngle")]
	public float FalloffAngle;

	private static bool FalloffWidth_IsValid;

	private static int FalloffWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterFalloffSettings:FalloffWidth")]
	public float FalloffWidth;

	private static bool EdgeOffset_IsValid;

	private static int EdgeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterFalloffSettings:EdgeOffset")]
	public float EdgeOffset;

	private static bool ZOffset_IsValid;

	private static int ZOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterFalloffSettings:ZOffset")]
	public float ZOffset;

	private static bool FWaterFalloffSettings_IsValid;

	private static int FWaterFalloffSettings_StructSize;

	public FWaterFalloffSettings Copy()
	{
		return this;
	}

	public static FWaterFalloffSettings FromNative(IntPtr nativeBuffer)
	{
		return new FWaterFalloffSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterFalloffSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterFalloffSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterFalloffSettings(nativeBuffer + arrayIndex * FWaterFalloffSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterFalloffSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterFalloffSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterFalloffSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterFalloffSettings");
			return;
		}
		EnumMarshaler<EWaterBrushFalloffMode>.ToNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address, FalloffMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FalloffAngle_Offset), FalloffAngle);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FalloffWidth_Offset), FalloffWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EdgeOffset_Offset), EdgeOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ZOffset_Offset), ZOffset);
	}

	public FWaterFalloffSettings(IntPtr nativeStruct)
	{
		if (!FWaterFalloffSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterFalloffSettings");
			FalloffMode = EWaterBrushFalloffMode.Angle;
			FalloffAngle = 0f;
			FalloffWidth = 0f;
			EdgeOffset = 0f;
			ZOffset = 0f;
		}
		else
		{
			FalloffMode = EnumMarshaler<EWaterBrushFalloffMode>.FromNative(IntPtr.Add(nativeStruct, FalloffMode_Offset), 0, FalloffMode_PropertyAddress.Address);
			FalloffAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FalloffAngle_Offset));
			FalloffWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FalloffWidth_Offset));
			EdgeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EdgeOffset_Offset));
			ZOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ZOffset_Offset));
		}
	}

	static FWaterFalloffSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterFalloffSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterFalloffSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterFalloffSettings");
		FWaterFalloffSettings_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FWaterFalloffSettings_IsValid = intPtr != IntPtr.Zero && FalloffMode_IsValid && FalloffAngle_IsValid && FalloffWidth_IsValid && EdgeOffset_IsValid && ZOffset_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterFalloffSettings", FWaterFalloffSettings_IsValid);
	}
}
