using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.ExponentialHeightFogConfig")]
public struct ExponentialHeightFogConfig
{
	public float FogDensity;

	public float FogHeightFalloff;

	public FExponentialHeightFogData SecondFogData;

	public float SecondFogDensity;

	public float SecondFogHeightFalloff;

	public float SecondFogHeightOffset;

	public FLinearColor FogInscatteringColor;

	public float FogMaxOpacity;

	public float StartDistance;

	public float FogCutoffDistance;

	public bool EnableVolumetricFog;

	public FColor Albedo;

	private static int ExponentialHeightFogConfig_StructSize;

	private static int ExponentialHeightFogConfig_IsValid;

	public void SetConfig(float _FogDensity, float _FogHeightFalloff, FExponentialHeightFogData _SecondFogData, FLinearColor _FogInscatteringColor, float _FogMaxOpacity, float _StartDistance, float _FogCutoffDistance, bool _EnableVolumetricFog, FColor _Albedo)
	{
		FogDensity = _FogDensity;
		FogHeightFalloff = _FogHeightFalloff;
		SecondFogData = _SecondFogData;
		FogInscatteringColor = _FogInscatteringColor;
		FogMaxOpacity = _FogMaxOpacity;
		StartDistance = _StartDistance;
		FogCutoffDistance = _FogCutoffDistance;
		EnableVolumetricFog = true;
		Albedo = _Albedo;
	}

	public ExponentialHeightFogConfig Copy()
	{
		return this;
	}

	public static ExponentialHeightFogConfig FromNative(IntPtr nativeBuffer)
	{
		return new ExponentialHeightFogConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, ExponentialHeightFogConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static ExponentialHeightFogConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new ExponentialHeightFogConfig(IntPtr.Add(nativeBuffer, arrayIndex * ExponentialHeightFogConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, ExponentialHeightFogConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * ExponentialHeightFogConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (ExponentialHeightFogConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ExponentialHeightFogConfig");
		}
	}

	public ExponentialHeightFogConfig(IntPtr nativeStruct)
	{
		if (ExponentialHeightFogConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.ExponentialHeightFogConfig");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.ExponentialHeightFogConfig");
		ExponentialHeightFogConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		ExponentialHeightFogConfig_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.ExponentialHeightFogConfig", (byte)ExponentialHeightFogConfig_IsValid != 0);
	}

	static ExponentialHeightFogConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(ExponentialHeightFogConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ExponentialHeightFogConfig));
	}
}
