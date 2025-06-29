using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig", "UnrealExtent", UnrealModuleType.Game)]
public struct FAutoMovementHeatmapConfig
{
	private static bool HeatmapPlaneOrigin_IsValid;

	private static int HeatmapPlaneOrigin_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig:HeatmapPlaneOrigin")]
	public FVector HeatmapPlaneOrigin;

	private static bool HeatmapPlaneSize_IsValid;

	private static int HeatmapPlaneSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig:HeatmapPlaneSize")]
	public FVector HeatmapPlaneSize;

	private static bool HeatmapTexParentFolder_IsValid;

	private static int HeatmapTexParentFolder_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig:HeatmapTexParentFolder")]
	public string HeatmapTexParentFolder;

	private static bool HeatmapBaseImgPath_IsValid;

	private static int HeatmapBaseImgPath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig:HeatmapBaseImgPath")]
	public string HeatmapBaseImgPath;

	private static bool HeatmapProfilingFilePath_IsValid;

	private static int HeatmapProfilingFilePath_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig:HeatmapProfilingFilePath")]
	public string HeatmapProfilingFilePath;

	private static bool HeatmapIntensityScale_IsValid;

	private static int HeatmapIntensityScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig:HeatmapIntensityScale")]
	public float HeatmapIntensityScale;

	private static bool HeatmapTileCount_IsValid;

	private static int HeatmapTileCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.AutoMovementHeatmapConfig:HeatmapTileCount")]
	public int HeatmapTileCount;

	private static bool FAutoMovementHeatmapConfig_IsValid;

	private static int FAutoMovementHeatmapConfig_StructSize;

	public FAutoMovementHeatmapConfig Copy()
	{
		return this;
	}

	public static FAutoMovementHeatmapConfig FromNative(IntPtr nativeBuffer)
	{
		return new FAutoMovementHeatmapConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAutoMovementHeatmapConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAutoMovementHeatmapConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAutoMovementHeatmapConfig(nativeBuffer + arrayIndex * FAutoMovementHeatmapConfig_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAutoMovementHeatmapConfig value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAutoMovementHeatmapConfig_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAutoMovementHeatmapConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AutoMovementHeatmapConfig");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HeatmapPlaneOrigin_Offset), HeatmapPlaneOrigin);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HeatmapPlaneSize_Offset), HeatmapPlaneSize);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, HeatmapTexParentFolder_Offset), HeatmapTexParentFolder);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, HeatmapBaseImgPath_Offset), HeatmapBaseImgPath);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, HeatmapProfilingFilePath_Offset), HeatmapProfilingFilePath);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HeatmapIntensityScale_Offset), HeatmapIntensityScale);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, HeatmapTileCount_Offset), HeatmapTileCount);
	}

	public FAutoMovementHeatmapConfig(IntPtr nativeStruct)
	{
		if (!FAutoMovementHeatmapConfig_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.AutoMovementHeatmapConfig");
			HeatmapPlaneOrigin = default(FVector);
			HeatmapPlaneSize = default(FVector);
			HeatmapTexParentFolder = FStringMarshaler.DefaultString;
			HeatmapBaseImgPath = FStringMarshaler.DefaultString;
			HeatmapProfilingFilePath = FStringMarshaler.DefaultString;
			HeatmapIntensityScale = 0f;
			HeatmapTileCount = 0;
		}
		else
		{
			HeatmapPlaneOrigin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HeatmapPlaneOrigin_Offset));
			HeatmapPlaneSize = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HeatmapPlaneSize_Offset));
			HeatmapTexParentFolder = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, HeatmapTexParentFolder_Offset));
			HeatmapBaseImgPath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, HeatmapBaseImgPath_Offset));
			HeatmapProfilingFilePath = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, HeatmapProfilingFilePath_Offset));
			HeatmapIntensityScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HeatmapIntensityScale_Offset));
			HeatmapTileCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, HeatmapTileCount_Offset));
		}
	}

	static FAutoMovementHeatmapConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAutoMovementHeatmapConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAutoMovementHeatmapConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.AutoMovementHeatmapConfig");
		FAutoMovementHeatmapConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		HeatmapPlaneOrigin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeatmapPlaneOrigin");
		HeatmapPlaneOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeatmapPlaneOrigin", Classes.FStructProperty);
		HeatmapPlaneSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeatmapPlaneSize");
		HeatmapPlaneSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeatmapPlaneSize", Classes.FStructProperty);
		HeatmapTexParentFolder_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeatmapTexParentFolder");
		HeatmapTexParentFolder_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeatmapTexParentFolder", Classes.FStrProperty);
		HeatmapBaseImgPath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeatmapBaseImgPath");
		HeatmapBaseImgPath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeatmapBaseImgPath", Classes.FStrProperty);
		HeatmapProfilingFilePath_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeatmapProfilingFilePath");
		HeatmapProfilingFilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeatmapProfilingFilePath", Classes.FStrProperty);
		HeatmapIntensityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeatmapIntensityScale");
		HeatmapIntensityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeatmapIntensityScale", Classes.FFloatProperty);
		HeatmapTileCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HeatmapTileCount");
		HeatmapTileCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HeatmapTileCount", Classes.FIntProperty);
		FAutoMovementHeatmapConfig_IsValid = intPtr != IntPtr.Zero && HeatmapPlaneOrigin_IsValid && HeatmapPlaneSize_IsValid && HeatmapTexParentFolder_IsValid && HeatmapBaseImgPath_IsValid && HeatmapProfilingFilePath_IsValid && HeatmapIntensityScale_IsValid && HeatmapTileCount_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.AutoMovementHeatmapConfig", FAutoMovementHeatmapConfig_IsValid);
	}
}
