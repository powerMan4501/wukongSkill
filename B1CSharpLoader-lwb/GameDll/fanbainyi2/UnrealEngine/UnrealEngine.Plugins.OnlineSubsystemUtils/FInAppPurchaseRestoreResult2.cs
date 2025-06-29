using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult2__DelegateSignature")]
public class FInAppPurchaseRestoreResult2 : FMulticastDelegate<FInAppPurchaseRestoreResult2.Signature>
{
	public delegate void Signature(EInAppPurchaseStatus PurchaseStatus, List<FInAppPurchaseRestoreInfo2> InAppPurchaseRestoreInfo);

	private static bool InAppPurchaseRestoreResult2__DelegateSignature_IsValid;

	private static IntPtr InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress;

	private static int InAppPurchaseRestoreResult2__DelegateSignature_ParamsSize;

	private static bool InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_IsValid;

	private static FFieldAddress InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_PropertyAddress;

	private static int InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_Offset;

	private static bool InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_IsValid;

	private static FFieldAddress InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_PropertyAddress;

	private static int InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInAppPurchaseRestoreResult2()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult2__DelegateSignature");
		InAppPurchaseRestoreResult2__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_PropertyAddress, InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress, "PurchaseStatus");
		InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress, "PurchaseStatus");
		InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress, "PurchaseStatus", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_PropertyAddress, InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress, "InAppPurchaseRestoreInfo");
		InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress, "InAppPurchaseRestoreInfo");
		InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress, "InAppPurchaseRestoreInfo", Classes.FArrayProperty);
		InAppPurchaseRestoreResult2__DelegateSignature_IsValid = InAppPurchaseRestoreResult2__DelegateSignature_FunctionAddress != IntPtr.Zero && InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_IsValid && InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult2__DelegateSignature", InAppPurchaseRestoreResult2__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(EInAppPurchaseStatus PurchaseStatus, List<FInAppPurchaseRestoreInfo2> InAppPurchaseRestoreInfo)
	{
		if (!InAppPurchaseRestoreResult2__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseRestoreResult2__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InAppPurchaseRestoreResult2__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InAppPurchaseRestoreResult2__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			EnumMarshaler<EInAppPurchaseStatus>.ToNative(IntPtr.Add(intPtr, InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_Offset), 0, InAppPurchaseRestoreResult2__DelegateSignature_PurchaseStatus_PropertyAddress.Address, PurchaseStatus);
			new TArrayCopyMarshaler<FInAppPurchaseRestoreInfo2>(1, InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_PropertyAddress, CachedMarshalingDelegates<FInAppPurchaseRestoreInfo2, FInAppPurchaseRestoreInfo2>.FromNative, CachedMarshalingDelegates<FInAppPurchaseRestoreInfo2, FInAppPurchaseRestoreInfo2>.ToNative).ToNative(IntPtr.Add(intPtr, InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_Offset), InAppPurchaseRestoreInfo);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InAppPurchaseRestoreResult2__DelegateSignature_InAppPurchaseRestoreInfo_PropertyAddress.Address, intPtr);
		}
	}
}
