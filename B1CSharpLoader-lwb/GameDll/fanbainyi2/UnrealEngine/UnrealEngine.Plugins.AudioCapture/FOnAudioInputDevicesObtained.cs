using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AudioCapture;

[UDelegate]
[UMetaPath("/Script/AudioCapture.OnAudioInputDevicesObtained__DelegateSignature")]
public class FOnAudioInputDevicesObtained : FDelegate<FOnAudioInputDevicesObtained.Signature>
{
	public delegate void Signature(List<FAudioInputDeviceInfo> AvailableDevices);

	private static bool OnAudioInputDevicesObtained__DelegateSignature_IsValid;

	private static IntPtr OnAudioInputDevicesObtained__DelegateSignature_FunctionAddress;

	private static int OnAudioInputDevicesObtained__DelegateSignature_ParamsSize;

	private static bool OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_IsValid;

	private static FFieldAddress OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress;

	private static int OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioInputDevicesObtained()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioInputDevicesObtained__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioCapture.OnAudioInputDevicesObtained__DelegateSignature");
		OnAudioInputDevicesObtained__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioInputDevicesObtained__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress, OnAudioInputDevicesObtained__DelegateSignature_FunctionAddress, "AvailableDevices");
		OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioInputDevicesObtained__DelegateSignature_FunctionAddress, "AvailableDevices");
		OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioInputDevicesObtained__DelegateSignature_FunctionAddress, "AvailableDevices", Classes.FArrayProperty);
		OnAudioInputDevicesObtained__DelegateSignature_IsValid = OnAudioInputDevicesObtained__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioCapture.OnAudioInputDevicesObtained__DelegateSignature", OnAudioInputDevicesObtained__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FAudioInputDeviceInfo> AvailableDevices)
	{
		if (!OnAudioInputDevicesObtained__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioCapture.OnAudioInputDevicesObtained__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioInputDevicesObtained__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioInputDevicesObtained__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FAudioInputDeviceInfo>(1, OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress, CachedMarshalingDelegates<FAudioInputDeviceInfo, FAudioInputDeviceInfo>.FromNative, CachedMarshalingDelegates<FAudioInputDeviceInfo, FAudioInputDeviceInfo>.ToNative).ToNative(IntPtr.Add(intPtr, OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_Offset), AvailableDevices);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnAudioInputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress.Address, intPtr);
		}
	}
}
