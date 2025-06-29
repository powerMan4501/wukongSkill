using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.DepthFieldGlowInfo", "Engine", UnrealModuleType.Engine)]
public struct FDepthFieldGlowInfo
{
	private static bool EnableGlow_IsValid;

	private static FFieldAddress EnableGlow_PropertyAddress;

	private static int EnableGlow_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/Engine.DepthFieldGlowInfo:bEnableGlow")]
	public bool EnableGlow;

	private static bool GlowColor_IsValid;

	private static int GlowColor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.DepthFieldGlowInfo:GlowColor")]
	public FLinearColor GlowColor;

	private static bool GlowOuterRadius_IsValid;

	private static int GlowOuterRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.DepthFieldGlowInfo:GlowOuterRadius")]
	public FVector2D GlowOuterRadius;

	private static bool GlowInnerRadius_IsValid;

	private static int GlowInnerRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/Engine.DepthFieldGlowInfo:GlowInnerRadius")]
	public FVector2D GlowInnerRadius;

	private static bool FDepthFieldGlowInfo_IsValid;

	private static int FDepthFieldGlowInfo_StructSize;

	public FDepthFieldGlowInfo Copy()
	{
		return this;
	}

	public static FDepthFieldGlowInfo FromNative(IntPtr nativeBuffer)
	{
		return new FDepthFieldGlowInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDepthFieldGlowInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDepthFieldGlowInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDepthFieldGlowInfo(nativeBuffer + arrayIndex * FDepthFieldGlowInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDepthFieldGlowInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDepthFieldGlowInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDepthFieldGlowInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DepthFieldGlowInfo");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableGlow_Offset), 0, EnableGlow_PropertyAddress.Address, EnableGlow);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, GlowColor_Offset), GlowColor);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, GlowOuterRadius_Offset), GlowOuterRadius);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, GlowInnerRadius_Offset), GlowInnerRadius);
	}

	public FDepthFieldGlowInfo(IntPtr nativeStruct)
	{
		if (!FDepthFieldGlowInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DepthFieldGlowInfo");
			EnableGlow = false;
			GlowColor = default(FLinearColor);
			GlowOuterRadius = default(FVector2D);
			GlowInnerRadius = default(FVector2D);
		}
		else
		{
			EnableGlow = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableGlow_Offset), 0, EnableGlow_PropertyAddress.Address);
			GlowColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, GlowColor_Offset));
			GlowOuterRadius = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, GlowOuterRadius_Offset));
			GlowInnerRadius = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, GlowInnerRadius_Offset));
		}
	}

	static FDepthFieldGlowInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDepthFieldGlowInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDepthFieldGlowInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DepthFieldGlowInfo");
		FDepthFieldGlowInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EnableGlow_PropertyAddress, intPtr, "bEnableGlow");
		EnableGlow_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableGlow");
		EnableGlow_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableGlow", Classes.FBoolProperty);
		GlowColor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlowColor");
		GlowColor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlowColor", Classes.FStructProperty);
		GlowOuterRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlowOuterRadius");
		GlowOuterRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlowOuterRadius", Classes.FStructProperty);
		GlowInnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GlowInnerRadius");
		GlowInnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GlowInnerRadius", Classes.FStructProperty);
		FDepthFieldGlowInfo_IsValid = intPtr != IntPtr.Zero && EnableGlow_IsValid && GlowColor_IsValid && GlowOuterRadius_IsValid && GlowInnerRadius_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.DepthFieldGlowInfo", FDepthFieldGlowInfo_IsValid);
	}
}
