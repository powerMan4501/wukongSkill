using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnAudioMultiEnvelopeValue__DelegateSignature")]
public class FOnAudioMultiEnvelopeValue : FMulticastDelegate<FOnAudioMultiEnvelopeValue.Signature>
{
	public delegate void Signature(float AverageEnvelopeValue, float MaxEnvelope, int NumWaveInstances);

	private static bool OnAudioMultiEnvelopeValue__DelegateSignature_IsValid;

	private static IntPtr OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress;

	private static int OnAudioMultiEnvelopeValue__DelegateSignature_ParamsSize;

	private static bool OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_IsValid;

	private static FFieldAddress OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_PropertyAddress;

	private static int OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_Offset;

	private static bool OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_IsValid;

	private static FFieldAddress OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_PropertyAddress;

	private static int OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_Offset;

	private static bool OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_IsValid;

	private static FFieldAddress OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_PropertyAddress;

	private static int OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAudioMultiEnvelopeValue()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnAudioMultiEnvelopeValue__DelegateSignature");
		OnAudioMultiEnvelopeValue__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_PropertyAddress, OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "AverageEnvelopeValue");
		OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "AverageEnvelopeValue");
		OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "AverageEnvelopeValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_PropertyAddress, OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "MaxEnvelope");
		OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "MaxEnvelope");
		OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "MaxEnvelope", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_PropertyAddress, OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "NumWaveInstances");
		OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_Offset = NativeReflectionCached.GetPropertyOffset(OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "NumWaveInstances");
		OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress, "NumWaveInstances", Classes.FIntProperty);
		OnAudioMultiEnvelopeValue__DelegateSignature_IsValid = OnAudioMultiEnvelopeValue__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_IsValid && OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_IsValid && OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnAudioMultiEnvelopeValue__DelegateSignature", OnAudioMultiEnvelopeValue__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float AverageEnvelopeValue, float MaxEnvelope, int NumWaveInstances)
	{
		if (!OnAudioMultiEnvelopeValue__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnAudioMultiEnvelopeValue__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAudioMultiEnvelopeValue__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAudioMultiEnvelopeValue__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_Offset), 0, OnAudioMultiEnvelopeValue__DelegateSignature_AverageEnvelopeValue_PropertyAddress.Address, AverageEnvelopeValue);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_Offset), 0, OnAudioMultiEnvelopeValue__DelegateSignature_MaxEnvelope_PropertyAddress.Address, MaxEnvelope);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_Offset), 0, OnAudioMultiEnvelopeValue__DelegateSignature_NumWaveInstances_PropertyAddress.Address, NumWaveInstances);
			ProcessDelegate(intPtr);
		}
	}
}
