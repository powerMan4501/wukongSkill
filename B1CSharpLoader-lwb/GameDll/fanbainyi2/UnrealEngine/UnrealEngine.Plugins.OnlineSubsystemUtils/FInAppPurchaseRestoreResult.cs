using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.OnlineSubsystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult__DelegateSignature")]
public class FInAppPurchaseRestoreResult : FMulticastDelegate<FInAppPurchaseRestoreResult.Signature>
{
	public delegate void Signature(EInAppPurchaseState CompletionStatus, List<FInAppPurchaseRestoreInfo> InAppRestorePurchaseInformation);

	private static bool InAppPurchaseRestoreResult__DelegateSignature_IsValid;

	private static IntPtr InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress;

	private static int InAppPurchaseRestoreResult__DelegateSignature_ParamsSize;

	private static bool InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_IsValid;

	private static FFieldAddress InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_PropertyAddress;

	private static int InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_Offset;

	private static bool InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_IsValid;

	private static FFieldAddress InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_PropertyAddress;

	private static int InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInAppPurchaseRestoreResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult__DelegateSignature");
		InAppPurchaseRestoreResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_PropertyAddress, InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress, "CompletionStatus");
		InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress, "CompletionStatus");
		InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress, "CompletionStatus", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_PropertyAddress, InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress, "InAppRestorePurchaseInformation");
		InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress, "InAppRestorePurchaseInformation");
		InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress, "InAppRestorePurchaseInformation", Classes.FArrayProperty);
		InAppPurchaseRestoreResult__DelegateSignature_IsValid = InAppPurchaseRestoreResult__DelegateSignature_FunctionAddress != IntPtr.Zero && InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_IsValid && InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult__DelegateSignature", InAppPurchaseRestoreResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EInAppPurchaseState CompletionStatus, List<FInAppPurchaseRestoreInfo> InAppRestorePurchaseInformation)
	{
		if (!InAppPurchaseRestoreResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InAppPurchaseRestoreResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InAppPurchaseRestoreResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EInAppPurchaseState>.ToNative(IntPtr.Add(intPtr, InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_Offset), 0, InAppPurchaseRestoreResult__DelegateSignature_CompletionStatus_PropertyAddress.Address, CompletionStatus);
			new TArrayCopyMarshaler<FInAppPurchaseRestoreInfo>(1, InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_PropertyAddress, CachedMarshalingDelegates<FInAppPurchaseRestoreInfo, FInAppPurchaseRestoreInfo>.FromNative, CachedMarshalingDelegates<FInAppPurchaseRestoreInfo, FInAppPurchaseRestoreInfo>.ToNative).ToNative(IntPtr.Add(intPtr, InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_Offset), InAppRestorePurchaseInformation);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InAppPurchaseRestoreResult__DelegateSignature_InAppRestorePurchaseInformation_PropertyAddress.Address, intPtr);
		}
	}
}
