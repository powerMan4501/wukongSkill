using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnAudioOutputDevicesObtained__DelegateSignature")]
public class FOnAudioOutputDevicesObtained : FDelegate<FOnAudioOutputDevicesObtained.Signature>
{
	public delegate void Signature(List<FAudioOutputDeviceInfo> AvailableDevices);

	private static bool OnAudioOutputDevicesObtained__DelegateSignature_IsValid;

	private static IntPtr OnAudioOutputDevicesObtained__DelegateSignature_FunctionAddress;

	private static int OnAudioOutputDevicesObtained__DelegateSignature_ParamsSize;

	private static bool OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_IsValid;

	private static FFieldAddress OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress;

	private static int OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioOutputDevicesObtained()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioOutputDevicesObtained__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnAudioOutputDevicesObtained__DelegateSignature");
		OnAudioOutputDevicesObtained__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioOutputDevicesObtained__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress, OnAudioOutputDevicesObtained__DelegateSignature_FunctionAddress, "AvailableDevices");
		OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioOutputDevicesObtained__DelegateSignature_FunctionAddress, "AvailableDevices");
		OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioOutputDevicesObtained__DelegateSignature_FunctionAddress, "AvailableDevices", Classes.FArrayProperty);
		OnAudioOutputDevicesObtained__DelegateSignature_IsValid = OnAudioOutputDevicesObtained__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnAudioOutputDevicesObtained__DelegateSignature", OnAudioOutputDevicesObtained__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FAudioOutputDeviceInfo> AvailableDevices)
	{
		if (!OnAudioOutputDevicesObtained__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnAudioOutputDevicesObtained__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioOutputDevicesObtained__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioOutputDevicesObtained__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FAudioOutputDeviceInfo>(1, OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress, CachedMarshalingDelegates<FAudioOutputDeviceInfo, FAudioOutputDeviceInfo>.FromNative, CachedMarshalingDelegates<FAudioOutputDeviceInfo, FAudioOutputDeviceInfo>.ToNative).ToNative(IntPtr.Add(intPtr, OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_Offset), AvailableDevices);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnAudioOutputDevicesObtained__DelegateSignature_AvailableDevices_PropertyAddress.Address, intPtr);
		}
	}
}
