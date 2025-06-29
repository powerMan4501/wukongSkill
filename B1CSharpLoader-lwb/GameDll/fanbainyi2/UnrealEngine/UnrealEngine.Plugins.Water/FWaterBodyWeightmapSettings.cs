using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Water.WaterBodyWeightmapSettings", "Water", UnrealModuleType.EnginePlugin)]
public struct FWaterBodyWeightmapSettings
{
	private static bool FalloffWidth_IsValid;

	private static int FalloffWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyWeightmapSettings:FalloffWidth")]
	public float FalloffWidth;

	private static bool EdgeOffset_IsValid;

	private static int EdgeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyWeightmapSettings:EdgeOffset")]
	public float EdgeOffset;

	private static bool ModulationTexture_IsValid;

	private static int ModulationTexture_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyWeightmapSettings:ModulationTexture")]
	public UTexture2D ModulationTexture;

	private static bool TextureTiling_IsValid;

	private static int TextureTiling_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyWeightmapSettings:TextureTiling")]
	public float TextureTiling;

	private static bool TextureInfluence_IsValid;

	private static int TextureInfluence_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyWeightmapSettings:TextureInfluence")]
	public float TextureInfluence;

	private static bool Midpoint_IsValid;

	private static int Midpoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyWeightmapSettings:Midpoint")]
	public float Midpoint;

	private static bool FinalOpacity_IsValid;

	private static int FinalOpacity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Water.WaterBodyWeightmapSettings:FinalOpacity")]
	public float FinalOpacity;

	private static bool FWaterBodyWeightmapSettings_IsValid;

	private static int FWaterBodyWeightmapSettings_StructSize;

	public FWaterBodyWeightmapSettings Copy()
	{
		return this;
	}

	public static FWaterBodyWeightmapSettings FromNative(IntPtr nativeBuffer)
	{
		return new FWaterBodyWeightmapSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FWaterBodyWeightmapSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FWaterBodyWeightmapSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FWaterBodyWeightmapSettings(nativeBuffer + arrayIndex * FWaterBodyWeightmapSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FWaterBodyWeightmapSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FWaterBodyWeightmapSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FWaterBodyWeightmapSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBodyWeightmapSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FalloffWidth_Offset), FalloffWidth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, EdgeOffset_Offset), EdgeOffset);
		UObjectMarshaler<UTexture2D>.ToNative(IntPtr.Add(nativeStruct, ModulationTexture_Offset), ModulationTexture);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TextureTiling_Offset), TextureTiling);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TextureInfluence_Offset), TextureInfluence);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Midpoint_Offset), Midpoint);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FinalOpacity_Offset), FinalOpacity);
	}

	public FWaterBodyWeightmapSettings(IntPtr nativeStruct)
	{
		if (!FWaterBodyWeightmapSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Water.WaterBodyWeightmapSettings");
			FalloffWidth = 0f;
			EdgeOffset = 0f;
			ModulationTexture = null;
			TextureTiling = 0f;
			TextureInfluence = 0f;
			Midpoint = 0f;
			FinalOpacity = 0f;
		}
		else
		{
			FalloffWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FalloffWidth_Offset));
			EdgeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, EdgeOffset_Offset));
			ModulationTexture = UObjectMarshaler<UTexture2D>.FromNative(IntPtr.Add(nativeStruct, ModulationTexture_Offset));
			TextureTiling = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TextureTiling_Offset));
			TextureInfluence = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TextureInfluence_Offset));
			Midpoint = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Midpoint_Offset));
			FinalOpacity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FinalOpacity_Offset));
		}
	}

	static FWaterBodyWeightmapSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FWaterBodyWeightmapSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FWaterBodyWeightmapSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Water.WaterBodyWeightmapSettings");
		FWaterBodyWeightmapSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FalloffWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FalloffWidth");
		FalloffWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FalloffWidth", Classes.FFloatProperty);
		EdgeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EdgeOffset");
		EdgeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EdgeOffset", Classes.FFloatProperty);
		ModulationTexture_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ModulationTexture");
		ModulationTexture_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ModulationTexture", Classes.FObjectProperty);
		TextureTiling_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureTiling");
		TextureTiling_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureTiling", Classes.FFloatProperty);
		TextureInfluence_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TextureInfluence");
		TextureInfluence_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TextureInfluence", Classes.FFloatProperty);
		Midpoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Midpoint");
		Midpoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Midpoint", Classes.FFloatProperty);
		FinalOpacity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FinalOpacity");
		FinalOpacity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FinalOpacity", Classes.FFloatProperty);
		FWaterBodyWeightmapSettings_IsValid = intPtr != IntPtr.Zero && FalloffWidth_IsValid && EdgeOffset_IsValid && ModulationTexture_IsValid && TextureTiling_IsValid && TextureInfluence_IsValid && Midpoint_IsValid && FinalOpacity_IsValid;
		NativeReflection.LogStructIsValid("/Script/Water.WaterBodyWeightmapSettings", FWaterBodyWeightmapSettings_IsValid);
	}
}
