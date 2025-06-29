using System;
using b1.Plugins.CustomLightSystem;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.EnvChangeConfig")]
public struct FEnvChangeConfig
{
	public ULevelSequencePlayer EnvLevelSequencePlayer;

	public float CurALTime;

	public float CurTargerALTime;

	public float FinalTargetALTime;

	public ADirectionalLight CLS_DLight;

	public ASkyLight CLS_SLight;

	public ASkyAtmosphere CLS_AFog;

	public AExponentialHeightFog CLS_EHFog;

	public FCLSMaterialParametersCollectionProperty CLS_TargetMPCProperty;

	public FCLSMaterialParametersCollectionProperty CLS_OriMPCProperty;

	private static int EnvChangeConfig_StructSize;

	private static int EnvChangeConfig_IsValid;

	public FEnvChangeConfig Copy()
	{
		return this;
	}

	public static FEnvChangeConfig FromNative(IntPtr nativeBuffer)
	{
		return new FEnvChangeConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEnvChangeConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEnvChangeConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEnvChangeConfig(IntPtr.Add(nativeBuffer, arrayIndex * EnvChangeConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEnvChangeConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EnvChangeConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EnvChangeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvChangeConfig");
		}
	}

	public FEnvChangeConfig(IntPtr nativeStruct)
	{
		if (EnvChangeConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvChangeConfig");
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EnvChangeConfig");
		EnvChangeConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		EnvChangeConfig_IsValid = ((intPtr != IntPtr.Zero) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EnvChangeConfig", (byte)EnvChangeConfig_IsValid != 0);
	}

	static FEnvChangeConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEnvChangeConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEnvChangeConfig));
	}
}
