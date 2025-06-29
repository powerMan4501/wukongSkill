using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UDelegate]
[UMetaPath("/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature")]
public class FOnMontageBlendingOutStartedMCDelegate : FMulticastDelegate<FOnMontageBlendingOutStartedMCDelegate.Signature>
{
	public delegate void Signature(UAnimMontage Montage, bool bInterrupted);

	private static bool OnMontageBlendingOutStartedMCDelegate__DelegateSignature_IsValid;

	private static IntPtr OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress;

	private static int OnMontageBlendingOutStartedMCDelegate__DelegateSignature_ParamsSize;

	private static bool OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_IsValid;

	private static FFieldAddress OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_PropertyAddress;

	private static int OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_Offset;

	private static bool OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_IsValid;

	private static FFieldAddress OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_PropertyAddress;

	private static int OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnMontageBlendingOutStartedMCDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature");
		OnMontageBlendingOutStartedMCDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_PropertyAddress, OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress, "Montage");
		OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_Offset = NativeReflectionCached.GetPropertyOffset(OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress, "Montage");
		OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress, "Montage", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_PropertyAddress, OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress, "bInterrupted");
		OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_Offset = NativeReflectionCached.GetPropertyOffset(OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress, "bInterrupted");
		OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_IsValid = NativeReflectionCached.ValidatePropertyClass(OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress, "bInterrupted", Classes.FBoolProperty);
		OnMontageBlendingOutStartedMCDelegate__DelegateSignature_IsValid = OnMontageBlendingOutStartedMCDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_IsValid && OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature", OnMontageBlendingOutStartedMCDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UAnimMontage Montage, bool bInterrupted)
	{
		if (!OnMontageBlendingOutStartedMCDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.OnMontageBlendingOutStartedMCDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnMontageBlendingOutStartedMCDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnMontageBlendingOutStartedMCDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_Offset), 0, OnMontageBlendingOutStartedMCDelegate__DelegateSignature_Montage_PropertyAddress.Address, Montage);
			BoolMarshaler.ToNative(IntPtr.Add(intPtr, OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_Offset), 0, OnMontageBlendingOutStartedMCDelegate__DelegateSignature_bInterrupted_PropertyAddress.Address, bInterrupted);
			ProcessDelegate(intPtr);
		}
	}
}
