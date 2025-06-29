using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.RandomPatrolConfig")]
public struct FRandomPatrolConfig
{
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.RandomPatrolConfig:EnvQuery")]
	public UEnvQuery EnvQuery;

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.ClampMax, 100)]
	[Tooltip("百分比，填1~100以内的数")]
	[USharpPath("/Script/b1-Managed.RandomPatrolConfig:WaitAMProbability")]
	public float WaitAMProbability;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.RandomPatrolConfig:WaitAM")]
	public List<UAnimMontage> WaitAM;

	private static int RandomPatrolConfig_StructSize;

	private static int RandomPatrolConfig_IsValid;

	private static bool EnvQuery_IsValid;

	private static int EnvQuery_Offset;

	private static bool WaitAMProbability_IsValid;

	private static int WaitAMProbability_Offset;

	private static bool WaitAM_IsValid;

	private static int WaitAM_Offset;

	private static FFieldAddress WaitAM_PropertyAddress;

	public FRandomPatrolConfig Copy()
	{
		FRandomPatrolConfig result = this;
		if (WaitAM != null)
		{
			result.WaitAM = new List<UAnimMontage>(WaitAM);
		}
		return result;
	}

	public static FRandomPatrolConfig FromNative(IntPtr nativeBuffer)
	{
		return new FRandomPatrolConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FRandomPatrolConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FRandomPatrolConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FRandomPatrolConfig(IntPtr.Add(nativeBuffer, arrayIndex * RandomPatrolConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FRandomPatrolConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * RandomPatrolConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (RandomPatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RandomPatrolConfig");
			return;
		}
		UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(nativeStruct, EnvQuery_Offset), EnvQuery);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WaitAMProbability_Offset), WaitAMProbability);
		new TArrayCopyMarshaler<UAnimMontage>(1, WaitAM_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).ToNative(IntPtr.Add(nativeStruct, WaitAM_Offset), WaitAM);
	}

	public FRandomPatrolConfig(IntPtr nativeStruct)
	{
		if (RandomPatrolConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.RandomPatrolConfig");
			EnvQuery = null;
			WaitAMProbability = 0f;
			WaitAM = null;
		}
		else
		{
			EnvQuery = UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(nativeStruct, EnvQuery_Offset));
			WaitAMProbability = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WaitAMProbability_Offset));
			WaitAM = new TArrayCopyMarshaler<UAnimMontage>(1, WaitAM_PropertyAddress, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.FromNative, CachedMarshalingDelegates<UAnimMontage, UObjectMarshaler<UAnimMontage>>.ToNative).FromNative(IntPtr.Add(nativeStruct, WaitAM_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.RandomPatrolConfig");
		RandomPatrolConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		EnvQuery_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnvQuery");
		EnvQuery_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnvQuery", Classes.FObjectProperty);
		WaitAMProbability_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitAMProbability");
		WaitAMProbability_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitAMProbability", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref WaitAM_PropertyAddress, intPtr, "WaitAM");
		WaitAM_Offset = NativeReflection.GetPropertyOffset(intPtr, "WaitAM");
		WaitAM_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WaitAM", Classes.FArrayProperty);
		RandomPatrolConfig_IsValid = ((intPtr != IntPtr.Zero && EnvQuery_IsValid && WaitAMProbability_IsValid && WaitAM_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.RandomPatrolConfig", (byte)RandomPatrolConfig_IsValid != 0);
	}

	static FRandomPatrolConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FRandomPatrolConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FRandomPatrolConfig));
	}
}
