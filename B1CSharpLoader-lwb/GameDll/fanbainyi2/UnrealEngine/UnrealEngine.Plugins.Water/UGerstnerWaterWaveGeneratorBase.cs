using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Water;

[Abstract]
[UClass(Flags = (ClassFlags)810029217uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorBase", "Water", UnrealModuleType.EnginePlugin)]
public class UGerstnerWaterWaveGeneratorBase : UObject
{
	private static bool GenerateGerstnerWaves_IsValid;

	private IntPtr GenerateGerstnerWaves_InstanceFunctionAddress;

	private static IntPtr GenerateGerstnerWaves_FunctionAddress;

	private static int GenerateGerstnerWaves_ParamsSize;

	private static bool GenerateGerstnerWaves_OutWaves_IsValid;

	private static FFieldAddress GenerateGerstnerWaves_OutWaves_PropertyAddress;

	private static int GenerateGerstnerWaves_OutWaves_Offset;

	[UFunction(Flags = 1212288000u)]
	[UMetaPath("/Script/Water.GerstnerWaterWaveGeneratorBase:GenerateGerstnerWaves")]
	public unsafe void GenerateGerstnerWaves(out List<FGerstnerWave> OutWaves)
	{
		CheckDestroyed();
		if (!GenerateGerstnerWaves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.GerstnerWaterWaveGeneratorBase:GenerateGerstnerWaves");
			OutWaves = null;
			return;
		}
		if (GenerateGerstnerWaves_InstanceFunctionAddress == IntPtr.Zero)
		{
			GenerateGerstnerWaves_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "GenerateGerstnerWaves");
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateGerstnerWaves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateGerstnerWaves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateGerstnerWaves_InstanceFunctionAddress, intPtr, GenerateGerstnerWaves_ParamsSize);
		OutWaves = new TArrayCopyMarshaler<FGerstnerWave>(1, GenerateGerstnerWaves_OutWaves_PropertyAddress, CachedMarshalingDelegates<FGerstnerWave, FGerstnerWave>.FromNative, CachedMarshalingDelegates<FGerstnerWave, FGerstnerWave>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateGerstnerWaves_OutWaves_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateGerstnerWaves_OutWaves_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void GenerateGerstnerWaves_Implementation(out List<FGerstnerWave> OutWaves)
	{
		CheckDestroyed();
		if (!GenerateGerstnerWaves_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Water.GerstnerWaterWaveGeneratorBase:GenerateGerstnerWaves");
			OutWaves = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GenerateGerstnerWaves_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GenerateGerstnerWaves_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GenerateGerstnerWaves_FunctionAddress, intPtr, GenerateGerstnerWaves_ParamsSize);
		OutWaves = new TArrayCopyMarshaler<FGerstnerWave>(1, GenerateGerstnerWaves_OutWaves_PropertyAddress, CachedMarshalingDelegates<FGerstnerWave, FGerstnerWave>.FromNative, CachedMarshalingDelegates<FGerstnerWave, FGerstnerWave>.ToNative).FromNative(IntPtr.Add(intPtr, GenerateGerstnerWaves_OutWaves_Offset));
		NativeReflection.DestroyValue_InContainer(GenerateGerstnerWaves_OutWaves_PropertyAddress.Address, intPtr);
	}

	static UGerstnerWaterWaveGeneratorBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGerstnerWaterWaveGeneratorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGerstnerWaterWaveGeneratorBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Water.GerstnerWaterWaveGeneratorBase");
		GenerateGerstnerWaves_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateGerstnerWaves");
		GenerateGerstnerWaves_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateGerstnerWaves_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GenerateGerstnerWaves_OutWaves_PropertyAddress, GenerateGerstnerWaves_FunctionAddress, "OutWaves");
		GenerateGerstnerWaves_OutWaves_Offset = NativeReflectionCached.GetPropertyOffset(GenerateGerstnerWaves_FunctionAddress, "OutWaves");
		GenerateGerstnerWaves_OutWaves_IsValid = NativeReflectionCached.ValidatePropertyClass(GenerateGerstnerWaves_FunctionAddress, "OutWaves", Classes.FArrayProperty);
		GenerateGerstnerWaves_IsValid = GenerateGerstnerWaves_FunctionAddress != IntPtr.Zero && GenerateGerstnerWaves_OutWaves_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Water.GerstnerWaterWaveGeneratorBase:GenerateGerstnerWaves", GenerateGerstnerWaves_IsValid);
	}
}
