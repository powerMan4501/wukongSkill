using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Landmass;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Landmass.BrushEffectCurves", "Landmass", UnrealModuleType.EnginePlugin)]
public struct FBrushEffectCurves
{
	private static bool UseCurveChannel_IsValid;

	private static FFieldAddress UseCurveChannel_PropertyAddress;

	private static int UseCurveChannel_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurves:bUseCurveChannel")]
	public bool UseCurveChannel;

	private static bool ElevationCurveAsset_IsValid;

	private static int ElevationCurveAsset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurves:ElevationCurveAsset")]
	public UCurveFloat ElevationCurveAsset;

	private static bool ChannelEdgeOffset_IsValid;

	private static int ChannelEdgeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurves:ChannelEdgeOffset")]
	public float ChannelEdgeOffset;

	private static bool ChannelDepth_IsValid;

	private static int ChannelDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurves:ChannelDepth")]
	public float ChannelDepth;

	private static bool CurveRampWidth_IsValid;

	private static int CurveRampWidth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Landmass.BrushEffectCurves:CurveRampWidth")]
	public float CurveRampWidth;

	private static bool FBrushEffectCurves_IsValid;

	private static int FBrushEffectCurves_StructSize;

	public FBrushEffectCurves Copy()
	{
		return this;
	}

	public static FBrushEffectCurves FromNative(IntPtr nativeBuffer)
	{
		return new FBrushEffectCurves(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FBrushEffectCurves value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FBrushEffectCurves FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FBrushEffectCurves(nativeBuffer + arrayIndex * FBrushEffectCurves_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FBrushEffectCurves value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FBrushEffectCurves_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FBrushEffectCurves_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectCurves");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, UseCurveChannel_Offset), 0, UseCurveChannel_PropertyAddress.Address, UseCurveChannel);
		UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(nativeStruct, ElevationCurveAsset_Offset), ElevationCurveAsset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChannelEdgeOffset_Offset), ChannelEdgeOffset);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ChannelDepth_Offset), ChannelDepth);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CurveRampWidth_Offset), CurveRampWidth);
	}

	public FBrushEffectCurves(IntPtr nativeStruct)
	{
		if (!FBrushEffectCurves_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Landmass.BrushEffectCurves");
			UseCurveChannel = false;
			ElevationCurveAsset = null;
			ChannelEdgeOffset = 0f;
			ChannelDepth = 0f;
			CurveRampWidth = 0f;
		}
		else
		{
			UseCurveChannel = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, UseCurveChannel_Offset), 0, UseCurveChannel_PropertyAddress.Address);
			ElevationCurveAsset = UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(nativeStruct, ElevationCurveAsset_Offset));
			ChannelEdgeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChannelEdgeOffset_Offset));
			ChannelDepth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ChannelDepth_Offset));
			CurveRampWidth = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CurveRampWidth_Offset));
		}
	}

	static FBrushEffectCurves()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FBrushEffectCurves)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FBrushEffectCurves));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Landmass.BrushEffectCurves");
		FBrushEffectCurves_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref UseCurveChannel_PropertyAddress, intPtr, "bUseCurveChannel");
		UseCurveChannel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUseCurveChannel");
		UseCurveChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUseCurveChannel", Classes.FBoolProperty);
		ElevationCurveAsset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElevationCurveAsset");
		ElevationCurveAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElevationCurveAsset", Classes.FObjectProperty);
		ChannelEdgeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChannelEdgeOffset");
		ChannelEdgeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChannelEdgeOffset", Classes.FFloatProperty);
		ChannelDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ChannelDepth");
		ChannelDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ChannelDepth", Classes.FFloatProperty);
		CurveRampWidth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveRampWidth");
		CurveRampWidth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveRampWidth", Classes.FFloatProperty);
		FBrushEffectCurves_IsValid = intPtr != IntPtr.Zero && UseCurveChannel_IsValid && ElevationCurveAsset_IsValid && ChannelEdgeOffset_IsValid && ChannelDepth_IsValid && CurveRampWidth_IsValid;
		NativeReflection.LogStructIsValid("/Script/Landmass.BrushEffectCurves", FBrushEffectCurves_IsValid);
	}
}
