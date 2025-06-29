using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.FontRenderInfo", "Engine", UnrealModuleType.Engine)]
public struct FFontRenderInfo
{
	private static bool ClipText_IsValid;

	private static FFieldAddress ClipText_PropertyAddress;

	private static int ClipText_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.FontRenderInfo:bClipText")]
	public bool ClipText;

	private static bool EnableShadow_IsValid;

	private static FFieldAddress EnableShadow_PropertyAddress;

	private static int EnableShadow_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.FontRenderInfo:bEnableShadow")]
	public bool EnableShadow;

	private static bool GlowInfo_IsValid;

	private static int GlowInfo_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/Engine.FontRenderInfo:GlowInfo")]
	public FDepthFieldGlowInfo GlowInfo;

	private static bool FFontRenderInfo_IsValid;

	private static int FFontRenderInfo_StructSize;

	public FFontRenderInfo Copy()
	{
		return this;
	}

	public static FFontRenderInfo FromNative(IntPtr nativeBuffer)
	{
		return new FFontRenderInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FFontRenderInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FFontRenderInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FFontRenderInfo(nativeBuffer + arrayIndex * FFontRenderInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FFontRenderInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FFontRenderInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FFontRenderInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FontRenderInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ClipText_Offset), 0, ClipText_PropertyAddress.Address, ClipText);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address, EnableShadow);
		FDepthFieldGlowInfo.ToNative(IntPtr.Add(nativeStruct, GlowInfo_Offset), GlowInfo);
	}

	public FFontRenderInfo(IntPtr nativeStruct)
	{
		if (!FFontRenderInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.FontRenderInfo");
			ClipText = false;
			EnableShadow = false;
			GlowInfo = default(FDepthFieldGlowInfo);
		}
		else
		{
			ClipText = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ClipText_Offset), 0, ClipText_PropertyAddress.Address);
			EnableShadow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableShadow_Offset), 0, EnableShadow_PropertyAddress.Address);
			GlowInfo = FDepthFieldGlowInfo.FromNative(IntPtr.Add(nativeStruct, GlowInfo_Offset));
		}
	}

	static FFontRenderInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FFontRenderInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FFontRenderInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.FontRenderInfo");
		FFontRenderInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ClipText_PropertyAddress, intPtr, "bClipText");
		ClipText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bClipText");
		ClipText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bClipText", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableShadow_PropertyAddress, intPtr, "bEnableShadow");
		EnableShadow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableShadow");
		EnableShadow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableShadow", Classes.FBoolProperty);
		GlowInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlowInfo");
		GlowInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlowInfo", Classes.FStructProperty);
		FFontRenderInfo_IsValid = intPtr != IntPtr.Zero && ClipText_IsValid && EnableShadow_IsValid && GlowInfo_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.FontRenderInfo", FFontRenderInfo_IsValid);
	}
}
