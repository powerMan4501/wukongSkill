using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UDelegate]
[UMetaPath("/Script/b1.BGUOnMontagePlayDelegate__DelegateSignature")]
public class FBGUOnMontagePlayDelegate : FMulticastDelegate<FBGUOnMontagePlayDelegate.Signature>
{
	public delegate void Signature(int ReqIdx, UAnimInstance AnimInstance, UAnimMontage Montage);

	private static bool BGUOnMontagePlayDelegate__DelegateSignature_IsValid;

	private static IntPtr BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress;

	private static int BGUOnMontagePlayDelegate__DelegateSignature_ParamsSize;

	private static bool BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_IsValid;

	private static FFieldAddress BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_PropertyAddress;

	private static int BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_Offset;

	private static bool BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_IsValid;

	private static FFieldAddress BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_PropertyAddress;

	private static int BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_Offset;

	private static bool BGUOnMontagePlayDelegate__DelegateSignature_Montage_IsValid;

	private static FFieldAddress BGUOnMontagePlayDelegate__DelegateSignature_Montage_PropertyAddress;

	private static int BGUOnMontagePlayDelegate__DelegateSignature_Montage_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FBGUOnMontagePlayDelegate()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/b1.BGUOnMontagePlayDelegate__DelegateSignature");
		BGUOnMontagePlayDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_PropertyAddress, BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "ReqIdx");
		BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_Offset = NativeReflectionCached.GetPropertyOffset(BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "ReqIdx");
		BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "ReqIdx", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_PropertyAddress, BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "AnimInstance");
		BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_Offset = NativeReflectionCached.GetPropertyOffset(BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "AnimInstance");
		BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "AnimInstance", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref BGUOnMontagePlayDelegate__DelegateSignature_Montage_PropertyAddress, BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "Montage");
		BGUOnMontagePlayDelegate__DelegateSignature_Montage_Offset = NativeReflectionCached.GetPropertyOffset(BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "Montage");
		BGUOnMontagePlayDelegate__DelegateSignature_Montage_IsValid = NativeReflectionCached.ValidatePropertyClass(BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress, "Montage", Classes.FObjectProperty);
		BGUOnMontagePlayDelegate__DelegateSignature_IsValid = BGUOnMontagePlayDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_IsValid && BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_IsValid && BGUOnMontagePlayDelegate__DelegateSignature_Montage_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGUOnMontagePlayDelegate__DelegateSignature", BGUOnMontagePlayDelegate__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(int ReqIdx, UAnimInstance AnimInstance, UAnimMontage Montage)
	{
		if (!BGUOnMontagePlayDelegate__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGUOnMontagePlayDelegate__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(BGUOnMontagePlayDelegate__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGUOnMontagePlayDelegate__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_Offset), 0, BGUOnMontagePlayDelegate__DelegateSignature_ReqIdx_PropertyAddress.Address, ReqIdx);
			UObjectMarshaler<UAnimInstance>.ToNative(IntPtr.Add(intPtr, BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_Offset), 0, BGUOnMontagePlayDelegate__DelegateSignature_AnimInstance_PropertyAddress.Address, AnimInstance);
			UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(intPtr, BGUOnMontagePlayDelegate__DelegateSignature_Montage_Offset), 0, BGUOnMontagePlayDelegate__DelegateSignature_Montage_PropertyAddress.Address, Montage);
			ProcessDelegate(intPtr);
		}
	}
}
