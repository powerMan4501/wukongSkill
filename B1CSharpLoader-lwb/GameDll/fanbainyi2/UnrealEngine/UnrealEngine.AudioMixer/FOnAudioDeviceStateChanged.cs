using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnAudioDeviceStateChanged__DelegateSignature")]
public class FOnAudioDeviceStateChanged : FMulticastDelegate<FOnAudioDeviceStateChanged.Signature>
{
	public delegate void Signature(string DeviceId, EAudioDeviceChangedState NewState);

	private static bool OnAudioDeviceStateChanged__DelegateSignature_IsValid;

	private static IntPtr OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress;

	private static int OnAudioDeviceStateChanged__DelegateSignature_ParamsSize;

	private static bool OnAudioDeviceStateChanged__DelegateSignature_DeviceId_IsValid;

	private static FFieldAddress OnAudioDeviceStateChanged__DelegateSignature_DeviceId_PropertyAddress;

	private static int OnAudioDeviceStateChanged__DelegateSignature_DeviceId_Offset;

	private static bool OnAudioDeviceStateChanged__DelegateSignature_NewState_IsValid;

	private static FFieldAddress OnAudioDeviceStateChanged__DelegateSignature_NewState_PropertyAddress;

	private static int OnAudioDeviceStateChanged__DelegateSignature_NewState_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioDeviceStateChanged()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnAudioDeviceStateChanged__DelegateSignature");
		OnAudioDeviceStateChanged__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioDeviceStateChanged__DelegateSignature_DeviceId_PropertyAddress, OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress, "DeviceId");
		OnAudioDeviceStateChanged__DelegateSignature_DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress, "DeviceId");
		OnAudioDeviceStateChanged__DelegateSignature_DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress, "DeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAudioDeviceStateChanged__DelegateSignature_NewState_PropertyAddress, OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress, "NewState");
		OnAudioDeviceStateChanged__DelegateSignature_NewState_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress, "NewState");
		OnAudioDeviceStateChanged__DelegateSignature_NewState_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress, "NewState", Classes.FEnumProperty);
		OnAudioDeviceStateChanged__DelegateSignature_IsValid = OnAudioDeviceStateChanged__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioDeviceStateChanged__DelegateSignature_DeviceId_IsValid && OnAudioDeviceStateChanged__DelegateSignature_NewState_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnAudioDeviceStateChanged__DelegateSignature", OnAudioDeviceStateChanged__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string DeviceId, EAudioDeviceChangedState NewState)
	{
		if (!OnAudioDeviceStateChanged__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnAudioDeviceStateChanged__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioDeviceStateChanged__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioDeviceStateChanged__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnAudioDeviceStateChanged__DelegateSignature_DeviceId_Offset), 0, OnAudioDeviceStateChanged__DelegateSignature_DeviceId_PropertyAddress.Address, DeviceId);
			EnumMarshaler<EAudioDeviceChangedState>.ToNative(IntPtr.Add(intPtr, OnAudioDeviceStateChanged__DelegateSignature_NewState_Offset), 0, OnAudioDeviceStateChanged__DelegateSignature_NewState_PropertyAddress.Address, NewState);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnAudioDeviceStateChanged__DelegateSignature_DeviceId_PropertyAddress.Address, intPtr);
		}
	}
}
