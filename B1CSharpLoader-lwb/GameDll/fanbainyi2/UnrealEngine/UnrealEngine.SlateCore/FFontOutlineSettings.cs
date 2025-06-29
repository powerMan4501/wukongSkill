using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 268801)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.FontOutlineSettings", "SlateCore", UnrealModuleType.Engine)]
public struct FFontOutlineSettings
{
	private static bool OutlineSize_IsValid;

	private static int OutlineSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontOutlineSettings:OutlineSize")]
	public int OutlineSize;

	private static bool SeparateFillAlpha_IsValid;

	private static FFieldAddress SeparateFillAlpha_PropertyAddress;

	private static int SeparateFillAlpha_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontOutlineSettings:bSeparateFillAlpha")]
	public bool SeparateFillAlpha;

	private static bool ApplyOutlineToDropShadows_IsValid;

	private static FFieldAddress ApplyOutlineToDropShadows_PropertyAddress;

	private static int ApplyOutlineToDropShadows_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontOutlineSettings:bApplyOutlineToDropShadows")]
	public bool ApplyOutlineToDropShadows;

	private static bool OutlineMaterial_IsValid;

	private static int OutlineMaterial_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/SlateCore.FontOutlineSettings:OutlineMaterial")]
	public UObject OutlineMaterial;

	private static bool OutlineColor_IsValid;

	private static int OutlineColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SlateCore.FontOutlineSettings:OutlineColor")]
	public FLinearColor OutlineColor;

	private static bool GSSoftShadowCfg_IsValid;

	private static int GSSoftShadowCfg_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/SlateCore.FontOutlineSettings:GSSoftShadowCfg")]
	public FFontGSSoftShadowCfg GSSoftShadowCfg;

	private static bool FFontOutlineSettings_IsValid;

	private static int FFontOutlineSettings_StructSize;

	public FFontOutlineSettings Copy()
	{
		return this;
	}

	public static FFontOutlineSettings FromNative(IntPtr nativeBuffer)
	{
		return new FFontOutlineSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFontOutlineSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFontOutlineSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFontOutlineSettings(nativeBuffer + arrayIndex * FFontOutlineSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFontOutlineSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFontOutlineSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFontOutlineSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.FontOutlineSettings");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OutlineSize_Offset), OutlineSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SeparateFillAlpha_Offset), 0, SeparateFillAlpha_PropertyAddress.Address, SeparateFillAlpha);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ApplyOutlineToDropShadows_Offset), 0, ApplyOutlineToDropShadows_PropertyAddress.Address, ApplyOutlineToDropShadows);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(nativeStruct, OutlineMaterial_Offset), OutlineMaterial);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, OutlineColor_Offset), OutlineColor);
		FFontGSSoftShadowCfg.ToNative(IntPtr.Add(nativeStruct, GSSoftShadowCfg_Offset), GSSoftShadowCfg);
	}

	public FFontOutlineSettings(IntPtr nativeStruct)
	{
		if (!FFontOutlineSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SlateCore.FontOutlineSettings");
			OutlineSize = 0;
			SeparateFillAlpha = false;
			ApplyOutlineToDropShadows = false;
			OutlineMaterial = null;
			OutlineColor = default(FLinearColor);
			GSSoftShadowCfg = default(FFontGSSoftShadowCfg);
		}
		else
		{
			OutlineSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OutlineSize_Offset));
			SeparateFillAlpha = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SeparateFillAlpha_Offset), 0, SeparateFillAlpha_PropertyAddress.Address);
			ApplyOutlineToDropShadows = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ApplyOutlineToDropShadows_Offset), 0, ApplyOutlineToDropShadows_PropertyAddress.Address);
			OutlineMaterial = UObjectMarshaler<UObject>.FromNative(IntPtr.Add(nativeStruct, OutlineMaterial_Offset));
			OutlineColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, OutlineColor_Offset));
			GSSoftShadowCfg = FFontGSSoftShadowCfg.FromNative(IntPtr.Add(nativeStruct, GSSoftShadowCfg_Offset));
		}
	}

	static FFontOutlineSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFontOutlineSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFontOutlineSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SlateCore.FontOutlineSettings");
		FFontOutlineSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		OutlineSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutlineSize");
		OutlineSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutlineSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SeparateFillAlpha_PropertyAddress, intPtr, "bSeparateFillAlpha");
		SeparateFillAlpha_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSeparateFillAlpha");
		SeparateFillAlpha_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSeparateFillAlpha", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyOutlineToDropShadows_PropertyAddress, intPtr, "bApplyOutlineToDropShadows");
		ApplyOutlineToDropShadows_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bApplyOutlineToDropShadows");
		ApplyOutlineToDropShadows_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bApplyOutlineToDropShadows", Classes.FBoolProperty);
		OutlineMaterial_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutlineMaterial");
		OutlineMaterial_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutlineMaterial", Classes.FObjectProperty);
		OutlineColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutlineColor");
		OutlineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutlineColor", Classes.FStructProperty);
		GSSoftShadowCfg_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSSoftShadowCfg");
		GSSoftShadowCfg_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSSoftShadowCfg", Classes.FStructProperty);
		FFontOutlineSettings_IsValid = intPtr != IntPtr.Zero && OutlineSize_IsValid && SeparateFillAlpha_IsValid && ApplyOutlineToDropShadows_IsValid && OutlineMaterial_IsValid && OutlineColor_IsValid && GSSoftShadowCfg_IsValid;
		NativeReflection.LogStructIsValid("/Script/SlateCore.FontOutlineSettings", FFontOutlineSettings_IsValid);
	}
}
