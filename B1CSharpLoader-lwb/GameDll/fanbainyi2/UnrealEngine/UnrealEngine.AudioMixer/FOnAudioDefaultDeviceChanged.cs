using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnAudioDefaultDeviceChanged__DelegateSignature")]
public class FOnAudioDefaultDeviceChanged : FMulticastDelegate<FOnAudioDefaultDeviceChanged.Signature>
{
	public delegate void Signature(EAudioDeviceChangedRole AudioDeviceRole, string DeviceId);

	private static bool OnAudioDefaultDeviceChanged__DelegateSignature_IsValid;

	private static IntPtr OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress;

	private static int OnAudioDefaultDeviceChanged__DelegateSignature_ParamsSize;

	private static bool OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_IsValid;

	private static FFieldAddress OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_PropertyAddress;

	private static int OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_Offset;

	private static bool OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_IsValid;

	private static FFieldAddress OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_PropertyAddress;

	private static int OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioDefaultDeviceChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnAudioDefaultDeviceChanged__DelegateSignature");
		OnAudioDefaultDeviceChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_PropertyAddress, OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress, "AudioDeviceRole");
		OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress, "AudioDeviceRole");
		OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress, "AudioDeviceRole", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_PropertyAddress, OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress, "DeviceId");
		OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress, "DeviceId");
		OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress, "DeviceId", Classes.FStrProperty);
		OnAudioDefaultDeviceChanged__DelegateSignature_IsValid = OnAudioDefaultDeviceChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_IsValid && OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnAudioDefaultDeviceChanged__DelegateSignature", OnAudioDefaultDeviceChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EAudioDeviceChangedRole AudioDeviceRole, string DeviceId)
	{
		if (!OnAudioDefaultDeviceChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnAudioDefaultDeviceChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioDefaultDeviceChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioDefaultDeviceChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EAudioDeviceChangedRole>.ToNative(IntPtr.Add(intPtr, OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_Offset), 0, OnAudioDefaultDeviceChanged__DelegateSignature_AudioDeviceRole_PropertyAddress.Address, AudioDeviceRole);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_Offset), 0, OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_PropertyAddress.Address, DeviceId);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnAudioDefaultDeviceChanged__DelegateSignature_DeviceId_PropertyAddress.Address, intPtr);
		}
	}
}
