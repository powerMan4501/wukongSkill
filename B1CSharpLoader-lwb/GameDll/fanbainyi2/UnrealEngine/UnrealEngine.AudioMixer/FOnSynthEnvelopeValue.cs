using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.AudioMixer;

[UDelegate]
[UMetaPath("/Script/AudioMixer.OnSynthEnvelopeValue__DelegateSignature")]
public class FOnSynthEnvelopeValue : FMulticastDelegate<FOnSynthEnvelopeValue.Signature>
{
	public delegate void Signature(float EnvelopeValue);

	private static bool OnSynthEnvelopeValue__DelegateSignature_IsValid;

	private static IntPtr OnSynthEnvelopeValue__DelegateSignature_FunctionAddress;

	private static int OnSynthEnvelopeValue__DelegateSignature_ParamsSize;

	private static bool OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_IsValid;

	private static FFieldAddress OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_PropertyAddress;

	private static int OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSynthEnvelopeValue()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSynthEnvelopeValue__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AudioMixer.OnSynthEnvelopeValue__DelegateSignature");
		OnSynthEnvelopeValue__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSynthEnvelopeValue__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_PropertyAddress, OnSynthEnvelopeValue__DelegateSignature_FunctionAddress, "EnvelopeValue");
		OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_Offset = NativeReflectionCached.GetPropertyOffset(OnSynthEnvelopeValue__DelegateSignature_FunctionAddress, "EnvelopeValue");
		OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSynthEnvelopeValue__DelegateSignature_FunctionAddress, "EnvelopeValue", Classes.FFloatProperty);
		OnSynthEnvelopeValue__DelegateSignature_IsValid = OnSynthEnvelopeValue__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AudioMixer.OnSynthEnvelopeValue__DelegateSignature", OnSynthEnvelopeValue__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float EnvelopeValue)
	{
		if (!OnSynthEnvelopeValue__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AudioMixer.OnSynthEnvelopeValue__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSynthEnvelopeValue__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSynthEnvelopeValue__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_Offset), 0, OnSynthEnvelopeValue__DelegateSignature_EnvelopeValue_PropertyAddress.Address, EnvelopeValue);
			ProcessDelegate(intPtr);
		}
	}
}
