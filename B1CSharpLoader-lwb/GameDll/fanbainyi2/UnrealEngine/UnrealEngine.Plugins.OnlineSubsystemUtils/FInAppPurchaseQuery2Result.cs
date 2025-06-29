using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseQuery2Result__DelegateSignature")]
public class FInAppPurchaseQuery2Result : FMulticastDelegate<FInAppPurchaseQuery2Result.Signature>
{
	public delegate void Signature(List<FOnlineProxyStoreOffer> InAppOfferInformation);

	private static bool InAppPurchaseQuery2Result__DelegateSignature_IsValid;

	private static IntPtr InAppPurchaseQuery2Result__DelegateSignature_FunctionAddress;

	private static int InAppPurchaseQuery2Result__DelegateSignature_ParamsSize;

	private static bool InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_IsValid;

	private static FFieldAddress InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_PropertyAddress;

	private static int InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInAppPurchaseQuery2Result()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InAppPurchaseQuery2Result__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.InAppPurchaseQuery2Result__DelegateSignature");
		InAppPurchaseQuery2Result__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InAppPurchaseQuery2Result__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_PropertyAddress, InAppPurchaseQuery2Result__DelegateSignature_FunctionAddress, "InAppOfferInformation");
		InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseQuery2Result__DelegateSignature_FunctionAddress, "InAppOfferInformation");
		InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseQuery2Result__DelegateSignature_FunctionAddress, "InAppOfferInformation", Classes.FArrayProperty);
		InAppPurchaseQuery2Result__DelegateSignature_IsValid = InAppPurchaseQuery2Result__DelegateSignature_FunctionAddress != IntPtr.Zero && InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseQuery2Result__DelegateSignature", InAppPurchaseQuery2Result__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FOnlineProxyStoreOffer> InAppOfferInformation)
	{
		if (!InAppPurchaseQuery2Result__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseQuery2Result__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InAppPurchaseQuery2Result__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InAppPurchaseQuery2Result__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FOnlineProxyStoreOffer>(1, InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_PropertyAddress, CachedMarshalingDelegates<FOnlineProxyStoreOffer, FOnlineProxyStoreOffer>.FromNative, CachedMarshalingDelegates<FOnlineProxyStoreOffer, FOnlineProxyStoreOffer>.ToNative).ToNative(IntPtr.Add(intPtr, InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_Offset), InAppOfferInformation);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InAppPurchaseQuery2Result__DelegateSignature_InAppOfferInformation_PropertyAddress.Address, intPtr);
		}
	}
}
