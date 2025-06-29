using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MobilePatchingUtils;

[UDelegate]
[UMetaPath("/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature")]
public class FOnRequestContentSucceeded : FDelegate<FOnRequestContentSucceeded.Signature>
{
	public delegate void Signature(UMobilePendingContent MobilePendingContent);

	private static bool OnRequestContentSucceeded__DelegateSignature_IsValid;

	private static IntPtr OnRequestContentSucceeded__DelegateSignature_FunctionAddress;

	private static int OnRequestContentSucceeded__DelegateSignature_ParamsSize;

	private static bool OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_IsValid;

	private static FFieldAddress OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_PropertyAddress;

	private static int OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnRequestContentSucceeded()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnRequestContentSucceeded__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature");
		OnRequestContentSucceeded__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRequestContentSucceeded__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_PropertyAddress, OnRequestContentSucceeded__DelegateSignature_FunctionAddress, "MobilePendingContent");
		OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_Offset = NativeReflectionCached.GetPropertyOffset(OnRequestContentSucceeded__DelegateSignature_FunctionAddress, "MobilePendingContent");
		OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRequestContentSucceeded__DelegateSignature_FunctionAddress, "MobilePendingContent", Classes.FObjectProperty);
		OnRequestContentSucceeded__DelegateSignature_IsValid = OnRequestContentSucceeded__DelegateSignature_FunctionAddress != IntPtr.Zero && OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature", OnRequestContentSucceeded__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(UMobilePendingContent MobilePendingContent)
	{
		if (!OnRequestContentSucceeded__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.OnRequestContentSucceeded__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnRequestContentSucceeded__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRequestContentSucceeded__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			UObjectMarshaler<UMobilePendingContent>.ToNative(IntPtr.Add(intPtr, OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_Offset), 0, OnRequestContentSucceeded__DelegateSignature_MobilePendingContent_PropertyAddress.Address, MobilePendingContent);
			ProcessDelegate(intPtr);
		}
	}
}
