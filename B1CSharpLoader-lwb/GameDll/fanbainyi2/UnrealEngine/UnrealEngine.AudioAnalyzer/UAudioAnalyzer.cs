using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioAnalyzer;

[Abstract]
[UClass(Flags = (ClassFlags)810553505uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AudioAnalyzer.AudioAnalyzer", "AudioAnalyzer", UnrealModuleType.Engine)]
public class UAudioAnalyzer : UObject
{
	private static bool StopAnalyzing_IsValid;

	private static IntPtr StopAnalyzing_FunctionAddress;

	private static int StopAnalyzing_ParamsSize;

	private static bool StopAnalyzing_WorldContextObject_IsValid;

	private static FFieldAddress StopAnalyzing_WorldContextObject_PropertyAddress;

	private static int StopAnalyzing_WorldContextObject_Offset;

	private static bool StartAnalyzing_IsValid;

	private static IntPtr StartAnalyzing_FunctionAddress;

	private static int StartAnalyzing_ParamsSize;

	private static bool StartAnalyzing_WorldContextObject_IsValid;

	private static FFieldAddress StartAnalyzing_WorldContextObject_PropertyAddress;

	private static int StartAnalyzing_WorldContextObject_Offset;

	private static bool StartAnalyzing_AudioBusToAnalyze_IsValid;

	private static FFieldAddress StartAnalyzing_AudioBusToAnalyze_PropertyAddress;

	private static int StartAnalyzing_AudioBusToAnalyze_Offset;

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AudioAnalyzer.AudioAnalyzer:StopAnalyzing")]
	public unsafe void StopAnalyzing(UObject WorldContextObject)
	{
		CheckDestroyed();
		if (!StopAnalyzing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioAnalyzer.AudioAnalyzer:StopAnalyzing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopAnalyzing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopAnalyzing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StopAnalyzing_WorldContextObject_Offset), 0, StopAnalyzing_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopAnalyzing_FunctionAddress, intPtr, StopAnalyzing_ParamsSize);
	}

	[UFunction(Flags = 67240969u)]
	[UMetaPath("/Script/AudioAnalyzer.AudioAnalyzer:StartAnalyzing")]
	public unsafe void StartAnalyzing(UObject WorldContextObject, UAudioBus AudioBusToAnalyze)
	{
		CheckDestroyed();
		if (!StartAnalyzing_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioAnalyzer.AudioAnalyzer:StartAnalyzing");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartAnalyzing_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartAnalyzing_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, StartAnalyzing_WorldContextObject_Offset), 0, StartAnalyzing_WorldContextObject_PropertyAddress.Address, WorldContextObject);
		UObjectMarshaler<UAudioBus>.ToNative(IntPtr.Add(intPtr, StartAnalyzing_AudioBusToAnalyze_Offset), 0, StartAnalyzing_AudioBusToAnalyze_PropertyAddress.Address, AudioBusToAnalyze);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartAnalyzing_FunctionAddress, intPtr, StartAnalyzing_ParamsSize);
	}

	static UAudioAnalyzer()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioAnalyzer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioAnalyzer));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AudioAnalyzer.AudioAnalyzer");
		StopAnalyzing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopAnalyzing");
		StopAnalyzing_ParamsSize = NativeReflection.GetFunctionParamsSize(StopAnalyzing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopAnalyzing_WorldContextObject_PropertyAddress, StopAnalyzing_FunctionAddress, "WorldContextObject");
		StopAnalyzing_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StopAnalyzing_FunctionAddress, "WorldContextObject");
		StopAnalyzing_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StopAnalyzing_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		StopAnalyzing_IsValid = StopAnalyzing_FunctionAddress != IntPtr.Zero && StopAnalyzing_WorldContextObject_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioAnalyzer.AudioAnalyzer:StopAnalyzing", StopAnalyzing_IsValid);
		StartAnalyzing_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartAnalyzing");
		StartAnalyzing_ParamsSize = NativeReflection.GetFunctionParamsSize(StartAnalyzing_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzing_WorldContextObject_PropertyAddress, StartAnalyzing_FunctionAddress, "WorldContextObject");
		StartAnalyzing_WorldContextObject_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzing_FunctionAddress, "WorldContextObject");
		StartAnalyzing_WorldContextObject_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzing_FunctionAddress, "WorldContextObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartAnalyzing_AudioBusToAnalyze_PropertyAddress, StartAnalyzing_FunctionAddress, "AudioBusToAnalyze");
		StartAnalyzing_AudioBusToAnalyze_Offset = NativeReflectionCached.GetPropertyOffset(StartAnalyzing_FunctionAddress, "AudioBusToAnalyze");
		StartAnalyzing_AudioBusToAnalyze_IsValid = NativeReflectionCached.ValidatePropertyClass(StartAnalyzing_FunctionAddress, "AudioBusToAnalyze", Classes.FObjectProperty);
		StartAnalyzing_IsValid = StartAnalyzing_FunctionAddress != IntPtr.Zero && StartAnalyzing_WorldContextObject_IsValid && StartAnalyzing_AudioBusToAnalyze_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioAnalyzer.AudioAnalyzer:StartAnalyzing", StartAnalyzing_IsValid);
	}
}
