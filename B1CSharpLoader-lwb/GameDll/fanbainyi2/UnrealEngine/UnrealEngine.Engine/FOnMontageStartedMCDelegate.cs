using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature")]
public class FOnMontageStartedMCDelegate : FMulticastDelegate<FOnMontageStartedMCDelegate.Signature>
{
	public delegate void Signature(UAnimMontage Montage);

	private static bool OnMontageStartedMCDelegate__DelegateSignature_IsValid;

	private static IntPtr OnMontageStartedMCDelegate__DelegateSignature_FunctionAddress;

	private static int OnMontageStartedMCDelegate__DelegateSignature_ParamsSize;

	private static bool OnMontageStartedMCDelegate__DelegateSignature_Montage_IsValid;

	private static FFieldAddress OnMontageStartedMCDelegate__DelegateSignature_Montage_PropertyAddress;

	private static int OnMontageStartedMCDelegate__DelegateSignature_Montage_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMontageStartedMCDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMontageStartedMCDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature");
		OnMontageStartedMCDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMontageStartedMCDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMontageStartedMCDelegate__DelegateSignature_Montage_PropertyAddress, OnMontageStartedMCDelegate__DelegateSignature_FunctionAddress, "Montage");
		OnMontageStartedMCDelegate__DelegateSignature_Montage_Offset = NativeReflectionCached.GetPropertyOffset(OnMontageStartedMCDelegate__DelegateSignature_FunctionAddress, "Montage");
		OnMontageStartedMCDelegate__DelegateSignature_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMontageStartedMCDelegate__DelegateSignature_FunctionAddress, "Montage", Classes.FObjectProperty);
		OnMontageStartedMCDelegate__DelegateSignature_IsValid = OnMontageStartedMCDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMontageStartedMCDelegate__DelegateSignature_Montage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature", OnMontageStartedMCDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UAnimMontage Montage)
	{
		if (!OnMontageStartedMCDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnMontageStartedMCDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMontageStartedMCDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMontageStartedMCDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, OnMontageStartedMCDelegate__DelegateSignature_Montage_Offset), 0, OnMontageStartedMCDelegate__DelegateSignature_Montage_PropertyAddress.Address, Montage);
			ProcessDelegate(intPtr);
		}
	}
}
