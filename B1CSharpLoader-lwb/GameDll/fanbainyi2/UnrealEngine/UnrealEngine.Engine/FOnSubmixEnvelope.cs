using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnSubmixEnvelope__DelegateSignature")]
public class FOnSubmixEnvelope : FMulticastDelegate<FOnSubmixEnvelope.Signature>
{
	public delegate void Signature(List<float> Envelope);

	private static bool OnSubmixEnvelope__DelegateSignature_IsValid;

	private static IntPtr OnSubmixEnvelope__DelegateSignature_FunctionAddress;

	private static int OnSubmixEnvelope__DelegateSignature_ParamsSize;

	private static bool OnSubmixEnvelope__DelegateSignature_Envelope_IsValid;

	private static FFieldAddress OnSubmixEnvelope__DelegateSignature_Envelope_PropertyAddress;

	private static int OnSubmixEnvelope__DelegateSignature_Envelope_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSubmixEnvelope()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSubmixEnvelope__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnSubmixEnvelope__DelegateSignature");
		OnSubmixEnvelope__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSubmixEnvelope__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSubmixEnvelope__DelegateSignature_Envelope_PropertyAddress, OnSubmixEnvelope__DelegateSignature_FunctionAddress, "Envelope");
		OnSubmixEnvelope__DelegateSignature_Envelope_Offset = NativeReflectionCached.GetPropertyOffset(OnSubmixEnvelope__DelegateSignature_FunctionAddress, "Envelope");
		OnSubmixEnvelope__DelegateSignature_Envelope_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSubmixEnvelope__DelegateSignature_FunctionAddress, "Envelope", Classes.FArrayProperty);
		OnSubmixEnvelope__DelegateSignature_IsValid = OnSubmixEnvelope__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSubmixEnvelope__DelegateSignature_Envelope_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnSubmixEnvelope__DelegateSignature", OnSubmixEnvelope__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<float> Envelope)
	{
		if (!OnSubmixEnvelope__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnSubmixEnvelope__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSubmixEnvelope__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSubmixEnvelope__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<float>(1, OnSubmixEnvelope__DelegateSignature_Envelope_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, OnSubmixEnvelope__DelegateSignature_Envelope_Offset), Envelope);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnSubmixEnvelope__DelegateSignature_Envelope_PropertyAddress.Address, intPtr);
		}
	}
}
