using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.RadialDamageParams", "Engine", UnrealModuleType.Engine)]
public struct FRadialDamageParams
{
	private static bool BaseDamage_IsValid;

	private static int BaseDamage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialDamageParams:BaseDamage")]
	public float BaseDamage;

	private static bool MinimumDamage_IsValid;

	private static int MinimumDamage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialDamageParams:MinimumDamage")]
	public float MinimumDamage;

	private static bool InnerRadius_IsValid;

	private static int InnerRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialDamageParams:InnerRadius")]
	public float InnerRadius;

	private static bool OuterRadius_IsValid;

	private static int OuterRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialDamageParams:OuterRadius")]
	public float OuterRadius;

	private static bool DamageFalloff_IsValid;

	private static int DamageFalloff_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.RadialDamageParams:DamageFalloff")]
	public float DamageFalloff;

	private static bool FRadialDamageParams_IsValid;

	private static int FRadialDamageParams_StructSize;

	public FRadialDamageParams Copy()
	{
		return this;
	}

	public static FRadialDamageParams FromNative(IntPtr nativeBuffer)
	{
		return new FRadialDamageParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRadialDamageParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRadialDamageParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRadialDamageParams(nativeBuffer + arrayIndex * FRadialDamageParams_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRadialDamageParams value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FRadialDamageParams_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FRadialDamageParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RadialDamageParams");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BaseDamage_Offset), BaseDamage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MinimumDamage_Offset), MinimumDamage);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InnerRadius_Offset), InnerRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OuterRadius_Offset), OuterRadius);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DamageFalloff_Offset), DamageFalloff);
	}

	public FRadialDamageParams(IntPtr nativeStruct)
	{
		if (!FRadialDamageParams_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.RadialDamageParams");
			BaseDamage = 0f;
			MinimumDamage = 0f;
			InnerRadius = 0f;
			OuterRadius = 0f;
			DamageFalloff = 0f;
		}
		else
		{
			BaseDamage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BaseDamage_Offset));
			MinimumDamage = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MinimumDamage_Offset));
			InnerRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InnerRadius_Offset));
			OuterRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OuterRadius_Offset));
			DamageFalloff = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DamageFalloff_Offset));
		}
	}

	static FRadialDamageParams()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FRadialDamageParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRadialDamageParams));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.RadialDamageParams");
		FRadialDamageParams_StructSize = NativeReflection.GetStructSize(intPtr);
		BaseDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BaseDamage");
		BaseDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BaseDamage", Classes.FFloatProperty);
		MinimumDamage_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinimumDamage");
		MinimumDamage_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinimumDamage", Classes.FFloatProperty);
		InnerRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InnerRadius");
		InnerRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InnerRadius", Classes.FFloatProperty);
		OuterRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OuterRadius");
		OuterRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OuterRadius", Classes.FFloatProperty);
		DamageFalloff_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DamageFalloff");
		DamageFalloff_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DamageFalloff", Classes.FFloatProperty);
		FRadialDamageParams_IsValid = intPtr != IntPtr.Zero && BaseDamage_IsValid && MinimumDamage_IsValid && InnerRadius_IsValid && OuterRadius_IsValid && DamageFalloff_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.RadialDamageParams", FRadialDamageParams_IsValid);
	}
}
