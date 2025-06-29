using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnSubmixEnvelopeBP__DelegateSignature")]
public class FOnSubmixEnvelopeBP : FDelegate<FOnSubmixEnvelopeBP.Signature>
{
	public delegate void Signature(List<float> Envelope);

	private static bool OnSubmixEnvelopeBP__DelegateSignature_IsValid;

	private static IntPtr OnSubmixEnvelopeBP__DelegateSignature_FunctionAddress;

	private static int OnSubmixEnvelopeBP__DelegateSignature_ParamsSize;

	private static bool OnSubmixEnvelopeBP__DelegateSignature_Envelope_IsValid;

	private static FFieldAddress OnSubmixEnvelopeBP__DelegateSignature_Envelope_PropertyAddress;

	private static int OnSubmixEnvelopeBP__DelegateSignature_Envelope_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnSubmixEnvelopeBP()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnSubmixEnvelopeBP__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnSubmixEnvelopeBP__DelegateSignature");
		OnSubmixEnvelopeBP__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnSubmixEnvelopeBP__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnSubmixEnvelopeBP__DelegateSignature_Envelope_PropertyAddress, OnSubmixEnvelopeBP__DelegateSignature_FunctionAddress, "Envelope");
		OnSubmixEnvelopeBP__DelegateSignature_Envelope_Offset = NativeReflectionCached.GetPropertyOffset(OnSubmixEnvelopeBP__DelegateSignature_FunctionAddress, "Envelope");
		OnSubmixEnvelopeBP__DelegateSignature_Envelope_IsValid = NativeReflectionCached.ValidatePropertyClass(OnSubmixEnvelopeBP__DelegateSignature_FunctionAddress, "Envelope", Classes.FArrayProperty);
		OnSubmixEnvelopeBP__DelegateSignature_IsValid = OnSubmixEnvelopeBP__DelegateSignature_FunctionAddress != IntPtr.Zero && OnSubmixEnvelopeBP__DelegateSignature_Envelope_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnSubmixEnvelopeBP__DelegateSignature", OnSubmixEnvelopeBP__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<float> Envelope)
	{
		if (!OnSubmixEnvelopeBP__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnSubmixEnvelopeBP__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnSubmixEnvelopeBP__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnSubmixEnvelopeBP__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<float>(1, OnSubmixEnvelopeBP__DelegateSignature_Envelope_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).ToNative(IntPtr.Add(intPtr, OnSubmixEnvelopeBP__DelegateSignature_Envelope_Offset), Envelope);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnSubmixEnvelopeBP__DelegateSignature_Envelope_PropertyAddress.Address, intPtr);
		}
	}
}
