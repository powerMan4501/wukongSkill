using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature")]
public class FOnSetCurrentAudioCultureCallback : FDelegate<FOnSetCurrentAudioCultureCallback.Signature>
{
	public delegate void Signature(bool Succeeded);

	private static bool OnSetCurrentAudioCultureCallback__DelegateSignature_IsValid;

	private static IntPtr OnSetCurrentAudioCultureCallback__DelegateSignature_FunctionAddress;

	private static int OnSetCurrentAudioCultureCallback__DelegateSignature_ParamsSize;

	private static bool OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_IsValid;

	private static FFieldAddress OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_PropertyAddress;

	private static int OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSetCurrentAudioCultureCallback()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSetCurrentAudioCultureCallback__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature");
		OnSetCurrentAudioCultureCallback__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSetCurrentAudioCultureCallback__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_PropertyAddress, OnSetCurrentAudioCultureCallback__DelegateSignature_FunctionAddress, "Succeeded");
		OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_Offset = NativeReflectionCached.GetPropertyOffset(OnSetCurrentAudioCultureCallback__DelegateSignature_FunctionAddress, "Succeeded");
		OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSetCurrentAudioCultureCallback__DelegateSignature_FunctionAddress, "Succeeded", Classes.FBoolProperty);
		OnSetCurrentAudioCultureCallback__DelegateSignature_IsValid = OnSetCurrentAudioCultureCallback__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature", OnSetCurrentAudioCultureCallback__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(bool Succeeded)
	{
		if (!OnSetCurrentAudioCultureCallback__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnSetCurrentAudioCultureCallback__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSetCurrentAudioCultureCallback__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSetCurrentAudioCultureCallback__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_Offset), 0, OnSetCurrentAudioCultureCallback__DelegateSignature_Succeeded_PropertyAddress.Address, Succeeded);
			ProcessDelegate(intPtr);
		}
	}
}
