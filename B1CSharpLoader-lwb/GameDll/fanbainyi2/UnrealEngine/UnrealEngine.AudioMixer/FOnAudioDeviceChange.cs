using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnAudioDeviceChange__DelegateSignature")]
public class FOnAudioDeviceChange : FMulticastDelegate<FOnAudioDeviceChange.Signature>
{
	public delegate void Signature(string DeviceId);

	private static bool OnAudioDeviceChange__DelegateSignature_IsValid;

	private static IntPtr OnAudioDeviceChange__DelegateSignature_FunctionAddress;

	private static int OnAudioDeviceChange__DelegateSignature_ParamsSize;

	private static bool OnAudioDeviceChange__DelegateSignature_DeviceId_IsValid;

	private static FFieldAddress OnAudioDeviceChange__DelegateSignature_DeviceId_PropertyAddress;

	private static int OnAudioDeviceChange__DelegateSignature_DeviceId_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioDeviceChange()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioDeviceChange__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnAudioDeviceChange__DelegateSignature");
		OnAudioDeviceChange__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioDeviceChange__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioDeviceChange__DelegateSignature_DeviceId_PropertyAddress, OnAudioDeviceChange__DelegateSignature_FunctionAddress, "DeviceId");
		OnAudioDeviceChange__DelegateSignature_DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioDeviceChange__DelegateSignature_FunctionAddress, "DeviceId");
		OnAudioDeviceChange__DelegateSignature_DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioDeviceChange__DelegateSignature_FunctionAddress, "DeviceId", Classes.FStrProperty);
		OnAudioDeviceChange__DelegateSignature_IsValid = OnAudioDeviceChange__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioDeviceChange__DelegateSignature_DeviceId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnAudioDeviceChange__DelegateSignature", OnAudioDeviceChange__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string DeviceId)
	{
		if (!OnAudioDeviceChange__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnAudioDeviceChange__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioDeviceChange__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioDeviceChange__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnAudioDeviceChange__DelegateSignature_DeviceId_Offset), 0, OnAudioDeviceChange__DelegateSignature_DeviceId_PropertyAddress.Address, DeviceId);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnAudioDeviceChange__DelegateSignature_DeviceId_PropertyAddress.Address, intPtr);
		}
	}
}
