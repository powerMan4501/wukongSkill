using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.TressFX;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/TressFX.TressFXShadeSettings", "TressFX", UnrealModuleType.GamePlugin)]
public struct FTressFXShadeSettings
{
	private static bool FiberRadius_IsValid;

	private static int FiberRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXShadeSettings:FiberRadius")]
	public float FiberRadius;

	private static bool FiberSpacing_IsValid;

	private static int FiberSpacing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXShadeSettings:FiberSpacing")]
	public float FiberSpacing;

	private static bool HairThickness_IsValid;

	private static int HairThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXShadeSettings:HairThickness")]
	public float HairThickness;

	private static bool RootTangentBlending_IsValid;

	private static int RootTangentBlending_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXShadeSettings:RootTangentBlending")]
	public float RootTangentBlending;

	private static bool ShadowThickness_IsValid;

	private static int ShadowThickness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/TressFX.TressFXShadeSettings:ShadowThickness")]
	public float ShadowThickness;

	private static bool FTressFXShadeSettings_IsValid;

	private static int FTressFXShadeSettings_StructSize;

	public FTressFXShadeSettings Copy()
	{
		return this;
	}

	public static FTressFXShadeSettings FromNative(IntPtr nativeBuffer)
	{
		return new FTressFXShadeSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTressFXShadeSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTressFXShadeSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTressFXShadeSettings(nativeBuffer + arrayIndex * FTressFXShadeSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTressFXShadeSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FTressFXShadeSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FTressFXShadeSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.TressFXShadeSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FiberRadius_Offset), FiberRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FiberSpacing_Offset), FiberSpacing);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HairThickness_Offset), HairThickness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RootTangentBlending_Offset), RootTangentBlending);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ShadowThickness_Offset), ShadowThickness);
	}

	public FTressFXShadeSettings(IntPtr nativeStruct)
	{
		if (!FTressFXShadeSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/TressFX.TressFXShadeSettings");
			FiberRadius = 0f;
			FiberSpacing = 0f;
			HairThickness = 0f;
			RootTangentBlending = 0f;
			ShadowThickness = 0f;
		}
		else
		{
			FiberRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FiberRadius_Offset));
			FiberSpacing = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FiberSpacing_Offset));
			HairThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HairThickness_Offset));
			RootTangentBlending = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RootTangentBlending_Offset));
			ShadowThickness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ShadowThickness_Offset));
		}
	}

	static FTressFXShadeSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FTressFXShadeSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTressFXShadeSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/TressFX.TressFXShadeSettings");
		FTressFXShadeSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		FiberRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FiberRadius");
		FiberRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FiberRadius", Classes.FFloatProperty);
		FiberSpacing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FiberSpacing");
		FiberSpacing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FiberSpacing", Classes.FFloatProperty);
		HairThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HairThickness");
		HairThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HairThickness", Classes.FFloatProperty);
		RootTangentBlending_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RootTangentBlending");
		RootTangentBlending_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RootTangentBlending", Classes.FFloatProperty);
		ShadowThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShadowThickness");
		ShadowThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShadowThickness", Classes.FFloatProperty);
		FTressFXShadeSettings_IsValid = intPtr != IntPtr.Zero && FiberRadius_IsValid && FiberSpacing_IsValid && HairThickness_IsValid && RootTangentBlending_IsValid && ShadowThickness_IsValid;
		NativeReflection.LogStructIsValid("/Script/TressFX.TressFXShadeSettings", FTressFXShadeSettings_IsValid);
	}
}
