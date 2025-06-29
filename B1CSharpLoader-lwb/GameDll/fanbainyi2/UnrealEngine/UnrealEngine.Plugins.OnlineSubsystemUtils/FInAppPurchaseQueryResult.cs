using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Plugins.OnlineSubsystem;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OnlineSubsystemUtils;

[UDelegate]
[UMetaPath("/Script/OnlineSubsystemUtils.InAppPurchaseQueryResult__DelegateSignature")]
public class FInAppPurchaseQueryResult : FMulticastDelegate<FInAppPurchaseQueryResult.Signature>
{
	public delegate void Signature(List<FInAppPurchaseProductInfo> InAppPurchaseInformation);

	private static bool InAppPurchaseQueryResult__DelegateSignature_IsValid;

	private static IntPtr InAppPurchaseQueryResult__DelegateSignature_FunctionAddress;

	private static int InAppPurchaseQueryResult__DelegateSignature_ParamsSize;

	private static bool InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_IsValid;

	private static FFieldAddress InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_PropertyAddress;

	private static int InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FInAppPurchaseQueryResult()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		InAppPurchaseQueryResult__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/OnlineSubsystemUtils.InAppPurchaseQueryResult__DelegateSignature");
		InAppPurchaseQueryResult__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(InAppPurchaseQueryResult__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_PropertyAddress, InAppPurchaseQueryResult__DelegateSignature_FunctionAddress, "InAppPurchaseInformation");
		InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_Offset = NativeReflectionCached.GetPropertyOffset(InAppPurchaseQueryResult__DelegateSignature_FunctionAddress, "InAppPurchaseInformation");
		InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_IsValid = NativeReflectionCached.ValidatePropertyClass(InAppPurchaseQueryResult__DelegateSignature_FunctionAddress, "InAppPurchaseInformation", Classes.FArrayProperty);
		InAppPurchaseQueryResult__DelegateSignature_IsValid = InAppPurchaseQueryResult__DelegateSignature_FunctionAddress != IntPtr.Zero && InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OnlineSubsystemUtils.InAppPurchaseQueryResult__DelegateSignature", InAppPurchaseQueryResult__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(List<FInAppPurchaseProductInfo> InAppPurchaseInformation)
	{
		if (!InAppPurchaseQueryResult__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OnlineSubsystemUtils.InAppPurchaseQueryResult__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(InAppPurchaseQueryResult__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InAppPurchaseQueryResult__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			new TArrayCopyMarshaler<FInAppPurchaseProductInfo>(1, InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_PropertyAddress, CachedMarshalingDelegates<FInAppPurchaseProductInfo, FInAppPurchaseProductInfo>.FromNative, CachedMarshalingDelegates<FInAppPurchaseProductInfo, FInAppPurchaseProductInfo>.ToNative).ToNative(IntPtr.Add(intPtr, InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_Offset), InAppPurchaseInformation);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(InAppPurchaseQueryResult__DelegateSignature_InAppPurchaseInformation_PropertyAddress.Address, intPtr);
		}
	}
}
