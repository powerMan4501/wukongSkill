using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnMainAudioOutputDeviceObtained__DelegateSignature")]
public class FOnMainAudioOutputDeviceObtained : FDelegate<FOnMainAudioOutputDeviceObtained.Signature>
{
	public delegate void Signature(string CurrentDevice);

	private static bool OnMainAudioOutputDeviceObtained__DelegateSignature_IsValid;

	private static IntPtr OnMainAudioOutputDeviceObtained__DelegateSignature_FunctionAddress;

	private static int OnMainAudioOutputDeviceObtained__DelegateSignature_ParamsSize;

	private static bool OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_IsValid;

	private static FFieldAddress OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_PropertyAddress;

	private static int OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMainAudioOutputDeviceObtained()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMainAudioOutputDeviceObtained__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnMainAudioOutputDeviceObtained__DelegateSignature");
		OnMainAudioOutputDeviceObtained__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMainAudioOutputDeviceObtained__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_PropertyAddress, OnMainAudioOutputDeviceObtained__DelegateSignature_FunctionAddress, "CurrentDevice");
		OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_Offset = NativeReflectionCached.GetPropertyOffset(OnMainAudioOutputDeviceObtained__DelegateSignature_FunctionAddress, "CurrentDevice");
		OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMainAudioOutputDeviceObtained__DelegateSignature_FunctionAddress, "CurrentDevice", Classes.FStrProperty);
		OnMainAudioOutputDeviceObtained__DelegateSignature_IsValid = OnMainAudioOutputDeviceObtained__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnMainAudioOutputDeviceObtained__DelegateSignature", OnMainAudioOutputDeviceObtained__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(string CurrentDevice)
	{
		if (!OnMainAudioOutputDeviceObtained__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnMainAudioOutputDeviceObtained__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMainAudioOutputDeviceObtained__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMainAudioOutputDeviceObtained__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			FStringMarshaler.ToNative(IntPtr.Add(intPtr, OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_Offset), 0, OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_PropertyAddress.Address, CurrentDevice);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnMainAudioOutputDeviceObtained__DelegateSignature_CurrentDevice_PropertyAddress.Address, intPtr);
		}
	}
}
