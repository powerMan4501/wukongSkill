using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.OnlineSubsystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseResult__DelegateSignature")]
public class FInAppPurchaseResult : FMulticastDelegate<FInAppPurchaseResult.Signature>
{
	public delegate void Signature(EInAppPurchaseState PurchaseStatus, FInAppPurchaseProductInfo InAppPurchaseReceipts);

	private static bool InAppPurchaseResult__DelegateSignature_IsValid;

	private static IntPtr InAppPurchaseResult__DelegateSignature_FunctionAddress;

	private static int InAppPurchaseResult__DelegateSignature_ParamsSize;

	private static bool InAppPurchaseResult__DelegateSignature_PurchaseStatus_IsValid;

	private static FFieldAddress InAppPurchaseResult__DelegateSignature_PurchaseStatus_PropertyAddress;

	private static int InAppPurchaseResult__DelegateSignature_PurchaseStatus_Offset;

	private static bool InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_IsValid;

	private static FFieldAddress InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_PropertyAddress;

	private static int InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInAppPurchaseResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InAppPurchaseResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.InAppPurchaseResult__DelegateSignature");
		InAppPurchaseResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InAppPurchaseResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseResult__DelegateSignature_PurchaseStatus_PropertyAddress, InAppPurchaseResult__DelegateSignature_FunctionAddress, "PurchaseStatus");
		InAppPurchaseResult__DelegateSignature_PurchaseStatus_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseResult__DelegateSignature_FunctionAddress, "PurchaseStatus");
		InAppPurchaseResult__DelegateSignature_PurchaseStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseResult__DelegateSignature_FunctionAddress, "PurchaseStatus", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_PropertyAddress, InAppPurchaseResult__DelegateSignature_FunctionAddress, "InAppPurchaseReceipts");
		InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseResult__DelegateSignature_FunctionAddress, "InAppPurchaseReceipts");
		InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseResult__DelegateSignature_FunctionAddress, "InAppPurchaseReceipts", Classes.FStructProperty);
		InAppPurchaseResult__DelegateSignature_IsValid = InAppPurchaseResult__DelegateSignature_FunctionAddress != IntPtr.Zero && InAppPurchaseResult__DelegateSignature_PurchaseStatus_IsValid && InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseResult__DelegateSignature", InAppPurchaseResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EInAppPurchaseState PurchaseStatus, FInAppPurchaseProductInfo InAppPurchaseReceipts)
	{
		if (!InAppPurchaseResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InAppPurchaseResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InAppPurchaseResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EInAppPurchaseState>.ToNative(IntPtr.Add(intPtr, InAppPurchaseResult__DelegateSignature_PurchaseStatus_Offset), 0, InAppPurchaseResult__DelegateSignature_PurchaseStatus_PropertyAddress.Address, PurchaseStatus);
			NativeReflection.InitializeValue_InContainer(InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_PropertyAddress.Address, intPtr);
			FInAppPurchaseProductInfo.ToNative(IntPtr.Add(intPtr, InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_Offset), 0, InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_PropertyAddress.Address, InAppPurchaseReceipts);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InAppPurchaseResult__DelegateSignature_InAppPurchaseReceipts_PropertyAddress.Address, intPtr);
		}
	}
}
