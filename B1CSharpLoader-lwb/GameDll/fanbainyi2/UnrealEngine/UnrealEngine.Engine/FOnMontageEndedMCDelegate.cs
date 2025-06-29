using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature")]
public class FOnMontageEndedMCDelegate : FMulticastDelegate<FOnMontageEndedMCDelegate.Signature>
{
	public delegate void Signature(UAnimMontage Montage, bool bInterrupted);

	private static bool OnMontageEndedMCDelegate__DelegateSignature_IsValid;

	private static IntPtr OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress;

	private static int OnMontageEndedMCDelegate__DelegateSignature_ParamsSize;

	private static bool OnMontageEndedMCDelegate__DelegateSignature_Montage_IsValid;

	private static FFieldAddress OnMontageEndedMCDelegate__DelegateSignature_Montage_PropertyAddress;

	private static int OnMontageEndedMCDelegate__DelegateSignature_Montage_Offset;

	private static bool OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_IsValid;

	private static FFieldAddress OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_PropertyAddress;

	private static int OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMontageEndedMCDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature");
		OnMontageEndedMCDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMontageEndedMCDelegate__DelegateSignature_Montage_PropertyAddress, OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress, "Montage");
		OnMontageEndedMCDelegate__DelegateSignature_Montage_Offset = NativeReflectionCached.GetPropertyOffset(OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress, "Montage");
		OnMontageEndedMCDelegate__DelegateSignature_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_PropertyAddress, OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress, "bInterrupted");
		OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_Offset = NativeReflectionCached.GetPropertyOffset(OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress, "bInterrupted");
		OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress, "bInterrupted", Classes.FBoolProperty);
		OnMontageEndedMCDelegate__DelegateSignature_IsValid = OnMontageEndedMCDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMontageEndedMCDelegate__DelegateSignature_Montage_IsValid && OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature", OnMontageEndedMCDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UAnimMontage Montage, bool bInterrupted)
	{
		if (!OnMontageEndedMCDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnMontageEndedMCDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMontageEndedMCDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMontageEndedMCDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, OnMontageEndedMCDelegate__DelegateSignature_Montage_Offset), 0, OnMontageEndedMCDelegate__DelegateSignature_Montage_PropertyAddress.Address, Montage);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_Offset), 0, OnMontageEndedMCDelegate__DelegateSignature_bInterrupted_PropertyAddress.Address, bInterrupted);
			ProcessDelegate(intPtr);
		}
	}
}
