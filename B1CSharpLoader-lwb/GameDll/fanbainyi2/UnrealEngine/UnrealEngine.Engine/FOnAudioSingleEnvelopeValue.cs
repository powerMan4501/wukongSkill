using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAudioSingleEnvelopeValue__DelegateSignature")]
public class FOnAudioSingleEnvelopeValue : FMulticastDelegate<FOnAudioSingleEnvelopeValue.Signature>
{
	public delegate void Signature(USoundWave PlayingSoundWave, float EnvelopeValue);

	private static bool OnAudioSingleEnvelopeValue__DelegateSignature_IsValid;

	private static IntPtr OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress;

	private static int OnAudioSingleEnvelopeValue__DelegateSignature_ParamsSize;

	private static bool OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_IsValid;

	private static FFieldAddress OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_PropertyAddress;

	private static int OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_Offset;

	private static bool OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_IsValid;

	private static FFieldAddress OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_PropertyAddress;

	private static int OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioSingleEnvelopeValue()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAudioSingleEnvelopeValue__DelegateSignature");
		OnAudioSingleEnvelopeValue__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_PropertyAddress, OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress, "PlayingSoundWave");
		OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress, "PlayingSoundWave");
		OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress, "PlayingSoundWave", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_PropertyAddress, OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress, "EnvelopeValue");
		OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress, "EnvelopeValue");
		OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress, "EnvelopeValue", Classes.FFloatProperty);
		OnAudioSingleEnvelopeValue__DelegateSignature_IsValid = OnAudioSingleEnvelopeValue__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_IsValid && OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAudioSingleEnvelopeValue__DelegateSignature", OnAudioSingleEnvelopeValue__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(USoundWave PlayingSoundWave, float EnvelopeValue)
	{
		if (!OnAudioSingleEnvelopeValue__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAudioSingleEnvelopeValue__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioSingleEnvelopeValue__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioSingleEnvelopeValue__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<USoundWave>.ToNative(IntPtr.Add(intPtr, OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_Offset), 0, OnAudioSingleEnvelopeValue__DelegateSignature_PlayingSoundWave_PropertyAddress.Address, PlayingSoundWave);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_Offset), 0, OnAudioSingleEnvelopeValue__DelegateSignature_EnvelopeValue_PropertyAddress.Address, EnvelopeValue);
			ProcessDelegate(intPtr);
		}
	}
}
