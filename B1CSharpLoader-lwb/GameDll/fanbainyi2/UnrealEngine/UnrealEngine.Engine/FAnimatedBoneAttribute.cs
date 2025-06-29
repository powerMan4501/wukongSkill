using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.AnimatedBoneAttribute", "Engine", UnrealModuleType.Engine)]
public struct FAnimatedBoneAttribute
{
	private static bool Identifier_IsValid;

	private static int Identifier_Offset;

	[UProperty(Flags = (PropFlags)6755399441186837uL)]
	[UMetaPath("/Script/Engine.AnimatedBoneAttribute:Identifier")]
	public FAnimationAttributeIdentifier Identifier;

	private static bool Curve_IsValid;

	private static int Curve_Offset;

	[UProperty(Flags = (PropFlags)4503599627501589uL)]
	[UMetaPath("/Script/Engine.AnimatedBoneAttribute:Curve")]
	public FAttributeCurve Curve;

	private static bool FAnimatedBoneAttribute_IsValid;

	private static int FAnimatedBoneAttribute_StructSize;

	public FAnimatedBoneAttribute Copy()
	{
		return this;
	}

	public static FAnimatedBoneAttribute FromNative(IntPtr nativeBuffer)
	{
		return new FAnimatedBoneAttribute(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAnimatedBoneAttribute value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAnimatedBoneAttribute FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAnimatedBoneAttribute(nativeBuffer + arrayIndex * FAnimatedBoneAttribute_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAnimatedBoneAttribute value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAnimatedBoneAttribute_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAnimatedBoneAttribute_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimatedBoneAttribute");
			return;
		}
		FAnimationAttributeIdentifier.ToNative(IntPtr.Add(nativeStruct, Identifier_Offset), Identifier);
		FAttributeCurve.ToNative(IntPtr.Add(nativeStruct, Curve_Offset), Curve);
	}

	public FAnimatedBoneAttribute(IntPtr nativeStruct)
	{
		if (!FAnimatedBoneAttribute_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.AnimatedBoneAttribute");
			Identifier = default(FAnimationAttributeIdentifier);
			Curve = default(FAttributeCurve);
		}
		else
		{
			Identifier = FAnimationAttributeIdentifier.FromNative(IntPtr.Add(nativeStruct, Identifier_Offset));
			Curve = FAttributeCurve.FromNative(IntPtr.Add(nativeStruct, Curve_Offset));
		}
	}

	static FAnimatedBoneAttribute()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAnimatedBoneAttribute)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAnimatedBoneAttribute));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.AnimatedBoneAttribute");
		FAnimatedBoneAttribute_StructSize = NativeReflection.GetStructSize(intPtr);
		Identifier_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Identifier");
		Identifier_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Identifier", Classes.FStructProperty);
		Curve_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Curve");
		Curve_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Curve", Classes.FStructProperty);
		FAnimatedBoneAttribute_IsValid = intPtr != IntPtr.Zero && Identifier_IsValid && Curve_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.AnimatedBoneAttribute", FAnimatedBoneAttribute_IsValid);
	}
}
