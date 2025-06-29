using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseResult2__DelegateSignature")]
public class FInAppPurchaseResult2 : FMulticastDelegate<FInAppPurchaseResult2.Signature>
{
	public delegate void Signature(EInAppPurchaseStatus PurchaseStatus, List<FInAppPurchaseReceiptInfo2> InAppPurchaseReceipts);

	private static bool InAppPurchaseResult2__DelegateSignature_IsValid;

	private static IntPtr InAppPurchaseResult2__DelegateSignature_FunctionAddress;

	private static int InAppPurchaseResult2__DelegateSignature_ParamsSize;

	private static bool InAppPurchaseResult2__DelegateSignature_PurchaseStatus_IsValid;

	private static FFieldAddress InAppPurchaseResult2__DelegateSignature_PurchaseStatus_PropertyAddress;

	private static int InAppPurchaseResult2__DelegateSignature_PurchaseStatus_Offset;

	private static bool InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_IsValid;

	private static FFieldAddress InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_PropertyAddress;

	private static int InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInAppPurchaseResult2()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InAppPurchaseResult2__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.InAppPurchaseResult2__DelegateSignature");
		InAppPurchaseResult2__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InAppPurchaseResult2__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseResult2__DelegateSignature_PurchaseStatus_PropertyAddress, InAppPurchaseResult2__DelegateSignature_FunctionAddress, "PurchaseStatus");
		InAppPurchaseResult2__DelegateSignature_PurchaseStatus_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseResult2__DelegateSignature_FunctionAddress, "PurchaseStatus");
		InAppPurchaseResult2__DelegateSignature_PurchaseStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseResult2__DelegateSignature_FunctionAddress, "PurchaseStatus", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_PropertyAddress, InAppPurchaseResult2__DelegateSignature_FunctionAddress, "InAppPurchaseReceipts");
		InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseResult2__DelegateSignature_FunctionAddress, "InAppPurchaseReceipts");
		InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseResult2__DelegateSignature_FunctionAddress, "InAppPurchaseReceipts", Classes.FArrayProperty);
		InAppPurchaseResult2__DelegateSignature_IsValid = InAppPurchaseResult2__DelegateSignature_FunctionAddress != IntPtr.Zero && InAppPurchaseResult2__DelegateSignature_PurchaseStatus_IsValid && InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseResult2__DelegateSignature", InAppPurchaseResult2__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EInAppPurchaseStatus PurchaseStatus, List<FInAppPurchaseReceiptInfo2> InAppPurchaseReceipts)
	{
		if (!InAppPurchaseResult2__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseResult2__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InAppPurchaseResult2__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InAppPurchaseResult2__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EInAppPurchaseStatus>.ToNative(IntPtr.Add(intPtr, InAppPurchaseResult2__DelegateSignature_PurchaseStatus_Offset), 0, InAppPurchaseResult2__DelegateSignature_PurchaseStatus_PropertyAddress.Address, PurchaseStatus);
			new TArrayCopyMarshaler<FInAppPurchaseReceiptInfo2>(1, InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_PropertyAddress, CachedMarshalingDelegates<FInAppPurchaseReceiptInfo2, FInAppPurchaseReceiptInfo2>.FromNative, CachedMarshalingDelegates<FInAppPurchaseReceiptInfo2, FInAppPurchaseReceiptInfo2>.ToNative).ToNative(IntPtr.Add(intPtr, InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_Offset), InAppPurchaseReceipts);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InAppPurchaseResult2__DelegateSignature_InAppPurchaseReceipts_PropertyAddress.Address, intPtr);
		}
	}
}
