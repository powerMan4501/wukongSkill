using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UDelegate]
[UMetaPath("/Script/AkAudio.OnAkBankCallback__DelegateSignature")]
public class FOnAkBankCallback : FDelegate<FOnAkBankCallback.Signature>
{
	public delegate void Signature(EAkResult Result);

	private static bool OnAkBankCallback__DelegateSignature_IsValid;

	private static IntPtr OnAkBankCallback__DelegateSignature_FunctionAddress;

	private static int OnAkBankCallback__DelegateSignature_ParamsSize;

	private static bool OnAkBankCallback__DelegateSignature_Result_IsValid;

	private static FFieldAddress OnAkBankCallback__DelegateSignature_Result_PropertyAddress;

	private static int OnAkBankCallback__DelegateSignature_Result_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnAkBankCallback()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnAkBankCallback__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/AkAudio.OnAkBankCallback__DelegateSignature");
		OnAkBankCallback__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAkBankCallback__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnAkBankCallback__DelegateSignature_Result_PropertyAddress, OnAkBankCallback__DelegateSignature_FunctionAddress, "Result");
		OnAkBankCallback__DelegateSignature_Result_Offset = NativeReflectionCached.GetPropertyOffset(OnAkBankCallback__DelegateSignature_FunctionAddress, "Result");
		OnAkBankCallback__DelegateSignature_Result_IsValid = NativeReflectionCached.ValidatePropertyClass(OnAkBankCallback__DelegateSignature_FunctionAddress, "Result", Classes.FEnumProperty);
		OnAkBankCallback__DelegateSignature_IsValid = OnAkBankCallback__DelegateSignature_FunctionAddress != IntPtr.Zero && OnAkBankCallback__DelegateSignature_Result_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AkAudio.OnAkBankCallback__DelegateSignature", OnAkBankCallback__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EAkResult Result)
	{
		if (!OnAkBankCallback__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AkAudio.OnAkBankCallback__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnAkBankCallback__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAkBankCallback__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EAkResult>.ToNative(IntPtr.Add(intPtr, OnAkBankCallback__DelegateSignature_Result_Offset), 0, OnAkBankCallback__DelegateSignature_Result_PropertyAddress.Address, Result);
			ProcessDelegate(intPtr);
		}
	}
}
