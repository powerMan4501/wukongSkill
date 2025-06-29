using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MobilePatchingUtils;

[UDelegate]
[UMetaPath("/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature")]
public class FOnRequestContentFailed : FDelegate<FOnRequestContentFailed.Signature>
{
	public delegate void Signature(FText ErrorText, int ErrorCode);

	private static bool OnRequestContentFailed__DelegateSignature_IsValid;

	private static IntPtr OnRequestContentFailed__DelegateSignature_FunctionAddress;

	private static int OnRequestContentFailed__DelegateSignature_ParamsSize;

	private static bool OnRequestContentFailed__DelegateSignature_ErrorText_IsValid;

	private static FFieldAddress OnRequestContentFailed__DelegateSignature_ErrorText_PropertyAddress;

	private static int OnRequestContentFailed__DelegateSignature_ErrorText_Offset;

	private static bool OnRequestContentFailed__DelegateSignature_ErrorCode_IsValid;

	private static FFieldAddress OnRequestContentFailed__DelegateSignature_ErrorCode_PropertyAddress;

	private static int OnRequestContentFailed__DelegateSignature_ErrorCode_Offset;

	public override Signature GetInvoker()
	{
		return Invoker;
	}

	static FOnRequestContentFailed()
	{
		LoadNativeType();
	}

	private static void LoadNativeType()
	{
		OnRequestContentFailed__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature");
		OnRequestContentFailed__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRequestContentFailed__DelegateSignature_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnRequestContentFailed__DelegateSignature_ErrorText_PropertyAddress, OnRequestContentFailed__DelegateSignature_FunctionAddress, "ErrorText");
		OnRequestContentFailed__DelegateSignature_ErrorText_Offset = NativeReflectionCached.GetPropertyOffset(OnRequestContentFailed__DelegateSignature_FunctionAddress, "ErrorText");
		OnRequestContentFailed__DelegateSignature_ErrorText_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRequestContentFailed__DelegateSignature_FunctionAddress, "ErrorText", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref OnRequestContentFailed__DelegateSignature_ErrorCode_PropertyAddress, OnRequestContentFailed__DelegateSignature_FunctionAddress, "ErrorCode");
		OnRequestContentFailed__DelegateSignature_ErrorCode_Offset = NativeReflectionCached.GetPropertyOffset(OnRequestContentFailed__DelegateSignature_FunctionAddress, "ErrorCode");
		OnRequestContentFailed__DelegateSignature_ErrorCode_IsValid = NativeReflectionCached.ValidatePropertyClass(OnRequestContentFailed__DelegateSignature_FunctionAddress, "ErrorCode", Classes.FIntProperty);
		OnRequestContentFailed__DelegateSignature_IsValid = OnRequestContentFailed__DelegateSignature_FunctionAddress != IntPtr.Zero && OnRequestContentFailed__DelegateSignature_ErrorText_IsValid && OnRequestContentFailed__DelegateSignature_ErrorCode_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature", OnRequestContentFailed__DelegateSignature_IsValid);
	}

	private unsafe void Invoker(FText ErrorText, int ErrorCode)
	{
		if (!OnRequestContentFailed__DelegateSignature_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.OnRequestContentFailed__DelegateSignature");
		}
		else if (IsBound)
		{
			byte* ptr = stackalloc byte[(int)(uint)(OnRequestContentFailed__DelegateSignature_ParamsSize + 16)];
			int num = (int)((16L - (long)ptr) & 0xF);
			byte* ptr2 = ptr + num;
			Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRequestContentFailed__DelegateSignature_ParamsSize);
			IntPtr intPtr = new IntPtr(ptr2);
			NativeReflection.InitializeValue_InContainer(OnRequestContentFailed__DelegateSignature_ErrorText_PropertyAddress.Address, intPtr);
			FTextMarshaler.ToNative(IntPtr.Add(intPtr, OnRequestContentFailed__DelegateSignature_ErrorText_Offset), 0, OnRequestContentFailed__DelegateSignature_ErrorText_PropertyAddress.Address, ErrorText);
			BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OnRequestContentFailed__DelegateSignature_ErrorCode_Offset), 0, OnRequestContentFailed__DelegateSignature_ErrorCode_PropertyAddress.Address, ErrorCode);
			ProcessDelegate(intPtr);
			NativeReflection.DestroyValue_InContainer(OnRequestContentFailed__DelegateSignature_ErrorText_PropertyAddress.Address, intPtr);
		}
	}
}
