using System;
using System.Runtime.CompilerServices;
using UnrealEngine.AudioMixer;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioCapture;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/AudioCapture.AudioCapture", "AudioCapture", UnrealModuleType.EnginePlugin)]
public class UAudioCapture : UAudioGenerator
{
	private static bool StopCapturingAudio_IsValid;

	private static IntPtr StopCapturingAudio_FunctionAddress;

	private static int StopCapturingAudio_ParamsSize;

	private static bool StartCapturingAudio_IsValid;

	private static IntPtr StartCapturingAudio_FunctionAddress;

	private static int StartCapturingAudio_ParamsSize;

	private static bool IsCapturingAudio_IsValid;

	private static IntPtr IsCapturingAudio_FunctionAddress;

	private static int IsCapturingAudio_ParamsSize;

	private static bool IsCapturingAudio_ReturnValue_IsValid;

	private static FFieldAddress IsCapturingAudio_ReturnValue_PropertyAddress;

	private static int IsCapturingAudio_ReturnValue_Offset;

	private static bool GetAudioCaptureDeviceInfo_IsValid;

	private static IntPtr GetAudioCaptureDeviceInfo_FunctionAddress;

	private static int GetAudioCaptureDeviceInfo_ParamsSize;

	private static bool GetAudioCaptureDeviceInfo_OutInfo_IsValid;

	private static FFieldAddress GetAudioCaptureDeviceInfo_OutInfo_PropertyAddress;

	private static int GetAudioCaptureDeviceInfo_OutInfo_Offset;

	private static bool GetAudioCaptureDeviceInfo_ReturnValue_IsValid;

	private static FFieldAddress GetAudioCaptureDeviceInfo_ReturnValue_PropertyAddress;

	private static int GetAudioCaptureDeviceInfo_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioCapture.AudioCapture:StopCapturingAudio")]
	public unsafe void StopCapturingAudio()
	{
		CheckDestroyed();
		if (!StopCapturingAudio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.AudioCapture:StopCapturingAudio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopCapturingAudio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopCapturingAudio_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopCapturingAudio_FunctionAddress, argsSize: StopCapturingAudio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioCapture.AudioCapture:StartCapturingAudio")]
	public unsafe void StartCapturingAudio()
	{
		CheckDestroyed();
		if (!StartCapturingAudio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.AudioCapture:StartCapturingAudio");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartCapturingAudio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartCapturingAudio_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StartCapturingAudio_FunctionAddress, argsSize: StartCapturingAudio_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AudioCapture.AudioCapture:IsCapturingAudio")]
	public unsafe bool IsCapturingAudio()
	{
		CheckDestroyed();
		if (!IsCapturingAudio_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.AudioCapture:IsCapturingAudio");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCapturingAudio_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCapturingAudio_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCapturingAudio_FunctionAddress, intPtr, IsCapturingAudio_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCapturingAudio_ReturnValue_Offset), 0, IsCapturingAudio_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AudioCapture.AudioCapture:GetAudioCaptureDeviceInfo")]
	public unsafe bool GetAudioCaptureDeviceInfo(out FAudioCaptureDeviceInfo OutInfo)
	{
		CheckDestroyed();
		if (!GetAudioCaptureDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.AudioCapture:GetAudioCaptureDeviceInfo");
			OutInfo = default(FAudioCaptureDeviceInfo);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAudioCaptureDeviceInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAudioCaptureDeviceInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAudioCaptureDeviceInfo_OutInfo_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAudioCaptureDeviceInfo_FunctionAddress, intPtr, GetAudioCaptureDeviceInfo_ParamsSize);
		OutInfo = FAudioCaptureDeviceInfo.FromNative(IntPtr.Add(intPtr, GetAudioCaptureDeviceInfo_OutInfo_Offset), 0, GetAudioCaptureDeviceInfo_OutInfo_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAudioCaptureDeviceInfo_ReturnValue_Offset), 0, GetAudioCaptureDeviceInfo_ReturnValue_PropertyAddress.Address);
	}

	static UAudioCapture()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAudioCapture)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAudioCapture));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/AudioCapture.AudioCapture");
		StopCapturingAudio_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StopCapturingAudio");
		StopCapturingAudio_ParamsSize = NativeReflection.GetFunctionParamsSize(StopCapturingAudio_FunctionAddress);
		StopCapturingAudio_IsValid = StopCapturingAudio_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.AudioCapture:StopCapturingAudio", StopCapturingAudio_IsValid);
		StartCapturingAudio_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartCapturingAudio");
		StartCapturingAudio_ParamsSize = NativeReflection.GetFunctionParamsSize(StartCapturingAudio_FunctionAddress);
		StartCapturingAudio_IsValid = StartCapturingAudio_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.AudioCapture:StartCapturingAudio", StartCapturingAudio_IsValid);
		IsCapturingAudio_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsCapturingAudio");
		IsCapturingAudio_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCapturingAudio_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCapturingAudio_ReturnValue_PropertyAddress, IsCapturingAudio_FunctionAddress, "ReturnValue");
		IsCapturingAudio_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCapturingAudio_FunctionAddress, "ReturnValue");
		IsCapturingAudio_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCapturingAudio_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCapturingAudio_IsValid = IsCapturingAudio_FunctionAddress != IntPtr.Zero && IsCapturingAudio_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.AudioCapture:IsCapturingAudio", IsCapturingAudio_IsValid);
		GetAudioCaptureDeviceInfo_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAudioCaptureDeviceInfo");
		GetAudioCaptureDeviceInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAudioCaptureDeviceInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAudioCaptureDeviceInfo_OutInfo_PropertyAddress, GetAudioCaptureDeviceInfo_FunctionAddress, "OutInfo");
		GetAudioCaptureDeviceInfo_OutInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioCaptureDeviceInfo_FunctionAddress, "OutInfo");
		GetAudioCaptureDeviceInfo_OutInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioCaptureDeviceInfo_FunctionAddress, "OutInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAudioCaptureDeviceInfo_ReturnValue_PropertyAddress, GetAudioCaptureDeviceInfo_FunctionAddress, "ReturnValue");
		GetAudioCaptureDeviceInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAudioCaptureDeviceInfo_FunctionAddress, "ReturnValue");
		GetAudioCaptureDeviceInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAudioCaptureDeviceInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAudioCaptureDeviceInfo_IsValid = GetAudioCaptureDeviceInfo_FunctionAddress != IntPtr.Zero && GetAudioCaptureDeviceInfo_OutInfo_IsValid && GetAudioCaptureDeviceInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.AudioCapture:GetAudioCaptureDeviceInfo", GetAudioCaptureDeviceInfo_IsValid);
	}
}
