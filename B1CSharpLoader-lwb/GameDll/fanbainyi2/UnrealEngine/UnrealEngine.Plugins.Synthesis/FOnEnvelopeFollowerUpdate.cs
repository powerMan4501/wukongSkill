using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Synthesis;

[UDelegate]
[UMetaPath("/Script/Synthesis.OnEnvelopeFollowerUpdate__DelegateSignature")]
public class FOnEnvelopeFollowerUpdate : FMulticastDelegate<FOnEnvelopeFollowerUpdate.Signature>
{
	public delegate void Signature(float EnvelopeValue);

	private static bool OnEnvelopeFollowerUpdate__DelegateSignature_IsValid;

	private static IntPtr OnEnvelopeFollowerUpdate__DelegateSignature_FunctionAddress;

	private static int OnEnvelopeFollowerUpdate__DelegateSignature_ParamsSize;

	private static bool OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_IsValid;

	private static FFieldAddress OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_PropertyAddress;

	private static int OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnEnvelopeFollowerUpdate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnEnvelopeFollowerUpdate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Synthesis.OnEnvelopeFollowerUpdate__DelegateSignature");
		OnEnvelopeFollowerUpdate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnEnvelopeFollowerUpdate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_PropertyAddress, OnEnvelopeFollowerUpdate__DelegateSignature_FunctionAddress, "EnvelopeValue");
		OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_Offset = NativeReflectionCached.GetPropertyOffset(OnEnvelopeFollowerUpdate__DelegateSignature_FunctionAddress, "EnvelopeValue");
		OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OnEnvelopeFollowerUpdate__DelegateSignature_FunctionAddress, "EnvelopeValue", Classes.FFloatProperty);
		OnEnvelopeFollowerUpdate__DelegateSignature_IsValid = OnEnvelopeFollowerUpdate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Synthesis.OnEnvelopeFollowerUpdate__DelegateSignature", OnEnvelopeFollowerUpdate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(float EnvelopeValue)
	{
		if (!OnEnvelopeFollowerUpdate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Synthesis.OnEnvelopeFollowerUpdate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnEnvelopeFollowerUpdate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnEnvelopeFollowerUpdate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_Offset), 0, OnEnvelopeFollowerUpdate__DelegateSignature_EnvelopeValue_PropertyAddress.Address, EnvelopeValue);
			ProcessDelegate(intPtr);
		}
	}
}
